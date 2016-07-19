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
        DataTable result = new DataTable();
        string checkEnd = null;
        public Calculator()
        {
            InitializeComponent();
        }
        private void ClearTheText(object sender, EventArgs e)
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
        public void DisplayOperation(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    checkEnd = textBox1.Text;
                    checkEnd = checkEnd.Substring(textBox1.Text.Length - 1);
                    Button ClickedButton = (Button)sender;
                   
                    if (checkEnd != ClickedButton.Text)
                    {
                        textBox1.Text += ClickedButton.Text;
                    }else
                    {
                        return;
                }
                      
                }
            }catch(Exception )
               {
                    textBox1.Text = "we have exception";
        }
        }
    public void Compute(object sender, EventArgs e)
        {
            var display = result.Compute(textBox1.Text, "");
            textBox1.Text = display.ToString();
           
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
