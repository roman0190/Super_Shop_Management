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
        ///roman
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

            else if (textBox_password.Text == textBox_confirmpassword.Text)
            {
                string regQuery = "INSERT INTO Registration_table (Username, Password, First_name, Last_Name, Email, Gender, Address) VALUES (@Username, @Password, @First_name, @Last_name, @Email, @Gender, @Address)";
                string loginQuery = "INSERT INTO login_table (username, password) VALUES (@Username, @Password)";

                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        using (SqlCommand regCommand = new SqlCommand(regQuery, conn, transaction))
                        {
                            regCommand.Parameters.AddWithValue("@Username", textBox_username.Text);
                            regCommand.Parameters.AddWithValue("@Password", textBox_password.Text);
                            regCommand.Parameters.AddWithValue("@First_name", textBox_firstname.Text);
                            regCommand.Parameters.AddWithValue("@Last_name", textBox_lastname.Text);
                            regCommand.Parameters.AddWithValue("@Email", textBox_email.Text);
                            regCommand.Parameters.AddWithValue("@Gender", comboBox1.Text);
                            regCommand.Parameters.AddWithValue("@Address", textBox_address.Text);

                            int regResult = regCommand.ExecuteNonQuery();

                            if (regResult != 1)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Error: could not insert into Registration_table.");
                                return;
                            }
                        }

                        using (SqlCommand loginCommand = new SqlCommand(loginQuery, conn, transaction))
                        {
                            loginCommand.Parameters.AddWithValue("@Username", textBox_username.Text);
                            loginCommand.Parameters.AddWithValue("@Password", textBox_password.Text);

                            int loginResult = loginCommand.ExecuteNonQuery();

                            if (loginResult != 1)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Error: could not insert into login_table.");
                                return;
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Data inserted into both tables successfully!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                conn.Close();
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
    }
}
