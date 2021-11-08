using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace QuitSmoking
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            label2.Text = textBox1.Text;
            label5.Text = textBox2.Text;
            label7.Text = (Convert.ToDouble(textBox1.Text) * 365 * Convert.ToDouble(textBox2.Text)*18).ToString();
            if (label14.Text == "Marlboro")
            {
                label9.Text = (37* 365*Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
            }
            else if(label14.Text == "Camel")
            {
                label9.Text = (33 * 365 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
            }
            else if (label14.Text == "Marquises")
            {
                label9.Text = (21 * 365 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
            }
            else if (label14.Text == "Chesterfield")
            {
                label9.Text = (22 * 365 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
            }
            else if (label14.Text == "Glamour Pinks")
            {
                label9.Text = (36 * 365 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
            }
            else if (label14.Text == "Winston")
            {
                label9.Text = (35 * 365 * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label14.Text = Form2.v;
        }
    }
}
