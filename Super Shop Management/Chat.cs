using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Super_Shop_Management
{
    public partial class Chat : Form
    {
        //User name get from login page text Box
        public static string SenderName { get; set; }

        private string connectionString = "Data Source=RFEGRF\\SQL2022;Initial Catalog=shop_management;Integrated Security=True";
        private string senderName = SenderName; // replace with login sender name
        private string receiverName = "MAAR-ket";
        public Chat()
        {
            InitializeComponent();
        }

        private void Chat_Load(object sender, EventArgs e)
        {

            // start the timer to fetch messages every 0.2 seconds
            Timer timer = new Timer();
            timer.Interval = 20;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();


        }
        private void timer_Tick(object sender, EventArgs e)
        {
            // fetch new messages from the database and display them in the ListBox
            string query = "SELECT Sender, Message, TimeStamp FROM Chat WHERE (Sender = @Receiver AND Receiver = @Sender) OR (Sender = @Sender AND Receiver = @Receiver) ORDER BY TimeStamp DESC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Sender", senderName);
                    command.Parameters.AddWithValue("@Receiver", receiverName);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // clear the ListBox before adding new messages
                        listBox1.Items.Clear();

                        while (reader.Read())
                        {
                            string senderName = reader.GetString(0);
                            string message = reader.GetString(1);
                            DateTime timeStamp = reader.GetDateTime(2);

                            string displayMessage = $"[{timeStamp:HH:mm}] {senderName}: {message}";
                            Color textColor = this.senderName == senderName ? Color.Blue : Color.Red;
                            listBox1.Items.Add(new MessageItem(displayMessage, textColor));
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // save the message to the database
            string message = textBoxMessage.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                string query = "INSERT INTO Chat (Sender, Receiver, Message) VALUES (@Sender, @Receiver, @Message)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Sender", senderName);
                        command.Parameters.AddWithValue("@Receiver", receiverName);
                        command.Parameters.AddWithValue("@Message", message);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        // add the sent message to the ListBox
                        DateTime timeStamp = DateTime.Now;
                        string displayMessage = $"[{timeStamp:HH:mm:ss}] {senderName}: {message}";
                        listBox1.Items.Add(new MessageItem(displayMessage, Color.Blue));
                    }
                }
                textBoxMessage.Text = "";
            }
        }

        // Define a custom class to hold message and text color
        private class MessageItem
        {
            public string Message { get; set; }
            public Color TextColor { get; set; }

            public MessageItem(string message, Color textColor)
            {
                Message = message;
                TextColor = textColor;
            }

            public override string ToString()
            {
                return Message;
            }
        }
    }
}
