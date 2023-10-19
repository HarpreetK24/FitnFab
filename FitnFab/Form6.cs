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
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using MySql.Data.MySqlClient;

namespace $safeprojectname$
{
    public partial class Form6 : Form
    {
        string data3;
        int newWidth = 240;
        int newHeight = 260;
        public Form6(string data2)
        {

            InitializeComponent();
            data3 = data2;
            label1.Text = data3;
        }

        

       
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f2 = new Form4(data3);
            f2.ShowDialog();
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

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            panel5.BackColor = Color.White;
            label4.ForeColor = Color.Black;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            String path = @"C:\Users\harpreetkamboj\Documents\$safeprojectname$.txt";
            string mail = "Username : " + textBox3.Text + "Password : " + "\n" + pass.Text;
            File.WriteAllText(path, mail);

            Regex validateEmailRegex = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            Regex validateNumberRegex = new Regex("^(?:-(?:[1-9](?:\\d{0,2}(?:,\\d{3})+|\\d*))|(?:0|(?:[1-9](?:\\d{0,2}(?:,\\d{3})+|\\d*))))(?:.\\d+|)$");
            Regex validateNumRegex = new Regex("^?(0|\\+91)[6789]\\d{9}$");


             if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
               pass.Text == "" || pass1.Text == "" ||
               (radioButton1.Checked == false && radioButton2.Checked == false))
            {
                MessageBox.Show("Please enter all details... No Blanks are Allowed !!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            else if (validateNumberRegex.IsMatch(textBox6.Text) == false || textBox6.Text == "0" )
            {
                String message = "Please Enter a valid weight";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (validateEmailRegex.IsMatch(textBox3.Text) == false)
            {
                String message = "Please Enter a valid email-id";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (validateNumRegex.IsMatch(textBox4.Text) == false)
            {
                String message = "Please Enter a valid Phone Number";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (validateGuidRegex.IsMatch(pass.Text) == false)
            {
                String message = "Please Enter a Strong password";
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
           // Regex validateNumRegex = new Regex("^?[6789]\\d{9}$");
           
            else if (pass.Text != pass1.Text)
            {
                MessageBox.Show("Re-entered Password in Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (pictureBox9.Image == null)
            {
                MessageBox.Show("Please Insert Your Picture !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
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

                else if (validateNumberRegex.IsMatch(textBox6.Text) == false || textBox6.Text == "0")
                {
                }
                else if (validateNumRegex.IsMatch(textBox4.Text) == false)
                {
                }
                else if (pictureBox9.Image == null)
                { 
                }
                else
                {
                    string connectionString = "server=localhost;uid=root;password=mysql;database=fitnfab;";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.ConnectionString = connectionString;
                    connection.Open();

                    string sql = "SELECT COUNT(*) FROM member WHERE email = @id";
                    MySqlCommand command1 = new MySqlCommand(sql, connection);
                    command1.Parameters.AddWithValue("@id", textBox3.Text);
                    int count = Convert.ToInt32(command1.ExecuteScalar());


                    if (count > 0)
                    {
                        MessageBox.Show("Member \"" + textBox3.Text + "\" Already Exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MySqlCommand command = new MySqlCommand("INSERT INTO member values(@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8,@value9)", connection);
                        command.Parameters.AddWithValue("@value1", textBox1.Text);
                        command.Parameters.AddWithValue("@value2", textBox2.Text);
                        command.Parameters.AddWithValue("@value3", dateTimePicker1.Text);
                        if (radioButton1.Checked == true)
                        {
                            command.Parameters.AddWithValue("@value4", radioButton1.Text);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@value4", radioButton2.Text);
                        }
                        command.Parameters.AddWithValue("@value5", textBox6.Text);
                        command.Parameters.AddWithValue("@value6", numericUpDown1.Text);
                        command.Parameters.AddWithValue("@value7", textBox5.Text);
                        command.Parameters.AddWithValue("@value8", textBox3.Text);
                        command.Parameters.AddWithValue("@value9", textBox4.Text);

                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Registration Successful ! \"", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        numericUpDown1.Text = "4.5";
                        textBox6.Clear();
                        pass.Clear(); pass1.Clear();
                        dateTimePicker1.ResetText();
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox3.Enabled = true;
                        pictureBox9.Image = null;

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
            numericUpDown1.Text = "4.5";
            textBox6.Clear();
            pass.Clear(); pass1.Clear();
            dateTimePicker1.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox3.Checked = false;
            checkBox3.Enabled = true;
            pictureBox9.Image = null;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
                int myAge =
    DateTime.Today.Year - dateTimePicker1.Value.Year; // CurrentYear - YourBirthDate

                textBox5.Text = myAge.ToString();
                checkBox3.Enabled = false;
            }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
           
            f.Filter = "JPG (*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image file = System.Drawing.Image.FromFile(f.FileName);
                Bitmap newImage = new Bitmap(newWidth, newHeight);

               
                using (Graphics graphics = Graphics.FromImage(newImage))
                {
                   
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                  
                    graphics.DrawImage(file, 0, 0, newWidth, newHeight);
                }

                
                pictureBox9.Image = newImage;
                label20.Visible = false;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f1 = new Form7(data3);
            f1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f1 = new Form8(data3);
            f1.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f2 = new Form9(data3);
            f2.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form11 f2 = new Form11(data3);
            f2.ShowDialog();
        }
    }
}
