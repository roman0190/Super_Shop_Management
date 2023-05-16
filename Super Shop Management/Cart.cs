using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Text;

namespace Super_Shop_Management
{
    public partial class cart : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");

        ///roman
         SqlConnection con = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");


        public static string CartTextValue { get; set; }



        public cart()
        {
            InitializeComponent();
        }
        // Go back to customer view page after clicking back button.(Back button)
        private void btn_Cart_back_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            this.Hide();
            customerView.Show();
        }
        // deleting selected product from cart after clickig remove button
        private void button_removeItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                bool select1 = Convert.ToBoolean(row.Cells["Selected"].Value);
                string User = Logined_Customer_Name.Text;

                if (select1 == true)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Selected WHERE ID=@ID AND [User] ='" + Logined_Customer_Name.Text + "'", con);
                    cmd.Parameters.AddWithValue("ID", row.Cells["ID"].Value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cart ct = new cart();
                    ct.Show();

                }

            }
        }
        private void cart_Load(object sender, EventArgs e)
        {
            Logined_Customer_Name.Text = CartTextValue;// showing logined customer name on the label.
            try
            {    // Showing items thats are in the cart for the customer who logined
                string q9 = " select ID,Product,Price from Selected Where [User] ='" + Logined_Customer_Name.Text + "'";
                SqlDataAdapter ada = new SqlDataAdapter(q9, con);
                DataTable dt = new DataTable();
                con.Open();
                ada.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is  : " + ex.Message);
            }

        }


        // Counting total of selected products. (Products price * selected Quantity)
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


        // Auto click of invisiable button when a product is selected in data grid view to show the total.
        public void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnInv.PerformClick();


        }

        //  invisiable button click-event to show the total
        private void btnInv_Click(object sender, EventArgs e)
        {
            SelectedRowTotal();
        }

        //To get the Quantity from itemInfo_table
        private float GetAvailableQuantity(int id)
        {
            string query = "SELECT Quantity FROM itemInfo_table WHERE ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);
            con.Open();
            float availableQty = Convert.ToSingle(cmd.ExecuteScalar());
            con.Close();

            return availableQty;
        }

        private static bool checkQuantity = true;
        private void btn_checkout_Click(object sender, EventArgs e)
        {
            //After purchase updating the quantity of iteam info table and category table at the same time
            //(Qty- Buyed qty )

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                bool select1 = Convert.ToBoolean(row.Cells["Selected"].Value);
                if (select1 == true)
                {

                    float Qty = Convert.ToInt32(row.Cells["Qty"].Value);
                    int ID = Convert.ToInt32(row.Cells["ID"].Value);

                    // Check if the selected quantity is greater than the available quantity
                    if (Qty > GetAvailableQuantity(ID))
                    {
                        MessageBox.Show("Please select a quantity less than or equal to the available quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue; // Skip to the next row
                       
                    }

                    else
                    {

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


                        checkQuantity = false;

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Qty", Qty);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                       
                    }
                }
            }

            if (checkQuantity ==false)
            {
                //insertng buyed product of cutomer into buyed table with their user name
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    bool select1 = Convert.ToBoolean(row.Cells["Selected"].Value);
                    if (select1)
                    {
                        try
                        {
                            string user = Logined_Customer_Name.Text;//getting user name from the label.
                            using (SqlCommand cmd = new SqlCommand("insert into Buyed (ID,Product,Price,Quantity,[User])values(@ID,@Product,@Price,@Qty,@User)", con))
                            {
                                cmd.Parameters.AddWithValue("ID", row.Cells["ID"].Value);
                                cmd.Parameters.AddWithValue("Product", row.Cells["Product"].Value);
                                cmd.Parameters.AddWithValue("Price", row.Cells["Price"].Value);
                                cmd.Parameters.AddWithValue("Qty", row.Cells["Qty"].Value);
                                cmd.Parameters.AddWithValue("@User", user);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Purchase Operation failed. Please try again later !! " + ex.Message);
                        }


                        // Making a temp table to store selected product to pass it in the invoice form

                        DataTable selectedProducts = new DataTable();
                        selectedProducts.Columns.Add("ID", typeof(int));
                        selectedProducts.Columns.Add("Qty", typeof(int));
                        selectedProducts.Columns.Add("Product", typeof(string));
                        selectedProducts.Columns.Add("Price", typeof(decimal));


                        // Populate the data table with selected products
                        try
                        {
                            foreach (DataGridViewRow dvrow in dataGridView2.Rows)
                            {
                                bool selected2 = Convert.ToBoolean(dvrow.Cells["Selected"].Value);
                                if (selected2)
                                {   //convering data accroding to temp table data
                                    int id = Convert.ToInt32(dvrow.Cells["ID"].Value);
                                    int Qty = Convert.ToInt32(dvrow.Cells["Qty"].Value);
                                    string product = dvrow.Cells["Product"].Value.ToString();
                                    decimal price = Convert.ToDecimal(dvrow.Cells["Price"].Value);
                                    //Felling temp table with data
                                    DataRow newRow = selectedProducts.NewRow();
                                    newRow["ID"] = id;
                                    newRow["Qty"] = Qty;
                                    newRow["Product"] = product;
                                    newRow["Price"] = price;
                                    selectedProducts.Rows.Add(newRow);
                                }


                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Please select a product! ");
                        }



                        // passing the value in invoice form
                        Invoice invoiceForm = new Invoice(selectedProducts);
                        Invoice.totalPrice = label_taka.Text;



                        // Deleting the selected product from cart after buying
                        bool select2 = Convert.ToBoolean(row.Cells["Selected"].Value);
                        string User = Logined_Customer_Name.Text;
                        if (select1 == true)
                        {
                            try
                            {
                                SqlCommand cmd = new SqlCommand("DELETE FROM Selected WHERE ID=@ID AND [User] ='" + Logined_Customer_Name.Text + "'", con);
                                cmd.Parameters.AddWithValue("ID", row.Cells["ID"].Value);
                                con.Open();
                                cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                // Handle the exception here, for example by displaying an error message
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                            finally
                            {
                                // Make sure to close the connection, even if an exception occurred
                                con.Close();
                            }
                        }


                        invoiceForm.Show();



                    }
                }


            }

        }





    }
}
