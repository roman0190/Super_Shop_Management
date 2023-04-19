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
    public partial class Admin_empPage : Form
    {
        public Admin_empPage()
        {
            InitializeComponent();
        }

        private void button_ItemInfo_Click(object sender, EventArgs e)
        {
            Admin_itemPage item = new Admin_itemPage();
            item.Show();
            this.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_logoutAdmin_Click(object sender, EventArgs e)
        {
            Login_page lgp = new Login_page();
            lgp.Show();
            this.Hide();
        }
    }
}
