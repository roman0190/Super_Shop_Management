namespace Super_Shop_Management
{
    partial class cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cart));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_checkout = new Guna.UI2.WinForms.Guna2Button();
            this.label_total = new System.Windows.Forms.Label();
            this.label_taka = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Cart_back = new Guna.UI2.WinForms.Guna2Button();
            this.button_removeItem = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Checkout";
            // 
            // btn_checkout
            // 
            this.btn_checkout.Animated = true;
            this.btn_checkout.AutoRoundedCorners = true;
            this.btn_checkout.BackColor = System.Drawing.Color.Transparent;
            this.btn_checkout.BorderRadius = 13;
            this.btn_checkout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_checkout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_checkout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_checkout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_checkout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_checkout.ForeColor = System.Drawing.Color.White;
            this.btn_checkout.Location = new System.Drawing.Point(494, 396);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(120, 29);
            this.btn_checkout.TabIndex = 2;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseTransparentBackground = true;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(309, 401);
            this.label_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(59, 26);
            this.label_total.TabIndex = 1;
            this.label_total.Text = "Total";
            // 
            // label_taka
            // 
            this.label_taka.AutoSize = true;
            this.label_taka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_taka.Location = new System.Drawing.Point(373, 401);
            this.label_taka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_taka.Name = "label_taka";
            this.label_taka.Size = new System.Drawing.Size(54, 26);
            this.label_taka.TabIndex = 1;
            this.label_taka.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 401);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "TK.";
            // 
            // btn_Cart_back
            // 
            this.btn_Cart_back.Animated = true;
            this.btn_Cart_back.AutoRoundedCorners = true;
            this.btn_Cart_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cart_back.BorderRadius = 14;
            this.btn_Cart_back.DefaultAutoSize = true;
            this.btn_Cart_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cart_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cart_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cart_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cart_back.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cart_back.ForeColor = System.Drawing.Color.White;
            this.btn_Cart_back.Location = new System.Drawing.Point(20, 25);
            this.btn_Cart_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cart_back.Name = "btn_Cart_back";
            this.btn_Cart_back.Size = new System.Drawing.Size(51, 31);
            this.btn_Cart_back.TabIndex = 2;
            this.btn_Cart_back.Text = "<=";
            this.btn_Cart_back.UseTransparentBackground = true;
            this.btn_Cart_back.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // button_removeItem
            // 
            this.button_removeItem.Animated = true;
            this.button_removeItem.AutoRoundedCorners = true;
            this.button_removeItem.BackColor = System.Drawing.Color.Transparent;
            this.button_removeItem.BorderRadius = 13;
            this.button_removeItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_removeItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_removeItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_removeItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_removeItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_removeItem.ForeColor = System.Drawing.Color.White;
            this.button_removeItem.Location = new System.Drawing.Point(32, 396);
            this.button_removeItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_removeItem.Name = "button_removeItem";
            this.button_removeItem.Size = new System.Drawing.Size(120, 29);
            this.button_removeItem.TabIndex = 3;
            this.button_removeItem.Text = "Remove items";
            this.button_removeItem.UseTransparentBackground = true;
            this.button_removeItem.Click += new System.EventHandler(this.button_removeItem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove});
            this.dataGridView2.Location = new System.Drawing.Point(32, 88);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(582, 285);
            this.dataGridView2.TabIndex = 4;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Select";
            this.Remove.MinimumWidth = 8;
            this.Remove.Name = "Remove";
            this.Remove.Width = 150;
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(645, 476);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button_removeItem);
            this.Controls.Add(this.btn_Cart_back);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_taka);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.SlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_checkout;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_taka;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_Cart_back;
        private Guna.UI2.WinForms.Guna2Button button_removeItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Remove;
    }
}