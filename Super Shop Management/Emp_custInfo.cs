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
        //Mrittika
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
            string query1 = "DELETE from Registration_table where Username = " + textBox_custUname.Text;
            SqlCommand cmd = new SqlCommand(query1, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
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
            conn.Open();
            string q2 = "select Username, Address, Email from Registration_table ";
            SqlDataAdapter sda = new SqlDataAdapter(q2, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_cust.DataSource = dt;
            conn.Close();
        }
    }
}
