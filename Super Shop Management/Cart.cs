using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Super_Shop_Management
{
    public partial class cart : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");

        ///roman
        SqlConnection con = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");

        private Login_page loginPage;
        public cart()
        {
            InitializeComponent();
            loginPage = new Login_page();
        }

        public void SomeMethod()
        {
            string uname = loginPage.TextBox1_uname.Text;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            this.Hide();
            customerView.Show();
        }

        private void button_removeItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                bool select1 = Convert.ToBoolean(row.Cells["Selected"].Value);
                if (select1 == true)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Selected WHERE ID=@ID ", con);
                    cmd.Parameters.AddWithValue("ID", row.Cells["ID"].Value);
                    //select1 = false;
                    con.Open();

                    cmd.ExecuteNonQuery();
                    con.Close();

                    cart ct = new cart();
                    ct.Show();

                }
                else
                {
                    //select1 = false;
                }
            }
        }
        private void cart_Load(object sender, EventArgs e)
        {
            string q9 = " select ID,Product,Price from Selected";
            SqlDataAdapter ada = new SqlDataAdapter(q9, con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        //Refreshing data grid view after removing
        private object GetDataFromDatabase()
        {
            DataTable dt = new DataTable();


            string query = "select ID,Product,Price from Selected";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);

            return dt;
        }





        public void SelectedRowTotal()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[0].Value) == true)
                {
                    int qty = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
                    int pri = Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value);

                    sum += pri * qty;
                }

            }
            label_taka.Text = sum.ToString();
        }






        public void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnInv.PerformClick();


        }
        private void btnInv_Click(object sender, EventArgs e)
        {
            SelectedRowTotal();
        }


        private void btn_checkout_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                bool select1 = Convert.ToBoolean(row.Cells["Selected"].Value);
                if (select1 == true)
                {
                    
                    float Qty = Convert.ToInt32(row.Cells["Qty"].Value);

                   
                    int ID = Convert.ToInt32(row.Cells["ID"].Value);

                    string query = "BEGIN TRANSACTION; " +
                                    "UPDATE itemInfo_table SET Quantity = Quantity - @Qty WHERE ID = @ID; " +
                                    "IF EXISTS(SELECT ID FROM Dal WHERE ID = @ID) " +
                                    "   UPDATE Dal SET Quantity = Quantity - @Qty WHERE ID = @ID; " +
                                    "ELSE IF EXISTS(SELECT id FROM Eggs WHERE id = @ID) " +
                                    "   UPDATE Eggs SET Quantity = Quantity - @Qty WHERE ID = @ID; " +
                                    "ELSE IF EXISTS(SELECT id FROM Fruits_vegetable WHERE id = @ID) " +
                                    "   UPDATE Fruits_vegetable SET Quantity = Quantity - @Qty WHERE ID = @ID; " +
                                    "ELSE IF EXISTS(SELECT id FROM Meat WHERE id = @ID) " +
                                    "   UPDATE Meat SET Quantity = Quantity - @Qty WHERE ID = @ID; " +
                                    "ELSE IF EXISTS(SELECT id FROM Milk_beverages WHERE id = @ID) " +
                                    "   UPDATE Milk_beverages SET Quantity = Quantity - @Qty WHERE ID = @ID; " +
                                    "ELSE IF EXISTS(SELECT id FROM oil WHERE id = @ID) " +
                                    "   UPDATE oil SET Quantity = Quantity - @Qty WHERE ID = @ID; " +
                                    "ELSE IF EXISTS(SELECT id FROM Rice WHERE id = @ID) " +
                                    "   UPDATE Rice SET Quantity = Quantity - @Qty WHERE ID = @ID; " +
                                    "ELSE IF EXISTS(SELECT id FROM Spices WHERE id = @ID) " +
                                    "   UPDATE Spices SET Quantity = Quantity - @Qty WHERE ID = @ID; " +
                                    "COMMIT;";




                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Qty", Qty);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }




        }

    }



}
