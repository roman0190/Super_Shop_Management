
namespace Super_Shop_Management
{
    partial class Support
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_send = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_messege = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_send
            // 
            this.Button_send.Animated = true;
            this.Button_send.BorderColor = System.Drawing.Color.White;
            this.Button_send.BorderRadius = 10;
            this.Button_send.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_send.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_send.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_send.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_send.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Button_send.ForeColor = System.Drawing.Color.White;
            this.Button_send.IndicateFocus = true;
            this.Button_send.Location = new System.Drawing.Point(394, 548);
            this.Button_send.Name = "Button_send";
            this.Button_send.Size = new System.Drawing.Size(49, 28);
            this.Button_send.TabIndex = 6;
            this.Button_send.Text = "=>";
            // 
            // TextBox_messege
            // 
            this.TextBox_messege.BorderColor = System.Drawing.Color.Black;
            this.TextBox_messege.BorderRadius = 2;
            this.TextBox_messege.BorderThickness = 2;
            this.TextBox_messege.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_messege.DefaultText = "";
            this.TextBox_messege.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_messege.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_messege.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_messege.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_messege.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TextBox_messege.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_messege.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_messege.ForeColor = System.Drawing.Color.White;
            this.TextBox_messege.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_messege.Location = new System.Drawing.Point(12, 539);
            this.TextBox_messege.Name = "TextBox_messege";
            this.TextBox_messege.PasswordChar = '\0';
            this.TextBox_messege.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TextBox_messege.PlaceholderText = "";
            this.TextBox_messege.SelectedText = "";
            this.TextBox_messege.Size = new System.Drawing.Size(371, 37);
            this.TextBox_messege.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 522);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(436, 522);
            this.dataGridView2.TabIndex = 0;
            // 
            // Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 638);
            this.Controls.Add(this.Button_send);
            this.Controls.Add(this.TextBox_messege);
            this.Controls.Add(this.panel2);
            this.Name = "Support";
            this.Text = "Support Chat";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Button_send;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_messege;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}