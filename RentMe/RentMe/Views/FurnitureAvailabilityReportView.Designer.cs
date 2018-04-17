namespace RentMe.Views
{
    partial class FurnitureAvailabilityReportView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.furnitureReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentMeDataSet = new RentMe.RentMeDataSet();
            this.furnitureReportTableAdapter = new RentMe.RentMeDataSetTableAdapters.FurnitureReportTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.furnitureReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "FurnitureDataSet";
            reportDataSource2.Value = this.furnitureReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RentMe.Reports.FurnitureAvailabilityReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(19, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1209, 379);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // furnitureReportBindingSource
            // 
            this.furnitureReportBindingSource.DataMember = "FurnitureReport";
            this.furnitureReportBindingSource.DataSource = this.rentMeDataSet;
            // 
            // rentMeDataSet
            // 
            this.rentMeDataSet.DataSetName = "RentMeDataSet";
            this.rentMeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furnitureReportTableAdapter
            // 
            this.furnitureReportTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(577, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 31);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FurnitureAvailabilityReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 447);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FurnitureAvailabilityReportView";
            this.Text = "FurnitureAvailabilityReportView";
            this.Load += new System.EventHandler(this.FurnitureAvailabilityReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.furnitureReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentMeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RentMeDataSet rentMeDataSet;
        private System.Windows.Forms.BindingSource furnitureReportBindingSource;
        private RentMeDataSetTableAdapters.FurnitureReportTableAdapter furnitureReportTableAdapter;
        private System.Windows.Forms.Button btnExit;
    }
}