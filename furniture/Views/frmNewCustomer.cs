using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furniture
{
    public partial class frmNewCustomer : Form
    {
        int page = 1;
        bool update = false;
        public frmNewCustomer(int i)
        {
            page = i;
            InitializeComponent();
        }
        public frmNewCustomer(DataSet dt)
        {
            InitializeComponent();
            TxtCustID.Text = dt.Tables[0].Rows[0][0].ToString();
            TxtFnam.Text = dt.Tables[0].Rows[0][1].ToString();
            TxtLname.Text = dt.Tables[0].Rows[0][2].ToString();
            TxtSex.Text = dt.Tables[0].Rows[0][3].ToString();
            TxtDOB.Text = dt.Tables[0].Rows[0][4].ToString();
            TxtAddress.Text = dt.Tables[0].Rows[0][5].ToString();
            TxtPhone.Text = dt.Tables[0].Rows[0][6].ToString();
            TxtSSN.Text = dt.Tables[0].Rows[0][7].ToString();
            TxtCustID.Enabled = false;
            update = true;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (update)
            {
                if (TxtCustID.Text.Length == 0 || TxtFnam.Text.Length == 0 || TxtLname.Text.Length == 0 || TxtSex.Text.Length == 0 || TxtDOB.Text.Length == 0 || TxtAddress.Text.Length == 0 || TxtPhone.Text.Length == 0 || TxtSSN.Text.Length == 0)
                {
                    MessageBox.Show("Please provide all information required !");
                }
                else
                {
                    if(new DB_Access().updateCustomer(TxtCustID.Text, TxtFnam.Text, TxtLname.Text, TxtSex.Text, TxtDOB.Text, TxtAddress.Text, TxtPhone.Text, TxtSSN.Text))
                    MessageBox.Show("Details are updated");
                }
            }else
            {
                if (TxtCustID.Text.Length == 0 || TxtFnam.Text.Length == 0 || TxtLname.Text.Length == 0 || TxtSex.Text.Length == 0 || TxtDOB.Text.Length == 0 || TxtAddress.Text.Length == 0 || TxtPhone.Text.Length == 0 || TxtSSN.Text.Length == 0) {
                    MessageBox.Show("Please provide all information required !");
                }
                else
                {
                    if(new DB_Access().addCustomer(TxtCustID.Text, TxtFnam.Text, TxtLname.Text, TxtSex.Text, TxtDOB.Text, TxtAddress.Text, TxtPhone.Text, TxtSSN.Text))
                    MessageBox.Show("Customer Successfully added");
                    TxtCustID.Text = "";
                    TxtFnam.Text = "";
                    TxtLname.Text = "";
                    TxtSex.Text = "";
                    TxtDOB.Text = "";
                    TxtAddress.Text = "";
                    TxtPhone.Text = "";
                    TxtSSN.Text = "";
                    


                }

            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            if (page== 1) { 
            this.Visible = false;
            new seach_customer().Visible = true;
            }
            else
            {
                this.Visible = false;
                new frmAdminControl().Visible = true;

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
