using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Lab1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Clicked on the button";
            MessageBox.Show("An event has occured");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (button1.Visible == false) MessageBox.Show("The first button is not visible");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int viNumber = Convert.ToInt32(textBox1.Text) * 5;
            label1.Text = "Entered number multiplied by 5 =" + viNumber.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
