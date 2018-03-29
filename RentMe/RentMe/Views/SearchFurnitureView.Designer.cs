namespace RentMe.Views
{
    partial class SearchFurnitureView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label furnitureDescrptionLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label styleLabel;
            System.Windows.Forms.Label dailyRateLabel;
            System.Windows.Forms.Label fineRateLabel;
            this.rentMeDataSet = new RentMe.RentMeDataSet();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureTableAdapter = new RentMe.RentMeDataSetTableAdapters.FurnitureTableAdapter();
            this.tableAdapterManager = new RentMe.RentMeDataSetTableAdapters.TableAdapterManager();
            this.furnitureDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnitureDetailsTableAdapter = new RentMe.RentMeDataSetTableAdapters.FurnitureDetailsTableAdapter();
            this.furnitureDescrptionTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.styleTextBox = new System.Windows.Forms.TextBox();
            this.dailyRateTextBox = new System.Windows.Forms.TextBox();
            this.fineRateTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            furnitureDescrptionLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            styleLabel = new System.Windows.Forms.Label();
            dailyRateLabel = new System.Windows.Forms.Label();
            fineRateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rentMeDataSet
            // 
            this.rentMeDataSet.DataSetName = "RentMeDataSet";
            this.rentMeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataMember = "Furniture";
            this.furnitureBindingSource.DataSource = this.rentMeDataSet;
            // 
            // furnitureTableAdapter
            // 
            this.furnitureTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FurnitureTableAdapter = this.furnitureTableAdapter;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.Rental_return_transactionTableAdapter = null;
            this.tableAdapterManager.Rental_transactionTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.Store_itemTableAdapter = null;
            this.tableAdapterManager.StreetsTableAdapter = null;
            this.tableAdapterManager.StyleTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentMe.RentMeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // furnitureDetailsBindingSource
            // 
            this.furnitureDetailsBindingSource.DataMember = "FurnitureDetails";
            this.furnitureDetailsBindingSource.DataSource = this.rentMeDataSet;
            // 
            // furnitureDetailsTableAdapter
            // 
            this.furnitureDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // furnitureDescrptionLabel
            // 
            furnitureDescrptionLabel.AutoSize = true;
            furnitureDescrptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            furnitureDescrptionLabel.Location = new System.Drawing.Point(47, 135);
            furnitureDescrptionLabel.Name = "furnitureDescrptionLabel";
            furnitureDescrptionLabel.Size = new System.Drawing.Size(86, 19);
            furnitureDescrptionLabel.TabIndex = 0;
            furnitureDescrptionLabel.Text = "Descrption:";
            // 
            // furnitureDescrptionTextBox
            // 
            this.furnitureDescrptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureDetailsBindingSource, "furnitureDescrption", true));
            this.furnitureDescrptionTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureDescrptionTextBox.Location = new System.Drawing.Point(139, 135);
            this.furnitureDescrptionTextBox.Multiline = true;
            this.furnitureDescrptionTextBox.Name = "furnitureDescrptionTextBox";
            this.furnitureDescrptionTextBox.Size = new System.Drawing.Size(332, 70);
            this.furnitureDescrptionTextBox.TabIndex = 1;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(47, 269);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(74, 19);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureDetailsBindingSource, "category", true));
            this.categoryTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTextBox.Location = new System.Drawing.Point(139, 269);
            this.categoryTextBox.Multiline = true;
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(332, 55);
            this.categoryTextBox.TabIndex = 3;
            // 
            // styleLabel
            // 
            styleLabel.AutoSize = true;
            styleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleLabel.Location = new System.Drawing.Point(47, 330);
            styleLabel.Name = "styleLabel";
            styleLabel.Size = new System.Drawing.Size(47, 19);
            styleLabel.TabIndex = 4;
            styleLabel.Text = "Style:";
            // 
            // styleTextBox
            // 
            this.styleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureDetailsBindingSource, "style", true));
            this.styleTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleTextBox.Location = new System.Drawing.Point(139, 330);
            this.styleTextBox.Multiline = true;
            this.styleTextBox.Name = "styleTextBox";
            this.styleTextBox.Size = new System.Drawing.Size(332, 54);
            this.styleTextBox.TabIndex = 5;
            // 
            // dailyRateLabel
            // 
            dailyRateLabel.AutoSize = true;
            dailyRateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dailyRateLabel.Location = new System.Drawing.Point(47, 222);
            dailyRateLabel.Name = "dailyRateLabel";
            dailyRateLabel.Size = new System.Drawing.Size(130, 19);
            dailyRateLabel.TabIndex = 6;
            dailyRateLabel.Text = "Daily Rental Rate:";
            // 
            // dailyRateTextBox
            // 
            this.dailyRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureDetailsBindingSource, "dailyRate", true));
            this.dailyRateTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyRateTextBox.Location = new System.Drawing.Point(179, 219);
            this.dailyRateTextBox.Name = "dailyRateTextBox";
            this.dailyRateTextBox.Size = new System.Drawing.Size(72, 27);
            this.dailyRateTextBox.TabIndex = 7;
            // 
            // fineRateLabel
            // 
            fineRateLabel.AutoSize = true;
            fineRateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fineRateLabel.Location = new System.Drawing.Point(267, 227);
            fineRateLabel.Name = "fineRateLabel";
            fineRateLabel.Size = new System.Drawing.Size(109, 19);
            fineRateLabel.TabIndex = 8;
            fineRateLabel.Text = "Late Fine Rate:";
            // 
            // fineRateTextBox
            // 
            this.fineRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureDetailsBindingSource, "fineRate", true));
            this.fineRateTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineRateTextBox.Location = new System.Drawing.Point(399, 224);
            this.fineRateTextBox.Name = "fineRateTextBox";
            this.fineRateTextBox.Size = new System.Drawing.Size(72, 27);
            this.fineRateTextBox.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(179, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // SearchFurnitureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(furnitureDescrptionLabel);
            this.Controls.Add(this.furnitureDescrptionTextBox);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(styleLabel);
            this.Controls.Add(this.styleTextBox);
            this.Controls.Add(dailyRateLabel);
            this.Controls.Add(this.dailyRateTextBox);
            this.Controls.Add(fineRateLabel);
            this.Controls.Add(this.fineRateTextBox);
            this.Name = "SearchFurnitureView";
            this.Text = "SearchFurnitureView";
            this.Load += new System.EventHandler(this.SearchFurnitureView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RentMeDataSet rentMeDataSet;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private RentMeDataSetTableAdapters.FurnitureTableAdapter furnitureTableAdapter;
        private RentMeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource furnitureDetailsBindingSource;
        private RentMeDataSetTableAdapters.FurnitureDetailsTableAdapter furnitureDetailsTableAdapter;
        private System.Windows.Forms.TextBox furnitureDescrptionTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox styleTextBox;
        private System.Windows.Forms.TextBox dailyRateTextBox;
        private System.Windows.Forms.TextBox fineRateTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}