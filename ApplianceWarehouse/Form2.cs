using System;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    public partial class Form2 : Form
    {
        EditTables edit = new EditTables();

        private bool _isAdding;
        private bool _isSaved;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeApllianceWarehouseDataSet.vendors". При необходимости она может быть перемещена или удалена.
            this.vendorsTableAdapter.Fill(this.homeApllianceWarehouseDataSet.vendors);

            _isSaved = true;
            _isAdding = false;
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            if (!_isSaved)
            {
                var result = MessageBox.Show(
                    "Вы хотите сохранить внесенные изменения?",
                    "Сохранение изменений",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    SaveEditings();
                    InitializeMainMenu();
                }
                else if (result == DialogResult.No)
                {
                    InitializeMainMenu();
                }
            }
            else
            {
                InitializeMainMenu();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            vendorsBindingSource.AddNew();

            _isSaved = false;
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
            if (!_isAdding)
            {
                SaveEditings();
            }
        }

        private void MyUpdate_Tick(object sender, EventArgs e)
        {
            CheckAdding();

            if (_isAdding)
            {
                btnAddNew.Enabled = false;
                btnLast.Enabled = false;
                btnFirst.Enabled = false;
                btnBack.Enabled = false;
                btnNext.Enabled = false;
                btnSave.Enabled = false;
                btnExitToMainMenu.Enabled = false;

                btnDelete.Text = "Отмена";
            }
            else
            {
                btnAddNew.Enabled = true;
                btnLast.Enabled = true;
                btnFirst.Enabled = true;
                btnBack.Enabled = true;
                btnNext.Enabled = true;
                btnSave.Enabled = true;
                btnExitToMainMenu.Enabled = true;

                btnDelete.Text = "Удалить";
            }
        }

        private void InitializeMainMenu()
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void SaveEditings()
        {
            this.Validate();
            this.vendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.homeApllianceWarehouseDataSet);

            _isSaved = true;
        }

        private void CheckAdding()
        {
            if (vendorNameTextBox.Text == "" || vendorPhoneNumberTextBox.Text == "" || vendorEmailAddressTextBox.Text == "")
            {
                _isAdding = true;
            }
            else
            {
                _isAdding = false;
            }
        }

        private void vendorPhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
