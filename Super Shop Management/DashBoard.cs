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
    public partial class DashBoard : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");
        ///roman
        SqlConnection con = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");
        public static string Custname { get; set; }
        public DashBoard()
        {
            InitializeComponent();
        }
        //back button
        private void btn_DB_back_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            this.Hide();
            customerView.Show();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            cus_lbl.Text = Custname;

            string q10 = " select * from Buyed Where [User]='"+cus_lbl.Text+"'";// Showing the products that logined customer had bought
            SqlDataAdapter ada = new SqlDataAdapter(q10, con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Dashview1.DataSource = dt;
           
        }
    }
}
