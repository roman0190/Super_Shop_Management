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
    public partial class Admin_empInfo : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");
        public Admin_empInfo()
        {
            InitializeComponent();
        }

        private void button_ItemInfo_Click(object sender, EventArgs e)
        {
            Admin_itemInfo item = new Admin_itemInfo();
            item.Show();
            this.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_logoutAdmin_Click(object sender, EventArgs e)
        {
            Login_page lgp = new Login_page();
            lgp.Show();
            this.Hide();
        }

        private void button_emp_insert_Click(object sender, EventArgs e)
        {
            if (textBox_emp_uname.Text == " " || textBox_emp_uname.Text == " " || comboBox_emp_role.Text == " ")
            {
                MessageBox.Show("Fill data properly");
            }
            else
            {
                string query = "insert into empInfo_table(username,password,role) values('" + textBox_emp_uname.Text + "','" + textBox_emp_pass.Text + "','" + comboBox_emp_role.Text + "')";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Employee Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox_emp_uname.Text = "";
                            textBox_emp_pass.Text = "";
                            comboBox_emp_role.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                conn.Close();
                display_data();
            }
        }

        private void button_emp_delete_Click(object sender, EventArgs e)
        {
            string query1 = "delete from empInfo_table where username = '" + textBox_emp_uname.Text + "'";
            SqlCommand cmd = new SqlCommand(query1, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Employee Info Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_emp_uname.Text = "";
                        textBox_emp_pass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            conn.Close();
            display_data();
        }

        private void button_emp_update_Click(object sender, EventArgs e)
        {
            string query1 = "update empInfo_table set password ='" + textBox_emp_pass.Text + "' where username = '" + textBox_emp_uname.Text + "'";
            SqlCommand cmd = new SqlCommand(query1, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Employee Info Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_emp_uname.Text = "";
                        textBox_emp_pass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            conn.Close();
            display_data();


        }

        private void Admin_empInfo_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button_emp_src_Click(object sender, EventArgs e)
        {
            string q1 = "SELECT * FROM empInfo_table WHERE username LIKE @search";
            SqlDataAdapter sda = new SqlDataAdapter(q1, conn);
            sda.SelectCommand.Parameters.AddWithValue("@search", "%" + textBox_search.Text + "%");
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_emp.DataSource = dt;

        }


        public void display_data()
        {
            conn.Open();
            string q2= "select * from empInfo_table ";
            SqlDataAdapter sda = new SqlDataAdapter(q2, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_emp.DataSource = dt;
            conn.Close();
        }
    }
}
