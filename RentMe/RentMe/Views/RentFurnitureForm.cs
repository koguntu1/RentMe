using RentMe.Controller;
using RentMe.Models;
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
    public partial class RentFurnitureForm : Form
    {

        private Member member;
        private Login login;
        private RentalItem rentalItem;
        private Furniture furniture;
        private LoginController lgnController;
        private Employee employee;
        private EmployeeController empController;
        private MemberController memController;
        private RentalItemController rentalItemController;
        private RentalTransactionController rentalTransactionController;
        private MDIView mdiView;
        public RentFurnitureForm(Furniture furnitureSelected)
        {
            InitializeComponent();
            furniture = furnitureSelected;
            lgnController = new LoginController();
            memController = new MemberController();
            empController = new EmployeeController();
            rentalItemController = new RentalItemController();
            rentalTransactionController = new RentalTransactionController();
            mdiView = new MDIView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "")
            {
                try
                {
                    member = new Member();
                    member.fname = txtFirstName.Text;
                    member.lname = txtLastName.Text;
                    this.GetMemberByName(member.fname, member.lname);
                    this.DisplayMember();
                    btnRent.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("No member found by that name. " +
                         "Please try again.", "Member Not Found");
                }

            }
            else if (mtxtHomePhone.MaskCompleted)
            {
                try
                {
                    if (Validator.IsPhoneNumber(mtxtHomePhone))
                    {
                        member = new Member();
                        member.homePhone = mtxtHomePhone.Text.Replace(".", "").Replace("(", "").Replace("_", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                        this.GetMemberByPhone(member.homePhone);
                        this.DisplayMember();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No member found by that phone number. " +
                    "Please try again.", "Member Not Found");

                }




            }
            else
            {
                MessageBox.Show("Search criteria incomplete. " +
                       "Please try again.", "Member Not Found");
                return;
            }
        }

        private void GetMemberByName(string firstName, string lastName)
        {
            try
            {
                member = this.memController.GetMemberByName(firstName, lastName);

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
            mtxtHomePhone.Text = member.homePhone;
        }

        private void btnRestart_Click_1(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMiddleInitial.Text = "";
            mtxtHomePhone.Text = "";
            mtxtRentalDate.Text = "";
            mtxtReturnDate.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentFurnitureForm_Load(object sender, EventArgs e)
        {
            btnRent.Enabled = false;
            Form frm = MDIView.ActiveForm;
            MenuStrip ms = (MenuStrip)frm.Controls["menuStrip1"];
            ToolStripMenuItem lt = (ToolStripMenuItem)ms.Items["login"];
            String userID = lt.Text;
            login = lgnController.getLoggedInUser(userID);
            employee = empController.GetEmployeeById(login.employeeID);
            txtEmployeeFName.Text = employee.fname;
            txtEmployeeMInitial.Text = employee.middleInitial;
            txtEmployeeLastName.Text = employee.lname;
            mtxtEmployeeHomePhone.Text = employee.homePhone;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (mtxtRentalDate.MaskCompleted && mtxtReturnDate.MaskCompleted && Convert.ToDateTime(mtxtRentalDate.Text) < Convert.ToDateTime(mtxtReturnDate.Text))
            {
                RentalItem rentalItem = this.setRentalItem();
                RentalTransaction rentalTransaction = this.setTransactionInformation();
                rentalItemController.AddRentalItem(rentalItem);
                rentalTransaction.rentalTransactionID = rentalTransactionController.AddRentalTransaction(rentalTransaction);
                this.Close();
            } else if (mtxtRentalDate.MaskCompleted && mtxtReturnDate.MaskCompleted && Convert.ToDateTime(mtxtRentalDate.Text) > Convert.ToDateTime(mtxtReturnDate.Text)) {
                MessageBox.Show("Return date cannot be before rental date. ", "Invalid Information.");

            } else
            {
                MessageBox.Show("Please provide a rental and return date. ", "Incomplete Information.");
            }
            
        }

        private RentalTransaction setTransactionInformation()
        {
            RentalTransaction rentalTransaction = new RentalTransaction();
            rentalTransaction.transactionDate = DateTime.Now;
            rentalTransaction.employeeID = employee.employeeID;
            return rentalTransaction;
        }

        private RentalItem setRentalItem()
        {
            rentalItem = new RentalItem();
            rentalItem.memberID = member.memberID;
            rentalItem.expectedReturn = Convert.ToDateTime(mtxtReturnDate.Text);
            rentalItem.itemID = furniture.FurnitureID;
            rentalItem.returnDate = Convert.ToDateTime(mtxtReturnDate.Text);
            rentalItem.rentalDate = Convert.ToDateTime(mtxtRentalDate.Text);
            return rentalItem;
        }
    }
}
