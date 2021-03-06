﻿using System;
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
        public CustomerView()
        {
            InitializeComponent();


        }

        private void CustomerRegistrationView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentMeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.rentMeDataSet.Employee);
            // TODO: This line of code loads data into the 'rentMeDataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter.Fill(this.rentMeDataSet.Gender);
            lblStateInfo.Text = "";
            // TODO: This line of code loads data into the 'rentMeDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.rentMeDataSet.States);
            // TODO: This line of code loads data into the 'rentMeDataSet.Streets' table. You can move, or remove it, as needed.
            this.streetsTableAdapter.Fill(this.rentMeDataSet.Streets);
            cboState.SelectedIndex = -1;
            cboStreetType.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
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
    }
}
