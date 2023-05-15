using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management
{
    public partial class Invoice : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");

        public static string Cusname { get; set; }
        public static string totalPrice { get; set; }



        public Invoice()
        {
            InitializeComponent();
        }

        private DataTable selectedProducts;

        public Invoice(DataTable selectedProducts)
        {
            InitializeComponent();

            this.selectedProducts = selectedProducts;
        }


       


        private void Invoice_Load(object sender, EventArgs e)
        {

            Customer_name_changer.Text = Cusname;// set username of logined customer

            lbl_taka.Text = totalPrice.ToString();// Showing total price ( get it from cart form)

            datagridview3.DataSource = selectedProducts;

            
            // Genarating 
             Random random = new Random();
            int randomNumber = random.Next(100000, 999999); // Generate a random number between 100000 and 999999

            Invoice_no_chnager.Text = "#" + randomNumber.ToString();
            




        }
        // Download pdf of Invoice

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Bitmap screenshot = new Bitmap(953, 812))
            {
                using (Graphics g = Graphics.FromImage(screenshot))
                {
                    g.CopyFromScreen(0, 0, 0, 0, new Size(953, 812));
                }

                e.Graphics.DrawImage(screenshot, 0, 0);
            }
        }



        private void CaptureFullScreenshot()
        {
            // Calculate the position and size of the invoice window
            int invoiceWidth = 953;
            int invoiceHeight = 812;
            int invoiceX = (Screen.PrimaryScreen.Bounds.Width - invoiceWidth) / 2;
            int invoiceY = (Screen.PrimaryScreen.Bounds.Height - invoiceHeight) / 2;

            // Create a bitmap to hold the screenshot
            Bitmap screenshot = new Bitmap(invoiceWidth, invoiceHeight);

            // Capture the screenshot of the invoice window
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(invoiceX, invoiceY, 0, 0, new Size(invoiceWidth, invoiceHeight));
            }

            // Show the screenshot in a picture box (optional)
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = screenshot;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            Form screenshotForm = new Form();
            screenshotForm.Controls.Add(pictureBox);
            screenshotForm.ShowDialog();
        }

        private void Download_Click(object sender, EventArgs e)
        {
            CaptureFullScreenshot();
        }
            
        //back button
        private void btn_back_Click(object sender, EventArgs e)
        {
            CustomerView cus = new CustomerView();
            this.Hide();
            cus.Show();
        }

        
    }
}
