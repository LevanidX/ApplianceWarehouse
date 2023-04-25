using System;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    public partial class Form9 : Form
    {
        ViewTables view = new ViewTables();
        MainMenu mainMenu = new MainMenu();

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeApllianceWarehouseDataSet.vendors". При необходимости она может быть перемещена или удалена.
            this.vendorsTableAdapter.Fill(this.homeApllianceWarehouseDataSet.vendors);
            this.deliveriesViewTableAdapter.Fill(this.homeApllianceWarehouseDataSet.deliveriesView);
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.InitializeMainMenu(this);
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            view.Filtering(deliveriesViewBindingSource, delVendorComboBox, "Поставщик");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            view.ClearAll(deliveriesViewDataGridView, deliveriesViewBindingSource, searchTextBox);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            view.Searching(deliveriesViewDataGridView, searchTextBox);
        }
    }
}
