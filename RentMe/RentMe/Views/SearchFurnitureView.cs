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
    public partial class SearchFurnitureView : Form
    {
        public SearchFurnitureView()
        {
            InitializeComponent();
        }

        private void furnitureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.furnitureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentMeDataSet);

        }

        private void SearchFurnitureView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentMeDataSet.FurnitureDetails' table. You can move, or remove it, as needed.
            this.furnitureDetailsTableAdapter.Fill(this.rentMeDataSet.FurnitureDetails);
            // TODO: This line of code loads data into the 'rentMeDataSet.Furniture' table. You can move, or remove it, as needed.
            this.furnitureTableAdapter.Fill(this.rentMeDataSet.Furniture);

        }
    }
}
