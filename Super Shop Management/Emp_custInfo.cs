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
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CGD8O08\\SQL2022;Initial Catalog=Dev;Integrated Security=True");
        public Emp_custInfo()
        {
            InitializeComponent();
        }

        private void button_custInfo_Click(object sender, EventArgs e)
        {

        }

        private void button_custUpdate_Click(object sender, EventArgs e)
        {
            string query1 = "UPDATE itemInfo_table SET Address = '" + textBox_custAddress.Text + "', Phone = '" + textBox_custPhone.Text + "', Rank = '" + comboBox_custRank.Text + "' WHERE ID = " + textBox_custId.Text + " AND Name = '" + textBox_custName.Text + "'";
            SqlCommand cmd = new SqlCommand(query1, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Item Info Updated!");
                    textBox_custId.Text = " ";
                    textBox_custName.Text = " ";
                    textBox_custAddress.Text = " ";
                    textBox_custPhone.Text = " ";
                    comboBox_custRank.Text = " ";
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
            string query1 = "DELETE from custInfo_table where ID = " + textBox_custId.Text;
            SqlCommand cmd = new SqlCommand(query1, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Customer removed!");
                    textBox_custId.Text = " ";
                }
                else
                    MessageBox.Show("Failed to remove customer!");
            }
            conn.Close();
            display_data();
        }
        public void display_data()
        {
            conn.Open();
            string q2 = "select * from custInfo_table ";
            SqlDataAdapter sda = new SqlDataAdapter(q2, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_cust.DataSource = dt;
            conn.Close();
        }
    }
}
