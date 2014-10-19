using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3AllPermutationOfString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                IterativePermutation p = new IterativePermutation(textBox1.Text);
                richTextBox1.Text = p.getResults();
            }
            else if (radioButton2.Checked)
            {
                richTextBox1.Text = "";
                RecursivePermutation p = new RecursivePermutation(textBox1.Text);
                richTextBox1.Text = p.getResults();
            }
        }
    }
}
