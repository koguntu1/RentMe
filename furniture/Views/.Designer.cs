namespace furniture
{
    partial class seach_customer
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
            this.LblSearch_customer = new System.Windows.Forms.Label();
            this.Lbl_searchByPhone = new System.Windows.Forms.Label();
            this.Lbl_byName = new System.Windows.Forms.Label();
            this.Lbl_or = new System.Windows.Forms.Label();
            this.by_phone = new System.Windows.Forms.TextBox();
            this.by_name = new System.Windows.Forms.TextBox();
            this.Out_customer = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.GO_button = new System.Windows.Forms.Button();
            this.btnlAddCustomer = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSearch_customer
            // 
            this.LblSearch_customer.AutoSize = true;
            this.LblSearch_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch_customer.Location = new System.Drawing.Point(174, 102);
            this.LblSearch_customer.Name = "LblSearch_customer";
            this.LblSearch_customer.Size = new System.Drawing.Size(118, 16);
            this.LblSearch_customer.TabIndex = 0;
            this.LblSearch_customer.Text = "Search customer...";
            // 
            // Lbl_searchByPhone
            // 
            this.Lbl_searchByPhone.AutoSize = true;
            this.Lbl_searchByPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_searchByPhone.Location = new System.Drawing.Point(174, 153);
            this.Lbl_searchByPhone.Name = "Lbl_searchByPhone";
            this.Lbl_searchByPhone.Size = new System.Drawing.Size(115, 16);
            this.Lbl_searchByPhone.TabIndex = 1;
            this.Lbl_searchByPhone.Text = "By Phone Numer: ";
            this.Lbl_searchByPhone.Click += new System.EventHandler(this.Lbl_searchByPhone_Click);
            // 
            // Lbl_byName
            // 
            this.Lbl_byName.AutoSize = true;
            this.Lbl_byName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_byName.Location = new System.Drawing.Point(174, 224);
            this.Lbl_byName.Name = "Lbl_byName";
            this.Lbl_byName.Size = new System.Drawing.Size(70, 16);
            this.Lbl_byName.TabIndex = 2;
            this.Lbl_byName.Text = "By Name :";
            this.Lbl_byName.Click += new System.EventHandler(this.Lbl_byName_Click);
            // 
            // Lbl_or
            // 
            this.Lbl_or.AutoSize = true;
            this.Lbl_or.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_or.Location = new System.Drawing.Point(374, 192);
            this.Lbl_or.Name = "Lbl_or";
            this.Lbl_or.Size = new System.Drawing.Size(28, 16);
            this.Lbl_or.TabIndex = 3;
            this.Lbl_or.Text = "OR";
            // 
            // by_phone
            // 
            this.by_phone.Location = new System.Drawing.Point(300, 153);
            this.by_phone.Name = "by_phone";
            this.by_phone.Size = new System.Drawing.Size(172, 20);
            this.by_phone.TabIndex = 4;
            this.by_phone.TextChanged += new System.EventHandler(this.Txt_byPhone);
            // 
            // by_name
            // 
            this.by_name.Location = new System.Drawing.Point(300, 224);
            this.by_name.Name = "by_name";
            this.by_name.Size = new System.Drawing.Size(172, 20);
            this.by_name.TabIndex = 5;
            this.by_name.TextChanged += new System.EventHandler(this.Txt_byName);
            // 
            // Out_customer
            // 
            this.Out_customer.AutoSize = true;
            this.Out_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Out_customer.Location = new System.Drawing.Point(320, 331);
            this.Out_customer.Name = "Out_customer";
            this.Out_customer.Size = new System.Drawing.Size(171, 16);
            this.Out_customer.TabIndex = 7;
            this.Out_customer.Text = "Customer found will be here";
            this.Out_customer.Visible = false;
            this.Out_customer.Click += new System.EventHandler(this.Out_customer_Click);
            // 
            // search_button
            // 
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(346, 267);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 8;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_button.Location = new System.Drawing.Point(534, 331);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(75, 23);
            this.Edit_button.TabIndex = 9;
            this.Edit_button.Text = "Edit details";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Visible = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // GO_button
            // 
            this.GO_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GO_button.Location = new System.Drawing.Point(534, 360);
            this.GO_button.Name = "GO_button";
            this.GO_button.Size = new System.Drawing.Size(75, 23);
            this.GO_button.TabIndex = 10;
            this.GO_button.Text = "Rent Furniture";
            this.GO_button.UseVisualStyleBackColor = true;
            this.GO_button.Visible = false;
            this.GO_button.Click += new System.EventHandler(this.GO_button_Click);
            // 
            // btnlAddCustomer
            // 
            this.btnlAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlAddCustomer.Location = new System.Drawing.Point(332, 94);
            this.btnlAddCustomer.Name = "btnlAddCustomer";
            this.btnlAddCustomer.Size = new System.Drawing.Size(110, 23);
            this.btnlAddCustomer.TabIndex = 11;
            this.btnlAddCustomer.Text = "Add New Customer";
            this.btnlAddCustomer.UseVisualStyleBackColor = true;
            this.btnlAddCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(534, 54);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 12;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(390, 360);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(115, 23);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return Furnitures";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturnFurniture_Click);
            // 
            // seach_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 411);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnlAddCustomer);
            this.Controls.Add(this.GO_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.Out_customer);
            this.Controls.Add(this.by_name);
            this.Controls.Add(this.by_phone);
            this.Controls.Add(this.Lbl_or);
            this.Controls.Add(this.Lbl_byName);
            this.Controls.Add(this.Lbl_searchByPhone);
            this.Controls.Add(this.LblSearch_customer);
            this.Name = "seach_customer";
            this.Text = "Search Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSearch_customer;
        private System.Windows.Forms.Label Lbl_searchByPhone;
        private System.Windows.Forms.Label Lbl_byName;
        private System.Windows.Forms.Label Lbl_or;
        private System.Windows.Forms.TextBox by_phone;
        private System.Windows.Forms.TextBox by_name;
        private System.Windows.Forms.Label Out_customer;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button GO_button;
        private System.Windows.Forms.Button btnlAddCustomer;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnReturn;
    }
}