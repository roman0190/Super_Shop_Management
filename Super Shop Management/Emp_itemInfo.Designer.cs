
namespace Super_Shop_Management
{
    partial class Emp_itemInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_itemInfo));
            this.button_empLogout = new System.Windows.Forms.Button();
            this.button_itemInfo = new System.Windows.Forms.Button();
            this.button_custInfo = new System.Windows.Forms.Button();
            this.panel_item = new System.Windows.Forms.Panel();
            this.button_itemSearch = new System.Windows.Forms.Button();
            this.textBox_itemSearch = new System.Windows.Forms.TextBox();
            this.comboBox_ctg = new System.Windows.Forms.ComboBox();
            this.panel_itemPrice = new System.Windows.Forms.Panel();
            this.textBox_itemPrice = new System.Windows.Forms.TextBox();
            this.panel_itemQuantity = new System.Windows.Forms.Panel();
            this.textBox_itemQty = new System.Windows.Forms.TextBox();
            this.panel_itemName = new System.Windows.Forms.Panel();
            this.textBox_itemName = new System.Windows.Forms.TextBox();
            this.panel_itemId = new System.Windows.Forms.Panel();
            this.button_itemDelete = new System.Windows.Forms.Button();
            this.button_itemUpdate = new System.Windows.Forms.Button();
            this.textBox_itemId = new System.Windows.Forms.TextBox();
            this.label_itemCtg = new System.Windows.Forms.Label();
            this.label_itemPrice = new System.Windows.Forms.Label();
            this.label_itemQuantity = new System.Windows.Forms.Label();
            this.label_itemName = new System.Windows.Forms.Label();
            this.label_itemId = new System.Windows.Forms.Label();
            this.dataGridView_items = new System.Windows.Forms.DataGridView();
            this.label_item = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.Label();
            this.pictureBox_emp = new System.Windows.Forms.PictureBox();
            this.panel_item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // button_empLogout
            // 
            this.button_empLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_empLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_empLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_empLogout.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_empLogout.ForeColor = System.Drawing.Color.White;
            this.button_empLogout.Location = new System.Drawing.Point(12, 519);
            this.button_empLogout.Name = "button_empLogout";
            this.button_empLogout.Size = new System.Drawing.Size(82, 31);
            this.button_empLogout.TabIndex = 10;
            this.button_empLogout.Text = "Logout";
            this.button_empLogout.UseVisualStyleBackColor = false;
            this.button_empLogout.Click += new System.EventHandler(this.button_empLogout_Click);
            // 
            // button_itemInfo
            // 
            this.button_itemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_itemInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_itemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_itemInfo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemInfo.ForeColor = System.Drawing.Color.White;
            this.button_itemInfo.Location = new System.Drawing.Point(21, 418);
            this.button_itemInfo.Name = "button_itemInfo";
            this.button_itemInfo.Size = new System.Drawing.Size(266, 31);
            this.button_itemInfo.TabIndex = 9;
            this.button_itemInfo.Text = "Item Information";
            this.button_itemInfo.UseVisualStyleBackColor = false;
            // 
            // button_custInfo
            // 
            this.button_custInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_custInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_custInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_custInfo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_custInfo.ForeColor = System.Drawing.Color.White;
            this.button_custInfo.Location = new System.Drawing.Point(21, 381);
            this.button_custInfo.Name = "button_custInfo";
            this.button_custInfo.Size = new System.Drawing.Size(266, 36);
            this.button_custInfo.TabIndex = 8;
            this.button_custInfo.Text = "Customer Information";
            this.button_custInfo.UseVisualStyleBackColor = false;
            this.button_custInfo.Click += new System.EventHandler(this.button_custInfo_Click);
            // 
            // panel_item
            // 
            this.panel_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_item.Controls.Add(this.button_itemSearch);
            this.panel_item.Controls.Add(this.textBox_itemSearch);
            this.panel_item.Controls.Add(this.comboBox_ctg);
            this.panel_item.Controls.Add(this.panel_itemPrice);
            this.panel_item.Controls.Add(this.textBox_itemPrice);
            this.panel_item.Controls.Add(this.panel_itemQuantity);
            this.panel_item.Controls.Add(this.textBox_itemQty);
            this.panel_item.Controls.Add(this.panel_itemName);
            this.panel_item.Controls.Add(this.textBox_itemName);
            this.panel_item.Controls.Add(this.panel_itemId);
            this.panel_item.Controls.Add(this.button_itemDelete);
            this.panel_item.Controls.Add(this.button_itemUpdate);
            this.panel_item.Controls.Add(this.textBox_itemId);
            this.panel_item.Controls.Add(this.label_itemCtg);
            this.panel_item.Controls.Add(this.label_itemPrice);
            this.panel_item.Controls.Add(this.label_itemQuantity);
            this.panel_item.Controls.Add(this.label_itemName);
            this.panel_item.Controls.Add(this.label_itemId);
            this.panel_item.Controls.Add(this.dataGridView_items);
            this.panel_item.Controls.Add(this.label_item);
            this.panel_item.Location = new System.Drawing.Point(302, 11);
            this.panel_item.Name = "panel_item";
            this.panel_item.Size = new System.Drawing.Size(931, 537);
            this.panel_item.TabIndex = 7;
            this.panel_item.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_item_Paint);
            // 
            // button_itemSearch
            // 
            this.button_itemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemSearch.Location = new System.Drawing.Point(579, 65);
            this.button_itemSearch.Name = "button_itemSearch";
            this.button_itemSearch.Size = new System.Drawing.Size(75, 28);
            this.button_itemSearch.TabIndex = 25;
            this.button_itemSearch.Text = "Search";
            this.button_itemSearch.UseVisualStyleBackColor = true;
            this.button_itemSearch.Click += new System.EventHandler(this.button_itemSearch_Click);
            // 
            // textBox_itemSearch
            // 
            this.textBox_itemSearch.Location = new System.Drawing.Point(660, 65);
            this.textBox_itemSearch.Multiline = true;
            this.textBox_itemSearch.Name = "textBox_itemSearch";
            this.textBox_itemSearch.Size = new System.Drawing.Size(258, 28);
            this.textBox_itemSearch.TabIndex = 12;
            // 
            // comboBox_ctg
            // 
            this.comboBox_ctg.AllowDrop = true;
            this.comboBox_ctg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ctg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ctg.FormattingEnabled = true;
            this.comboBox_ctg.Items.AddRange(new object[] {
            "dal",
            "eggs",
            "Fruits_vegetable",
            "Meat",
            "Milk_beverages",
            "oil",
            "Rice",
            "Spices"});
            this.comboBox_ctg.Location = new System.Drawing.Point(112, 266);
            this.comboBox_ctg.Name = "comboBox_ctg";
            this.comboBox_ctg.Size = new System.Drawing.Size(228, 28);
            this.comboBox_ctg.TabIndex = 24;
            // 
            // panel_itemPrice
            // 
            this.panel_itemPrice.BackColor = System.Drawing.Color.White;
            this.panel_itemPrice.ForeColor = System.Drawing.Color.White;
            this.panel_itemPrice.Location = new System.Drawing.Point(112, 254);
            this.panel_itemPrice.Name = "panel_itemPrice";
            this.panel_itemPrice.Size = new System.Drawing.Size(228, 1);
            this.panel_itemPrice.TabIndex = 23;
            // 
            // textBox_itemPrice
            // 
            this.textBox_itemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_itemPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_itemPrice.ForeColor = System.Drawing.Color.White;
            this.textBox_itemPrice.Location = new System.Drawing.Point(112, 232);
            this.textBox_itemPrice.Multiline = true;
            this.textBox_itemPrice.Name = "textBox_itemPrice";
            this.textBox_itemPrice.Size = new System.Drawing.Size(228, 25);
            this.textBox_itemPrice.TabIndex = 22;
            // 
            // panel_itemQuantity
            // 
            this.panel_itemQuantity.BackColor = System.Drawing.Color.White;
            this.panel_itemQuantity.ForeColor = System.Drawing.Color.White;
            this.panel_itemQuantity.Location = new System.Drawing.Point(112, 214);
            this.panel_itemQuantity.Name = "panel_itemQuantity";
            this.panel_itemQuantity.Size = new System.Drawing.Size(228, 1);
            this.panel_itemQuantity.TabIndex = 21;
            // 
            // textBox_itemQty
            // 
            this.textBox_itemQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_itemQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_itemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_itemQty.ForeColor = System.Drawing.Color.White;
            this.textBox_itemQty.Location = new System.Drawing.Point(112, 192);
            this.textBox_itemQty.Multiline = true;
            this.textBox_itemQty.Name = "textBox_itemQty";
            this.textBox_itemQty.Size = new System.Drawing.Size(228, 25);
            this.textBox_itemQty.TabIndex = 20;
            // 
            // panel_itemName
            // 
            this.panel_itemName.BackColor = System.Drawing.Color.White;
            this.panel_itemName.ForeColor = System.Drawing.Color.White;
            this.panel_itemName.Location = new System.Drawing.Point(112, 177);
            this.panel_itemName.Name = "panel_itemName";
            this.panel_itemName.Size = new System.Drawing.Size(228, 1);
            this.panel_itemName.TabIndex = 19;
            // 
            // textBox_itemName
            // 
            this.textBox_itemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_itemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_itemName.ForeColor = System.Drawing.Color.White;
            this.textBox_itemName.Location = new System.Drawing.Point(112, 155);
            this.textBox_itemName.Multiline = true;
            this.textBox_itemName.Name = "textBox_itemName";
            this.textBox_itemName.Size = new System.Drawing.Size(228, 25);
            this.textBox_itemName.TabIndex = 18;
            // 
            // panel_itemId
            // 
            this.panel_itemId.BackColor = System.Drawing.Color.White;
            this.panel_itemId.ForeColor = System.Drawing.Color.White;
            this.panel_itemId.Location = new System.Drawing.Point(112, 144);
            this.panel_itemId.Name = "panel_itemId";
            this.panel_itemId.Size = new System.Drawing.Size(228, 1);
            this.panel_itemId.TabIndex = 17;
            // 
            // button_itemDelete
            // 
            this.button_itemDelete.BackColor = System.Drawing.Color.SlateBlue;
            this.button_itemDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_itemDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_itemDelete.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemDelete.ForeColor = System.Drawing.Color.White;
            this.button_itemDelete.Location = new System.Drawing.Point(231, 315);
            this.button_itemDelete.Name = "button_itemDelete";
            this.button_itemDelete.Size = new System.Drawing.Size(109, 31);
            this.button_itemDelete.TabIndex = 16;
            this.button_itemDelete.Text = "DELETE";
            this.button_itemDelete.UseVisualStyleBackColor = false;
            this.button_itemDelete.Click += new System.EventHandler(this.button_itemDelete_Click);
            // 
            // button_itemUpdate
            // 
            this.button_itemUpdate.BackColor = System.Drawing.Color.SlateBlue;
            this.button_itemUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_itemUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_itemUpdate.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemUpdate.ForeColor = System.Drawing.Color.White;
            this.button_itemUpdate.Location = new System.Drawing.Point(112, 315);
            this.button_itemUpdate.Name = "button_itemUpdate";
            this.button_itemUpdate.Size = new System.Drawing.Size(113, 31);
            this.button_itemUpdate.TabIndex = 15;
            this.button_itemUpdate.Text = "UPDATE";
            this.button_itemUpdate.UseVisualStyleBackColor = false;
            this.button_itemUpdate.Click += new System.EventHandler(this.button_itemUpdate_Click);
            // 
            // textBox_itemId
            // 
            this.textBox_itemId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_itemId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_itemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_itemId.ForeColor = System.Drawing.Color.White;
            this.textBox_itemId.Location = new System.Drawing.Point(112, 122);
            this.textBox_itemId.Multiline = true;
            this.textBox_itemId.Name = "textBox_itemId";
            this.textBox_itemId.Size = new System.Drawing.Size(228, 25);
            this.textBox_itemId.TabIndex = 10;
            // 
            // label_itemCtg
            // 
            this.label_itemCtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_itemCtg.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_itemCtg.ForeColor = System.Drawing.Color.White;
            this.label_itemCtg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_itemCtg.Location = new System.Drawing.Point(14, 269);
            this.label_itemCtg.Name = "label_itemCtg";
            this.label_itemCtg.Size = new System.Drawing.Size(92, 25);
            this.label_itemCtg.TabIndex = 8;
            this.label_itemCtg.Text = "Category";
            // 
            // label_itemPrice
            // 
            this.label_itemPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_itemPrice.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_itemPrice.ForeColor = System.Drawing.Color.White;
            this.label_itemPrice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_itemPrice.Location = new System.Drawing.Point(14, 230);
            this.label_itemPrice.Name = "label_itemPrice";
            this.label_itemPrice.Size = new System.Drawing.Size(61, 25);
            this.label_itemPrice.TabIndex = 7;
            this.label_itemPrice.Text = "Price";
            // 
            // label_itemQuantity
            // 
            this.label_itemQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_itemQuantity.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_itemQuantity.ForeColor = System.Drawing.Color.White;
            this.label_itemQuantity.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_itemQuantity.Location = new System.Drawing.Point(14, 194);
            this.label_itemQuantity.Name = "label_itemQuantity";
            this.label_itemQuantity.Size = new System.Drawing.Size(86, 25);
            this.label_itemQuantity.TabIndex = 6;
            this.label_itemQuantity.Text = "Quantity";
            // 
            // label_itemName
            // 
            this.label_itemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_itemName.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_itemName.ForeColor = System.Drawing.Color.White;
            this.label_itemName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_itemName.Location = new System.Drawing.Point(14, 157);
            this.label_itemName.Name = "label_itemName";
            this.label_itemName.Size = new System.Drawing.Size(61, 25);
            this.label_itemName.TabIndex = 5;
            this.label_itemName.Text = "Name";
            // 
            // label_itemId
            // 
            this.label_itemId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_itemId.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_itemId.ForeColor = System.Drawing.Color.White;
            this.label_itemId.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_itemId.Location = new System.Drawing.Point(14, 120);
            this.label_itemId.Name = "label_itemId";
            this.label_itemId.Size = new System.Drawing.Size(41, 25);
            this.label_itemId.TabIndex = 4;
            this.label_itemId.Text = "ID";
            this.label_itemId.Click += new System.EventHandler(this.label_itemId_Click);
            // 
            // dataGridView_items
            // 
            this.dataGridView_items.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_items.Location = new System.Drawing.Point(357, 99);
            this.dataGridView_items.Name = "dataGridView_items";
            this.dataGridView_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_items.Size = new System.Drawing.Size(561, 423);
            this.dataGridView_items.TabIndex = 1;
            this.dataGridView_items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_items_CellContentClick);
            // 
            // label_item
            // 
            this.label_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_item.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item.ForeColor = System.Drawing.Color.White;
            this.label_item.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_item.Location = new System.Drawing.Point(425, 19);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(80, 32);
            this.label_item.TabIndex = 0;
            this.label_item.Text = "ITEM";
            this.label_item.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Employee
            // 
            this.Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employee.Font = new System.Drawing.Font("Romantic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Employee.ForeColor = System.Drawing.Color.White;
            this.Employee.Location = new System.Drawing.Point(37, 31);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(234, 23);
            this.Employee.TabIndex = 11;
            this.Employee.Text = "Employee Control Panel";
            // 
            // pictureBox_emp
            // 
            this.pictureBox_emp.Image = global::Super_Shop_Management.Properties.Resources.MAAR_ket2;
            this.pictureBox_emp.Location = new System.Drawing.Point(14, 11);
            this.pictureBox_emp.Name = "pictureBox_emp";
            this.pictureBox_emp.Size = new System.Drawing.Size(282, 347);
            this.pictureBox_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_emp.TabIndex = 6;
            this.pictureBox_emp.TabStop = false;
            // 
            // Emp_itemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1244, 561);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.button_empLogout);
            this.Controls.Add(this.button_itemInfo);
            this.Controls.Add(this.button_custInfo);
            this.Controls.Add(this.pictureBox_emp);
            this.Controls.Add(this.panel_item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emp_itemInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Information";
            this.Load += new System.EventHandler(this.Emp_itemInfo_Load);
            this.panel_item.ResumeLayout(false);
            this.panel_item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_empLogout;
        private System.Windows.Forms.Button button_itemInfo;
        private System.Windows.Forms.Button button_custInfo;
        private System.Windows.Forms.PictureBox pictureBox_emp;
        private System.Windows.Forms.Panel panel_item;
        private System.Windows.Forms.ComboBox comboBox_ctg;
        private System.Windows.Forms.Panel panel_itemPrice;
        private System.Windows.Forms.TextBox textBox_itemPrice;
        private System.Windows.Forms.Panel panel_itemQuantity;
        private System.Windows.Forms.TextBox textBox_itemQty;
        private System.Windows.Forms.Panel panel_itemName;
        private System.Windows.Forms.TextBox textBox_itemName;
        private System.Windows.Forms.Panel panel_itemId;
        private System.Windows.Forms.Button button_itemDelete;
        private System.Windows.Forms.Button button_itemUpdate;
        private System.Windows.Forms.TextBox textBox_itemId;
        private System.Windows.Forms.Label label_itemCtg;
        private System.Windows.Forms.Label label_itemPrice;
        private System.Windows.Forms.Label label_itemQuantity;
        private System.Windows.Forms.Label label_itemName;
        private System.Windows.Forms.Label label_itemId;
        private System.Windows.Forms.DataGridView dataGridView_items;
        private System.Windows.Forms.Label label_item;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.TextBox textBox_itemSearch;
        private System.Windows.Forms.Button button_itemSearch;
    }
}