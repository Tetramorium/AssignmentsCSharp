using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment._1.Calculator
{
    public partial class Form1 : Form
    {

        private bool isDouble;
        private bool isCalculated;
        private bool isFirstTimeAfterCalculate;

        private double oldNumber;
        private enum Operations
        {
            add,
            substract,
            multiply,
            divide,
            nothing
        };

        private Operations currentOperation = Operations.nothing;

        public Form1()
        {
            InitializeComponent();

        }

        private void AddToInput(string toAdd)
        {
            if (this.tb_Input.Text == "0" || (this.currentOperation != Operations.nothing && isFirstTimeAfterCalculate))
            {
                if (isCalculated)
                    clearInput();

                this.tb_Input.Text = toAdd.ToString();
                isFirstTimeAfterCalculate = false;
            }
            else
                this.tb_Input.Text += toAdd;
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = "0";
            clearInput();
        }

        private void clearInput()
        {
            isDouble = false;
            currentOperation = Operations.nothing;
            isCalculated = false;
        }

        private void bt_Comma_Click(object sender, EventArgs e)
        {
            if (!isDouble)
            {
                AddToInput(",");
                isDouble = true;
            }
        }

        private void bt_Calculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            switch (currentOperation)
            {
                case Operations.add:
                    this.tb_Input.Text = (oldNumber + double.Parse(this.tb_Input.Text)).ToString();
                    break;
                case Operations.substract:
                    this.tb_Input.Text = (oldNumber - double.Parse(this.tb_Input.Text)).ToString();
                    break;
                case Operations.multiply:
                    this.tb_Input.Text = (oldNumber * double.Parse(this.tb_Input.Text)).ToString();
                    break;
                case Operations.divide:
                    this.tb_Input.Text = (oldNumber / double.Parse(this.tb_Input.Text)).ToString();
                    break;
            }
            if (currentOperation != Operations.nothing)
                isCalculated = true;

            currentOperation = Operations.nothing;
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            AddToInput("1");
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            AddToInput("2");
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            AddToInput("3");
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            AddToInput("4");
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            AddToInput("5");
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            AddToInput("6");
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            AddToInput("7");
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            AddToInput("8");
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            AddToInput("9");
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            AddToInput("0");
        }

        private void operatorClicked(Operations operation)
        {
            if (currentOperation != Operations.nothing)
                Calculate();

            if (operation != Operations.add)
            {
                this.oldNumber = double.Parse(this.tb_Input.Text);
                clearInput();
                currentOperation = operation;
                isFirstTimeAfterCalculate = true;
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            operatorClicked(Operations.add);
        }

        private void bt_Substract_Click(object sender, EventArgs e)
        {
            operatorClicked(Operations.substract);
        }

        private void bt_Divide_Click(object sender, EventArgs e)
        {
            operatorClicked(Operations.divide);
        }
    }
}
