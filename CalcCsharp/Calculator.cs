using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcCsharp
{
    public partial class Calculator : Form
    {
        //some Variable
        string checkEnd = null;
        double number;
        string opertion;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            //clear the textBox;
            textBox1.Clear();
        }
        // add the number of button in textbox
        public void DisplayNumber(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            textBox1.Text += clickedButton.Text;
        }
        public void displayOperation(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    checkEnd = textBox1.Text;
                    checkEnd = checkEnd.Substring(textBox1.Text.Length - 1);
                    Button clickedButton = (Button)sender;
                    number = double.Parse(textBox1.Text);
                    opertion = clickedButton.Text;
                    if (checkEnd != clickedButton.Text)
                    {
                        textBox1.Text += clickedButton.Text;
                        textBox1.Text = "";
                    }
                    else if (checkEnd == clickedButton.Text)
                    {
                       // textBox1.Text = "not click double opreation";
                        return;
                    }
                    else
                    {
                        //textBox1.Text = check.Substring(0,check.Length-2) + op;
                    }
                      
                }
            }catch(Exception )
            {
                textBox1.Text = "we have exception";
            }
        }
        public void compute(object sender, EventArgs e)
        {
            DisplayText.Text = number + " " + opertion + " "  +textBox1.Text;
            switch (opertion)
            {
                case "+":
                    textBox1.Text = (number + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (number -double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (number / double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (number * double.Parse(textBox1.Text)).ToString();
                    break;
                default:

                    break;
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
