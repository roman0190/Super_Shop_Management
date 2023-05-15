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
    public partial class Invoice : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");

        public static string Cusname { get; set; }
        public static string totalPrice { get; set; }



        public Invoice()
        {
            InitializeComponent();
        }

        private DataTable selectedProducts;

        public Invoice(DataTable selectedProducts)
        {
            InitializeComponent();
           
            
            

            this.selectedProducts = selectedProducts;
        }


       


        private void Invoice_Load(object sender, EventArgs e)
        {

            Customer_name_changer.Text = Cusname;

            lbl_taka.Text = totalPrice.ToString();

            datagridview3.DataSource = selectedProducts;



        }

        private void Download_Click(object sender, EventArgs e)
        {
            
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            CustomerView cus = new CustomerView();
            this.Hide();
            cus.Show();
        }
    }
}
