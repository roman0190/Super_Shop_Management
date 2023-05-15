
namespace Super_Shop_Management
{
    partial class Cust_verification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cust_verification));
            this.label_verifyUname = new System.Windows.Forms.Label();
            this.textBox_petName = new System.Windows.Forms.TextBox();
            this.label_questionVU = new System.Windows.Forms.Label();
            this.button_verifyQ = new System.Windows.Forms.Button();
            this.textBox_uname = new System.Windows.Forms.TextBox();
            this.label_uname = new System.Windows.Forms.Label();
            this.label_backToLogin = new System.Windows.Forms.Label();
            this.label_aTheQ = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_verifyUname
            // 
            this.label_verifyUname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label_verifyUname.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_verifyUname.ForeColor = System.Drawing.Color.White;
            this.label_verifyUname.Location = new System.Drawing.Point(103, 41);
            this.label_verifyUname.Name = "label_verifyUname";
            this.label_verifyUname.Size = new System.Drawing.Size(235, 29);
            this.label_verifyUname.TabIndex = 18;
            this.label_verifyUname.Text = "Forgot Password?\r\n";
            // 
            // textBox_petName
            // 
            this.textBox_petName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox_petName.Location = new System.Drawing.Point(28, 230);
            this.textBox_petName.Multiline = true;
            this.textBox_petName.Name = "textBox_petName";
            this.textBox_petName.Size = new System.Drawing.Size(211, 27);
            this.textBox_petName.TabIndex = 27;
            // 
            // label_questionVU
            // 
            this.label_questionVU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label_questionVU.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_questionVU.ForeColor = System.Drawing.Color.White;
            this.label_questionVU.Location = new System.Drawing.Point(24, 195);
            this.label_questionVU.Name = "label_questionVU";
            this.label_questionVU.Size = new System.Drawing.Size(354, 19);
            this.label_questionVU.TabIndex = 26;
            this.label_questionVU.Text = "What was the name of your first pet?";
            // 
            // button_verifyQ
            // 
            this.button_verifyQ.BackColor = System.Drawing.Color.SlateBlue;
            this.button_verifyQ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_verifyQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_verifyQ.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.button_verifyQ.ForeColor = System.Drawing.Color.White;
            this.button_verifyQ.Location = new System.Drawing.Point(341, 230);
            this.button_verifyQ.Name = "button_verifyQ";
            this.button_verifyQ.Size = new System.Drawing.Size(81, 30);
            this.button_verifyQ.TabIndex = 25;
            this.button_verifyQ.Text = "Verify";
            this.button_verifyQ.UseVisualStyleBackColor = false;
            this.button_verifyQ.Click += new System.EventHandler(this.button_verifyQ_Click);
            // 
            // textBox_uname
            // 
            this.textBox_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox_uname.Location = new System.Drawing.Point(28, 152);
            this.textBox_uname.Multiline = true;
            this.textBox_uname.Name = "textBox_uname";
            this.textBox_uname.Size = new System.Drawing.Size(211, 27);
            this.textBox_uname.TabIndex = 24;
            // 
            // label_uname
            // 
            this.label_uname.AutoSize = true;
            this.label_uname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label_uname.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_uname.ForeColor = System.Drawing.Color.White;
            this.label_uname.Location = new System.Drawing.Point(24, 119);
            this.label_uname.Name = "label_uname";
            this.label_uname.Size = new System.Drawing.Size(98, 19);
            this.label_uname.TabIndex = 23;
            this.label_uname.Text = "Username";
            // 
            // label_backToLogin
            // 
            this.label_backToLogin.AutoSize = true;
            this.label_backToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label_backToLogin.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_backToLogin.ForeColor = System.Drawing.Color.White;
            this.label_backToLogin.Location = new System.Drawing.Point(12, 465);
            this.label_backToLogin.Name = "label_backToLogin";
            this.label_backToLogin.Size = new System.Drawing.Size(53, 19);
            this.label_backToLogin.TabIndex = 28;
            this.label_backToLogin.Text = "Back";
            this.label_backToLogin.Click += new System.EventHandler(this.label_backToLogin_Click);
            // 
            // label_aTheQ
            // 
            this.label_aTheQ.AutoSize = true;
            this.label_aTheQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label_aTheQ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aTheQ.ForeColor = System.Drawing.Color.SlateBlue;
            this.label_aTheQ.Location = new System.Drawing.Point(13, 74);
            this.label_aTheQ.Name = "label_aTheQ";
            this.label_aTheQ.Size = new System.Drawing.Size(409, 16);
            this.label_aTheQ.TabIndex = 29;
            this.label_aTheQ.Text = "Answer the question below to change your password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Super_Shop_Management.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Cust_verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(432, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_aTheQ);
            this.Controls.Add(this.label_backToLogin);
            this.Controls.Add(this.textBox_petName);
            this.Controls.Add(this.label_questionVU);
            this.Controls.Add(this.button_verifyQ);
            this.Controls.Add(this.textBox_uname);
            this.Controls.Add(this.label_uname);
            this.Controls.Add(this.label_verifyUname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cust_verification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verify username";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_verifyUname;
        private System.Windows.Forms.TextBox textBox_petName;
        private System.Windows.Forms.Label label_questionVU;
        private System.Windows.Forms.Button button_verifyQ;
        private System.Windows.Forms.TextBox textBox_uname;
        private System.Windows.Forms.Label label_uname;
        private System.Windows.Forms.Label label_backToLogin;
        private System.Windows.Forms.Label label_aTheQ;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}