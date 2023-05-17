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
    public partial class Emp_custInfo : Form
    {
        
        //roman
        SqlConnection conn = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");
        public Emp_custInfo()
        {
            InitializeComponent();
        }

        private void button_custInfo_Click(object sender, EventArgs e)
        {

        }

        private void button_custUpdate_Click(object sender, EventArgs e)
        {
            string query1 = "UPDATE Registration_table SET Address = '" + textBox_custAddress.Text + "', Email = '" + textBox_custEmail.Text + "' WHERE Username = '" + textBox_custUname.Text + "'";

            SqlCommand cmd = new SqlCommand(query1, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Customer Info Updated!");
                    textBox_custUname.Text = " ";
                    textBox_custAddress.Text = " ";
                    textBox_custEmail.Text = " ";
                }
                else
                    MessageBox.Show("Failed!");

            }
            conn.Close();
            display_data();
        }

        private void button_empLogout_Click(object sender, EventArgs e)
        {
            Login_page lgp = new Login_page();
            this.Hide();
            lgp.Show();
        }

        private void button_itemInfo_Click(object sender, EventArgs e)
        {
            Emp_itemInfo ii = new Emp_itemInfo();
            this.Hide();
            ii.Show();
        }

        private void Emp_custInfo_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button_custRemove_Click(object sender, EventArgs e)
        {
            string query1 = "DELETE FROM Registration_table WHERE Username = '" + textBox_custUname.Text + "'";
            string query2 = "DELETE from login_table WHERE Username = '" + textBox_custUname.Text + "'";

            SqlCommand cmd = new SqlCommand(query1, conn);
            SqlCommand cmd1 = new SqlCommand(query2, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                int rows1 = cmd1.ExecuteNonQuery();
                if (rows > 0 && rows1 > 0)
                {
                    MessageBox.Show("Customer removed!");
                    textBox_custUname.Text = " ";
                }
                else
                {
                    MessageBox.Show("Failed to remove customer!");
                }
                    
            }
            conn.Close();
            display_data();

        }
        public void display_data()
        {
            
            try
            {
                string q2 = "select Username, Address, Email,Active_Status from Registration_table ";
                SqlDataAdapter sda = new SqlDataAdapter(q2, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_cust.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView_cust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if the clicked row is valid
            {
                DataGridViewRow row = this.dataGridView_cust.Rows[e.RowIndex];

                // Populate textboxes with data from the selected row
                textBox_custUname.Text = row.Cells["Username"].Value.ToString();
                textBox_custAddress.Text = row.Cells["Address"].Value.ToString();
                textBox_custEmail.Text = row.Cells["Email"].Value.ToString();
            }
            try
            {
                foreach (DataGridViewRow row in dataGridView_cust.Rows)
                {
                    bool select1 = Convert.ToBoolean(row.Cells[0].Value);
                    if (select1)
                    {
                        SqlCommand cmd = new SqlCommand("insert into login_table (Username, Password)values(@Username,@Password)", conn);
                        cmd.Parameters.AddWithValue("username", row.Cells["username"].Value);
                        cmd.Parameters.AddWithValue("password", row.Cells["password"].Value);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This selecet Customer Alraedy Active or You can Active 1 Customer At a time");
            }

        }

        private void button_custSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string q1 = "SELECT Username, Address, Email FROM Registration_table WHERE Username LIKE '" + textBox_custSearch.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(q1, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_cust.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button_custActivate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO login_table (username, password) SELECT Username, Password FROM Registration_table WHERE Username = @Username", conn);
            cmd.Parameters.AddWithValue("@Username", textBox_custUname.Text);
            SqlCommand cmd2 = new SqlCommand("UPDATE Registration_table SET Active_Status = 'Active' WHERE Username = @Username", conn);
            cmd2.Parameters.AddWithValue("@Username", textBox_custUname.Text);


            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                int rowsAffected2 = cmd2.ExecuteNonQuery();
                conn.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User has been activated.");
                }
                else
                {
                    MessageBox.Show("No rows inserted.");
                }
            }
            catch
            {
                MessageBox.Show("User is already active.");
                Emp_custInfo emp = new Emp_custInfo();
                this.Hide();
                emp.Show();
            }

            Emp_custInfo emp1 = new Emp_custInfo();
            this.Hide();
            emp1.Show();

        }

        private void panel_custInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
