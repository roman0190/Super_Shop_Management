﻿using System;
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
        SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");
        public DashBoard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            this.Hide();
            customerView.Show();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            string q10 = " select * from Selected";
            SqlDataAdapter ada = new SqlDataAdapter(q10, con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Dashview1.DataSource = dt;

        }
    }
}
