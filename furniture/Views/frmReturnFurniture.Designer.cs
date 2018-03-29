namespace furniture
{
    partial class frmReturnFurniture
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
            this.customer_name = new System.Windows.Forms.TextBox();
            this.Lbl_customer_name = new System.Windows.Forms.Label();
            this.Lbl_rent_item = new System.Windows.Forms.Label();
            this.Lbl_fine = new System.Windows.Forms.Label();
            this.fineT = new System.Windows.Forms.TextBox();
            this.Fine = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.Lbl_amtreturn = new System.Windows.Forms.Label();
            this.AmtReturn = new System.Windows.Forms.TextBox();
            this.Lbl_totalAmount = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.fundRecords = new System.Windows.Forms.Button();
            this.grid_selected_item = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_selected_item)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_name
            // 
            this.customer_name.Enabled = false;
            this.customer_name.Location = new System.Drawing.Point(174, 55);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(136, 20);
            this.customer_name.TabIndex = 0;
            // 
            // Lbl_customer_name
            // 
            this.Lbl_customer_name.AutoSize = true;
            this.Lbl_customer_name.Location = new System.Drawing.Point(72, 58);
            this.Lbl_customer_name.Name = "Lbl_customer_name";
            this.Lbl_customer_name.Size = new System.Drawing.Size(88, 13);
            this.Lbl_customer_name.TabIndex = 1;
            this.Lbl_customer_name.Text = "Customer Name: ";
            // 
            // Lbl_rent_item
            // 
            this.Lbl_rent_item.AutoSize = true;
            this.Lbl_rent_item.Location = new System.Drawing.Point(72, 108);
            this.Lbl_rent_item.Name = "Lbl_rent_item";
            this.Lbl_rent_item.Size = new System.Drawing.Size(76, 13);
            this.Lbl_rent_item.TabIndex = 3;
            this.Lbl_rent_item.Text = "Rented Items: ";
            // 
            // Lbl_fine
            // 
            this.Lbl_fine.AutoSize = true;
            this.Lbl_fine.Location = new System.Drawing.Point(311, 299);
            this.Lbl_fine.Name = "Lbl_fine";
            this.Lbl_fine.Size = new System.Drawing.Size(33, 13);
            this.Lbl_fine.TabIndex = 5;
            this.Lbl_fine.Text = "Fine: ";
            // 
            // fineT
            // 
            this.fineT.Enabled = false;
            this.fineT.Location = new System.Drawing.Point(350, 296);
            this.fineT.Name = "fineT";
            this.fineT.Size = new System.Drawing.Size(93, 20);
            this.fineT.TabIndex = 4;
            // 
            // Fine
            // 
            this.Fine.AutoSize = true;
            this.Fine.Location = new System.Drawing.Point(157, 299);
            this.Fine.Name = "Fine";
            this.Fine.Size = new System.Drawing.Size(46, 13);
            this.Fine.TabIndex = 7;
            this.Fine.Text = "Amount:";
            // 
            // AmountBox
            // 
            this.AmountBox.Enabled = false;
            this.AmountBox.Location = new System.Drawing.Point(209, 296);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(70, 20);
            this.AmountBox.TabIndex = 6;
            // 
            // Lbl_amtreturn
            // 
            this.Lbl_amtreturn.AutoSize = true;
            this.Lbl_amtreturn.Location = new System.Drawing.Point(157, 346);
            this.Lbl_amtreturn.Name = "Lbl_amtreturn";
            this.Lbl_amtreturn.Size = new System.Drawing.Size(88, 13);
            this.Lbl_amtreturn.TabIndex = 9;
            this.Lbl_amtreturn.Text = "Amount to return:";
            this.Lbl_amtreturn.Click += new System.EventHandler(this.lblAmtToReturn_Click);
            // 
            // AmtReturn
            // 
            this.AmtReturn.Enabled = false;
            this.AmtReturn.Location = new System.Drawing.Point(278, 343);
            this.AmtReturn.Name = "AmtReturn";
            this.AmtReturn.Size = new System.Drawing.Size(109, 20);
            this.AmtReturn.TabIndex = 8;
            // 
            // Lbl_totalAmount
            // 
            this.Lbl_totalAmount.AutoSize = true;
            this.Lbl_totalAmount.Location = new System.Drawing.Point(157, 389);
            this.Lbl_totalAmount.Name = "Lbl_totalAmount";
            this.Lbl_totalAmount.Size = new System.Drawing.Size(72, 13);
            this.Lbl_totalAmount.TabIndex = 11;
            this.Lbl_totalAmount.Text = "Total amount:";
            // 
            // TotalAmount
            // 
            this.TotalAmount.Enabled = false;
            this.TotalAmount.Location = new System.Drawing.Point(278, 386);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(109, 20);
            this.TotalAmount.TabIndex = 10;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(458, 378);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "<<- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fundRecords
            // 
            this.fundRecords.Location = new System.Drawing.Point(331, 52);
            this.fundRecords.Name = "fundRecords";
            this.fundRecords.Size = new System.Drawing.Size(75, 23);
            this.fundRecords.TabIndex = 14;
            this.fundRecords.Text = "Find Record";
            this.fundRecords.UseVisualStyleBackColor = true;
            this.fundRecords.Click += new System.EventHandler(this.fundRecords_Click);
            // 
            // grid_selected_item
            // 
            this.grid_selected_item.AllowUserToAddRows = false;
            this.grid_selected_item.AllowUserToDeleteRows = false;
            this.grid_selected_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_selected_item.Location = new System.Drawing.Point(98, 124);
            this.grid_selected_item.Name = "grid_selected_item";
            this.grid_selected_item.ReadOnly = true;
            this.grid_selected_item.Size = new System.Drawing.Size(435, 150);
            this.grid_selected_item.TabIndex = 15;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 431);
            this.Controls.Add(this.grid_selected_item);
            this.Controls.Add(this.fundRecords);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.Lbl_totalAmount);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.Lbl_amtreturn);
            this.Controls.Add(this.AmtReturn);
            this.Controls.Add(this.Fine);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.Lbl_fine);
            this.Controls.Add(this.fineT);
            this.Controls.Add(this.Lbl_rent_item);
            this.Controls.Add(this.Lbl_customer_name);
            this.Controls.Add(this.customer_name);
            this.Name = "Form8";
            this.Text = "Return Furnitures";
            this.Load += new System.EventHandler(this.frmReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_selected_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label Lbl_customer_name;
        private System.Windows.Forms.Label Lbl_rent_item;
        private System.Windows.Forms.Label Lbl_fine;
        private System.Windows.Forms.TextBox fineT;
        private System.Windows.Forms.Label Fine;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.Label Lbl_amtreturn;
        private System.Windows.Forms.TextBox AmtReturn;
        private System.Windows.Forms.Label Lbl_totalAmount;
        private System.Windows.Forms.TextBox TotalAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button fundRecords;
        private System.Windows.Forms.DataGridView grid_selected_item;
    }
}