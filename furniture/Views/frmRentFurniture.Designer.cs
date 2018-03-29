namespace furniture
{
    partial class frmRentFurniture
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
            this.TxtEmployee_id = new System.Windows.Forms.TextBox();
            this.TxtCustomer_id = new System.Windows.Forms.TextBox();
            this.TxtTotal_price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LblCustomer_id = new System.Windows.Forms.Label();
            this.LblEmployee_id = new System.Windows.Forms.Label();
            this.LblTotal_amount = new System.Windows.Forms.Label();
            this.LblCurrent_date = new System.Windows.Forms.Label();
            this.LblDue_date = new System.Windows.Forms.Label();
            this.TxtDueDate = new System.Windows.Forms.TextBox();
            this.TxtRentDate = new System.Windows.Forms.TextBox();
            this.grid_selected_item = new System.Windows.Forms.DataGridView();
            this.item_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblDateFormat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_selected_item)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEmployee_id
            // 
            this.TxtEmployee_id.Enabled = false;
            this.TxtEmployee_id.Location = new System.Drawing.Point(176, 72);
            this.TxtEmployee_id.Name = "TxtEmployee_id";
            this.TxtEmployee_id.Size = new System.Drawing.Size(116, 20);
            this.TxtEmployee_id.TabIndex = 0;
            // 
            // TxtCustomer_id
            // 
            this.TxtCustomer_id.Enabled = false;
            this.TxtCustomer_id.Location = new System.Drawing.Point(416, 72);
            this.TxtCustomer_id.Name = "TxtCustomer_id";
            this.TxtCustomer_id.Size = new System.Drawing.Size(123, 20);
            this.TxtCustomer_id.TabIndex = 1;
            this.TxtCustomer_id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtTotal_price
            // 
            this.TxtTotal_price.Enabled = false;
            this.TxtTotal_price.Location = new System.Drawing.Point(375, 293);
            this.TxtTotal_price.Name = "TxtTotal_price";
            this.TxtTotal_price.Size = new System.Drawing.Size(82, 20);
            this.TxtTotal_price.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "<<- Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LblCustomer_id
            // 
            this.LblCustomer_id.AutoSize = true;
            this.LblCustomer_id.Location = new System.Drawing.Point(330, 75);
            this.LblCustomer_id.Name = "LblCustomer_id";
            this.LblCustomer_id.Size = new System.Drawing.Size(68, 13);
            this.LblCustomer_id.TabIndex = 6;
            this.LblCustomer_id.Text = "Customer ID:";
            // 
            // LblEmployee_id
            // 
            this.LblEmployee_id.AutoSize = true;
            this.LblEmployee_id.Location = new System.Drawing.Point(97, 75);
            this.LblEmployee_id.Name = "LblEmployee_id";
            this.LblEmployee_id.Size = new System.Drawing.Size(73, 13);
            this.LblEmployee_id.TabIndex = 7;
            this.LblEmployee_id.Text = "Employee ID: ";
            // 
            // LblTotal_amount
            // 
            this.LblTotal_amount.AutoSize = true;
            this.LblTotal_amount.Location = new System.Drawing.Point(283, 298);
            this.LblTotal_amount.Name = "LblTotal_amount";
            this.LblTotal_amount.Size = new System.Drawing.Size(76, 13);
            this.LblTotal_amount.TabIndex = 8;
            this.LblTotal_amount.Text = "Total Amount :";
            // 
            // LblCurrent_date
            // 
            this.LblCurrent_date.AutoSize = true;
            this.LblCurrent_date.Location = new System.Drawing.Point(97, 110);
            this.LblCurrent_date.Name = "LblCurrent_date";
            this.LblCurrent_date.Size = new System.Drawing.Size(71, 13);
            this.LblCurrent_date.TabIndex = 12;
            this.LblCurrent_date.Text = "Current date: ";
            // 
            // LblDue_date
            // 
            this.LblDue_date.AutoSize = true;
            this.LblDue_date.Location = new System.Drawing.Point(339, 107);
            this.LblDue_date.Name = "LblDue_date";
            this.LblDue_date.Size = new System.Drawing.Size(59, 13);
            this.LblDue_date.TabIndex = 11;
            this.LblDue_date.Text = "Due Date: ";
            // 
            // TxtDueDate
            // 
            this.TxtDueDate.Location = new System.Drawing.Point(416, 107);
            this.TxtDueDate.Name = "TxtDueDate";
            this.TxtDueDate.Size = new System.Drawing.Size(123, 20);
            this.TxtDueDate.TabIndex = 10;
            // 
            // TxtRentDate
            // 
            this.TxtRentDate.Enabled = false;
            this.TxtRentDate.Location = new System.Drawing.Point(176, 107);
            this.TxtRentDate.Name = "TxtRentDate";
            this.TxtRentDate.Size = new System.Drawing.Size(116, 20);
            this.TxtRentDate.TabIndex = 9;
            // 
            // grid_selected_item
            // 
            this.grid_selected_item.AllowUserToAddRows = false;
            this.grid_selected_item.AllowUserToDeleteRows = false;
            this.grid_selected_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_selected_item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_num,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid_selected_item.Location = new System.Drawing.Point(59, 133);
            this.grid_selected_item.Name = "grid_selected_item";
            this.grid_selected_item.ReadOnly = true;
            this.grid_selected_item.Size = new System.Drawing.Size(528, 143);
            this.grid_selected_item.TabIndex = 13;
            // 
            // item_num
            // 
            this.item_num.HeaderText = "Item number";
            this.item_num.Name = "item_num";
            this.item_num.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Furniture ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Style";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Rental Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // LblDateFormat
            // 
            this.LblDateFormat.AutoSize = true;
            this.LblDateFormat.Location = new System.Drawing.Point(545, 110);
            this.LblDateFormat.Name = "LblDateFormat";
            this.LblDateFormat.Size = new System.Drawing.Size(61, 13);
            this.LblDateFormat.TabIndex = 14;
            this.LblDateFormat.Text = "(mm/dd/yy)";
            this.LblDateFormat.Click += new System.EventHandler(this.LblDateFormat_Click);
            // 
            // frmRentFurniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 374);
            this.Controls.Add(this.LblDateFormat);
            this.Controls.Add(this.grid_selected_item);
            this.Controls.Add(this.LblCurrent_date);
            this.Controls.Add(this.LblDue_date);
            this.Controls.Add(this.TxtDueDate);
            this.Controls.Add(this.TxtRentDate);
            this.Controls.Add(this.LblTotal_amount);
            this.Controls.Add(this.LblEmployee_id);
            this.Controls.Add(this.LblCustomer_id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtTotal_price);
            this.Controls.Add(this.TxtCustomer_id);
            this.Controls.Add(this.TxtEmployee_id);
            this.Name = "frmRentFurniture";
            this.Text = "PAY";
            this.Load += new System.EventHandler(this.frmRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_selected_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEmployee_id;
        private System.Windows.Forms.TextBox TxtCustomer_id;
        private System.Windows.Forms.TextBox TxtTotal_price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblCustomer_id;
        private System.Windows.Forms.Label LblEmployee_id;
        private System.Windows.Forms.Label LblTotal_amount;
        private System.Windows.Forms.Label LblCurrent_date;
        private System.Windows.Forms.Label LblDue_date;
        private System.Windows.Forms.TextBox TxtDueDate;
        private System.Windows.Forms.TextBox TxtRentDate;
        private System.Windows.Forms.DataGridView grid_selected_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label LblDateFormat;
    }
}