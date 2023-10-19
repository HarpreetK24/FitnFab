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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace $safeprojectname$
{
    public partial class Form9 : Form
    {
        public string data2;
        public Form9(string data1)
        {
            InitializeComponent();
            data2 = data1;
            label1.Text = data1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;password=mysql;database=fitnfab;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.ConnectionString = connectionString;
            connection.Open();

            string sql = "SELECT COUNT(*) FROM member WHERE email = @id";
            MySqlCommand command1 = new MySqlCommand(sql, connection);
            command1.Parameters.AddWithValue("@id", textBox1.Text);
            int count = Convert.ToInt32(command1.ExecuteScalar());


            if (count == 1)
            {
                MySqlCommand command = new MySqlCommand("Delete from member where email=@value1", connection);
                command.Parameters.AddWithValue("@value1", textBox1.Text);

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Member Deleted Successfully!! \"", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Member Does not Exists! \"", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();

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

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(data2);
            f8.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f8 = new Form11(data2);
            f8.ShowDialog();
        }
    }
}
