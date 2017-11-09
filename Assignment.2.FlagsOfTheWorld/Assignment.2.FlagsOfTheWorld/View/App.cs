using Assignment._2.FlagsOfTheWorld.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment._2.FlagsOfTheWorld.Model.Enum.Enums;

namespace Assignment._2.FlagsOfTheWorld.View
{
    public partial class App : Form
    {
        public static AppLanguage CurrentLanguage { get; set; }

        public App()
        {
            InitializeComponent();

            this.mainMenu1.GameStarted += MainMenu1_GameStarted;
            this.mainMenu1.LanguageChanged += MainMenu1_LanguageChanged;

            this.gameMenu1.GameOver += showGameMenu;
            this.gameMenu1.BackToMenu += showGameMenu;

            App.CurrentLanguage = AppLanguage.Dutch;
            updateLanguage();
        }

        private void MainMenu1_LanguageChanged(object sender, Model.CustomEvent.ChangeLanguageEventArg e)
        {
            if (App.CurrentLanguage != e.AppLanguage)
            {
                App.CurrentLanguage = e.AppLanguage;
                updateLanguage();
            }
        }

        private void updateLanguage()
        {
            gameMenu1.UpdateFormLanguage();
            mainMenu1.UpdateFormLanguage();
        }

        private void showGameMenu(object sender, EventArgs e)
        {
            this.mainMenu1.Show();
            this.gameMenu1.Hide();
        }

        private void MainMenu1_GameStarted(object sender, EventArgs e)
        {
            this.mainMenu1.Hide();
            this.gameMenu1.startGame();
            this.gameMenu1.Show();
        }
    }
}
