using ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    internal class EditTables
    {
        public bool isAdding;
        public bool isSaved;

        public void DeleteItem(BindingSource bindingSource)
        {
            try
            {
                bindingSource.RemoveCurrent();

                isSaved = false;
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

        public void SaveEditings(Form currentForm, BindingSource bindingSource, TableAdapterManager tableAdapterManager, HomeApllianceWarehouseDataSet homeApllianceWarehouseDataSet)
        {
            currentForm.Validate();
            bindingSource.EndEdit();
            tableAdapterManager.UpdateAll(homeApllianceWarehouseDataSet);

            isSaved = true;
        }

        public void LockingAndUnlockingButtons(Button btnAddNew, Button btnLast, Button btnFirst, Button btnBack, 
            Button btnNext, Button btnSave, Button btnExitToMainMenu, Button btnDelete)
        {
            if (isAdding)
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
    }
}
