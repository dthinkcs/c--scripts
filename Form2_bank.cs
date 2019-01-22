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
        public static int balance = 1000;
        public static List<string> sentTopeople = new List<string>();
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
            if (Form2.balance - int.Parse(passwordTextBox.Text) >= 0)
            {
                string str = "You sent " + usernameTextBox.Text + " an amount of ₹" + passwordTextBox.Text;
                Form2.balance -= int.Parse(passwordTextBox.Text);
                label6.Text = "Balance: ₹" + Form2.balance;
                sentTopeople.Add(str);
                MessageBox.Show(str);
            }
            
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ;
            string str = "LAST TRANSACTIONS (at most last 5):\n\n";
            int k = 0;
            for (int i = Form2.sentTopeople.Count() - 1; i >= 0; i--, k++)
            {
                if (k >= 5) 
                    break;
                str += Form2.sentTopeople[i] + "\n";
            }
            MessageBox.Show(str);



        }
    }
}
