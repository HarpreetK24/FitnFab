using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form5 : Form
    {
        public string data1;
        public Form5(string data)
        {
            InitializeComponent();
            timer1.Start();
            data1 = data;
        }

        int startp = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startp += 10;
            progressBar1.Value = startp;
            percent.Text = startp + "%";
            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                Form4 f1  = new Form4(data1);
                f1.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
