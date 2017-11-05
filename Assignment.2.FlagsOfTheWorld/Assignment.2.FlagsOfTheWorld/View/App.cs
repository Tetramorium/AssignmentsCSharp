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

namespace Assignment._2.FlagsOfTheWorld
{
    public partial class App : Form
    {
        public List<Country> World { get; set; }

        public App()
        {
            InitializeComponent();

            using (HttpClient httpClient = new HttpClient())
            {
                var message = httpClient.GetAsync("https://restcountries.eu/rest/v2/all");
                Task<string> content = message.Result.Content.ReadAsStringAsync();
                World = JsonConvert.DeserializeObject<List<Country>>(content.Result);
            }

            this.mainMenu1.StartGame += MainMenu1_StartGame;
        }

        private void MainMenu1_StartGame(object sender, EventArgs e)
        {
            this.mainMenu1.Hide();
        }
    }
}
