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
        // SqlConnection con = new SqlConnection("Data Source=ABD777;Initial Catalog=develop;Integrated Security=True");

        //roman
        SqlConnection conn = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");

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
            // Draw the screenshot image on the PrintPage event
            e.Graphics.DrawImage(screenshot, e.MarginBounds);
        }


        Bitmap screenshot;
        private void CaptureFormScreenshot(Form form)
        {
            // Get the position and size of the form
            int formWidth = form.ClientSize.Width;
            int formHeight = form.ClientSize.Height;
            int formX = form.Location.X + form.DisplayRectangle.X;
            int formY = form.Location.Y + form.DisplayRectangle.Y;

            // Create a bitmap to hold the screenshot
            screenshot = new Bitmap(formWidth, formHeight);

            // Capture the screenshot of the form
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(formX, formY, 0, 0, new Size(formWidth, formHeight));
            }

            // Show the screenshot in a picture box (optional)
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = screenshot;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            Form screenshotForm = new Form();
            screenshotForm.Controls.Add(pictureBox);

            // Add a print button to the form
            Button printButton = new Button();
            printButton.Text = "Print";
            printButton.Click += new EventHandler(Download_Click);
            screenshotForm.Controls.Add(printButton);

            screenshotForm.ShowDialog();
        }

        private void Download_Click(object sender, EventArgs e)
        {
           CaptureFormScreenshot(this);

            // Create a PrintDocument object and set its properties
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;

            // Add an event handler for the PrintPage event
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // Print the image
            pd.Print();
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
