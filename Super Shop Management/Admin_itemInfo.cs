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
    public partial class Admin_itemInfo : Form
    {
        public Admin_itemInfo()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

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

        }

        private void button_item_delete_Click(object sender, EventArgs e)
        {

        }

        private void button_item_update_Click(object sender, EventArgs e)
        {

        }
    }
}
