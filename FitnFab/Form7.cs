using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace $safeprojectname$
{
    public partial class Form7 : Form
    {
        public String data2;
        public Form7(string data1)
        {
            InitializeComponent();
            data2 = data1;
            label1.Text = data1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;

            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 100;

            for (i = 0; i <= 100; i+=2)
            {
                toolStripProgressBar1.Value = i;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f2 = new Form4(data2);
            f2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f2 = new Form6(data2);
            f2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(data2);
            f8.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f2 = new Form9(data2);
            f2.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f2 = new Form11(data2);
            f2.ShowDialog();
        }
    }
}
