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
        //some Variables
        double num1;
        string check = null;
        double num2;
        string checkend = null;
        String op;
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
            //DisplayNumber("1");
        }

        private void btntwo__Click(object sender, EventArgs e)
        {
            //DisplayNumber("2");
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            //DisplayNumber("3");
        }

        private void btnfour__Click(object sender, EventArgs e)
        {
            //DisplayNumber("4");
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            //DisplayNumber("5");
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            //DisplayNumber("6");
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            //DisplayNumber("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            //DisplayNumber("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            //DisplayNumber("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            //DisplayNumber("0");
        }
        // operation button
        private void btnMinus_Click(object sender, EventArgs e)

        {
            displayOperation("-");
            
              

        }

        private void btnplus_Click(object sender, EventArgs e)
        {

            displayOperation("+");
               


        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            displayOperation("*");

            

        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            displayOperation("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
        }
        public void DisplayNumber(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            textBox1.Text += clickedButton.Text;
        }
        public void displayOperation(String op)
        {
            try
            {
                string ifop = op;
                if (textBox1.Text.Length > 0)
                {
                    checkend = textBox1.Text;
                    checkend = checkend.Substring(textBox1.Text.Length - 1);
                    check = textBox1.Text;
                    
                    if (checkend != op)
                    {
                        textBox1.Text += op;
                    }
                    else if (checkend == op)
                    {
                       // textBox1.Text = "not click double opreation";
                        return;
                    }
                    else
                    {
                        textBox1.Text = check.Substring(0,check.Length-2) + op;

                    }
                      
                }
            }catch(Exception )
            {
                textBox1.Text = "we have exception";
            }
        }

    }
}
