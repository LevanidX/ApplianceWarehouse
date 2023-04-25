using System;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    public partial class Form4 : Form
    {
        EditTables edit = new EditTables();
        RestrictionsForKeyPress restrictions = new RestrictionsForKeyPress();
        MainMenu mainMenu = new MainMenu();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.applianceTypeTableAdapter.Fill(this.homeApllianceWarehouseDataSet.applianceType);
            this.applianceTableAdapter.Fill(this.homeApllianceWarehouseDataSet.appliance);

            edit.isSaved = true;
            edit.isAdding = false;
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.ExitToMainMenu(this, applianceBindingSource, tableAdapterManager, homeApllianceWarehouseDataSet);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            applianceBindingSource.AddNew();
            edit.isSaved = false;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            applianceBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            applianceBindingSource.MoveLast();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            applianceBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            applianceBindingSource.MoveNext();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            edit.DeleteItem(applianceBindingSource);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!edit.isAdding)
            {
                edit.SaveEditings(this, applianceBindingSource, tableAdapterManager, homeApllianceWarehouseDataSet);
            }
        }

        private void MyUpdate_Tick(object sender, EventArgs e)
        {
            CheckAdding();

            edit.LockingAndUnlockingButtons(btnAddNew, btnLast, btnFirst, btnBack, btnNext,
                btnSave, btnExitToMainMenu, btnDelete);
        }

        private void appTypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            restrictions.RestrictAnything(e);
        }

        private void appWholesalePriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            restrictions.RestrictSymbols(e);
        }

        private void appRetailPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            restrictions.RestrictSymbols(e);
        }

        private void CheckAdding()
        {
            if (appTypeComboBox.Text == "" || appNameTextBox.Text == "" || appWholesalePriceTextBox.Text == "" || appRetailPriceTextBox.Text == "")
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
