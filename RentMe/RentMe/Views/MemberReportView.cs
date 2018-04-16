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
    public partial class MemberReportView : Form
    {
        public MemberReportView()
        {
            InitializeComponent();
        }

        private void MemberReportView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentMeDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.rentMeDataSet.Member);

            this.reportViewer1.RefreshReport();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
