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
    public partial class Cus_History : Form
    {

        //roman
        SqlConnection conn = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");
        public Cus_History()
        {
            InitializeComponent();
        }

        private void Cus_History_Load(object sender, EventArgs e)
        {
            display_data();
        }

        public void display_data()
        {
            conn.Open();
            string q2 = "select * from Buyed ";
            SqlDataAdapter sda = new SqlDataAdapter(q2, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string q1 = "SELECT * FROM Buyed WHERE [User] LIKE @search";
                SqlDataAdapter sda = new SqlDataAdapter(q1, conn);
                sda.SelectCommand.Parameters.AddWithValue("@search", "%" + textBox_search.Text + "%");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                // Calculate the sum of (Price * Quantity) for the User
                decimal sum = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Price"] != DBNull.Value && row["Quantity"] != DBNull.Value) // Check for null or DBNull values
                    {
                        decimal price = Convert.ToDecimal(row["Price"]);
                        int quantity = Convert.ToInt32(row["Quantity"]);
                        decimal productTotal = price * quantity;
                        sum += productTotal;
                    }
                }

                string sumAsString = sum.ToString(); // Convert sum to string

                label_total.Text = sumAsString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            Admin_empInfo emp = new Admin_empInfo();
            emp.Show();
            this.Hide();

        }
    }
}
