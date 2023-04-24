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
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-67JSOLH\\SQL2022;Initial Catalog=form;Integrated Security=True");
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void button_singnup_Click(object sender, EventArgs e)

        {
            /* if (textBox_password.Text == "" || textBox_confirmpassword.Text == "" || textBox_username.Text == "" ||textBox_address.Text == "" || textBox_email.Text == "" || textBox_firstname.Text =="" || textBox_lastname.Text =="" || comboBox1.Text =="")
           {
               MessageBox.Show("You must fill all the information");
           }*/
            if (textBox_firstname.Text == "")
            {
                MessageBox.Show("Enter your FirstName");
            }
            else if(textBox_lastname.Text== "")
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
            
          
            else
            {
                
                
                    if (textBox_password.Text == textBox_confirmpassword.Text)
                    {
                        MessageBox.Show("You are successfully registired");

                    }
                    else 
                    {
                        MessageBox.Show("Recheak plz");

                    }
                    
                
             


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
