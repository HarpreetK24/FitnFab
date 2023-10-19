using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace $safeprojectname$
{
    public partial class Form8 : Form
    {
        public String data2;
        public Form8(string data1)
        {
            InitializeComponent();
            data2 = data1;
            label1.Text = data1;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            label2.ForeColor = Color.Black;
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
            panel5.BackColor = Color.White;
            label4.ForeColor = Color.Black;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
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

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.DefaultExt = "txt";

                saveFileDialog.Filter = "Text files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    string text = "Equipment id : " + textBox5.Text + "\nEquipment Name : " + textBox2.Text + "\n\n" + "Muscle Category: " + textBox1.Text + "\n\n" + "Description : "+ textBox3.Text + "\n\n" + "Price : " + textBox4.Text;

                    File.WriteAllText(filePath, text);
                }
                int i;

                toolStripProgressBar1.Minimum = 0;
                toolStripProgressBar1.Maximum = 100;

                for (i = 0; i <= 100; i += 2)
                {
                    toolStripProgressBar1.Value = i;
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            else
            {
                String message = "Enter all the details of the equipment !!!";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f2 = new Form7(data2);
            f2.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            toolStripProgressBar1.Value = 0;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
              
                textBox1.Font = fontDialog.Font;
                textBox2.Font = fontDialog.Font;    
                textBox3.Font = fontDialog.Font;   
                textBox4.Font = fontDialog.Font;  
                textBox5.Font = fontDialog.Font;
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10(data2);
            f10.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;password=mysql;database=fitnfab;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.ConnectionString = connectionString;
            connection.Open();

            string sql = "SELECT COUNT(*) FROM equipments WHERE equip_id = @id";
            MySqlCommand command1 = new MySqlCommand(sql, connection);
            command1.Parameters.AddWithValue("@id", textBox5.Text);
            int count = Convert.ToInt32(command1.ExecuteScalar());


            if (count > 0)
            {
                MessageBox.Show("Equipment \"" + textBox5.Text + "\" Already Exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO equipments values(@value1,@value2,@value3,@value4,@value5)", connection);
                command.Parameters.AddWithValue("@value1", textBox5.Text);
                command.Parameters.AddWithValue("@value2", textBox2.Text);
                command.Parameters.AddWithValue("@value3", textBox1.Text);
                command.Parameters.AddWithValue("@value4", textBox3.Text);
                command.Parameters.AddWithValue("@value5", textBox4.Text);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Details Stored Successfully !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                toolStripProgressBar1.Value = 0;

            }
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
