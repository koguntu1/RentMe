﻿using RentMe.Models;
using RentMe.Controller;
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
    public partial class CustomerView : Form
    {
        private Member member;
        private MemberController memController;
        MenuView menuScreen = new MenuView();
        public CustomerView()
        {
            InitializeComponent();


        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentMeDataSet.Gender' table. You can move, or remove it, as needed.
            //this.genderTableAdapter.Fill(this.rentMeDataSet.Gender);
            lblStateInfo.Text = "";
            // TODO: This line of code loads data into the 'rentMeDataSet.States' table. You can move, or remove it, as needed.
            //this.statesTableAdapter.Fill(this.rentMeDataSet.States);
            // TODO: This line of code loads data into the 'rentMeDataSet.Streets' table. You can move, or remove it, as needed.
            //this.streetsTableAdapter.Fill(this.rentMeDataSet.Streets);
            cboState.SelectedIndex = -1;
            cboStreetType.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
            DisableControls();
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            mtxtHomePhone.Enabled = true;
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            btnExit.Enabled = true;


            // Add corrected code for user that is logged into system
            //lblUser.Text = fname + " " + middleinitial + ". " + lname;

        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayState();
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

        private void displayStreet()
        {
            if (cboStreetType.SelectedIndex == -1)
            {
                lblStreetInfo.Text = "";
            }
            else
            {
                DataRowView drv = (DataRowView)cboStreetType.SelectedItem;
                string streetType = drv["name"].ToString();

                if (streetType != null)
                {
                    lblStreetInfo.Text = streetType;
                }
                else
                {
                    lblStreetInfo.Text = "";
                }
            }
        }

        private void cboStreetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayStreet();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayGender();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisableControls();
            btnAdd.Enabled = true;
            btnExit.Enabled = true;
            btnSearch.Enabled = true;
            btnRestart.Enabled = true;
            btnAdd.Text = "Update";
            btnSearch.Text = "Search Again";
            if (Validator.IsPresent(txtFirstName) && Validator.IsPresent(txtLastName))
            {
                try
                {
                    member.fname = txtFirstName.Text;
                    member.lname = txtLastName.Text;
                    this.GetMemberByName(member.fname, member.lname);
                    this.DisplayMember();
                } catch (Exception)
                {
                    MessageBox.Show("No member found by that name. " +
                        "Please try again.", "Member Not Found");
                }

            }
            else if (Validator.IsPresent(mtxtHomePhone) && Validator.IsPhoneNumber(mtxtHomePhone))
            {
                try
                {
                    member.homePhone = mtxtHomePhone.Text;
                    this.GetMemberByPhone(member.homePhone);
                    this.DisplayMember();
                } catch (Exception)
                {
                    MessageBox.Show("No member found by that phone number. " +
                    "Please try again.", "Member Not Found");
                }

            }
            else
            {
                MessageBox.Show("No search criteria entered. " +
                       "Please try again.", "Member Not Found");
                return;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableControls();
            btnAdd.Enabled = false;
            btnSearch.Enabled = false;
            btnRestart.Enabled = true;
        }

        private void EnableControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = true;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = true;
                }

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = true;
                }

                if (ctrl is Button)
                {
                    ((Button)ctrl).Enabled = true;
                }
            }
        }

        private void DisableControls()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Enabled = false;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Enabled = false;
                }

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)ctrl).Enabled = false;
                }

                if (ctrl is Button)
                {
                    ((Button)ctrl).Enabled = false;
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DisableControls();
            txtFirstName.Enabled = true;
            txtFirstName.Text = "";
            txtLastName.Enabled = true;
            txtLastName.Text = "";
            mtxtHomePhone.Enabled = true;
            mtxtHomePhone.Text = "";
            btnSearch.Enabled = true;
            btnAdd.Enabled = true;
            btnAdd.Text = "Add";
            btnExit.Enabled = true;
            cboStreetType.SelectedIndex = -1;
            cboState.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
            lblStreetType.Text = "";
            lblState.Text = "";
            lblGender.Text = "";
        }
        private void GetMemberByName(string firstName, string lastName)
        {
            try
            {
                member = this.memController.GetMemberByName(firstName, lastName);
                if (member == null)
                    MessageBox.Show("No member found with this name. " +
                        "Please try again.", "Member Not Found");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetMemberByPhone(string phoneNumber)
        {
            try
            {
                member = this.memController.GetMemberByPhone(phoneNumber);
                if (member == null)
                    MessageBox.Show("No member found with this phone number. " +
                        "Please try again.", "Member Not Found");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayMember()
        {
            txtFirstName.Text = member.fname;
            txtMiddleInitial.Text = member.middleInitial;
            txtLastName.Text = member.lname;
            //mtxtStreetNumber.Text = member.streetNumber;
            //txtStreetName.Text = member.streetName;
            txtCity.Text = member.City;
            cboState.Text = member.State;
            mtxtZipCode.Text = member.PostalCode;
            mtxtHomePhone.Text = member.homePhone;
            mtxtDOB.Text = member.dateOfBirth.ToString();
            cboGender.Text = member.gender;
        }
    }
}



