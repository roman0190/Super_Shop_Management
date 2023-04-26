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
    public partial class Emp_itemInfo : Form
    {
        public Emp_itemInfo()
        {
            InitializeComponent();
        }

        private void label_itemId_Click(object sender, EventArgs e)
        {

        }

        private void button_empLogout_Click(object sender, EventArgs e)
        {
            Login_page lgp = new Login_page();
            this.Hide();
            lgp.Show();
        }

        private void button_custInfo_Click(object sender, EventArgs e)
        {
            Emp_custInfo cf = new Emp_custInfo();
            this.Hide();
            cf.Show();
        }

        private void button_itemUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
