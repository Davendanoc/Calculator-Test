using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Test
{
    public partial class Form1 : Form
    {

        public Double x, y;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string xt = textBox1.Text;
            x = Convert.ToDouble(xt);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string yt = textBox2.Text;
            y = Convert.ToDouble(yt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ans;


            if (selSum.Checked == true)
            {
                ans = x + y;
                textBox3.Text = ans.ToString("0.0000");
            }

            else if (selRes.Checked == true)
            {
                ans = x - y;
                textBox3.Text = ans.ToString("0.0000");
            }

            else if (selMul.Checked == true)
            {
                ans = x * y;
                textBox3.Text = ans.ToString("0.0000");
            }

            else if (selDi.Checked == true)
            {
                ans = x / y;
                textBox3.Text = ans.ToString("0.0000");
            }

            else
                textBox3.Text = "";
        }
    }
}

