using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._5.RomanCalculator
{
    public partial class App : Form
    {
        public enum Operations
        {
            Add,
            Substract,
            Multiply,
            Divide,
            Nothing
        }

        private Dictionary<string, int> RomanNumbers;

        private bool operatorIsClicked;
        private Operations currentOperation;
        private int currentValue;
        private int oldValue;
        
        public App()
        {
            InitializeComponent();

            this.currentOperation = Operations.Nothing;

            this.RomanNumbers = new Dictionary<string, int>();

            this.tTip_RomanNumerals.SetToolTip(this.bt_RomanI, "1");
            this.tTip_RomanNumerals.SetToolTip(this.bt_RomanV, "5");
            this.tTip_RomanNumerals.SetToolTip(this.bt_RomanX, "10");
            this.tTip_RomanNumerals.SetToolTip(this.bt_RomanL, "50");
            this.tTip_RomanNumerals.SetToolTip(this.bt_RomanC, "100");
            this.tTip_RomanNumerals.SetToolTip(this.bt_RomanD, "500");
            this.tTip_RomanNumerals.SetToolTip(this.bt_RomanM, "1000");

            RomanNumbers.Add("M", 1000);
            RomanNumbers.Add("CM", 900);
            RomanNumbers.Add("D", 500);
            RomanNumbers.Add("CD", 400);
            RomanNumbers.Add("C", 100);
            RomanNumbers.Add("XC", 90);
            RomanNumbers.Add("L", 50);
            RomanNumbers.Add("XL", 40);
            RomanNumbers.Add("X", 10);
            RomanNumbers.Add("IX", 9);
            RomanNumbers.Add("V", 5);
            RomanNumbers.Add("IV", 4);
            RomanNumbers.Add("I", 1);
        }

        private void AddToInput(string Input)
        {
            if (operatorIsClicked)
            {
                oldValue = currentValue;
                currentValue = 0;

                this.currentValue += RomanNumbers[Input];
                this.tb_Input.Text = ConvertIntToRoman(currentValue);

                operatorIsClicked = false;
            }
            else
            {
                this.currentValue += RomanNumbers[Input];
                this.tb_Input.Text = ConvertIntToRoman(currentValue);
            }
        }

        private string ConvertIntToRoman(int number)
        {
            StringBuilder str = new StringBuilder();

            foreach (KeyValuePair<string, int> i in this.RomanNumbers)
            {
                int temp = number / i.Value;
                for (int j = 0; j < temp; j++)
                {
                    str.Append(i.Key);
                }

                number -= temp * i.Value;
            }

            return str.ToString();
        }

        private void OperatorClicked(Operations operation)
        {
            operatorIsClicked = true;

            if (operation != Operations.Nothing)
            {
                if (currentOperation != Operations.Nothing)
                    Calculate();
            }

            currentOperation = operation;
        }

        private void Calculate()
        {
            switch (currentOperation)
            {
                case Operations.Add:
                    currentValue += oldValue;
                    break;
                case Operations.Substract:
                    currentValue -= oldValue;
                    break;
                case Operations.Multiply:
                    currentValue *= oldValue;
                    break;
                case Operations.Divide:
                    try
                    {
                        currentValue = oldValue / currentValue;
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("Don't divide by zero!");

                        Clear();
                    }                   
                    break;
            }
            operatorIsClicked = true;
            currentOperation = Operations.Nothing;
            this.tb_Input.Text = ConvertIntToRoman(currentValue);
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            OperatorClicked(Operations.Add);
        }

        private void bt_Substract_Click(object sender, EventArgs e)
        {
            OperatorClicked(Operations.Substract);
        }

        private void bt_Multiply_Click(object sender, EventArgs e)
        {
            OperatorClicked(Operations.Multiply);
        }

        private void bt_Divide_Click(object sender, EventArgs e)
        {
            OperatorClicked(Operations.Divide);
        }

        private void bt_RomanI_Click(object sender, EventArgs e)
        {
            AddToInput("I");
        }

        private void bt_RomanV_Click(object sender, EventArgs e)
        {
            AddToInput("V");
        }

        private void bt_RomanL_Click(object sender, EventArgs e)
        {
            AddToInput("L");
        }

        private void bt_RomanX_Click(object sender, EventArgs e)
        {
            AddToInput("X");
        }

        private void bt_RomanD_Click(object sender, EventArgs e)
        {
            AddToInput("D");
        }

        private void bt_RomanM_Click(object sender, EventArgs e)
        {
            AddToInput("M");
        }

        private void bt_RomanC_Click(object sender, EventArgs e)
        {
            AddToInput("C");
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            this.tb_Input.Text = "";
            this.currentValue = 0;
            this.operatorIsClicked = false;
            this.currentOperation = Operations.Nothing;
        }

        private void bt_Result_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
