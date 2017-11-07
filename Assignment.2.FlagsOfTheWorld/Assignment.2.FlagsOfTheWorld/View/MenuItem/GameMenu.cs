using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Assignment._2.FlagsOfTheWorld.Model;
using Svg;
using System.IO;
using static Assignment._2.FlagsOfTheWorld.Model.Enum.Enums;

namespace Assignment._2.FlagsOfTheWorld.View.MenuItem
{
    public partial class GameMenu : UserControl
    {

        public List<Country> World { get; set; }

        private int countriesLeft;
        private int wrongAnswers;
        private int score;

        private string wrongAnswerText;
        private string gameOverText;

        private static Random rng = new Random();

        public event EventHandler GameOver;

        public GameMenu()
        {
            InitializeComponent();

            using (HttpClient httpClient = new HttpClient())
            {
                var message = httpClient.GetAsync("https://restcountries.eu/rest/v2/all");
                Task<string> content = message.Result.Content.ReadAsStringAsync();
                World = JsonConvert.DeserializeObject<List<Country>>(content.Result);
            }
        }

        public void startGame()
        {
            // Reset all variables
            countriesLeft = World.Count();
            this.lbl_CountriesLeft.Text = countriesLeft.ToString();
            this.score = 0;
            this.wrongAnswers = 0;

            // Show the next flag
            showNextFlag();
        }

        private void draw(int index)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var message = httpClient.GetAsync(World[index].FlagUrl);

                Stream memoryStream = message.Result.Content.ReadAsStreamAsync().Result;

                using (memoryStream)
                {
                    SvgDocument svgDoc = SvgDocument.Open<SvgDocument>(memoryStream, null);

                    this.pb_FlagImage.Image = svgDoc.Draw();

                    this.bt_Confirm.Enabled = true;
                }
            }
        }

        private void showNextFlag()
        {
            // Get next random index
            int index = rng.Next(0, countriesLeft);
            countriesLeft--;

            // Get the country by random index and put it at the end of the list
            Country c = World[index];
            World.Remove(c);
            World.Add(c);

            // ToDo remove cheats! 
            switch (App.CurrentLanguage)
            {
                case AppLanguage.Dutch:
                    this.lbl_Cheat.Text = World[World.Count - 1].Translations.nl;
                    break;
                case AppLanguage.German:
                    this.lbl_Cheat.Text = World[World.Count - 1].Translations.de;
                    break;
                case AppLanguage.French:
                    this.lbl_Cheat.Text = World[World.Count - 1].Translations.fr;
                    break;
            }

            // Update labels
            this.lbl_CountriesLeft.Text = countriesLeft.ToString();
            this.lbl_Region.Text = World[World.Count - 1].Region;

            // Draw the flag in the PictureBox
            draw(World.Count - 1);
        }

        private void bt_Confirm_Click(object sender, EventArgs e)
        {
            this.bt_Confirm.Enabled = false;
            string correctCountry = "";

            switch (App.CurrentLanguage)
            {
                case AppLanguage.Dutch:
                    correctCountry = World[World.Count - 1].Translations.nl;
                    break;
                case AppLanguage.German:
                    correctCountry = World[World.Count - 1].Translations.de;
                    break;
                case AppLanguage.French:
                    correctCountry = World[World.Count - 1].Translations.fr;
                    break;
            }

            if (this.textBox1.Text.ToLower() == correctCountry.ToLower())
            {
                score++;
            }
            else
            {
                DialogResult d = MessageBox.Show(string.Format(wrongAnswerText, correctCountry));
                wrongAnswers++;
            }
            if(wrongAnswers == 3)
            {
                MessageBox.Show(string.Format(gameOverText, this.score));
                
                //bubble the event up to the parent
                if (this.GameOver != null)
                    this.GameOver(this, e);
            } else
            {
                this.textBox1.Clear();
                showNextFlag();
            }
        }

        public void UpdateFormLanguage()
        {
            switch (App.CurrentLanguage)
            {
                case AppLanguage.Dutch:
                    UpdateText(Translation.Language.Dutch);
                    break;
                case AppLanguage.German:
                    UpdateText(Translation.Language.German);
                    break;
                case AppLanguage.French:
                    UpdateText(Translation.Language.French);
                    break;
            }
        }

        private void UpdateText(translationText t)
        {
            this.bt_Confirm.Text = t.NextButton;
            this.lbl_CountriesLeftText.Text = t.LabelCountriesRemaining;

            this.wrongAnswerText = t.WrongAnswer;
            this.gameOverText = t.GameOver;
        }
    }
}
