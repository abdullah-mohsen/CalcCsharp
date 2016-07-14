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
        string checkend = null;
        double number;
        string op;
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
        private void btnOne_Click(object sender, EventArgs e)
        {
            
        }

        private void btntwo__Click(object sender, EventArgs e)
        {
            
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            
        }

        private void btnfour__Click(object sender, EventArgs e)
        {
            
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
           
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            
        }
        // operation button
        private void btnMinus_Click(object sender, EventArgs e)
        {
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
        }
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
                    checkend = textBox1.Text;
                    checkend = checkend.Substring(textBox1.Text.Length - 1);
                    Button clickedButton = (Button)sender;
                    number = double.Parse(textBox1.Text);
                    op = clickedButton.Text;
                    if (checkend != clickedButton.Text)
                    {
                        textBox1.Text += clickedButton.Text;
                        textBox1.Text = "";
                    }
                    else if (checkend == clickedButton.Text)
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
            DisplayText.Text = number + " " + op + " "  +textBox1.Text;
            switch (op)
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
