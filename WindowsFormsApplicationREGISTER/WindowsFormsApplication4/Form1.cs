using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // if (usernameTextBox.Text == "rraj" && passwordTextBox.Text == "1234")
            string choiceRadio = "";
            if (radioButton1.Checked)
                choiceRadio = radioButton1.Text;
            else if (radioButton2.Checked)
                choiceRadio = radioButton2.Text;

            string date = dateTimePicker1.Value.ToShortDateString();

            MessageBox.Show(usernameTextBox.Text + " your application has been submitted!\n" + textBox1.Text + "\n" + comboBox1.Text + "\n" + choiceRadio + "\n" + date);
           
  

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
