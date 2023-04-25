using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management
{
    public partial class CustomerView : Form
    {
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

        private void button_emp_update_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            this.Hide();
            dashBoard.Show();   

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            curt curt = new curt();
            this.Hide();
            curt.Show();    
        }

        private void ctgMeat_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(); 
            this.Hide(); ;
            categoryForm.Show();        
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {

        }

        private void ctgMilkBeverage_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide(); ;
            categoryForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide(); ;
            categoryForm.Show();
        }

        private void ctgEgg_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide(); ;
            categoryForm.Show();
        }

        private void ctgSpices_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide(); ;
            categoryForm.Show();
        }

        private void ctgRice_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide(); ;
            categoryForm.Show();
        }

        private void ctgDal_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide(); ;
            categoryForm.Show();
        }

        private void ctgOil_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide(); ;
            categoryForm.Show();
        }
    }
}
