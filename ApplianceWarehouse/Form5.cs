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
    public partial class Form5 : Form
    {
        private bool _isAdding;
        private bool _isSaved;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeApllianceWarehouseDataSet.vendors". При необходимости она может быть перемещена или удалена.
            this.vendorsTableAdapter.Fill(this.homeApllianceWarehouseDataSet.vendors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeApllianceWarehouseDataSet.appliance". При необходимости она может быть перемещена или удалена.
            this.applianceTableAdapter.Fill(this.homeApllianceWarehouseDataSet.appliance);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeApllianceWarehouseDataSet.deliveries". При необходимости она может быть перемещена или удалена.
            this.deliveriesTableAdapter.Fill(this.homeApllianceWarehouseDataSet.deliveries);

            _isSaved = true;
            _isAdding = false;
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
            this.deliveriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.homeApllianceWarehouseDataSet);

            _isSaved = true;
        }

        private void CheckAdding()
        {
            if (delApplianceComboBox.Text == "" || delVendorComboBox.Text == "" || delDateTextBox.Text == "")
            {
                _isAdding = true;
            }
            else
            {
                _isAdding = false;
            }
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
            deliveriesBindingSource.AddNew();

            _isSaved = false;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            deliveriesBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            deliveriesBindingSource.MoveLast();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            deliveriesBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            deliveriesBindingSource.MoveNext();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                deliveriesBindingSource.RemoveCurrent();

                _isSaved = false;
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show(
                    "Вы не можете удалить пустой элемент!\n" +
                    "Заполните хотя бы одну карточку, \n" +
                    "чтобы получить доступ ко всем функциям.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

        private void delApplianceComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void delVendorComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
