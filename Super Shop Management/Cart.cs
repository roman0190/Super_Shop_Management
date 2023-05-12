using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
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
        //SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");

        ///roman
        SqlConnection con = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");


        public static string CartTextValue { get; set; }

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

                    cart ct =new cart();
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

            Logined_Customer_Name.Text = CartTextValue;
        }
        
       

        private object GetDataFromDatabase()
        {
            DataTable dt = new DataTable();
            
            
              string query = "SELECT * FROM Selected";
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
                   
                    sum+=pri*qty;
                }

            }
            label_taka.Text= sum.ToString();    
        }
        /*public void click()
        {
            for(int i =0;i<dataGridView2.Rows.Count;i++)
            {
              
               if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[1].Value) == true)
               {
                    
               }
            }
            
        }*/

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            SelectedRowTotal();
           // click();    

        }

        public void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_checkout.PerformClick();
        }

    }


    
}
