using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace $safeprojectname$
{
    public partial class Form10 : Form
    {
        string data1;
        public Form10(string data)
        {
            InitializeComponent();
            data1 = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8(data1);
            f8.ShowDialog();
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string connectionString = "server=localhost;uid=root;password=mysql;database=fitnfab;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.ConnectionString = connectionString;
            connection.Open();

            string sql = "SELECT COUNT(*) FROM equipments WHERE equip_id = @id";
            MySqlCommand command1 = new MySqlCommand(sql, connection);
            command1.Parameters.AddWithValue("@id", textBox1.Text);
            int count = Convert.ToInt32(command1.ExecuteScalar());


            if (count > 0)
            {
                dataGridView1.Visible = true;
                string sql1 = "SELECT equip_id, equip_name, Muscle_category, equip_description, equip_price FROM equipments where equip_id=@id";
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
                MessageBox.Show("Equipment with ID \"" + textBox1.Text + "\" does not Exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        }
    }
}
