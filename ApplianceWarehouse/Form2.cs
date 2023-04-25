using System;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    public partial class Form2 : Form
    {
        EditTables edit = new EditTables();
        RestrictionsForKeyPress restrictions = new RestrictionsForKeyPress();
        MainMenu mainMenu = new MainMenu();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.vendorsTableAdapter.Fill(this.homeApllianceWarehouseDataSet.vendors);

            edit.isSaved = true;
            edit.isAdding = false;
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.ExitToMainMenu(this, vendorsBindingSource, tableAdapterManager, homeApllianceWarehouseDataSet);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            vendorsBindingSource.AddNew();
            edit.isSaved = false;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            vendorsBindingSource.MoveLast();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            vendorsBindingSource.MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            vendorsBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            vendorsBindingSource.MoveNext();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            edit.DeleteItem(vendorsBindingSource);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!edit.isAdding)
            {
                edit.SaveEditings(this, vendorsBindingSource, tableAdapterManager, homeApllianceWarehouseDataSet);
            }
        }

        private void MyUpdate_Tick(object sender, EventArgs e)
        {
            CheckAdding();

            edit.LockingAndUnlockingButtons(btnAddNew, btnLast, btnFirst, btnBack, btnNext, 
                btnSave, btnExitToMainMenu, btnDelete);
        }

        private void CheckAdding()
        {
            if (vendorNameTextBox.Text == "" || vendorPhoneNumberTextBox.Text == "" || vendorEmailAddressTextBox.Text == "")
            {
                edit.isAdding = true;
            }
            else
            {
                edit.isAdding = false;
            }
        }

        private void vendorPhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            restrictions.RestrictSymbols(e);
        }
    }
}
