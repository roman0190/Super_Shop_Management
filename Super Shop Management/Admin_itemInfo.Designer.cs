
namespace Super_Shop_Management
{
    partial class Admin_itemInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_itemInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Employee = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_item_src = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_item_update = new Guna.UI2.WinForms.Guna2Button();
            this.button_item_delete = new Guna.UI2.WinForms.Guna2Button();
            this.button_item_insert = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_item = new System.Windows.Forms.DataGridView();
            this.textBox_item_name = new System.Windows.Forms.TextBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.textBox_item_id = new System.Windows.Forms.TextBox();
            this.textBox_item_price = new System.Windows.Forms.TextBox();
            this.textBox_item_quantity = new System.Windows.Forms.TextBox();
            this.label_item_category = new System.Windows.Forms.Label();
            this.label_item_price = new System.Windows.Forms.Label();
            this.label_item_quantity = new System.Windows.Forms.Label();
            this.label_item_name = new System.Windows.Forms.Label();
            this.label_item_id = new System.Windows.Forms.Label();
            this.ITEM = new System.Windows.Forms.Label();
            this.button_empInfo = new System.Windows.Forms.Button();
            this.button_ItemInfo = new System.Windows.Forms.Button();
            this.button_logoutAdmin = new System.Windows.Forms.Button();
            this.button_chat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Employee);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 324);
            this.panel1.TabIndex = 0;
            // 
            // Employee
            // 
            this.Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employee.Font = new System.Drawing.Font("Romantic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Employee.ForeColor = System.Drawing.Color.White;
            this.Employee.Location = new System.Drawing.Point(47, 28);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(213, 23);
            this.Employee.TabIndex = 14;
            this.Employee.Text = "Admin Control Panel";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_item_src);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button_item_update);
            this.panel2.Controls.Add(this.button_item_delete);
            this.panel2.Controls.Add(this.button_item_insert);
            this.panel2.Controls.Add(this.dataGridView_item);
            this.panel2.Controls.Add(this.textBox_item_name);
            this.panel2.Controls.Add(this.textBox_search);
            this.panel2.Controls.Add(this.textBox_item_id);
            this.panel2.Controls.Add(this.textBox_item_price);
            this.panel2.Controls.Add(this.textBox_item_quantity);
            this.panel2.Controls.Add(this.label_item_category);
            this.panel2.Controls.Add(this.label_item_price);
            this.panel2.Controls.Add(this.label_item_quantity);
            this.panel2.Controls.Add(this.label_item_name);
            this.panel2.Controls.Add(this.label_item_id);
            this.panel2.Controls.Add(this.ITEM);
            this.panel2.Location = new System.Drawing.Point(315, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 536);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button_item_src
            // 
            this.button_item_src.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_item_src.Location = new System.Drawing.Point(529, 27);
            this.button_item_src.Name = "button_item_src";
            this.button_item_src.Size = new System.Drawing.Size(75, 23);
            this.button_item_src.TabIndex = 7;
            this.button_item_src.Text = "Search";
            this.button_item_src.UseVisualStyleBackColor = true;
            this.button_item_src.Click += new System.EventHandler(this.button_item_src_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Meat",
            "Milk_beverages",
            "Fruits_vegetable",
            "Spices",
            "Dal",
            "Rice",
            "Eggs",
            "Oil"});
            this.comboBox1.Location = new System.Drawing.Point(109, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // button_item_update
            // 
            this.button_item_update.Animated = true;
            this.button_item_update.AutoRoundedCorners = true;
            this.button_item_update.BackColor = System.Drawing.Color.Transparent;
            this.button_item_update.BorderColor = System.Drawing.Color.Snow;
            this.button_item_update.BorderRadius = 14;
            this.button_item_update.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.button_item_update.BorderThickness = 1;
            this.button_item_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_item_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_item_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_item_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_item_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_item_update.Font = new System.Drawing.Font("MS UI Gothic", 9.75F);
            this.button_item_update.ForeColor = System.Drawing.Color.White;
            this.button_item_update.Location = new System.Drawing.Point(187, 322);
            this.button_item_update.Name = "button_item_update";
            this.button_item_update.Size = new System.Drawing.Size(91, 30);
            this.button_item_update.TabIndex = 4;
            this.button_item_update.Text = "UPDATE";
            this.button_item_update.Click += new System.EventHandler(this.button_item_update_Click);
            // 
            // button_item_delete
            // 
            this.button_item_delete.Animated = true;
            this.button_item_delete.AutoRoundedCorners = true;
            this.button_item_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_item_delete.BorderColor = System.Drawing.Color.White;
            this.button_item_delete.BorderRadius = 14;
            this.button_item_delete.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.button_item_delete.BorderThickness = 1;
            this.button_item_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_item_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_item_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_item_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_item_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_item_delete.Font = new System.Drawing.Font("MS UI Gothic", 9.75F);
            this.button_item_delete.ForeColor = System.Drawing.Color.White;
            this.button_item_delete.Location = new System.Drawing.Point(240, 279);
            this.button_item_delete.Name = "button_item_delete";
            this.button_item_delete.Size = new System.Drawing.Size(91, 30);
            this.button_item_delete.TabIndex = 4;
            this.button_item_delete.Text = "DELETE";
            this.button_item_delete.Click += new System.EventHandler(this.button_item_delete_Click);
            // 
            // button_item_insert
            // 
            this.button_item_insert.Animated = true;
            this.button_item_insert.AutoRoundedCorners = true;
            this.button_item_insert.BackColor = System.Drawing.Color.Transparent;
            this.button_item_insert.BorderColor = System.Drawing.Color.White;
            this.button_item_insert.BorderRadius = 14;
            this.button_item_insert.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.button_item_insert.BorderThickness = 1;
            this.button_item_insert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_item_insert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_item_insert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_item_insert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_item_insert.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_item_insert.Font = new System.Drawing.Font("MS Gothic", 9.75F);
            this.button_item_insert.ForeColor = System.Drawing.Color.White;
            this.button_item_insert.Location = new System.Drawing.Point(131, 279);
            this.button_item_insert.Name = "button_item_insert";
            this.button_item_insert.Size = new System.Drawing.Size(91, 30);
            this.button_item_insert.TabIndex = 4;
            this.button_item_insert.Text = "INSERT";
            this.button_item_insert.Click += new System.EventHandler(this.button_item_insert_Click);
            // 
            // dataGridView_item
            // 
            this.dataGridView_item.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_item.Location = new System.Drawing.Point(368, 54);
            this.dataGridView_item.Name = "dataGridView_item";
            this.dataGridView_item.RowHeadersWidth = 62;
            this.dataGridView_item.Size = new System.Drawing.Size(486, 479);
            this.dataGridView_item.TabIndex = 2;
            this.dataGridView_item.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_item_CellContentClick);
            // 
            // textBox_item_name
            // 
            this.textBox_item_name.Location = new System.Drawing.Point(109, 144);
            this.textBox_item_name.Name = "textBox_item_name";
            this.textBox_item_name.Size = new System.Drawing.Size(244, 20);
            this.textBox_item_name.TabIndex = 1;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(610, 28);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(244, 20);
            this.textBox_search.TabIndex = 1;
            // 
            // textBox_item_id
            // 
            this.textBox_item_id.Location = new System.Drawing.Point(109, 112);
            this.textBox_item_id.Name = "textBox_item_id";
            this.textBox_item_id.Size = new System.Drawing.Size(244, 20);
            this.textBox_item_id.TabIndex = 1;
            // 
            // textBox_item_price
            // 
            this.textBox_item_price.Location = new System.Drawing.Point(109, 210);
            this.textBox_item_price.Name = "textBox_item_price";
            this.textBox_item_price.Size = new System.Drawing.Size(244, 20);
            this.textBox_item_price.TabIndex = 1;
            // 
            // textBox_item_quantity
            // 
            this.textBox_item_quantity.Location = new System.Drawing.Point(109, 178);
            this.textBox_item_quantity.Name = "textBox_item_quantity";
            this.textBox_item_quantity.Size = new System.Drawing.Size(244, 20);
            this.textBox_item_quantity.TabIndex = 1;
            // 
            // label_item_category
            // 
            this.label_item_category.AutoSize = true;
            this.label_item_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item_category.ForeColor = System.Drawing.SystemColors.Control;
            this.label_item_category.Location = new System.Drawing.Point(22, 243);
            this.label_item_category.Name = "label_item_category";
            this.label_item_category.Size = new System.Drawing.Size(81, 20);
            this.label_item_category.TabIndex = 0;
            this.label_item_category.Text = "Category";
            // 
            // label_item_price
            // 
            this.label_item_price.AutoSize = true;
            this.label_item_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item_price.ForeColor = System.Drawing.SystemColors.Control;
            this.label_item_price.Location = new System.Drawing.Point(22, 210);
            this.label_item_price.Name = "label_item_price";
            this.label_item_price.Size = new System.Drawing.Size(49, 20);
            this.label_item_price.TabIndex = 0;
            this.label_item_price.Text = "Price";
            // 
            // label_item_quantity
            // 
            this.label_item_quantity.AutoSize = true;
            this.label_item_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item_quantity.ForeColor = System.Drawing.SystemColors.Control;
            this.label_item_quantity.Location = new System.Drawing.Point(22, 176);
            this.label_item_quantity.Name = "label_item_quantity";
            this.label_item_quantity.Size = new System.Drawing.Size(76, 20);
            this.label_item_quantity.TabIndex = 0;
            this.label_item_quantity.Text = "Quantity";
            // 
            // label_item_name
            // 
            this.label_item_name.AutoSize = true;
            this.label_item_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item_name.ForeColor = System.Drawing.SystemColors.Control;
            this.label_item_name.Location = new System.Drawing.Point(22, 145);
            this.label_item_name.Name = "label_item_name";
            this.label_item_name.Size = new System.Drawing.Size(55, 20);
            this.label_item_name.TabIndex = 0;
            this.label_item_name.Text = "Name";
            // 
            // label_item_id
            // 
            this.label_item_id.AutoSize = true;
            this.label_item_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item_id.ForeColor = System.Drawing.SystemColors.Control;
            this.label_item_id.Location = new System.Drawing.Point(22, 112);
            this.label_item_id.Name = "label_item_id";
            this.label_item_id.Size = new System.Drawing.Size(28, 20);
            this.label_item_id.TabIndex = 0;
            this.label_item_id.Text = "ID";
            // 
            // ITEM
            // 
            this.ITEM.AutoSize = true;
            this.ITEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITEM.ForeColor = System.Drawing.SystemColors.Control;
            this.ITEM.Location = new System.Drawing.Point(393, 12);
            this.ITEM.Name = "ITEM";
            this.ITEM.Size = new System.Drawing.Size(66, 25);
            this.ITEM.TabIndex = 0;
            this.ITEM.Text = "ITEM";
            // 
            // button_empInfo
            // 
            this.button_empInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_empInfo.FlatAppearance.BorderSize = 0;
            this.button_empInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_empInfo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_empInfo.ForeColor = System.Drawing.Color.White;
            this.button_empInfo.Location = new System.Drawing.Point(39, 369);
            this.button_empInfo.Name = "button_empInfo";
            this.button_empInfo.Size = new System.Drawing.Size(233, 37);
            this.button_empInfo.TabIndex = 3;
            this.button_empInfo.Text = "Employee Information";
            this.button_empInfo.UseVisualStyleBackColor = false;
            this.button_empInfo.Click += new System.EventHandler(this.button_empInfo_Click);
            this.button_empInfo.MouseEnter += new System.EventHandler(this.button_empInfo_MouseEnter);
            this.button_empInfo.MouseLeave += new System.EventHandler(this.button_empInfo_MouseLeave);
            // 
            // button_ItemInfo
            // 
            this.button_ItemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_ItemInfo.FlatAppearance.BorderSize = 0;
            this.button_ItemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ItemInfo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ItemInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.button_ItemInfo.Location = new System.Drawing.Point(51, 407);
            this.button_ItemInfo.Name = "button_ItemInfo";
            this.button_ItemInfo.Size = new System.Drawing.Size(210, 37);
            this.button_ItemInfo.TabIndex = 3;
            this.button_ItemInfo.Text = "Item Information";
            this.button_ItemInfo.UseVisualStyleBackColor = false;
            this.button_ItemInfo.MouseEnter += new System.EventHandler(this.button_ItemInfo_MouseEnter);
            this.button_ItemInfo.MouseLeave += new System.EventHandler(this.button_ItemInfo_MouseLeave_1);
            // 
            // button_logoutAdmin
            // 
            this.button_logoutAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_logoutAdmin.FlatAppearance.BorderSize = 0;
            this.button_logoutAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logoutAdmin.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logoutAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.button_logoutAdmin.Location = new System.Drawing.Point(1, 526);
            this.button_logoutAdmin.Name = "button_logoutAdmin";
            this.button_logoutAdmin.Size = new System.Drawing.Size(87, 33);
            this.button_logoutAdmin.TabIndex = 4;
            this.button_logoutAdmin.Text = "Logout";
            this.button_logoutAdmin.UseVisualStyleBackColor = false;
            this.button_logoutAdmin.Click += new System.EventHandler(this.button_logoutAdmin_Click);
            this.button_logoutAdmin.MouseEnter += new System.EventHandler(this.button_logoutAdmin_MouseEnter_1);
            this.button_logoutAdmin.MouseLeave += new System.EventHandler(this.button_logoutAdmin_MouseLeave);
            // 
            // button_chat
            // 
            this.button_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_chat.FlatAppearance.BorderSize = 0;
            this.button_chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chat.ForeColor = System.Drawing.SystemColors.Control;
            this.button_chat.Location = new System.Drawing.Point(234, 533);
            this.button_chat.Name = "button_chat";
            this.button_chat.Size = new System.Drawing.Size(75, 23);
            this.button_chat.TabIndex = 5;
            this.button_chat.Text = "CHAT";
            this.button_chat.UseVisualStyleBackColor = false;
            this.button_chat.Click += new System.EventHandler(this.button_chat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Super_Shop_Management.Properties.Resources.MAAR_ket2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_itemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.button_chat);
            this.Controls.Add(this.button_logoutAdmin);
            this.Controls.Add(this.button_ItemInfo);
            this.Controls.Add(this.button_empInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_itemInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Information";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_empInfo;
        private System.Windows.Forms.Button button_ItemInfo;
        private System.Windows.Forms.Button button_logoutAdmin;
        private System.Windows.Forms.TextBox textBox_item_name;
        private System.Windows.Forms.TextBox textBox_item_id;
        private System.Windows.Forms.TextBox textBox_item_price;
        private System.Windows.Forms.TextBox textBox_item_quantity;
        private System.Windows.Forms.Label label_item_category;
        private System.Windows.Forms.Label label_item_price;
        private System.Windows.Forms.Label label_item_quantity;
        private System.Windows.Forms.Label label_item_name;
        private System.Windows.Forms.Label label_item_id;
        private System.Windows.Forms.Label ITEM;
        private System.Windows.Forms.DataGridView dataGridView_item;
        private System.Windows.Forms.TextBox textBox_search;
        private Guna.UI2.WinForms.Guna2Button button_item_insert;
        private Guna.UI2.WinForms.Guna2Button button_item_update;
        private Guna.UI2.WinForms.Guna2Button button_item_delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_item_src;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Button button_chat;
    }
}