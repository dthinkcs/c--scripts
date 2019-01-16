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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = label2.Text + Form1.username;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You sent " + usernameTextBox.Text + " an amount of ₹" + passwordTextBox.Text);
            
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You sent " + "drsarita" + " an amount of ₹" + "10");
            MessageBox.Show("You sent " + "drsarita" + " an amount of ₹" + "20");
            MessageBox.Show("You sent " + "drsarita" + " an amount of ₹" + "30");
            MessageBox.Show("You sent " + "drsarita" + " an amount of ₹" + "40");
            MessageBox.Show("You sent " + "drsarita" + " an amount of ₹" + "50");



        }
    }
}
