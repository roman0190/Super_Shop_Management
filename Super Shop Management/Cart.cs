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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Super_Shop_Management
{
    public partial class cart : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");

        public cart()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            this.Hide();
            customerView.Show();
        }

        private void cart_Load(object sender, EventArgs e)
        {
            string q9 = " select * from Selected";
            SqlDataAdapter ada = new SqlDataAdapter(q9, con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        
        private void button_removeItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["ID"].Value);
                int product = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Product"].Value);
                int price = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Price"].Value);
                int quantity = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Quantity"].Value);

                string query = "DELETE FROM Selected WHERE ID =@ID AND Product =@Product AND Price = @Price AND Quantity =@Quantity";
                
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Product", product);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                // Refresh the DataGridView
                dataGridView2.DataSource = GetDataFromDatabase();
            }
        }

        private object GetDataFromDatabase()
        {
            DataTable dt = new DataTable();
            
            {
                string query = "SELECT * FROM Selected";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            return dt;
        }
    }
    
}
