﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Super_Shop_Management
{
    public partial class Login_page : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=RFEGRF\\SQL2022;Initial Catalog=Shop_Management;Integrated Security=True");
        public Login_page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_lgin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_lgin_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_click(object sender, EventArgs e)
        {
            textBox1_lgin.Clear();
        }

        private void pass_click(object sender, EventArgs e)
        {
            textBox2_pass.Clear();
        }

        private void button1_login_MouseEnter(object sender, EventArgs e)
        {
            button1_login.ForeColor = Color.Black;
        }

        private void button1_login_MouseLeave(object sender, EventArgs e)
        {
            button1_login.ForeColor = Color.White;

        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            string q1 = "select * from login where username ='" + textBox1_lgin + "' and password = '" + textBox2_pass + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q1,conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
            {
                Admin_itemPage ad = new Admin_itemPage();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid");
            }














            /*if (textBox1_lgin.Text != "admin") //any condition
            {
                invalid_u_pnl.Visible = true;
                textBox1_lgin.Focus();
                return;
            }

            if (textBox2_lgin.Text != "admin") //any condition
            {
                invalid_p_pnl.Visible = true;
                textBox2_lgin.Focus();
                return;
            }

            if (textBox1_lgin.Text == "admin" && textBox2_lgin.Text == "admin")
            {
                Admin_itemPage ad = new Admin_itemPage();
                ad.Show();
                this.Hide();
            }*/

        }

        private void linkLabel_forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel_creatAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
