using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string tempCut = "";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void rANDOMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog(); 
            fd.Font = richTextBox1.SelectionFont; 
            fd.Color = richTextBox1.SelectionColor; 
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font; 
                richTextBox1.SelectionColor = fd.Color;

            } 
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(fName);
            sw.Write(richTextBox1.Text);
            sw.Flush();
            sw.Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = richTextBox1.SelectionColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;

            } 

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempCut = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = tempCut;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempCut = richTextBox1.SelectedText;
        }

        private void thisIsAwesomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var ary = richTextBox1.SelectedText.ToCharArray();
            Array.Reverse(ary);
            richTextBox1.SelectedText = new string(ary);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
