using System;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    public partial class Form6 : Form
    {
        ViewTables view = new ViewTables();
        MainMenu mainMenu = new MainMenu();

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.vendorViewTableAdapter.Fill(this.homeApllianceWarehouseDataSet.vendorView);

            view.itemsFound = 0;
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.InitializeMainMenu(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            view.Searching(vendorViewDataGridView, searchTextBox);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            view.ClearAll(vendorViewDataGridView, vendorViewBindingSource, searchTextBox);
        }
    }
}
