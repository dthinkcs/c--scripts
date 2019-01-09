using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            string str = label1.Text;
            int indexPlus = str.IndexOf('+');
            int indexMinus = str.IndexOf('-');
            int indexMultiply = str.IndexOf('x');
            int indexDivide = str.IndexOf('/');

            if (indexPlus != -1)
            {
                double n1 = double.Parse(str.Substring(0, indexPlus));
                double n2 = double.Parse(str.Substring(indexPlus + 1));
                double res = n1 + n2;
                label1.Text = res.ToString();
            }
            else if (indexMinus != -1)
            {
                double n1 = double.Parse(str.Substring(0, indexMinus));
                double n2 = double.Parse(str.Substring(indexMinus + 1));
                double res = n1 - n2;
                label1.Text = res.ToString();

            }
            else if (indexMultiply != -1)
            {
                double n1 = double.Parse(str.Substring(0, indexMultiply));
                double n2 = double.Parse(str.Substring(indexMultiply + 1));
                double res = n1 * n2;
                label1.Text = res.ToString();
            }
            else if (indexDivide != -1)
            {
                double n1 = double.Parse(str.Substring(0, indexDivide));
                double n2 = double.Parse(str.Substring(indexDivide + 1));
                double res = n1 / n2;
                label1.Text = res.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            label1.Text += "x";

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            label1.Text += "-";

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            label1.Text += "+";

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            label1.Text += "/";

        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {

            label1.Text = Math.Sqrt(double.Parse(label1.Text)).ToString(); 
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            label1.Text = Math.Sin(double.Parse(label1.Text)).ToString(); 
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            label1.Text = Math.Cos(double.Parse(label1.Text)).ToString(); 

        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            label1.Text = Math.Tan(double.Parse(label1.Text)).ToString(); 

        }


    }
}
