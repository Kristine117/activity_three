using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string userAnswer = "";
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer += "\n" + checkBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
            {
                MessageBox.Show("You selected: " + userAnswer + "\n" +textBox1.Text + "\nThank you");
            }
            MessageBox.Show("You selected: " + userAnswer + "\nThank you");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer += "\n" + checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer += "\n" + checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            userAnswer += "\n"+checkBox4.Text;

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox1.Visible = true;
        }
    }
}
