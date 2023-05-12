using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Super_Shop_Management
{
    public partial class CategoryForm : Form
    {
        ///SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");
        ///roman
        SqlConnection con = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");


        public CategoryForm(string selectedCategory)
        {
            InitializeComponent();
            if (selectedCategory == "ctgMeat")
            {
                string q1 = " select * from Meat";
                SqlDataAdapter ada = new SqlDataAdapter(q1, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (selectedCategory == "ctgMilkBeverage")
            {
                string q2 = " select * from Milk_beverages";
                SqlDataAdapter ada = new SqlDataAdapter(q2, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (selectedCategory == "ctgFruits")
            {
                string q3 = " select * from Fruits_vegetable";
                SqlDataAdapter ada = new SqlDataAdapter(q3, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (selectedCategory == "ctgEgg")
            {
                string q4 = " select * from Eggs";
                SqlDataAdapter ada = new SqlDataAdapter(q4, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (selectedCategory == "ctgSpices")
            {
                string q5 = " select * from Spices";
                SqlDataAdapter ada = new SqlDataAdapter(q5, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (selectedCategory == "ctgRice")
            {
                string q6 = " select * from Rice";
                SqlDataAdapter ada = new SqlDataAdapter(q6, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (selectedCategory == "ctgDal")
            {
                string q7 = " select * from Dal";
                SqlDataAdapter ada = new SqlDataAdapter(q7, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (selectedCategory == "ctgOil")
            {
                string q8 = " select * from Oil";
                SqlDataAdapter ada = new SqlDataAdapter(q8, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        
        public CategoryForm()
        {

            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            cart curt = new cart();
            this.Hide();
            curt.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            this.Hide();
            customerView.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool select1 = Convert.ToBoolean(row.Cells["Add"].Value);
                if (select1)
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("insert into Selected (ID,Product,Price,Quantity)values(@ID,@Product,@Price,@Quantity)", con))
                        {
                            cmd.Parameters.AddWithValue("ID", row.Cells["ID"].Value);
                            cmd.Parameters.AddWithValue("Product", row.Cells["Product"].Value);
                            cmd.Parameters.AddWithValue("Price", row.Cells["Price"].Value);
                            cmd.Parameters.AddWithValue("Quantity", row.Cells["Quantity"].Value);
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Data has been inserted successfully");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("This Product is Already Added to cart");
                    }

                    con.Close();
                }
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {


        }
    }
}
