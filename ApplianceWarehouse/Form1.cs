using System;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    public partial class Form1 : Form
    {
        MainMenu mainMenu = new MainMenu();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVendorsEdit_Click(object sender, EventArgs e)
        {
            mainMenu.InitializeNewWindow(this, new Form2());
        }

        private void btnApplianceTypeEdit_Click(object sender, EventArgs e)
        {
            mainMenu.InitializeNewWindow(this, new Form3());
        }

        private void btnApplianceEdit_Click(object sender, EventArgs e)
        {
            mainMenu.InitializeNewWindow(this, new Form4());
        }

        private void btnDeliveriesEdit_Click(object sender, EventArgs e)
        {
            mainMenu.InitializeNewWindow(this, new Form5());
        }

        private void btnVendorsView_Click(object sender, EventArgs e)
        {
            mainMenu.InitializeNewWindow(this, new Form6());
        }

        private void btnApplianceTypeView_Click(object sender, EventArgs e)
        {
            mainMenu.InitializeNewWindow(this, new Form7());
        }

        private void btnApplianceView_Click(object sender, EventArgs e)
        {
            mainMenu.InitializeNewWindow(this, new Form8());
        }

        private void btnDeliveriesView_Click(object sender, EventArgs e)
        {
           mainMenu.InitializeNewWindow(this, new Form9());
        }
    }
}
