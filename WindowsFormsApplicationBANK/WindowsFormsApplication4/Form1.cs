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
        public static string username = "";
        public static string password = "1234";

        public static double balance = 1000;
        public static string lastAccess = "16/01/2019";
        public static string date = "16/01/2019";

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
            if (usernameTextBox.Text == "rraj" && passwordTextBox.Text == password)
            {
                username = usernameTextBox.Text;
                MessageBox.Show("Rishabh Raj Welcome!");
                Form2 f2 = new Form2();
                f2.Show();
                Form1 f1 = new Form1();
                f1.Hide();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text;
        }
    }
}
