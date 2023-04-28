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
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-67JSOLH\\SQL2022;Initial Catalog=form;Integrated Security=True");
        //Mrittika
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CGD8O08\\SQL2022;Initial Catalog=Dev;Integrated Security=True");
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

            else if (textBox_password.Text == textBox_confirmpassword.Text)
            {
                string query = "insert into Registration_table (Username,Password,First_name,Last_Name,Email,Gender,Address) values('" + textBox_username.Text + "','" + textBox_password.Text + "','" + textBox_firstname.Text + "','" + textBox_lastname.Text + "','" + textBox_email.Text + "','" + comboBox1.Text + "','" + textBox_address.Text + "')";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Congratulation,you have successfully registered!!!");
                    else
                        MessageBox.Show("Opps!!!");

                }
            }
            else
            {

                MessageBox.Show("Recheck your password please!");
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
    }
}
