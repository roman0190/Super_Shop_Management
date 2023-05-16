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
        //roman
        SqlConnection conn = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");
        //Mrittika
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CGD8O08\\SQL2022;Initial Catalog=Dev;Integrated Security=True");
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
                string empQuery = "INSERT INTO empInfo_table (username, role, password, name, pnum) " + "VALUES ('" + textBox_emp_uname.Text + "', '" + comboBox_emp_role.Text + "', '" + textBox_emp_pass.Text + "', '" + textBox_emp_name.Text + "', '" + textBox_emp_pnum.Text + "')";

                string loginQuery = "INSERT INTO login_table (username, password, role) " + "VALUES ('" + textBox_emp_uname.Text + "', '" + textBox_emp_pass.Text + "', '" + comboBox_emp_role.Text + "')";

                SqlCommand empCmd = new SqlCommand(empQuery, conn);
                SqlCommand loginCmd = new SqlCommand(loginQuery, conn);
                SqlTransaction transaction = null;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    empCmd.Transaction = transaction;
                    loginCmd.Transaction = transaction;
                    int empRows = empCmd.ExecuteNonQuery();
                    int loginRows = loginCmd.ExecuteNonQuery();
                    if (empRows > 0 && loginRows > 0)
                    {
                        transaction.Commit();
                        MessageBox.Show("Employee Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_emp_uname.Text = "";
                        textBox_emp_pass.Text = "";
                        comboBox_emp_role.Text = "";
                        textBox_emp_name.Text = "";
                        textBox_emp_pnum.Text = "";
                    }
                    else
                    {
                        transaction.Rollback();
                        MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_emp_uname.Text = "";
                    textBox_emp_pass.Text = "";
                    comboBox_emp_role.Text = "";
                    textBox_emp_name.Text = "";
                    textBox_emp_pnum.Text = "";
                }
                finally
                {
                    conn.Close();
                }
                display_data();
        }

        private void button_emp_delete_Click(object sender, EventArgs e)
        {
            string empQuery = "DELETE FROM empInfo_table WHERE username = '" + textBox_emp_uname.Text + "'";
            string loginQuery = "DELETE FROM login_table WHERE username = '" + textBox_emp_uname.Text + "'";
            SqlCommand empCmd = new SqlCommand(empQuery, conn);
            SqlCommand loginCmd = new SqlCommand(loginQuery, conn);
            SqlTransaction transaction = null;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                empCmd.Transaction = transaction;
                loginCmd.Transaction = transaction;
                int empRows = empCmd.ExecuteNonQuery();
                int loginRows = loginCmd.ExecuteNonQuery();
                if (empRows > 0 && loginRows > 0)
                {
                    transaction.Commit();
                    MessageBox.Show("Employee Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_emp_uname.Text = "";
                    textBox_emp_pass.Text = "";
                    comboBox_emp_role.Text = "";
                    textBox_emp_name.Text = "";
                    textBox_emp_pnum.Text = "";
                }
                else
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_emp_uname.Text = "";
                textBox_emp_pass.Text = "";
                comboBox_emp_role.Text = "";
                textBox_emp_name.Text = "";
                textBox_emp_pnum.Text = "";
            }
            finally
            {
                conn.Close();
            }
            display_data();
        }

        private void button_emp_update_Click(object sender, EventArgs e)
        {
            string empQuery = "UPDATE empInfo_table SET role='" + comboBox_emp_role.Text + "', password='" + textBox_emp_pass.Text + "', name='" + textBox_emp_name.Text + "', pnum='" + textBox_emp_pnum.Text + "' WHERE username='" + textBox_emp_uname.Text + "'";

            string loginQuery = "UPDATE login_table SET password='" + textBox_emp_pass.Text + "', role='" + comboBox_emp_role.Text + "' WHERE username='" + textBox_emp_uname.Text + "'";

            SqlCommand empCmd = new SqlCommand(empQuery, conn);
            SqlCommand loginCmd = new SqlCommand(loginQuery, conn);
            SqlTransaction transaction = null;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                empCmd.Transaction = transaction;
                loginCmd.Transaction = transaction;
                int empRows = empCmd.ExecuteNonQuery();
                int loginRows = loginCmd.ExecuteNonQuery();
                if (empRows > 0 && loginRows > 0)
                {
                    transaction.Commit();
                    MessageBox.Show("Employee Info Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_emp_uname.Text = "";
                    textBox_emp_pass.Text = "";
                    comboBox_emp_role.Text = "";
                    textBox_emp_name.Text = "";
                    textBox_emp_pnum.Text = "";
                }
                else
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_emp_uname.Text = "";
                textBox_emp_pass.Text = "";
                comboBox_emp_role.Text = "";
                textBox_emp_name.Text = "";
                textBox_emp_pnum.Text = "";
            }
            finally
            {
                conn.Close();
            }
            display_data();
        }

        private void Admin_empInfo_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button_emp_src_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming that you have already created and opened a SqlConnection object named "conn"
                string q1 = "SELECT * FROM empInfo_table WHERE username LIKE @search";
                SqlDataAdapter sda = new SqlDataAdapter(q1, conn);
                sda.SelectCommand.Parameters.AddWithValue("@search", "%" + textBox_search.Text + "%");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_emp.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void display_data()
        {
            try
            {
                string q2 = "select * from empInfo_table ";
                SqlDataAdapter sda = new SqlDataAdapter(q2, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_emp.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dataGridView_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView_emp.Rows[e.RowIndex];

            // Assign the values of selected row to TextBoxes
            textBox_emp_uname.Text = row.Cells["username"].Value.ToString();
            textBox_emp_pass.Text = row.Cells["password"].Value.ToString();
            textBox_emp_name.Text = row.Cells["name"].Value.ToString();
            textBox_emp_pnum.Text = row.Cells["pnum"].Value.ToString();
            comboBox_emp_role.Text = row.Cells["role"].Value.ToString();
            
        }

        private void button_cusHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cus_History cusH = new Cus_History();
            cusH.Show();

        }
    }
}
