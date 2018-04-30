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
    public partial class CusView : Form
    {

        Member member;
        List<Member> memberList;
        MemberController memberController;
        public CusView()
        {
            InitializeComponent();
            member = new Member();
            memberController = new MemberController();
            memberList = new List<Member>();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SearchMember();
        }

        private void EmployeeView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchMember();
            }
        }

        private void SearchMember()
        {
            mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            btnRestart.Enabled = true;
            try
            {
                mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                String memberFName = txtFname.Text.ToString().ToUpper();
                String memberLName = txtLname.Text.ToString().ToUpper();
                String phoneNumber = mtxtHomePhone.Text.ToString();
                if (!memberFName.Equals("") || !mtxtHomePhone.Text.Equals("") || !memberLName.Equals(""))
                {
                    if ((!txtFname.Text.Equals("") || !txtLname.Equals("")))
                    {

                        memberList = memberController.GetMembersByName(memberFName,memberLName);
                    }

                    if (!mtxtHomePhone.Text.Equals(""))
                    {

                        memberList = memberController.GetMembersByPhone(phoneNumber);
                    }

                    DisplayEmployee();
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
                MessageBox.Show("No results found. Please try again." + ex.Message);
            }
        }

        public void refresh(String fname, String lname)
        {
            mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            btnRestart.Enabled = true;
            try
            {
                String memberFName = fname.ToUpper();
                String memberLName = lname.ToUpper();
               
                if (!memberFName.Equals("") || !memberLName.Equals(""))
                {
                    if ((!txtFname.Text.Equals("") || !txtLname.Equals("")))
                    {

                        memberList = memberController.GetMembersByName(memberFName, memberLName);
                    }

                    DisplayEmployee();
                    btnAdd.Enabled = true;
                    btnExit.Enabled = true;
                    btnSearch.Enabled = true;
                    btnRestart.Enabled = true;
                    btnSearch.Text = "Search Again";
                }
                else
                {
                    MessageBox.Show("You must enter a name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No results found. Please try again." + ex.Message);
            }
        }
        private void DisplayEmployee()
        {

            if (memberList.Count == 0)
            {
                MessageBox.Show("No results. Please search again.");
                ClearForm();
            }
            else
            {
                BindingList<Member> bindingEmployeeList = new BindingList<Member>(memberList);
                memberDataGridView.DataSource = bindingEmployeeList;
                memberDataGridView.AutoGenerateColumns = true;
                memberDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                memberDataGridView.Columns["memberID"].HeaderText = "Member ID";
                memberDataGridView.Columns["fname"].HeaderText = "First Name";
                memberDataGridView.Columns["middleInitial"].HeaderText = "MI";
                memberDataGridView.Columns["lname"].HeaderText = "Last Name";
                memberDataGridView.Columns["Address1"].HeaderText = "Address";
                memberDataGridView.Columns["Address2"].HeaderText = "Address, cont.";
                memberDataGridView.Columns["dateOfBirth"].HeaderText = "Birth Date";
                memberDataGridView.Columns["homePhone"].HeaderText = "Phone Number";
                memberDataGridView.Columns["dateOfBirth"].DefaultCellStyle.Format = "MM/dd/yyyy";
                memberDataGridView.Columns["homePhone"].DefaultCellStyle.Format = "(###) ###-####";
                memberDataGridView.Columns["gender"].HeaderText = "Gender";
                memberDataGridView.Columns["fullname"].HeaderText = "Full Name";
                editButton.HeaderText = "Edit Member";
                editButton.Text = "Edit Member";
                editButton.Name = "editButton";
                editButton.UseColumnTextForButtonValue = true;
                if (memberDataGridView.Columns["editButton"] == null)
                {
                    memberDataGridView.Columns.Insert(0, editButton);
                }
                int i = 0;
                foreach (DataGridViewColumn c in memberDataGridView.Columns)
                {
                    i += c.Width;
                }
                memberDataGridView.Width = i + memberDataGridView.RowHeadersWidth + 2;
                memberDataGridView.Focus();
                memberDataGridView.CurrentCell = memberDataGridView.Rows[0].Cells[0];
            }

        }

        private void memberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewRow row = this.memberDataGridView.Rows[e.RowIndex];
                    Member member = new Member();
                    member.memberID = Convert.ToInt32(row.Cells["memberID"].Value.ToString());
                    member.fname = row.Cells["fname"].Value.ToString();
                    member.middleInitial = row.Cells["middleInitial"].Value.ToString();
                    member.lname = row.Cells["lname"].Value.ToString();
                    member.Address1 = row.Cells["Address1"].Value.ToString();
                    member.Address2 = row.Cells["Address2"].Value.ToString();
                    member.City = row.Cells["City"].Value.ToString();
                    member.State = row.Cells["State"].Value.ToString();
                    member.PostalCode = row.Cells["PostalCode"].Value.ToString();
                    member.dateOfBirth = Convert.ToDateTime(row.Cells["dateOfBirth"].Value.ToString());
                    member.homePhone = row.Cells["homePhone"].Value.ToString();
                    member.gender = row.Cells["gender"].Value.ToString();
                    member.fullname = row.Cells["fullname"].Value.ToString();
                    AddUpdateMemberView addUpdateMemberView = new AddUpdateMemberView(true, member, this);
                    addUpdateMemberView.StartPosition = FormStartPosition.CenterScreen;
                    addUpdateMemberView.Show();
                }
            }
            catch (Exception ex)
            {
                if (ex is IndexOutOfRangeException || ex is ArgumentOutOfRangeException)
                {

                }
                else
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateMemberView addUpdateMemberView = new AddUpdateMemberView(false, null, this);
            addUpdateMemberView.StartPosition = FormStartPosition.CenterScreen;
            addUpdateMemberView.Show();
            addUpdateMemberView.Refresh();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            memberDataGridView.DataSource = null;
            memberDataGridView.Columns.Clear();
            memberDataGridView.Rows.Clear();
            memberDataGridView.Refresh();
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
