using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._7.YahtzeeGame.View.CustomControl
{
    public class DiceButton : Button
    {
        private bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                if (value)
                    this.BackColor = System.Drawing.Color.Green;
                else
                    this.BackColor = System.Drawing.Color.Empty;
                isSelected = value;
            }
        }

        public int Value { get; set; }

        //https://stackoverflow.com/questions/14354922/remove-blue-outlining-of-buttons

        public DiceButton()
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
    }
}
