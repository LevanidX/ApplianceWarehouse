using System;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    public partial class Form5 : Form
    {
        EditTables edit = new EditTables();
        RestrictionsForKeyPress restrictions = new RestrictionsForKeyPress();
        MainMenu mainMenu = new MainMenu();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.vendorsTableAdapter.Fill(this.homeApllianceWarehouseDataSet.vendors);
            this.applianceTableAdapter.Fill(this.homeApllianceWarehouseDataSet.appliance);
            this.deliveriesTableAdapter.Fill(this.homeApllianceWarehouseDataSet.deliveries);

            edit.isSaved = true;
            edit.isAdding = false;
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.ExitToMainMenu(this, deliveriesBindingSource, tableAdapterManager, homeApllianceWarehouseDataSet);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            deliveriesBindingSource.AddNew();
            edit.isSaved = false;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            deliveriesBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            deliveriesBindingSource.MoveLast();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            deliveriesBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            deliveriesBindingSource.MoveNext();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            edit.DeleteItem(deliveriesBindingSource);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!edit.isAdding)
            {
                edit.SaveEditings(this, deliveriesBindingSource, tableAdapterManager, homeApllianceWarehouseDataSet);
            }
        }

        private void MyUpdate_Tick(object sender, EventArgs e)
        {
            CheckAdding();

            edit.LockingAndUnlockingButtons(btnAddNew, btnLast, btnFirst, btnBack, btnNext,
                btnSave, btnExitToMainMenu, btnDelete);
        }

        private void delApplianceComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            restrictions.RestrictAnything(e);
        }

        private void delVendorComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            restrictions.RestrictAnything(e);
        }

        private void CheckAdding()
        {
            if (delApplianceComboBox.Text == "" || delVendorComboBox.Text == "" || delDateTextBox.Text == "")
            {
                edit.isAdding = true;
            }
            else
            {
                edit.isAdding = false;
            }
        }
    }
}
