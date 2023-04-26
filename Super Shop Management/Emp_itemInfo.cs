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
        //mrittika
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CGD8O08\\SQL2022;Initial Catalog=Dev;Integrated Security=True");
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
        }

        private void Emp_itemInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
