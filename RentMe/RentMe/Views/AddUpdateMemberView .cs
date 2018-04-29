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
    public partial class AddUpdateMemberView : Form
    {
        MemberController memberController;
        CusView memberview;
        Member member;
        bool update;
        public AddUpdateMemberView(bool isUpdate, Member employeeSelected, CusView parent)
        {
            InitializeComponent();
            memberController = new MemberController();
            this.memberview = parent;
            this.memberview.Enabled = false;
            member = employeeSelected;
            update = isUpdate;
        }

        private void MemberView_Load(object sender, EventArgs e)
        {
            this.statesTableAdapter.Fill(this.rentMeDataSet.States);
            this.genderTableAdapter.Fill(this.rentMeDataSet.Gender);
            this.loginTableAdapter.Fill(this.rentMeDataSet.Login);
         
            if (update)
            {
                this.Text = "Update Member";
                lblMember.Text = "Update Member Information";
               
                DisplayMember(member);
               
            }
            else
            {
                this.Text = "Add Member";
                lblMember.Text = "Add Member";
                cboState.SelectedIndex = -1;
                cboGender.SelectedIndex = -1;
                
            }

        }

        private void displayState()
        {

            if (cboState.SelectedIndex == -1)
            {
                lblStateInfo.Text = "";
            }
            else
            {
                DataRowView drv = (DataRowView)cboState.SelectedItem;
                string stateName = drv["name"].ToString() + ", " + drv["country"].ToString();

                if (stateName != null)
                {
                    lblStateInfo.Text = stateName;
                }
                else
                {
                    lblStateInfo.Text = "";
                }
            }

        }
        private void displayGender()
        {

            if (cboGender.SelectedIndex == -1)
            {
                cboGender.Text = "";
            }
            else
            {
                DataRowView drv = (DataRowView)cboGender.SelectedItem;
                string genderType = drv["description"].ToString();

                if (genderType != null)
                {
                    lblGender.Text = genderType;
                }
                else
                {
                    lblGender.Text = "";
                }
            }
        }



        private void DisplayMember(Member member)
        {
            txtFname.Text = member.fname.ToString();
            txtMI.Text = member.middleInitial.ToString();
            txtLname.Text = member.lname.ToString();
            txtAddress1.Text = member.Address1.ToString();
            txtAddress2.Text = member.Address2.ToString();
            txtCity.Text = member.City.ToString();
            cboState.SelectedValue = member.State.ToString();
            mtxtZip.Text = member.PostalCode.ToString();
            mtxtHomePhone.Text = member.homePhone.ToString();
            tpBirthDate.Text = member.dateOfBirth.ToString();
            cboGender.SelectedValue = member.gender.ToString();
        }

        private void PutEmployee(Member member)
        {
            member.fname = txtFname.Text;
            member.fname = txtFname.Text;
            member.middleInitial = txtMI.Text;
            member.lname = txtLname.Text;
            member.Address1 = txtAddress1.Text;
            member.Address2 = txtAddress2.Text;
            member.City = txtCity.Text;
            member.State = cboState.SelectedValue.ToString();
            mtxtZip.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            member.PostalCode = mtxtZip.Text;
            mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            member.homePhone = mtxtHomePhone.Text;
            member.dateOfBirth = tpBirthDate.Value;
            member.gender = cboGender.SelectedValue.ToString();
            
           
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
               
                this.Close();
               
     
        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayState();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayGender();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            mtxtZip.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtFname.Text == string.Empty)
            {
                MessageBox.Show("Please enter a first name.");
                return;
            }
            else if (txtLname.Text == string.Empty)
            {
                MessageBox.Show("Please enter a last name.");
                return;
            }

            else if (txtAddress1.Text == string.Empty)
            {
                MessageBox.Show("Please enter an address.");
                return;
            }

            else if (txtCity.Text == string.Empty)
            {
                MessageBox.Show("Please enter a city.");
                return;
            }

            else if (mtxtZip.Text == string.Empty)
            {
                MessageBox.Show("Please enter a zip code.");
                return;
            }

            else if (mtxtHomePhone.Text == string.Empty)
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

            else if (cboState.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a state.");
                return;
            }

            else if (cboGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.");
                return;
            }
            else
            {
                AddUpdateMember();
            }


            
        }

        private void AddUpdateEmployeeView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mtxtZip.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                mtxtHomePhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if (txtFname.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a first name.");
                    return;
                }
                else if (txtLname.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a last name.");
                    return;
                }

                else if (txtAddress1.Text == string.Empty)
                {
                    MessageBox.Show("Please enter an address.");
                    return;
                }

                else if (txtCity.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a city.");
                    return;
                }

                else if (mtxtZip.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a zip code.");
                    return;
                }

                else if (mtxtHomePhone.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a phone number.");
                    return;
                }

                else if (cboState.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a state.");
                    return;
                }

                else if (cboGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }
                else
                {
                    AddUpdateMember();
                }
            }
        }

      
        private void AddUpdateMember()
        {
           Member newMember = new Member();

            try
            {
                if (!update)
                {
                    this.PutEmployee(newMember);
                    int memberID = this.memberController.AddMember(newMember);
                    member = newMember;
                    member.memberID = memberID;
                    MessageBox.Show("Member successfully added");
                    btnSubmit.Text = "Update Member";
                    lblMember.Text = "Update Member Information";
                    this.Text = "Update Member";
                }

                else if (update)
                {
                    this.PutEmployee(newMember);
                    newMember.memberID = member.memberID;
                    if (!memberController.UpdateMember(member, newMember))
                    {
                        MessageBox.Show("Another user has updated or " +
                            "deleted that member.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Member " + newMember.fname + " " + newMember.lname + " updated.");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void AddUpdateMemberView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.memberview.Enabled = true;
            if (txtFname.Text != string.Empty || txtLname.Text != string.Empty)
            {
                this.memberview.refresh(member.fname, member.lname);

            }
        }
    }
}
