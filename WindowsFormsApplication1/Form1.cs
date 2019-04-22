using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int integer = Convert.ToInt32(inputBox.Text);
            if (integer % 2 == 0)
            {
                resultBox.Text = integer + " is Even";
            }
            else
            {
                resultBox.Text = integer + " is Odd";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            inputBox.Text = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
