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
    public partial class Emp_itemInfo : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CGD8O08\\SQL2022;Initial Catalog=Dev;Integrated Security=True");

        //roman
        //SqlConnection conn = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");
        public Emp_itemInfo()
        {
            InitializeComponent();
        }

        private void label_itemId_Click(object sender, EventArgs e)
        {

        }

        private void button_empLogout_Click(object sender, EventArgs e)
        {
            Login_page lgp = new Login_page();
            this.Hide();
            lgp.Show();
        }

        private void button_custInfo_Click(object sender, EventArgs e)
        {
            Emp_custInfo cf = new Emp_custInfo();
            this.Hide();
            cf.Show();
        }

        private void button_itemUpdate_Click(object sender, EventArgs e)
        {
            string query1 = "UPDATE itemInfo_table SET Quantity = '" + textBox_itemQty.Text + "', Price = '" + textBox_itemPrice.Text + "', Category = '" + comboBox_ctg.Text + "' WHERE ID = " + textBox_itemId.Text + " AND Name = '" + textBox_itemName.Text + "'";
            SqlCommand cmd = new SqlCommand(query1, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Item Info Updated!");
                    textBox_itemId.Text = " ";
                    textBox_itemName.Text = " ";
                    textBox_itemQty.Text = " ";
                    textBox_itemPrice.Text = " ";
                    comboBox_ctg.Text = " ";
                }
                else
                    MessageBox.Show("Failed!");

            }
            conn.Close();
            display_data();
        }

        private void button_itemDelete_Click(object sender, EventArgs e)
        {
            string query1 = "DELETE from itemInfo_table where ID = " + textBox_itemId.Text;
            SqlCommand cmd = new SqlCommand(query1, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Item Deleted!");
                    textBox_itemId.Text = " ";
                }
                else
                    MessageBox.Show("Failed to delete item!");
            }
            conn.Close();
            display_data();
        }

        private void panel_item_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Emp_itemInfo_Load(object sender, EventArgs e)
        {
            display_data();
        }
        public void display_data()
        {
            conn.Open();
            string q2 = "select * from itemInfo_table ";
            SqlDataAdapter sda = new SqlDataAdapter(q2, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_items.DataSource = dt;
            conn.Close();
        }

        private void button_itemSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            string q1 = "SELECT * FROM itemInfo_table WHERE Name LIKE '" + textBox_itemSearch.Text + "%'";

            SqlDataAdapter sda = new SqlDataAdapter(q1, conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_items.DataSource = dt;
            conn.Close();
        }

        private void dataGridView_items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if the clicked row is valid
            {
                DataGridViewRow row = this.dataGridView_items.Rows[e.RowIndex];

                // Populate textboxes with data from the selected row
                textBox_itemId.Text = row.Cells["ID"].Value.ToString();
                textBox_itemName.Text = row.Cells["Name"].Value.ToString();
                textBox_itemQty.Text = row.Cells["Quantity"].Value.ToString();
                textBox_itemPrice.Text = row.Cells["Price"].Value.ToString();
                comboBox_ctg.Text = row.Cells["Category"].Value.ToString();
            }
        }
    }
}
