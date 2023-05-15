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
    public partial class Cust_verification : Form
    {
        //Mrittika
        // SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CGD8O08\\SQL2022;Initial Catalog=Dev;Integrated Security=True");

        //roman
        SqlConnection conn = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");

        public static string uname;
        public Cust_verification()
        {
            InitializeComponent();
        }

        private void label_backToLogin_Click(object sender, EventArgs e)
        {
            Login_page lg = new Login_page();
            this.Hide();
            lg.Show();
        }

        private void button_verifyQ_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Registration_table WHERE Username = @username AND PetName = @petname";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", textBox_uname.Text);
            cmd.Parameters.AddWithValue("@petname", textBox_petName.Text);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Create new password textbox
                    TextBox textBox_newPass = new TextBox();
                    textBox_newPass.Name = "textBox_newPass";
                    //textBox_newPass.PasswordChar = '*';
                    textBox_newPass.Font = new Font("Microsoft Sans Serif", 14.25f);
                    textBox_newPass.ForeColor = SystemColors.WindowText;
                    textBox_newPass.Size = new Size(211, 27);
                    textBox_newPass.Location = new Point(28, 330);
                    this.Controls.Add(textBox_newPass);

                    // Create new confirm password textbox
                    TextBox txtConfirmPass = new TextBox();
                    txtConfirmPass.Name = "txtConfirmPass";
                    //txtConfirmPass.PasswordChar = '*';
                    txtConfirmPass.Font = new Font("Microsoft Sans Serif", 14.25f);
                    txtConfirmPass.ForeColor = SystemColors.WindowText;
                    txtConfirmPass.Size = new Size(211, 27);
                    txtConfirmPass.Location = new Point(28, 403);
                    this.Controls.Add(txtConfirmPass);

                    // Create new password label
                    Label lblNewPass = new Label();
                    lblNewPass.Name = "lblNewPass";
                    lblNewPass.Text = "New Password";
                    lblNewPass.Font = new Font("MS UI Gothic", 14.25f, FontStyle.Bold);
                    lblNewPass.ForeColor = Color.White;
                    lblNewPass.Size = new Size(138, 19);
                    lblNewPass.Location = new Point(24, 296);
                    this.Controls.Add(lblNewPass);

                    // Create new confirm password label
                    Label lblConfirmPass = new Label();
                    lblConfirmPass.Name = "lblConfirmPass";
                    lblConfirmPass.Text = "Confirm Password";
                    lblConfirmPass.Font = new Font("MS UI Gothic", 14.25f, FontStyle.Bold);
                    lblConfirmPass.ForeColor = Color.White;
                    lblConfirmPass.Size = new Size(172, 19);
                    lblConfirmPass.Location = new Point(24, 371);
                    this.Controls.Add(lblConfirmPass);

                    // Create new reset password label
                    Label lblresetPass = new Label();
                    lblresetPass.Name = "lblresetPassword";
                    lblresetPass.Text = "Reset Password";
                    lblresetPass.Font = new Font("MS UI Gothic", 20.25f, FontStyle.Bold);
                    lblresetPass.ForeColor = Color.White;
                    lblresetPass.Size = new Size(208, 27);
                    lblresetPass.Location = new Point(112, 249);
                    this.Controls.Add(lblresetPass);

                    // Create new reset password button
                    Button btnResetPass = new Button();
                    btnResetPass.Name = "btnResetPass";
                    btnResetPass.Text = "Reset Password";
                    btnResetPass.Font = new Font("MS UI Gothic", 14.25f, FontStyle.Bold);
                    btnResetPass.BackColor = Color.SlateBlue;
                    btnResetPass.ForeColor = Color.White;
                    btnResetPass.Size = new Size(81, 29);
                    btnResetPass.Location = new Point(341, 454);
                    btnResetPass.FlatStyle = FlatStyle.Flat;
                    btnResetPass.FlatAppearance.BorderSize = 0;
                    btnResetPass.Click += new EventHandler(button_resetPass_Click);
                    this.Controls.Add(btnResetPass);

                    // Hide the verify button and pet name textbox
                    button_verifyQ.Hide();
                    textBox_petName.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or pet name. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying credentials: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_resetPass_Click(object sender, EventArgs e)
        {
            TextBox textBox_newPass = this.Controls.Find("textBox_newPass", true).FirstOrDefault() as TextBox;
            TextBox textBox_confirmPass = this.Controls.Find("txtConfirmPass", true).FirstOrDefault() as TextBox;

            if (textBox_newPass != null && textBox_confirmPass != null)
            {
                string password = textBox_confirmPass.Text;
                string username = textBox_uname.Text;
                if (textBox_newPass.Text == textBox_confirmPass.Text)
                {

                    //Using a parameterized query to prevent SQL injection
                    string query = @"BEGIN TRANSACTION;
                    UPDATE Registration_table SET Password = @password WHERE Username = @username;
                    UPDATE Login_table SET Password = @password WHERE Username = @username;
                    COMMIT;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password successfully changed");

                        Login_page lg = new Login_page();
                        this.Hide();
                        lg.Show();
                    }
                    catch (Exception ex)
                    {
                        // Handle the error
                        MessageBox.Show("Error changing password: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, your new password and confirm password do not match.");
                }
            }

        }
    }
}
