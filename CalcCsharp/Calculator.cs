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
        int count;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            //clear the textBox;
            textBox1.Clear();
            count = 0;

        }
    }
}
