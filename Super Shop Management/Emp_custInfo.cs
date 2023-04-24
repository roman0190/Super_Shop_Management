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
    public partial class Emp_custInfo : Form
    {
        public Emp_custInfo()
        {
            InitializeComponent();
        }

        private void button_custInfo_Click(object sender, EventArgs e)
        {

        }

        private void button_custUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button_empLogout_Click(object sender, EventArgs e)
        {
            Login_page lgp = new Login_page();
            this.Hide();
            lgp.Show();
        }

        private void button_itemInfo_Click(object sender, EventArgs e)
        {
            Emp_itemInfo ii = new Emp_itemInfo();
            this.Hide();
            ii.Show();
        }
    }
}
