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
        //roman
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
            if (textBox_item_id.Text == " " || textBox_item_name.Text == " " || textBox_item_price.Text == " " || comboBox1.Text == " ")
            {
                MessageBox.Show("Fill data properly");
            }
            else
            {
                string query = "BEGIN TRANSACTION " +
                "INSERT INTO itemInfo_table (id, name, price, quantity, category) VALUES (@id, @name, @price, @quantity, @category) " +
                "IF (@category = 'Dal') " +
                "    INSERT INTO Dal (id, product, price, quantity) VALUES (@id, @name, @price, @quantity) " +
                "ELSE IF (@category = 'Eggs') " +
                "    INSERT INTO Eggs (id, product, price, quantity) VALUES (@id, @name, @price, @quantity) " +
                 "ELSE IF (@category = 'Fruits_vegetable') " +
                "    INSERT INTO Fruits_vegetable (id, product, price, quantity) VALUES (@id, @name, @price, @quantity) " +
                 "ELSE IF (@category = 'Meat') " +
                "    INSERT INTO Meat (id, product, price, quantity) VALUES (@id, @name, @price, @quantity) " +
                 "ELSE IF (@category = 'Milk_beverages') " +
                "    INSERT INTO Milk_beverages (id, product, price, quantity) VALUES (@id, @name, @price, @quantity) " +
                 "ELSE IF (@category = 'oil') " +
                "    INSERT INTO oil (id, product, price, quantity) VALUES (@id, @name, @price, @quantity) " +
                 "ELSE IF (@category = 'Rice') " +
                "    INSERT INTO Rice (id, product, price, quantity) VALUES (@id, @name, @price, @quantity) " +
                 "ELSE IF (@category = 'Spices') " +
                "    INSERT INTO Spices (id, product, price, quantity) VALUES (@id, @name, @price, @quantity) " +
                "COMMIT";


                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", textBox_item_id.Text);
                cmd.Parameters.AddWithValue("@name", textBox_item_name.Text);
                cmd.Parameters.AddWithValue("@price", textBox_item_price.Text);
                cmd.Parameters.AddWithValue("@quantity", textBox_item_quantity.Text);
                cmd.Parameters.AddWithValue("@category", comboBox1.Text);
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
            string query = "BEGIN TRANSACTION " +
               "DELETE FROM itemInfo_table WHERE id = @id " +
               "IF EXISTS(SELECT id FROM Dal WHERE id = @id) " +
               "   DELETE FROM Dal WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Eggs WHERE id = @id) " +
               "   DELETE FROM Eggs WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Fruits_vegetable WHERE id = @id) " +
               "   DELETE FROM Fruits_vegetable WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Meat WHERE id = @id) " +
               "   DELETE FROM Meat WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Milk_beverages WHERE id = @id) " +
               "   DELETE FROM Milk_beverages WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM oil WHERE id = @id) " +
               "   DELETE FROM oil WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Rice WHERE id = @id) " +
               "   DELETE FROM Rice WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Spices WHERE id = @id) " +
               "   DELETE FROM Spices WHERE id = @id " +
               "COMMIT";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", textBox_item_id.Text);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Item deleted!!!");
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

        private void button_item_update_Click(object sender, EventArgs e)
        {
            string query = "BEGIN TRANSACTION " +
               "UPDATE itemInfo_table SET name = @name, price = @price, quantity = @quantity WHERE id = @id " +
               "IF EXISTS(SELECT id FROM Dal WHERE id = @id) " +
               "   UPDATE Dal SET product = @name, price = @price, quantity = @quantity WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Eggs WHERE id = @id) " +
               "   UPDATE Eggs SET product = @name, price = @price, quantity = @quantity WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Fruits_vegetable WHERE id = @id) " +
               "   UPDATE Fruits_vegetable SET product = @name, price = @price, quantity = @quantity WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Meat WHERE id = @id) " +
               "   UPDATE Meat SET product = @name, price = @price, quantity = @quantity WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Milk_beverages WHERE id = @id) " +
               "   UPDATE Milk_beverages SET product = @name, price = @price, quantity = @quantity WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM oil WHERE id = @id) " +
               "   UPDATE oil SET product = @name, price = @price, quantity = @quantity WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Rice WHERE id = @id) " +
               "   UPDATE Rice SET product = @name, price = @price, quantity = @quantity WHERE id = @id " +
               "ELSE IF EXISTS(SELECT id FROM Spices WHERE id = @id) " +
               "   UPDATE Spices SET product = @name, price = @price, quantity = @quantity WHERE id = @id " +
               "COMMIT";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", textBox_item_id.Text);
            cmd.Parameters.AddWithValue("@name", textBox_item_name.Text);
            cmd.Parameters.AddWithValue("@price", textBox_item_price.Text);
            cmd.Parameters.AddWithValue("@quantity", textBox_item_quantity.Text);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Item updated!!!");
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
        private void button_item_src_Click(object sender, EventArgs e)
        {
            try
            {
                string q1 = "SELECT * FROM itemInfo_table WHERE name LIKE @search";
                SqlDataAdapter sda = new SqlDataAdapter(q1, conn);
                sda.SelectCommand.Parameters.AddWithValue("@search", "%" + textBox_search.Text + "%");
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_item.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

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
            this.Refresh();
        }

        private void dataGridView_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView_item.Rows[e.RowIndex];

            // Assign the values of selected row to TextBoxes
            textBox_item_id.Text = row.Cells["id"].Value.ToString();
            textBox_item_name.Text = row.Cells["name"].Value.ToString();
            textBox_item_price.Text = row.Cells["price"].Value.ToString();
            textBox_item_quantity.Text = row.Cells["quantity"].Value.ToString();
            comboBox1.Text = row.Cells["Category"].Value.ToString();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_chat_Click(object sender, EventArgs e)
        {
            
            Support support = new Support();
            support.Show();
        }

        private void button_cusHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
