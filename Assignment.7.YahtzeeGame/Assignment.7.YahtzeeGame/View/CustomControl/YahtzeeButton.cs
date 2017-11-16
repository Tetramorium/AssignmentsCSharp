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
        public bool isPicked { get; set; }

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

        public void calculateScore(List<int> dices)
        {
            if (calculateScoreHandler != null)
                this.Score = calculateScoreHandler(dices);
        }
    }
}
