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

namespace $safeprojectname$
{
    public partial class Form11 : Form
    {
        public string data2;
        public Form11(String data)
        {
            InitializeComponent();
            data2 = data;
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


            if (count > 0)
            {
                dataGridView1.Visible = true;
                string sql1 = "SELECT fname, lname, dob, sex, weight, height, age, email, phone  FROM member where email=@id";
                MySqlCommand command = new MySqlCommand(sql1, connection);
                command.Parameters.AddWithValue("@id", textBox1.Text);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                connection.Close();
            }
            else
            {
                MessageBox.Show("Member does not Exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(data2);
            f8.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
