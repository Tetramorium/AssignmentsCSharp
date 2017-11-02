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
using Newtonsoft.Json;
using System.Threading;

namespace Assignment._1.Calculator
{
    public partial class Form1 : Form
    {

        private bool isDouble;
        private bool isCalculated;
        private bool isFirstTimeAfterCalculate;
        private bool isEuro;

        private double oldNumber;
        private Operations oldOperation;
        private Operations currentOperation;

        private RatesResult currentCurrencyValue;

        private enum Operations
        {
            add,
            substract,
            multiply,
            divide,
            modulus,
            nothing
        };

        public Form1()
        {
            InitializeComponent();

            currentOperation = Operations.nothing;
            currentCurrencyValue = new RatesResult();
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
                case Operations.modulus:
                    this.tb_Input.Text = (oldNumber % double.Parse(this.tb_Input.Text)).ToString();
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
            if (operation != Operations.nothing)
            {
                Calculate();

                this.oldNumber = double.Parse(this.tb_Input.Text);
                oldOperation = operation;

                clearInput();
                currentOperation = operation;
                isFirstTimeAfterCalculate = true;
            }
        }

        private void bt_Percentage_Click(object sender, EventArgs e)
        {
            operatorClicked(Operations.modulus);
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

        private void bt_Multiply_Click(object sender, EventArgs e)
        {
            operatorClicked(Operations.multiply);
        }

        private void bt_ConvertCurrency_Click(object sender, EventArgs e)
        {
            if (currentCurrencyValue.Rates == null || currentCurrencyValue.Date < DateTime.Now.AddDays(-2))
            {
                try
                {
                    UpdateCurrencyRates();
                }
                catch
                {
                    MessageBox.Show("Currency convertor API is currently unavailable.");
                }
            }
            if (currentCurrencyValue.Rates != null)
            {
                if (!isEuro)
                {
                    double result = Math.Round(double.Parse(this.tb_Input.Text) * currentCurrencyValue.Rates.USD, 2);
                    this.tb_Input.Text = result.ToString();
                    this.bt_ConvertCurrency.Text = "€";
                    this.lbl_CurrentCurrency.Text = "$";
                }
                else
                {
                    double value = double.Parse(this.tb_Input.Text);
                    double result = Math.Round((value / currentCurrencyValue.Rates.USD), 2);
                    this.tb_Input.Text = result.ToString();
                    this.bt_ConvertCurrency.Text = "$";
                    this.lbl_CurrentCurrency.Text = "€";
                }

                isEuro = !isEuro;
            } else
            {
                MessageBox.Show("Currency convertor API is currently unavailable.");
            }
        }

        public void UpdateCurrencyRates()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var message = httpClient.GetAsync("http://api.fixer.io/latest?symbols=USD");
                Task<string> content = message.Result.Content.ReadAsStringAsync();
                currentCurrencyValue = JsonConvert.DeserializeObject<RatesResult>(content.Result);
            }
        }
    }
}
