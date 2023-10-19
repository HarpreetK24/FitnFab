using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace $safeprojectname$
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            String path = @"C:\Users\harpreetkamboj\Documents\$safeprojectname$.txt";
            string mail = "Username : "+textBox3.Text+"Password : "+"\n"+pass.Text;
            File.WriteAllText(path, mail);
    
            Regex validateEmailRegex = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");
            if (validateEmailRegex.IsMatch(textBox3.Text) == false)
            {
                String message = "Please Enter a valid email-id";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            
            if (validateGuidRegex.IsMatch(pass.Text) == false)
            {
                String message = "Please Enter a Strong password";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
          
            
           

            //Regex validateNumRegex = new Regex("^?(0|\\+91)[6789]\\d{9}$");
            Regex validateNumRegex = new Regex("^?[6789]\\d{9}$");
            if (validateNumRegex.IsMatch(textBox4.Text) == false) 
            {
                String message = "Please Enter a valid Phone Number";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
               pass.Text == "" || pass1.Text == "" || 
               (radioButton1.Checked == false && radioButton2.Checked == false ))
            {
                MessageBox.Show("Please enter all details... No Blanks are Allowed !!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(pass.Text != pass1.Text)
            {
                MessageBox.Show("Re-entered Password in Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
               pass.Text == "" || pass1.Text == "" ||
               (radioButton1.Checked == false && radioButton2.Checked == false))
                {
                    MessageBox.Show("Some entries are missing !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
                else if (validateEmailRegex.IsMatch(textBox3.Text) == false)
                {
                   
                }

               
               else if (validateGuidRegex.IsMatch(pass.Text) == false)
                {
                    
                }

             
                else if (validateNumRegex.IsMatch(textBox4.Text) == false)
                {
                }

                else
                {
                    string connectionString = "server=localhost;uid=root;password=mysql;database=fitnfab;";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.ConnectionString = connectionString;
                    connection.Open();

                    string sql = "SELECT COUNT(*) FROM register WHERE username = @username";
                    MySqlCommand command1 = new MySqlCommand(sql, connection);
                    command1.Parameters.AddWithValue("@username", textBox1.Text);
                    int count = Convert.ToInt32(command1.ExecuteScalar());


                    if (count > 0)
                    {
                        MessageBox.Show("Username \"" + textBox1.Text + "\" Already Exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MySqlCommand command = new MySqlCommand("INSERT INTO register values(@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8)", connection);
                        command.Parameters.AddWithValue("@value1", textBox1.Text);
                        command.Parameters.AddWithValue("@value2", textBox2.Text);
                        if (radioButton1.Checked == true)
                        {
                            command.Parameters.AddWithValue("@value3", radioButton1.Text);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@value3", radioButton2.Text);
                        }

                        command.Parameters.AddWithValue("@value4", textBox3.Text);
                        command.Parameters.AddWithValue("@value5", textBox4.Text);
                        command.Parameters.AddWithValue("@value6", pass1.Text);
                        command.Parameters.AddWithValue("@value7", dateTimePicker1.Text);
                        command.Parameters.AddWithValue("@value8", richTextBox1.Text);

                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Thank you for Registering \"" + textBox1.Text + "\" !!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
               
            }
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
           
            pass.Clear(); pass1.Clear();
            dateTimePicker1.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
           
       
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }


       
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
