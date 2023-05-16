using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Super_Shop_Management
{
    public partial class CategoryForm : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");
        ///roman
        SqlConnection con = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");


        public static string CusValue { get; set; }

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
                        string User = Cus_Name.Text;
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                        if (quantity == 0)
                        {
                            MessageBox.Show("This product is not available.", "Product Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }

                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Selected WHERE ID = @ID AND [User] = @User", con))
                            {
                                cmd.Parameters.AddWithValue("@ID", row.Cells["ID"].Value);
                                cmd.Parameters.AddWithValue("@User", User);
                                con.Open();
                                int count = (int)cmd.ExecuteScalar();
                                con.Close();

                                if (count > 0)
                                {
                                    MessageBox.Show("This product is already added to the cart.", "Product Already Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    continue;
                                }
                            }

                            using (SqlCommand cmd = new SqlCommand("INSERT INTO Selected (ID, Product, Price, Quantity, [User]) VALUES (@ID, @Product, @Price, @Quantity, @User)", con))
                            {
                                cmd.Parameters.AddWithValue("@ID", row.Cells["ID"].Value);
                                cmd.Parameters.AddWithValue("@Product", row.Cells["Product"].Value);
                                cmd.Parameters.AddWithValue("@Price", row.Cells["Price"].Value);
                                cmd.Parameters.AddWithValue("@Quantity", row.Cells["Quantity"].Value);
                                cmd.Parameters.AddWithValue("@User", User);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        MessageBox.Show("Product has been added to the cart.", "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while adding the product to the cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            Cus_Name.Text = CusValue;

        }
    }
}
