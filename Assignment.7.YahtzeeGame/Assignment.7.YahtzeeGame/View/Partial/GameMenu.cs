using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment._7.YahtzeeGame.View.CustomControl;
using Assignment._7.YahtzeeGame.Tools;

namespace Assignment._7.YahtzeeGame.View.Partial
{
    public partial class GameMenu : UserControl
    {
        public static Random rng = new Random();

        private int totalSumSameNumber = 0;
        private List<Bitmap> diceImages;
        private List<int> currentDiceValues;

        private List<YahtzeeButton> sameNumber;

        private int rollsRemaining = 3;

        public int RollsRemaining
        {
            get { return rollsRemaining; }
            set
            {
                this.lbl_RollsRemaining.Text = value.ToString();
                rollsRemaining = value;
            }
        }


        public GameMenu()
        {
            InitializeComponent();

            this.bt_Ones.calculateScoreHandler = YahtzeeScoreFunctions.calculateOnes;
            this.bt_Twos.calculateScoreHandler = YahtzeeScoreFunctions.calculateTwos;
            this.bt_Threes.calculateScoreHandler = YahtzeeScoreFunctions.calculateThrees;
            this.bt_Fours.calculateScoreHandler = YahtzeeScoreFunctions.calculateFours;
            this.bt_Fives.calculateScoreHandler = YahtzeeScoreFunctions.calculateFives;
            this.bt_Sixes.calculateScoreHandler = YahtzeeScoreFunctions.calculateSixes;

            this.bt_Ones.Click += sameNumberYahtzeeClicked;
            this.bt_Twos.Click += sameNumberYahtzeeClicked;
            this.bt_Threes.Click += sameNumberYahtzeeClicked;
            this.bt_Fours.Click += sameNumberYahtzeeClicked;
            this.bt_Fives.Click += sameNumberYahtzeeClicked;
            this.bt_Sixes.Click += sameNumberYahtzeeClicked;

            //sameNumber = new List<YahtzeeButton>();

            //sameNumber.Add(bt_Ones);
            //sameNumber.Add(bt_Twos);
            //sameNumber.Add(bt_Threes);
            //sameNumber.Add(bt_Fours);
            //sameNumber.Add(bt_Fives);
            //sameNumber.Add(bt_Sixes);

            this.bt_ThreeOfKind.calculateScoreHandler = YahtzeeScoreFunctions.calculateThreeOfKind;
            this.bt_FourOfKind.calculateScoreHandler = YahtzeeScoreFunctions.calculateFourOfKind;
            this.bt_FullHouse.calculateScoreHandler = YahtzeeScoreFunctions.calculateFullHouse;
            this.bt_SmallStraight.calculateScoreHandler = YahtzeeScoreFunctions.calculateSmallStraight;
            this.bt_LargeStraight.calculateScoreHandler = YahtzeeScoreFunctions.calculateLargeStraight;

            this.bt_Yahtzee.calculateScoreHandler = YahtzeeScoreFunctions.calculateYahtzee;
            this.bt_Chance.calculateScoreHandler = YahtzeeScoreFunctions.calculateChance;

            diceImages = new List<Bitmap>();

            diceImages.Add(Properties.Resources._1);
            diceImages.Add(Properties.Resources._2);
            diceImages.Add(Properties.Resources._3);
            diceImages.Add(Properties.Resources._4);
            diceImages.Add(Properties.Resources._5);
            diceImages.Add(Properties.Resources._6);

            currentDiceValues = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                currentDiceValues.Add(0);
            }

            addClickEventDices();
            addClickEventYahtzeeButtons();

            toggleDiceButtons<DiceButton>(false);
            getRandomDices();
        }

        private void sameNumberYahtzeeClicked(object sender, EventArgs e)
        {
            YahtzeeButton ybt = (YahtzeeButton)sender;
            totalSumSameNumber += ybt.Score;

            if (totalSumSameNumber > 63)
                this.lbl_SameNumberBonus.Text = "35";
        }
        public void toggleYahtzeeButtons(bool shouldBeEnabled)
        {
            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                if (c is YahtzeeButton)
                {
                    YahtzeeButton ybt = (YahtzeeButton)c;
                    if (!ybt.IsPicked)
                        c.Enabled = shouldBeEnabled;
                }
            }
        }

        public void toggleDiceButtons<T>(bool shouldBeEnabled)
        {
            foreach (Control c in this.Controls)
            {
                if (c is T)
                    c.Enabled = shouldBeEnabled;
            }
        }

        public void showPotentionalScores(List<int> dices)
        {
            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                if (c is YahtzeeButton)
                {
                    YahtzeeButton yb = (YahtzeeButton)c;

                    if (!yb.IsPicked)
                        yb.calculateScore(dices);
                }
            }
        }

        public void addClickEventYahtzeeButtons()
        {
            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                if (c is YahtzeeButton)
                {
                    YahtzeeButton db = (YahtzeeButton)c;
                    c.Click += bt_YahtzeeClick;
                }
            }
        }

        private void bt_YahtzeeClick(object sender, EventArgs e)
        {
            YahtzeeButton ytz = (YahtzeeButton)sender;
            ytz.IsPicked = true;
            ytz.Enabled = false;

            this.RollsRemaining = 3;
            toggleDiceButtons<DiceButton>(false);
            toggleYahtzeeButtons(false);
            this.bt_RollDice.Enabled = true;
        }

        public void addClickEventDices()
        {
            foreach (Control c in this.Controls)
            {
                if (c is DiceButton)
                {
                    DiceButton db = (DiceButton)c;
                    c.Click += bt_DiceClick;
                }
            }
        }

        public void StartGame()
        {
            toggleYahtzeeButtons(false);
        }

        private void bt_DiceClick(object sender, EventArgs e)
        {
            DiceButton db = (DiceButton)sender;
            db.IsSelected = !db.IsSelected;
        }

        private void getRandomDices()
        {
            int temp = 0;
            foreach (Control c in this.Controls)
            {
                if (c is DiceButton)
                {
                    DiceButton db = (DiceButton)c;
                    if (!db.IsSelected)
                    {
                        int j = rng.Next(1, 7);
                        this.currentDiceValues[temp] = j;
                        db.BackgroundImage = diceImages[j - 1];
                    }
                    temp++;
                }
            }
        }

        private void bt_RollDice_Click(object sender, EventArgs e)
        {
            getRandomDices();
            List<int> copy = new List<int>(currentDiceValues);
            copy.Sort();

            showPotentionalScores(copy);

            if (RollsRemaining == 3)
            {
                this.toggleDiceButtons<DiceButton>(true);
                toggleYahtzeeButtons(true);
            }

            this.RollsRemaining--;

            if (rollsRemaining == 0)
            {
                this.toggleDiceButtons<DiceButton>(false);
                this.bt_RollDice.Enabled = false;
            }
        }
    }
}
