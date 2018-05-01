namespace RentMe.Views
{
    partial class AddUpdateFurnitureView
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.lblFurnitureInfo = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.txtFineRate = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(65, 164);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 19);
            label1.TabIndex = 69;
            label1.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(65, 217);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 19);
            label2.TabIndex = 71;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(65, 270);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 19);
            label3.TabIndex = 72;
            label3.Text = "Style:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(65, 370);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 19);
            label4.TabIndex = 75;
            label4.Text = "Daily Rate:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(65, 322);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 19);
            label5.TabIndex = 73;
            label5.Text = "Fine Rate:";
            // 
            // cboCategory
            // 
            this.cboCategory.AllowDrop = true;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(191, 214);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(240, 27);
            this.cboCategory.TabIndex = 66;
            this.cboCategory.Tag = "Category ID";
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cboStyle
            // 
            this.cboStyle.AllowDrop = true;
            this.cboStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStyle.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(191, 267);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(240, 27);
            this.cboStyle.TabIndex = 65;
            this.cboStyle.Tag = "Style ID";
            this.cboStyle.SelectedIndexChanged += new System.EventHandler(this.cboStyle_SelectedIndexChanged);
            // 
            // lblFurnitureInfo
            // 
            this.lblFurnitureInfo.AutoSize = true;
            this.lblFurnitureInfo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurnitureInfo.Location = new System.Drawing.Point(174, 91);
            this.lblFurnitureInfo.Name = "lblFurnitureInfo";
            this.lblFurnitureInfo.Size = new System.Drawing.Size(306, 39);
            this.lblFurnitureInfo.TabIndex = 64;
            this.lblFurnitureInfo.Text = "Furniture Information";
            this.lblFurnitureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(191, 161);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(240, 27);
            this.txtDescription.TabIndex = 70;
            this.txtDescription.Tag = "Description";
            // 
            // txtDailyRate
            // 
            this.txtDailyRate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDailyRate.Location = new System.Drawing.Point(191, 367);
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.Size = new System.Drawing.Size(240, 27);
            this.txtDailyRate.TabIndex = 76;
            this.txtDailyRate.Tag = "Daily Rate";
            // 
            // txtFineRate
            // 
            this.txtFineRate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFineRate.Location = new System.Drawing.Point(191, 319);
            this.txtFineRate.Name = "txtFineRate";
            this.txtFineRate.Size = new System.Drawing.Size(240, 27);
            this.txtFineRate.TabIndex = 74;
            this.txtFineRate.Tag = "Fine Rate";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(69, 419);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(147, 31);
            this.btnSubmit.TabIndex = 78;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(359, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 77;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(247, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // AddUpdateFurnitureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 473);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDailyRate);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtFineRate);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(label1);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.lblFurnitureInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddUpdateFurnitureView";
            this.Text = "Add or Update Furniture";
            this.Load += new System.EventHandler(this.AddUpdateFurnitureView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.Label lblFurnitureInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDailyRate;
        private System.Windows.Forms.TextBox txtFineRate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
    }
}