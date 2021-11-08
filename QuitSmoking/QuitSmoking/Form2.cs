using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuitSmoking
{
    public partial class Form2 : Form
    {
        public static string v ="";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Marlboro");
            comboBox1.Items.Add("Camel");
            comboBox1.Items.Add("Marquises");
            comboBox1.Items.Add("Chesterfield");
            comboBox1.Items.Add("Glamour Pinks");
            comboBox1.Items.Add("Winston");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = "18 mg";
            if (comboBox1.SelectedIndex == 0)
            {
                label4.Text = "37 DH";               
                groupBox2.Visible = true;
                comboBox1.Items.Clear();
                label6.Text = "Marlboro";
                pictureBox1.Visible = true;
                 label9.Text = "Marlboro";               
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label4.Text = "33 DH";             
                groupBox2.Visible = true;
                comboBox1.Items.Clear();
                label6.Text = "Camel";
                pictureBox2.Visible = true;
                label9.Text = "Camel";
            }
            else if (comboBox1.SelectedIndex == 2)
            {   
                label4.Text = "21 DH";
                groupBox2.Visible = true;
                comboBox1.Items.Clear();
                label6.Text = "Marquises";
                pictureBox3.Visible = true;
                label9.Text = "Marquises";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label4.Text = "22 DH";
                groupBox2.Visible = true;
                comboBox1.Items.Clear();
                label6.Text = "Chesterfield";
                pictureBox4.Visible = true;
                label9.Text = "Chesterfield";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
 
                label4.Text = "36 DH";
                groupBox2.Visible = true;
                comboBox1.Items.Clear();
                label6.Text = "Glamour Pinks";
                pictureBox5.Visible = true;
                label9.Text = "Glamour Pinks";
            }
            else if (comboBox1.SelectedIndex == 5)
            {        
                label4.Text = "35DH";              
                groupBox2.Visible = true;
                comboBox1.Items.Clear();
                label6.Text = "Winston";
                pictureBox6.Visible = true;
                label9.Text = "Winston";
            }
            
        }
            
            
        

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            v = label9.Text;
            this.Hide();
            Form3 f = new Form3();
            f.Show();
            
        }
    }
}
