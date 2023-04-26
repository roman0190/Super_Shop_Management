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
    public partial class Admin_itemInfo : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");
        public Admin_itemInfo()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button_logoutAdmin_MouseEnter_1(object sender, EventArgs e)
        {
            button_logoutAdmin.ForeColor = Color.SlateBlue;
            button_logoutAdmin.BackColor = Color.White;
        }

        private void button_logoutAdmin_MouseLeave(object sender, EventArgs e)
        {
            button_logoutAdmin.ForeColor = Color.White;
            button_logoutAdmin.BackColor = Color.Empty;
        }

        private void button_ItemInfo_MouseEnter(object sender, EventArgs e)
        {
            button_ItemInfo.ForeColor = Color.SlateBlue;
            button_ItemInfo.BackColor = Color.White;
        }

        private void button_ItemInfo_MouseLeave_1(object sender, EventArgs e)
        {
            button_ItemInfo.ForeColor = Color.White;
            button_ItemInfo.BackColor = Color.Empty;
        }

        private void button_empInfo_MouseEnter(object sender, EventArgs e)
        {
            button_empInfo.ForeColor = Color.SlateBlue;
            button_empInfo.BackColor = Color.White;
        }

        private void button_empInfo_MouseLeave(object sender, EventArgs e)
        {
            button_empInfo.ForeColor = Color.White;
            button_empInfo.BackColor = Color.Empty;
        }

        private void button_logoutAdmin_Click(object sender, EventArgs e)
        {
            Login_page lgp = new Login_page();
            lgp.Show();
            this.Hide();
        }

        private void button_empInfo_Click(object sender, EventArgs e)
        {
            Admin_empInfo emp = new Admin_empInfo();
            emp.Show();
            this.Hide();

        }

        private void button_item_insert_Click(object sender, EventArgs e)
        {
            if (textBox_item_id.Text == " " || textBox_item_name.Text == " " || textBox_item_price.Text == " "|| comboBox1.Text == " ")
            {
                MessageBox.Show("Fill data properly");
            }
            else
            {
                string query = "insert into itemInfo_table (id,name,price,quantity,category) values('" + textBox_item_id.Text + "','" + textBox_item_name.Text + "','" + textBox_item_price.Text + "','" + textBox_item_quantity.Text + "','" + comboBox1.Text + "')";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Item inserted!!!");
                            textBox_item_id.Text = "";
                            textBox_item_name.Text = "";
                            textBox_item_price.Text = "";
                            textBox_item_quantity.Text = "";
                            comboBox1.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed!!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                conn.Close();
                display_data();
            }

        }

        private void button_item_delete_Click(object sender, EventArgs e)
        {
            string query1 = "DELETE from itemInfo_table where ID = " + textBox_item_id.Text;
            SqlCommand cmd = new SqlCommand(query1, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Item Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_item_id.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button_item_update_Click(object sender, EventArgs e)
        {
            string query1 = "UPDATE itemInfo_table SET Quantity = '" + textBox_item_quantity.Text + "', Price = '" + textBox_item_price.Text + "', Category = '" + comboBox1.Text + "' WHERE ID = " + textBox_item_id.Text + " AND Name = '" + textBox_item_name.Text + "'";
            SqlCommand cmd = new SqlCommand(query1, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Item Info Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_item_id.Text = "";
                        textBox_item_name.Text = "";
                        textBox_item_quantity.Text = "";
                        textBox_item_price.Text = "";
                        comboBox1.Text = "";
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
        private void button_item_src_Click(object sender, EventArgs e)
        {

            string q1 = "SELECT * FROM itemInfo_table WHERE name LIKE @search";
            SqlDataAdapter sda = new SqlDataAdapter(q1,conn); // pass in the command object
            sda.SelectCommand.Parameters.AddWithValue("@search", "%" + textBox_search.Text + "%");
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView_item.DataSource = dt;
        }

        public void display_data()
        {
            conn.Open();
            string q2 = "select * from itemInfo_table ";
            SqlDataAdapter sda = new SqlDataAdapter(q2, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_item.DataSource = dt;
            conn.Close();
        }

        
    }
}
