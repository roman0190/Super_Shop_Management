using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new splash());
            //Application.Run(new Login_page());
            Application.Run(new Admin_itemInfo());
            //Application.Run(new Admin_empInfo());
            //Application.Run(new CustomerView());
            //Application.Run(new Emp_itemInfo());
            //Application.Run(new Emp_custInfo());
            //Application.Run(new Registration_Form());

        }
    }
}
