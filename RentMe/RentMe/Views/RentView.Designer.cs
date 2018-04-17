namespace RentMe.Views
{
    partial class RentView
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
            System.Windows.Forms.Label lblItemID;
            System.Windows.Forms.Label lblFurnitureID;
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label label1;
            this.cboEmployeeID = new System.Windows.Forms.ComboBox();
            this.cboCustomerID = new System.Windows.Forms.ComboBox();
            this.lblFurnitureInfo = new System.Windows.Forms.Label();
            this.mtxtCurrentDate = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDueDate = new System.Windows.Forms.MaskedTextBox();
            this.LblDateFormat = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fine_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daily_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            lblItemID = new System.Windows.Forms.Label();
            lblFurnitureID = new System.Windows.Forms.Label();
            fnameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            lblItemID.Location = new System.Drawing.Point(408, 134);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new System.Drawing.Size(96, 19);
            lblItemID.TabIndex = 57;
            lblItemID.Text = "Customer ID:";
            // 
            // lblFurnitureID
            // 
            lblFurnitureID.AutoSize = true;
            lblFurnitureID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            lblFurnitureID.Location = new System.Drawing.Point(51, 134);
            lblFurnitureID.Name = "lblFurnitureID";
            lblFurnitureID.Size = new System.Drawing.Size(98, 19);
            lblFurnitureID.TabIndex = 56;
            lblFurnitureID.Text = "Employee ID:";
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fnameLabel.Location = new System.Drawing.Point(51, 183);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(101, 19);
            fnameLabel.TabIndex = 87;
            fnameLabel.Text = "Current Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(406, 183);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 19);
            label1.TabIndex = 89;
            label1.Text = "Due Date:";
            // 
            // cboEmployeeID
            // 
            this.cboEmployeeID.AllowDrop = true;
            this.cboEmployeeID.DisplayMember = "furnitureID";
            this.cboEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployeeID.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboEmployeeID.FormattingEnabled = true;
            this.cboEmployeeID.Location = new System.Drawing.Point(155, 131);
            this.cboEmployeeID.Name = "cboEmployeeID";
            this.cboEmployeeID.Size = new System.Drawing.Size(204, 27);
            this.cboEmployeeID.TabIndex = 54;
            this.cboEmployeeID.Tag = "Employee";
            this.cboEmployeeID.ValueMember = "furnitureID";
            // 
            // cboCustomerID
            // 
            this.cboCustomerID.AllowDrop = true;
            this.cboCustomerID.DisplayMember = "itemID";
            this.cboCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerID.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboCustomerID.FormattingEnabled = true;
            this.cboCustomerID.Location = new System.Drawing.Point(510, 131);
            this.cboCustomerID.Name = "cboCustomerID";
            this.cboCustomerID.Size = new System.Drawing.Size(219, 27);
            this.cboCustomerID.TabIndex = 55;
            this.cboCustomerID.ValueMember = "itemID";
            // 
            // lblFurnitureInfo
            // 
            this.lblFurnitureInfo.AutoSize = true;
            this.lblFurnitureInfo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurnitureInfo.Location = new System.Drawing.Point(283, 46);
            this.lblFurnitureInfo.Name = "lblFurnitureInfo";
            this.lblFurnitureInfo.Size = new System.Drawing.Size(245, 39);
            this.lblFurnitureInfo.TabIndex = 59;
            this.lblFurnitureInfo.Text = "Rent Information";
            this.lblFurnitureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtxtCurrentDate
            // 
            this.mtxtCurrentDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCurrentDate.Location = new System.Drawing.Point(155, 180);
            this.mtxtCurrentDate.Mask = "00/00/0000";
            this.mtxtCurrentDate.Name = "mtxtCurrentDate";
            this.mtxtCurrentDate.Size = new System.Drawing.Size(204, 27);
            this.mtxtCurrentDate.TabIndex = 88;
            this.mtxtCurrentDate.Tag = "Date of Birth";
            this.mtxtCurrentDate.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtDueDate
            // 
            this.mtxtDueDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDueDate.Location = new System.Drawing.Point(510, 180);
            this.mtxtDueDate.Mask = "00/00/0000";
            this.mtxtDueDate.Name = "mtxtDueDate";
            this.mtxtDueDate.Size = new System.Drawing.Size(219, 27);
            this.mtxtDueDate.TabIndex = 90;
            this.mtxtDueDate.Tag = "Date of Birth";
            this.mtxtDueDate.ValidatingType = typeof(System.DateTime);
            // 
            // LblDateFormat
            // 
            this.LblDateFormat.AutoSize = true;
            this.LblDateFormat.Location = new System.Drawing.Point(766, 187);
            this.LblDateFormat.Name = "LblDateFormat";
            this.LblDateFormat.Size = new System.Drawing.Size(61, 13);
            this.LblDateFormat.TabIndex = 91;
            this.LblDateFormat.Text = "(mm/dd/yy)";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.funitureID,
            this.Category,
            this.Style,
            this.Description,
            this.Fine_rate,
            this.Daily_rate,
            this.add});
            this.dataGridViewItems.Location = new System.Drawing.Point(64, 231);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(772, 206);
            this.dataGridViewItems.TabIndex = 92;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            // 
            // funitureID
            // 
            this.funitureID.HeaderText = "Furniture ID";
            this.funitureID.Name = "funitureID";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Style
            // 
            this.Style.HeaderText = "Style";
            this.Style.Name = "Style";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Fine_rate
            // 
            this.Fine_rate.HeaderText = "Fine Rate";
            this.Fine_rate.Name = "Fine_rate";
            // 
            // Daily_rate
            // 
            this.Daily_rate.HeaderText = "Daily Rate";
            this.Daily_rate.Name = "Daily_rate";
            // 
            // add
            // 
            this.add.HeaderText = "Add Cart";
            this.add.Name = "add";
            // 
            // btnRent
            // 
            this.btnRent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(594, 462);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(91, 31);
            this.btnRent.TabIndex = 93;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(736, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 94;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(306, 466);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(154, 27);
            this.txtTotalAmount.TabIndex = 95;
            this.txtTotalAmount.Tag = "Total Amount";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(180, 469);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(111, 19);
            this.lblFirstName.TabIndex = 96;
            this.lblFirstName.Text = "Total Amount: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(328, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // RentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.LblDateFormat);
            this.Controls.Add(this.mtxtDueDate);
            this.Controls.Add(label1);
            this.Controls.Add(this.mtxtCurrentDate);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.lblFurnitureInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboEmployeeID);
            this.Controls.Add(lblItemID);
            this.Controls.Add(this.cboCustomerID);
            this.Controls.Add(lblFurnitureID);
            this.Name = "RentView";
            this.Text = "Rent View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEmployeeID;
        private System.Windows.Forms.ComboBox cboCustomerID;
        private System.Windows.Forms.Label lblFurnitureInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mtxtCurrentDate;
        private System.Windows.Forms.MaskedTextBox mtxtDueDate;
        private System.Windows.Forms.Label LblDateFormat;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn funitureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fine_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daily_rate;
        private System.Windows.Forms.DataGridViewButtonColumn add;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblFirstName;
    }
}