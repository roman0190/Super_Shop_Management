using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Super_Shop_Management
{
    public partial class CustomerView : Form
    {
        private Login_page log = new Login_page();
        ///SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");

        ///roman
        SqlConnection con = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");
        public CustomerView()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        // Go to dashboard button
        private void button_emp_update_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            this.Hide();
            dashBoard.Show();

        }
        //go to cart button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cart curt = new cart();
            this.Hide();
            curt.Show();
           
        }

        private void ctgMeat_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm("ctgMeat");
            this.Hide(); ;
            categoryForm.Show();
          
        }
        

        private void CustomerView_Load(object sender, EventArgs e)
        {
            
        }

        private void ctgMilkBeverage_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm("ctgMilkBeverage");
            this.Hide(); ;
            categoryForm.Show();
        }

        private void ctgFruits_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm("ctgFruits");
            this.Hide(); ;
            categoryForm.Show();
        }

        private void ctgEgg_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm("ctgEgg");
            this.Hide(); ;
            categoryForm.Show();
        }

        private void ctgSpices_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm("ctgSpices");
            this.Hide(); ;
            categoryForm.Show();
        }

        private void ctgRice_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm("ctgRice");
            this.Hide(); ;
            categoryForm.Show();
        }

        private void ctgDal_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm("ctgDal");
            this.Hide(); ;
            categoryForm.Show();
        }

        private void ctgOil_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm("ctgOil");
            this.Hide(); ;
            categoryForm.Show();
        }

        private void button_support_Click(object sender, EventArgs e)
        {

            Chat chat = new Chat();
            chat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_page login = new Login_page();
            login.Show();
            this.Hide();

        }
    }
}
