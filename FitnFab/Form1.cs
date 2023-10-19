
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Process.Start(new ProcessStartInfo() { FileName = "C:\\Users\\harpreetkamboj\\Documents\\login.html", UseShellExecute = true });
            Form3 f1 = new Form3();
            f1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 

            switch(true)
            {
                case true:
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        string connectionString = "server=localhost;uid=root;password=mysql;database=fitnfab;";
                        MySqlConnection connection = new MySqlConnection(connectionString);
                        connection.ConnectionString = connectionString;
                        connection.Open();

                        string sql = "SELECT COUNT(*) FROM register WHERE username = @username and password = @password";
                        MySqlCommand command1 = new MySqlCommand(sql, connection);
                        command1.Parameters.AddWithValue("@username", textBox1.Text);
                        command1.Parameters.AddWithValue("@password", textBox2.Text);
                        int count = Convert.ToInt32(command1.ExecuteScalar());


                        if (count > 0)
                        {
                            this.Hide();
                            string data = "SELECT name FROM register WHERE username = @username";
                            MySqlCommand command2 = new MySqlCommand(data, connection);
                            command2.Parameters.AddWithValue("@username", textBox1.Text);

                            string username = command2.ExecuteScalar().ToString();
                            Form5 f2 = new Form5(username);
                            f2.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (textBox1.Text == "")
                    {
                        String message = "Please enter an email-id";
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (textBox2.Text == "")
                    {
                        String message = "Please enter the Password ";
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            differentcolor();
        }
        public void differentcolor()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Button && (string)x.Tag == "group1")
                {
                    x.BackColor = Color.Black;
                    x.ForeColor = Color.White;
                }

            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.BlueViolet;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.OrangeRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.IndianRed;
        }

        private void linklabel1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Blue;
        }

        private void linklabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Red;
        }

       
    }
}