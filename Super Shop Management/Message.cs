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
    public partial class Message : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");
        public Message()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Message_Load(object sender, EventArgs e)
        {
            display_data();
        }
        public void display_data()
        {

            try
            {
                string q2 = "Select cus_msg,emp_msg from msg_table";
                SqlDataAdapter sda = new SqlDataAdapter(q2, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
