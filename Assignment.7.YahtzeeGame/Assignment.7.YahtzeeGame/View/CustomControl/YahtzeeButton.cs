using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._7.YahtzeeGame.View.CustomControl
{
    public class YahtzeeButton : Button
    {
        private bool isPicked;

        public bool IsPicked
        {
            get { return isPicked; }
            set
            {
                if (value)
                    this.ForeColor = System.Drawing.Color.Green;
                isPicked = value;
            }
        }


        private int score;

        public int Score
        {
            get { return score; }
            set
            {
                this.Text = value.ToString();
                this.ForeColor = System.Drawing.Color.Red;
                score = value;
            }
        }


        public delegate int showScore(List<int> dices);

        public showScore calculateScoreHandler { get; set; }

        //https://stackoverflow.com/questions/14354922/remove-blue-outlining-of-buttons

        public YahtzeeButton()
        {
            this.SetStyle(ControlStyles.Selectable, false);
        }

        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }

        public void calculateScore(List<int> dices)
        {
            if (calculateScoreHandler != null)
                this.Score = calculateScoreHandler(dices);
        }
    }
}
