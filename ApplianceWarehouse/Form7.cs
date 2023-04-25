using System;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    public partial class Form7 : Form
    {
        ViewTables view = new ViewTables();
        MainMenu mainMenu = new MainMenu();

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.applianceTypeViewTableAdapter.Fill(this.homeApllianceWarehouseDataSet.applianceTypeView);

            view.itemsFound = 0;
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.InitializeMainMenu(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            view.Searching(applianceTypeViewDataGridView, searchTextBox);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            view.ClearAll(applianceTypeViewDataGridView, applianceTypeViewBindingSource, searchTextBox);
        }
    }
}
