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
    public partial class CustomerRegistrationView : Form
    {
        public CustomerRegistrationView()
        {
            InitializeComponent();
            
            
        }

        private void CustomerRegistrationView_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            // TODO: This line of code loads data into the 'rentMeDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.rentMeDataSet.States);
            // TODO: This line of code loads data into the 'rentMeDataSet.Streets' table. You can move, or remove it, as needed.
            this.streetsTableAdapter.Fill(this.rentMeDataSet.Streets);
            fillLabel();
            cboState.SelectedIndex = 0;

        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillLabel();
        }

        private void fillLabel()
        {
            string stateName = cboState.SelectedValue as string;

            if (stateName != null)
            {
                label1.Text = stateName;
            }
            
        }
    }
}
