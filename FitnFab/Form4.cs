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
    public partial class Form4 : Form
    {
        public String data2;
        public Form4(string data1)
        {
            InitializeComponent();
            data2 = data1;
           label1.Text = data1;
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addMemebrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            label2.ForeColor= Color.Black;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            label8.ForeColor = Color.Black;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = Color.White;
            label3.ForeColor = Color.Black;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Transparent;
            label8.ForeColor = Color.White;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            panel7.BackColor = Color.White;
            label5.ForeColor = Color.Black;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            panel8.BackColor = Color.White;
            label6.ForeColor = Color.Black;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            panel9.BackColor = Color.White;
            label7.ForeColor = Color.Black;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.Transparent;
            label7.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f2 = new Form6(data2);
            f2.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f2 = new Form4(data2);
            f2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(data2);
            f8.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f2 = new Form7(data2);
            f2.ShowDialog();
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
