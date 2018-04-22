using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Controller;
using RentMe.Models;

namespace RentMe.Views
{
    public partial class ReturnHistoryView : Form
    {
        EmployeeController employeeController;
        MemberController memberController;
        private List<Employee> employeeList;
        private List<Member> memberList;
        DataSet dt;

        public ReturnHistoryView()
        {
            InitializeComponent();
            employeeController = new EmployeeController();
            memberController = new MemberController();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                employeeList = employeeController.GetemployeeList();
                cboEmployeeID.DataSource = employeeList;
                cboEmployeeID.DisplayMember = "fullname";
                cboEmployeeID.ValueMember = "employeeID";
                cboEmployeeID.SelectedValue = -1;

                memberList = memberController.GetMemberList();
                cboMemberID.DataSource = memberList;
                cboMemberID.DisplayMember = "fullname";
                cboMemberID.ValueMember = "memberID";
                cboMemberID.SelectedValue = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisableControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = false;
                }

                if (ctrl is Button)
                {
                    ((Button)ctrl).Enabled = false;
                }

                if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Enabled = true;
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DisableControls();
            btnSearch.Enabled = true;
            cboEmployeeID.Enabled = true;
            cboMemberID.Enabled = true;
            btnExit.Enabled = true;
            dataGridViewReturnItem.DataSource = null;
            dataGridViewReturnItem.Rows.Clear();
            dataGridViewReturnItem.Refresh();
            if (dt != null)
            {
                dt.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dt != null)
            {
                dt.Clear();
            }
            DateTime fromDate = tpFromDate.Value;
            DateTime toDate = dtToDate.Value;
            if (fromDate > toDate)
            {
                MessageBox.Show("From Date must be smaller than To Date.", "Invalid Input");
            }
            else
            {
                try
                {
                    dt = RentalController.GetReturnHistory((int)cboEmployeeID.SelectedValue, (int)cboMemberID.SelectedValue, fromDate, toDate);
                    dataGridViewReturnItem.DataSource = dt;
                    dataGridViewReturnItem.DataMember = "ReturnHistory";
                    //hiden some columns
                    dataGridViewReturnItem.Columns[4].Visible = false;
                    dataGridViewReturnItem.Columns[11].Visible = false;
                    //dataGridViewReturnItem.Columns[9].Visible = false;
                    dataGridViewReturnItem.Columns[12].DefaultCellStyle.Format = "C";
                    DisableControls();
                    btnExit.Enabled = true;
                    btnRestart.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }
        }

        private void ReturnHistoryView_Load(object sender, EventArgs e)
        {
            DisableControls();
            btnSearch.Enabled = true;
            cboEmployeeID.Enabled = true;
            cboMemberID.Enabled = true;
            btnExit.Enabled = true;
        }
    }
}
