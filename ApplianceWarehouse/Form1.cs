using System;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    public partial class Form1 : Form
    {
        private bool isBtnVendorsActive;
        private bool isBtnApplianceTypeActive;
        private bool isBtnApplianceActive;
        private bool isBtnDeliveriesActive;

        public Form1()
        {
            InitializeComponent();


        }

        MainMenu mainMenu = new MainMenu();

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isBtnVendorsActive)
            {
                mainMenu.InitializeNewButtons(this, btnVendors, !isBtnVendorsActive);
                isBtnVendorsActive = false;

                mainMenu.LockButtons(btnAppliance, btnApplianceType, btnDeliveries, isBtnVendorsActive);
            }

            if (isBtnApplianceTypeActive)
            {
                mainMenu.InitializeNewButtons(this, btnApplianceType, !isBtnApplianceTypeActive);
                isBtnApplianceTypeActive = false;

                mainMenu.LockButtons(btnAppliance, btnVendors, btnDeliveries, isBtnApplianceTypeActive);
            }

            if (isBtnApplianceActive)
            {
                mainMenu.InitializeNewButtons(this, btnAppliance, !isBtnApplianceActive);
                isBtnApplianceActive = false;

                mainMenu.LockButtons(btnVendors, btnApplianceType, btnDeliveries, isBtnApplianceActive);
            }

            if (isBtnDeliveriesActive)
            {
                mainMenu.InitializeNewButtons(this, btnDeliveries, !isBtnDeliveriesActive);
                isBtnDeliveriesActive = false;

                mainMenu.LockButtons(btnAppliance, btnApplianceType, btnVendors, isBtnDeliveriesActive);
            }
        }

        private void btnExitProgramm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            isBtnVendorsActive = true;
            mainMenu.InitializeNewButtons(this, btnVendors, isBtnVendorsActive);

            mainMenu.LockButtons(btnAppliance, btnApplianceType, btnDeliveries, isBtnVendorsActive);
        }

        private void btnApplianceType_Click(object sender, EventArgs e)
        {
            isBtnApplianceTypeActive = true;
            mainMenu.InitializeNewButtons(this, btnApplianceType, isBtnApplianceTypeActive);

            mainMenu.LockButtons(btnAppliance, btnVendors, btnDeliveries, isBtnApplianceTypeActive);
        }

        private void btnAppliance_Click(object sender, EventArgs e)
        {
            isBtnApplianceActive = true;
            mainMenu.InitializeNewButtons(this, btnAppliance, isBtnApplianceActive);

            mainMenu.LockButtons(btnVendors, btnApplianceType, btnDeliveries, isBtnApplianceActive);
        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            isBtnDeliveriesActive = true;
            mainMenu.InitializeNewButtons(this, btnDeliveries, isBtnDeliveriesActive);

            mainMenu.LockButtons(btnAppliance, btnApplianceType, btnVendors, isBtnDeliveriesActive);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isBtnVendorsActive)
            {
                mainMenu.InitializeNewWindow(this, new Form2());
            }

            if (isBtnApplianceTypeActive)
            {
                mainMenu.InitializeNewWindow(this, new Form3());
            }

            if (isBtnApplianceActive)
            {
                mainMenu.InitializeNewWindow(this, new Form4());
            }

            if (isBtnDeliveriesActive)
            {
                mainMenu.InitializeNewWindow(this, new Form5());
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (isBtnVendorsActive)
            {
                mainMenu.InitializeNewWindow(this, new Form6());
            }

            if (isBtnApplianceTypeActive)
            {
                mainMenu.InitializeNewWindow(this, new Form7());
            }

            if (isBtnApplianceActive)
            {
                mainMenu.InitializeNewWindow(this, new Form8());
            }

            if (isBtnDeliveriesActive)
            {
                mainMenu.InitializeNewWindow(this, new Form9());
            }
        }
    }
}
