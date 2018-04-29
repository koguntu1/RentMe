using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe.Views
{
    public partial class FurnitureAvailabilityReportView : Form
    {
        public FurnitureAvailabilityReportView()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FurnitureAvailabilityReportView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentMeDataSet.FurnitureReport' table. You can move, or remove it, as needed.
           this.furnitureReportTableAdapter.Fill(this.rentMeDataSet.FurnitureReport);





            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
