using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentMe.Models;
using RentMe.Controller;


namespace RentMe.Views
{
    public partial class EmployeeView : Form
    {

        Employee employee;
        List<Employee> employeeList;
        EmployeeController employeeController;
        public EmployeeView()
        {
            InitializeComponent();
            employee = new Employee();
            employeeController = new EmployeeController();
            employeeList = new List<Employee>();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SearchEmployee();
        }

        private void EmployeeView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchEmployee();
            }
        }

        private void SearchEmployee()
        {
            mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            btnRestart.Enabled = true;
            try
            {
                mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                String employeeName = ("%" + txtFname.Text.ToString().ToUpper() + "%" + txtLname.Text.ToString().ToUpper() + "%");
                String phoneNumber = ("%" + mtxtHomePhone.Text.ToString() + "%");
                if (!employeeName.Equals("%%%") || !mtxtHomePhone.Text.Equals(""))
                {
                    if ((!txtFname.Text.Equals("") || !txtLname.Equals("")))
                    {

                        employeeList = employeeController.GetEmployeeByName(employeeName);
                    }

                    if (!mtxtHomePhone.Text.Equals(""))
                    {

                        employeeList = employeeController.GetEmployeeByPhone(phoneNumber);
                    }

                    DisplayEmployee(employee);
                    btnAdd.Enabled = true;
                    btnExit.Enabled = true;
                    btnSearch.Enabled = true;
                    btnRestart.Enabled = true;
                    btnSearch.Text = "Search Again";
                }
                else
                {
                    MessageBox.Show("You must enter a name or phone number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No results found. Please try again.");
            }
        }
        private void DisplayEmployee(Employee employee)
        {

            if (employeeList.Count == 0)
            {
                MessageBox.Show("No results. Please search again.");
                ClearForm();
            }
            else
            {
                BindingList<Employee> bindingEmployeeList = new BindingList<Employee>(employeeList);
                employeeDataGridView.DataSource = bindingEmployeeList;
                employeeDataGridView.AutoGenerateColumns = true;
                employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                employeeDataGridView.Columns["password"].Visible = false;
                employeeDataGridView.Columns["password"].HeaderText = "";
                employeeDataGridView.Columns["employeeID"].HeaderText = "Employee ID";
                employeeDataGridView.Columns["fname"].HeaderText = "First Name";
                employeeDataGridView.Columns["middleInitial"].HeaderText = "MI";
                employeeDataGridView.Columns["lname"].HeaderText = "Last Name";
                employeeDataGridView.Columns["Address1"].HeaderText = "Address";
                employeeDataGridView.Columns["Address2"].HeaderText = "Address, cont.";
                employeeDataGridView.Columns["dateOfBirth"].HeaderText = "Birth Date";
                employeeDataGridView.Columns["gender"].HeaderText = "Gender";
                employeeDataGridView.Columns["admin"].HeaderText = "Admin";
                employeeDataGridView.Columns["homePhone"].HeaderText = "Phone Number";
                employeeDataGridView.Columns["login"].HeaderText = "User ID";
                employeeDataGridView.Columns["dateOfBirth"].DefaultCellStyle.Format = "MM/dd/yyyy";
                employeeDataGridView.Columns["homePhone"].DefaultCellStyle.Format = "(###) ###-####";
                editButton.HeaderText = "Edit Employee";
                editButton.Text = "Edit Employee";
                editButton.Name = "editButton";
                editButton.UseColumnTextForButtonValue = true;
                if (employeeDataGridView.Columns["editButton"] == null)
                {
                    employeeDataGridView.Columns.Insert(0, editButton);
                }
                int i = 0;
                foreach (DataGridViewColumn c in employeeDataGridView.Columns)
                {
                    i += c.Width;
                }
                employeeDataGridView.Width = i + employeeDataGridView.RowHeadersWidth + 2;
                employeeDataGridView.Focus();
                employeeDataGridView.CurrentCell = employeeDataGridView.Rows[0].Cells[0];
            }

        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewRow row = this.employeeDataGridView.Rows[e.RowIndex];
                    Employee employee = new Employee();
                    employee.employeeID = Convert.ToInt32(row.Cells["employeeID"].Value.ToString());
                    employee.fname = row.Cells["fname"].Value.ToString();
                    employee.middleInitial = row.Cells["middleInitial"].Value.ToString();
                    employee.lname = row.Cells["lname"].Value.ToString();
                    employee.Address1 = row.Cells["Address1"].Value.ToString();
                    employee.Address2 = row.Cells["Address2"].Value.ToString();
                    employee.City = row.Cells["City"].Value.ToString();
                    employee.State = row.Cells["State"].Value.ToString();
                    employee.PostalCode = row.Cells["PostalCode"].Value.ToString();
                    employee.gender = row.Cells["gender"].Value.ToString();
                    employee.admin = row.Cells["admin"].Value.ToString();
                    employee.login = row.Cells["login"].Value.ToString();
                    employee.dateOfBirth = Convert.ToDateTime(row.Cells["dateOfBirth"].Value.ToString());
                    employee.homePhone = row.Cells["homePhone"].Value.ToString();
                    AddUpdateEmployeeView addUpdateEmployeeView = new AddUpdateEmployeeView(true, employee);
                    addUpdateEmployeeView.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateEmployeeView addUpdateEmployeeView = new AddUpdateEmployeeView(false, null);
            addUpdateEmployeeView.Show();
            addUpdateEmployeeView.Refresh();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            employeeDataGridView.DataSource = null;
            employeeDataGridView.Columns.Clear();
            employeeDataGridView.Rows.Clear();
            employeeDataGridView.Refresh();
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }

                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = String.Empty;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
