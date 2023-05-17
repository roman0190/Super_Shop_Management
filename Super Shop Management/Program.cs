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
            Application.Run(new splash());
            //Application.Run(new Login_page());
            // Application.Run(new Admin_itemInfo());
            //Application.Run(new Admin_empInfo());
            //Application.Run(new CustomerView());
            //Application.Run(new Emp_itemInfo());
            //Application.Run(new Emp_custInfo());
            // Application.Run(new Registration_Form());
           // Application.Run(new Cus_History());


            // create and show Support form in a separate thread
            var supportThread = new System.Threading.Thread(() =>
            {
                //Application.Run(new Support());
            });
            supportThread.Start();

            // create and show Chat form in the main thread
            //Application.Run(new Chat());

        }
    }
}
