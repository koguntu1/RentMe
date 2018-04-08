namespace RentMe.Views
{
    partial class AddItemView
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
            System.Windows.Forms.Label lblFurnitureID;
            this.cboFurnitureID = new System.Windows.Forms.ComboBox();
            this.lblFurnitureInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            lblFurnitureID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFurnitureID
            // 
            this.cboFurnitureID.AllowDrop = true;
            this.cboFurnitureID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFurnitureID.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboFurnitureID.FormattingEnabled = true;
            this.cboFurnitureID.Location = new System.Drawing.Point(125, 120);
            this.cboFurnitureID.Name = "cboFurnitureID";
            this.cboFurnitureID.Size = new System.Drawing.Size(299, 27);
            this.cboFurnitureID.TabIndex = 54;
            this.cboFurnitureID.Tag = "Furniture";
            this.cboFurnitureID.ValueMember = "furnitureID";
            // 
            // lblFurnitureID
            // 
            lblFurnitureID.AutoSize = true;
            lblFurnitureID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            lblFurnitureID.Location = new System.Drawing.Point(35, 123);
            lblFurnitureID.Name = "lblFurnitureID";
            lblFurnitureID.Size = new System.Drawing.Size(77, 19);
            lblFurnitureID.TabIndex = 57;
            lblFurnitureID.Text = "Furniture:";
            // 
            // lblFurnitureInfo
            // 
            this.lblFurnitureInfo.AutoSize = true;
            this.lblFurnitureInfo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurnitureInfo.Location = new System.Drawing.Point(118, 57);
            this.lblFurnitureInfo.Name = "lblFurnitureInfo";
            this.lblFurnitureInfo.Size = new System.Drawing.Size(306, 39);
            this.lblFurnitureInfo.TabIndex = 56;
            this.lblFurnitureInfo.Text = "Furniture Information";
            this.lblFurnitureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(193, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(39, 176);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(147, 31);
            this.btnSubmit.TabIndex = 80;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(333, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 79;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 245);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboFurnitureID);
            this.Controls.Add(lblFurnitureID);
            this.Controls.Add(this.lblFurnitureInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddItemView";
            this.Text = "Add Item";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFurnitureID;
        private System.Windows.Forms.Label lblFurnitureInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
    }
}