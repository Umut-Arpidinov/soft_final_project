using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                percentageResult.Text = Convert.ToString(Convert.ToDouble(textFirstResult.Text) * 10 / 100);
            }
            if (radioButton2.Checked == true)
            {
                percentageResult.Text = Convert.ToString(Convert.ToDouble(textFirstResult.Text) * 20 / 100);
            }
            if (radioButton3.Checked == true)
            {
                percentageResult.Text = Convert.ToString(Convert.ToDouble(textFirstResult.Text) * 50 / 100);
            }

        }

        private void getFirstResult_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(firstNum.Text);
            double b = Convert.ToDouble(secondNum.Text);
            double c = Convert.ToDouble(thirdNum.Text);
            double result = (i + b) / c;
            textFirstResult.Text = Convert.ToString(result);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void percentageResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
