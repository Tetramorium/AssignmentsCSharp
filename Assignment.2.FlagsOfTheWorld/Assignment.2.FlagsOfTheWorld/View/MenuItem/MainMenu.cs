using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment._2.FlagsOfTheWorld.Model.CustomEvent;
using static Assignment._2.FlagsOfTheWorld.Model.Enum.Enums;
using Assignment._2.FlagsOfTheWorld.Model;

namespace Assignment._2.FlagsOfTheWorld.View.MenuItem
{
    public partial class MainMenu : UserControl
    {
        public event EventHandler GameStarted;
        public event EventHandler<ChangeLanguageEventArg> LanguageChanged;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.GameStarted != null)
                this.GameStarted(this, e);
        }

        public void UpdateLanguage(AppLanguage l)
        {
            //bubble the event up to the parent
            if (this.LanguageChanged != null)
                this.LanguageChanged(this, new ChangeLanguageEventArg { AppLanguage = l });
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

        private void UpdateText (translationText t)
        {
            this.bt_Start.Text = t.StartButton;
            this.rtb_GameInfo.Text = t.InfoText_MainMenu;
        }

        private void bt_Dutch_Click(object sender, EventArgs e)
        {
            UpdateLanguage(AppLanguage.Dutch);
        }

        private void bt_German_Click(object sender, EventArgs e)
        {
            UpdateLanguage(AppLanguage.German);
        }

        private void bt_French_Click(object sender, EventArgs e)
        {
            UpdateLanguage(AppLanguage.French);
        }
    }
}
