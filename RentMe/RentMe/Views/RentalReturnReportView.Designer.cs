namespace RentMe.Views
{
    partial class RentalReturnReportView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rentalReturnReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentMeDataSet = new RentMe.RentMeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rentalReturnReportTableAdapter = new RentMe.RentMeDataSetTableAdapters.RentalReturnReportTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentalReturnReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // rentalReturnReportBindingSource
            // 
            this.rentalReturnReportBindingSource.DataMember = "RentalReturnReport";
            this.rentalReturnReportBindingSource.DataSource = this.rentMeDataSet;
            // 
            // rentMeDataSet
            // 
            this.rentMeDataSet.DataSetName = "RentMeDataSet";
            this.rentMeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "RentalReturnDataSet";
            reportDataSource1.Value = this.rentalReturnReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RentMe.Reports.RentalReturnReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1209, 379);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // rentalReturnReportTableAdapter
            // 
            this.rentalReturnReportTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(542, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RentalReturnReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 447);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RentalReturnReportView";
            this.Text = "Rental Return Report";
            this.Load += new System.EventHandler(this.RentalReturnReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalReturnReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RentMeDataSet rentMeDataSet;
        private System.Windows.Forms.BindingSource rentalReturnReportBindingSource;
        private RentMeDataSetTableAdapters.RentalReturnReportTableAdapter rentalReturnReportTableAdapter;
        private System.Windows.Forms.Button btnExit;
    }
}