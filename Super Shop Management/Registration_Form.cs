using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management
{
    public partial class Registration_Form : Form
    {
     
        //roman
        SqlConnection conn = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");
       
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void button_singnup_Click(object sender, EventArgs e)

        {

            if (textBox_firstname.Text == "")
            {
                MessageBox.Show("Enter your FirstName");
            }
            else if (textBox_lastname.Text == "")
            {
                MessageBox.Show("Enter your lastName");
            }
            else if (textBox_username.Text == "")
            {
                MessageBox.Show("Enter your Username");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter your Gender");
            }
            else if (textBox_address.Text == "")
            {
                MessageBox.Show("Enter your Address");
            }
            else if (textBox_email.Text == "")
            {
                MessageBox.Show("Enter your Email");
            }
            else if (textBox_petName.Text == "")
            {
                MessageBox.Show("Enter your Pet name");
            }

            else if (textBox_password.Text == textBox_confirmpassword.Text)
            {
                if (textBox_password.Text.Length >= 4)
                {
                    try
                    {
                        string query = "IF NOT EXISTS (SELECT * FROM login_table WHERE Username = '" + textBox_username.Text + "') BEGIN INSERT INTO Registration_table (Username, Password, First_name, Last_Name, Email, Gender, Address, PetName) VALUES('" + textBox_username.Text + "','" + textBox_password.Text + "','" + textBox_firstname.Text + "','" + textBox_lastname.Text + "','" + textBox_email.Text + "','" + comboBox1.Text + "','" + textBox_address.Text + "','" + textBox_petName.Text + "') END";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        conn.Open();
                        if (conn.State == ConnectionState.Open)
                        {
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                                MessageBox.Show("Congratulations, you have successfully registered! Within 24Houre Your Account will be Active");
                            else
                                MessageBox.Show("Username already exists in the Database. Use another username");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Password must have a minimum length of 4 characters.");
                }
            }
            else
            {

                MessageBox.Show("Recheak your password please!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_login_Click(object sender, EventArgs e)
        {
            Login_page login = new Login_page();
            this.Hide();
            login.Show();
        }
        private void textBox_petName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
