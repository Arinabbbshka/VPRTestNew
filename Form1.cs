using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPRTestNew
{
    public partial class Form1 : Form
    {
        public static int question =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            question = 11;
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            question = 8;
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            question = 9;
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            question = 10;
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            question = 7;
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            
        }
    }
}
