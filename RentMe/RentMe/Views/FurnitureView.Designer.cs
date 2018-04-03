﻿namespace RentMe.Views
{
    partial class FurnitureView
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
            System.Windows.Forms.Label lblItemID;
            System.Windows.Forms.Label lblFurnitureID;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label descriptionLabel1;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFurnitureInfo = new System.Windows.Forms.Label();
            this.cboItemID = new System.Windows.Forms.ComboBox();
            this.store_itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentMeDataSet = new RentMe.RentMeDataSet();
            this.cboFurnitureID = new System.Windows.Forms.ComboBox();
            this.furnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.furnitureTableAdapter = new RentMe.RentMeDataSetTableAdapters.FurnitureTableAdapter();
            this.tableAdapterManager = new RentMe.RentMeDataSetTableAdapters.TableAdapterManager();
            this.store_itemTableAdapter = new RentMe.RentMeDataSetTableAdapters.Store_itemTableAdapter();
            this.styleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.styleTableAdapter = new RentMe.RentMeDataSetTableAdapters.StyleTableAdapter();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new RentMe.RentMeDataSetTableAdapters.CategoryTableAdapter();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lvFurniture = new System.Windows.Forms.ListView();
            this.columnFurnitureID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRentalRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFineRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lblItemID = new System.Windows.Forms.Label();
            lblFurnitureID = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            lblItemID.Location = new System.Drawing.Point(371, 113);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new System.Drawing.Size(62, 19);
            lblItemID.TabIndex = 53;
            lblItemID.Text = "Item ID:";
            // 
            // lblFurnitureID
            // 
            lblFurnitureID.AutoSize = true;
            lblFurnitureID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            lblFurnitureID.Location = new System.Drawing.Point(17, 116);
            lblFurnitureID.Name = "lblFurnitureID";
            lblFurnitureID.Size = new System.Drawing.Size(95, 19);
            lblFurnitureID.TabIndex = 51;
            lblFurnitureID.Text = "Furniture ID:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Calibri", 12F);
            descriptionLabel.Location = new System.Drawing.Point(68, 160);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(44, 19);
            descriptionLabel.TabIndex = 58;
            descriptionLabel.Text = "Style:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Font = new System.Drawing.Font("Calibri", 12F);
            descriptionLabel1.Location = new System.Drawing.Point(362, 165);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(71, 19);
            descriptionLabel1.TabIndex = 59;
            descriptionLabel1.Text = "Category:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentMe.Properties.Resources._2018_03_27_13_08_06;
            this.pictureBox1.Location = new System.Drawing.Point(246, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(256, 471);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(91, 31);
            this.btnRestart.TabIndex = 48;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(18, 471);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 31);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(137, 471);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 31);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(494, 471);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(375, 471);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 31);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblFurnitureInfo
            // 
            this.lblFurnitureInfo.AutoSize = true;
            this.lblFurnitureInfo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFurnitureInfo.Location = new System.Drawing.Point(171, 61);
            this.lblFurnitureInfo.Name = "lblFurnitureInfo";
            this.lblFurnitureInfo.Size = new System.Drawing.Size(306, 39);
            this.lblFurnitureInfo.TabIndex = 49;
            this.lblFurnitureInfo.Text = "Furniture Information";
            this.lblFurnitureInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboItemID
            // 
            this.cboItemID.AllowDrop = true;
            this.cboItemID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.store_itemBindingSource, "itemID", true));
            this.cboItemID.DataSource = this.store_itemBindingSource;
            this.cboItemID.DisplayMember = "itemID";
            this.cboItemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemID.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboItemID.FormattingEnabled = true;
            this.cboItemID.Location = new System.Drawing.Point(439, 108);
            this.cboItemID.Name = "cboItemID";
            this.cboItemID.Size = new System.Drawing.Size(121, 27);
            this.cboItemID.TabIndex = 54;
            this.cboItemID.ValueMember = "itemID";
            // 
            // store_itemBindingSource
            // 
            this.store_itemBindingSource.DataMember = "Store_item";
            this.store_itemBindingSource.DataSource = this.rentMeDataSet;
            // 
            // rentMeDataSet
            // 
            this.rentMeDataSet.DataSetName = "RentMeDataSet";
            this.rentMeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboFurnitureID
            // 
            this.cboFurnitureID.AllowDrop = true;
            this.cboFurnitureID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.furnitureBindingSource, "furnitureID", true));
            this.cboFurnitureID.DataSource = this.furnitureBindingSource;
            this.cboFurnitureID.DisplayMember = "furnitureID";
            this.cboFurnitureID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFurnitureID.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboFurnitureID.FormattingEnabled = true;
            this.cboFurnitureID.Location = new System.Drawing.Point(118, 116);
            this.cboFurnitureID.Name = "cboFurnitureID";
            this.cboFurnitureID.Size = new System.Drawing.Size(121, 27);
            this.cboFurnitureID.TabIndex = 55;
            this.cboFurnitureID.ValueMember = "furnitureID";
            // 
            // furnitureBindingSource
            // 
            this.furnitureBindingSource.DataMember = "Furniture";
            this.furnitureBindingSource.DataSource = this.rentMeDataSet;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
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
            // store_itemTableAdapter
            // 
            this.store_itemTableAdapter.ClearBeforeFill = true;
            // 
            // styleBindingSource
            // 
            this.styleBindingSource.DataMember = "Style";
            this.styleBindingSource.DataSource = this.rentMeDataSet;
            // 
            // styleTableAdapter
            // 
            this.styleTableAdapter.ClearBeforeFill = true;
            // 
            // cboStyle
            // 
            this.cboStyle.AllowDrop = true;
            this.cboStyle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.styleBindingSource, "description", true));
            this.cboStyle.DataSource = this.styleBindingSource;
            this.cboStyle.DisplayMember = "description";
            this.cboStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStyle.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(118, 165);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(121, 27);
            this.cboStyle.TabIndex = 59;
            this.cboStyle.ValueMember = "styleID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.rentMeDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // cboCategory
            // 
            this.cboCategory.AllowDrop = true;
            this.cboCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "description", true));
            this.cboCategory.DataSource = this.categoryBindingSource;
            this.cboCategory.DisplayMember = "description";
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(439, 162);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 27);
            this.cboCategory.TabIndex = 62;
            this.cboCategory.ValueMember = "categoryID";
            // 
            // lvFurniture
            // 
            this.lvFurniture.AllowDrop = true;
            this.lvFurniture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFurnitureID,
            this.columnDescription,
            this.columnItemID,
            this.columnCategory,
            this.columnStyle,
            this.columnRentalRate,
            this.columnFineRate});
            this.lvFurniture.Font = new System.Drawing.Font("Calibri", 11F);
            this.lvFurniture.Location = new System.Drawing.Point(18, 198);
            this.lvFurniture.Name = "lvFurniture";
            this.lvFurniture.Size = new System.Drawing.Size(694, 246);
            this.lvFurniture.TabIndex = 63;
            this.lvFurniture.UseCompatibleStateImageBehavior = false;
            this.lvFurniture.View = System.Windows.Forms.View.Details;
            // 
            // columnFurnitureID
            // 
            this.columnFurnitureID.Text = "FurnitureID";
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            // 
            // columnItemID
            // 
            this.columnItemID.Text = "ItemID";
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            // 
            // columnStyle
            // 
            this.columnStyle.Text = "Style";
            // 
            // columnRentalRate
            // 
            this.columnRentalRate.Text = "Daily Rate";
            // 
            // columnFineRate
            // 
            this.columnFineRate.Text = "Daily Late Fee";
            // 
            // FurnitureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 531);
            this.Controls.Add(this.lvFurniture);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(descriptionLabel1);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.cboFurnitureID);
            this.Controls.Add(lblItemID);
            this.Controls.Add(this.cboItemID);
            this.Controls.Add(lblFurnitureID);
            this.Controls.Add(this.lblFurnitureInfo);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FurnitureView";
            this.Text = "SearchFurnitureView";
            this.Load += new System.EventHandler(this.SearchFurnitureView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.store_itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RentMeDataSet rentMeDataSet;
        private System.Windows.Forms.BindingSource furnitureBindingSource;
        private RentMeDataSetTableAdapters.FurnitureTableAdapter furnitureTableAdapter;
        private RentMeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblFurnitureInfo;
        private System.Windows.Forms.BindingSource store_itemBindingSource;
        private RentMeDataSetTableAdapters.Store_itemTableAdapter store_itemTableAdapter;
        private System.Windows.Forms.ComboBox cboItemID;
        private System.Windows.Forms.ComboBox cboFurnitureID;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.BindingSource styleBindingSource;
        private RentMeDataSetTableAdapters.StyleTableAdapter styleTableAdapter;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private RentMeDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ListView lvFurniture;
        private System.Windows.Forms.ColumnHeader columnFurnitureID;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader columnStyle;
        private System.Windows.Forms.ColumnHeader columnRentalRate;
        private System.Windows.Forms.ColumnHeader columnFineRate;
        private System.Windows.Forms.ColumnHeader columnItemID;
    }
}
