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
    public partial class EmployeeReportView : Form
    {
        public EmployeeReportView()
        {
            InitializeComponent();
        }

        private void EmployeeReportView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentMeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.rentMeDataSet.Employee);

            this.reportViewer1.RefreshReport();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
