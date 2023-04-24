
namespace employee
{
    partial class employee_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_Form));
            this.panel_item = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel_itemPrice = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel_itemQuantity = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel_itemName = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_itemId = new System.Windows.Forms.Panel();
            this.button_itemDelete = new System.Windows.Forms.Button();
            this.button_itemUpdate = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_itemCtg = new System.Windows.Forms.Label();
            this.label_itemPrice = new System.Windows.Forms.Label();
            this.label_itemQuantity = new System.Windows.Forms.Label();
            this.label_itemName = new System.Windows.Forms.Label();
            this.label_itemId = new System.Windows.Forms.Label();
            this.label_ctgSearch = new System.Windows.Forms.Label();
            this.comboBox_searchCtg = new System.Windows.Forms.ComboBox();
            this.dataGridView_items = new System.Windows.Forms.DataGridView();
            this.label_item = new System.Windows.Forms.Label();
            this.pictureBox_emp = new System.Windows.Forms.PictureBox();
            this.button_custInfo = new System.Windows.Forms.Button();
            this.button_itemInfo = new System.Windows.Forms.Button();
            this.button_empLogout = new System.Windows.Forms.Button();
            this.panel_item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_item
            // 
            this.panel_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_item.Controls.Add(this.comboBox1);
            this.panel_item.Controls.Add(this.panel_itemPrice);
            this.panel_item.Controls.Add(this.textBox4);
            this.panel_item.Controls.Add(this.panel_itemQuantity);
            this.panel_item.Controls.Add(this.textBox2);
            this.panel_item.Controls.Add(this.panel_itemName);
            this.panel_item.Controls.Add(this.textBox1);
            this.panel_item.Controls.Add(this.panel_itemId);
            this.panel_item.Controls.Add(this.button_itemDelete);
            this.panel_item.Controls.Add(this.button_itemUpdate);
            this.panel_item.Controls.Add(this.textBox_id);
            this.panel_item.Controls.Add(this.label_itemCtg);
            this.panel_item.Controls.Add(this.label_itemPrice);
            this.panel_item.Controls.Add(this.label_itemQuantity);
            this.panel_item.Controls.Add(this.label_itemName);
            this.panel_item.Controls.Add(this.label_itemId);
            this.panel_item.Controls.Add(this.label_ctgSearch);
            this.panel_item.Controls.Add(this.comboBox_searchCtg);
            this.panel_item.Controls.Add(this.dataGridView_items);
            this.panel_item.Controls.Add(this.label_item);
            this.panel_item.Location = new System.Drawing.Point(301, 12);
            this.panel_item.Name = "panel_item";
            this.panel_item.Size = new System.Drawing.Size(931, 537);
            this.panel_item.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Meat",
            "Beverage",
            "Vegetable",
            "Fruits",
            "Milk",
            "Spices",
            "Daal",
            "Rice",
            "Egg",
            "Oil"});
            this.comboBox1.Location = new System.Drawing.Point(112, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 28);
            this.comboBox1.TabIndex = 24;
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
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(112, 232);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 25);
            this.textBox4.TabIndex = 22;
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(112, 192);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 25);
            this.textBox2.TabIndex = 20;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(112, 155);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 25);
            this.textBox1.TabIndex = 18;
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
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.ForeColor = System.Drawing.Color.White;
            this.textBox_id.Location = new System.Drawing.Point(112, 122);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(228, 25);
            this.textBox_id.TabIndex = 10;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
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
            // 
            // label_ctgSearch
            // 
            this.label_ctgSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_ctgSearch.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ctgSearch.ForeColor = System.Drawing.Color.White;
            this.label_ctgSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_ctgSearch.Location = new System.Drawing.Point(567, 68);
            this.label_ctgSearch.Name = "label_ctgSearch";
            this.label_ctgSearch.Size = new System.Drawing.Size(87, 25);
            this.label_ctgSearch.TabIndex = 3;
            this.label_ctgSearch.Text = "Search:";
            this.label_ctgSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_ctgSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_searchCtg
            // 
            this.comboBox_searchCtg.AllowDrop = true;
            this.comboBox_searchCtg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_searchCtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_searchCtg.FormattingEnabled = true;
            this.comboBox_searchCtg.Items.AddRange(new object[] {
            "Meat",
            "Beverage",
            "Vegetable",
            "Fruits",
            "Milk",
            "Spices",
            "Daal",
            "Rice",
            "Egg",
            "Oil"});
            this.comboBox_searchCtg.Location = new System.Drawing.Point(660, 65);
            this.comboBox_searchCtg.Name = "comboBox_searchCtg";
            this.comboBox_searchCtg.Size = new System.Drawing.Size(258, 28);
            this.comboBox_searchCtg.TabIndex = 2;
            // 
            // dataGridView_items
            // 
            this.dataGridView_items.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_items.Location = new System.Drawing.Point(357, 99);
            this.dataGridView_items.Name = "dataGridView_items";
            this.dataGridView_items.Size = new System.Drawing.Size(561, 423);
            this.dataGridView_items.TabIndex = 1;
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
            // pictureBox_emp
            // 
            this.pictureBox_emp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_emp.Image")));
            this.pictureBox_emp.Location = new System.Drawing.Point(13, 12);
            this.pictureBox_emp.Name = "pictureBox_emp";
            this.pictureBox_emp.Size = new System.Drawing.Size(266, 359);
            this.pictureBox_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_emp.TabIndex = 0;
            this.pictureBox_emp.TabStop = false;
            // 
            // button_custInfo
            // 
            this.button_custInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_custInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_custInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_custInfo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_custInfo.ForeColor = System.Drawing.Color.White;
            this.button_custInfo.Location = new System.Drawing.Point(13, 391);
            this.button_custInfo.Name = "button_custInfo";
            this.button_custInfo.Size = new System.Drawing.Size(266, 36);
            this.button_custInfo.TabIndex = 3;
            this.button_custInfo.Text = "Customer Information";
            this.button_custInfo.UseVisualStyleBackColor = false;
            this.button_custInfo.Click += new System.EventHandler(this.button_custInfo_Click);
            // 
            // button_itemInfo
            // 
            this.button_itemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_itemInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_itemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_itemInfo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_itemInfo.ForeColor = System.Drawing.Color.White;
            this.button_itemInfo.Location = new System.Drawing.Point(13, 433);
            this.button_itemInfo.Name = "button_itemInfo";
            this.button_itemInfo.Size = new System.Drawing.Size(266, 31);
            this.button_itemInfo.TabIndex = 4;
            this.button_itemInfo.Text = "Item Information";
            this.button_itemInfo.UseVisualStyleBackColor = false;
            this.button_itemInfo.Click += new System.EventHandler(this.button_itemInfo_Click);
            // 
            // button_empLogout
            // 
            this.button_empLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_empLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_empLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_empLogout.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_empLogout.ForeColor = System.Drawing.Color.White;
            this.button_empLogout.Location = new System.Drawing.Point(11, 520);
            this.button_empLogout.Name = "button_empLogout";
            this.button_empLogout.Size = new System.Drawing.Size(82, 31);
            this.button_empLogout.TabIndex = 5;
            this.button_empLogout.Text = "Logout";
            this.button_empLogout.UseVisualStyleBackColor = false;
            this.button_empLogout.MouseEnter += new System.EventHandler(this.button_empLogout_MouseEnter);
            this.button_empLogout.MouseLeave += new System.EventHandler(this.button_empLogout_MouseLeave);
            // 
            // employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1244, 561);
            this.Controls.Add(this.button_empLogout);
            this.Controls.Add(this.button_itemInfo);
            this.Controls.Add(this.button_custInfo);
            this.Controls.Add(this.pictureBox_emp);
            this.Controls.Add(this.panel_item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1260, 600);
            this.Name = "employee_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.employee_Form_Load);
            this.panel_item.ResumeLayout(false);
            this.panel_item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_item;
        private System.Windows.Forms.Label label_item;
        private System.Windows.Forms.PictureBox pictureBox_emp;
        private System.Windows.Forms.Button button_custInfo;
        private System.Windows.Forms.Button button_itemInfo;
        private System.Windows.Forms.DataGridView dataGridView_items;
        private System.Windows.Forms.Button button_empLogout;
        private System.Windows.Forms.ComboBox comboBox_searchCtg;
        private System.Windows.Forms.Label label_ctgSearch;
        private System.Windows.Forms.Label label_itemId;
        private System.Windows.Forms.Label label_itemPrice;
        private System.Windows.Forms.Label label_itemQuantity;
        private System.Windows.Forms.Label label_itemName;
        private System.Windows.Forms.Label label_itemCtg;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button button_itemDelete;
        private System.Windows.Forms.Button button_itemUpdate;
        private System.Windows.Forms.Panel panel_itemId;
        private System.Windows.Forms.Panel panel_itemName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel_itemQuantity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel_itemPrice;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

