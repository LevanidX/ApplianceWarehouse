using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    public partial class Form8 : Form
    {
        ViewTables view = new ViewTables();
        MainMenu mainMenu = new MainMenu();

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.applianceTypeTableAdapter.Fill(this.homeApllianceWarehouseDataSet.applianceType);
            this.applianceViewTableAdapter.Fill(this.homeApllianceWarehouseDataSet.applianceView);
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu.InitializeMainMenu(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            view.Searching(applianceViewDataGridView, searchTextBox);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            view.ClearAll(applianceViewDataGridView, applianceViewBindingSource, searchTextBox);
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            view.Filtering(applianceViewBindingSource, appTypeComboBox, "Тип бытовой техники");
        }
    }
}
