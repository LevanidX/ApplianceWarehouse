using System;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    public partial class Form3 : Form
    {
        EditTables edit = new EditTables();
        MainMenu mainMenu = new MainMenu();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.applianceTypeTableAdapter.Fill(this.homeApllianceWarehouseDataSet.applianceType);

            edit.isSaved = true;
            edit.isAdding = false;
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.ExitToMainMenu(this, applianceTypeBindingSource, tableAdapterManager, homeApllianceWarehouseDataSet);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            applianceTypeBindingSource.AddNew();
            edit.isSaved = false;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            applianceTypeBindingSource.MoveLast();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            applianceTypeBindingSource.MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            applianceTypeBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            applianceTypeBindingSource.MoveNext();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            edit.DeleteItem(applianceTypeBindingSource);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!edit.isAdding)
            {
                edit.SaveEditings(this, applianceTypeBindingSource, tableAdapterManager, homeApllianceWarehouseDataSet);
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
            if (appTypeNameTextBox.Text == "")
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
