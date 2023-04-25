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
    public partial class Form3 : Form
    {
        private bool _isAdding;
        private bool _isSaved;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeApllianceWarehouseDataSet.applianceType". При необходимости она может быть перемещена или удалена.
            this.applianceTypeTableAdapter.Fill(this.homeApllianceWarehouseDataSet.applianceType);

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
            applianceTypeBindingSource.AddNew();

            _isSaved = false;
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
            try
            {
                applianceTypeBindingSource.RemoveCurrent();

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

        private void InitializeMainMenu()
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void SaveEditings()
        {
            this.Validate();
            this.applianceTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.homeApllianceWarehouseDataSet);

            _isSaved = true;
        }

        private void CheckAdding()
        {
            if (appTypeNameTextBox.Text == "")
            {
                _isAdding = true;
            }
            else
            {
                _isAdding = false;
            }
        }
    }
}
