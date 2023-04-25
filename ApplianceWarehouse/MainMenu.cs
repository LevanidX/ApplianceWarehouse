using ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    internal class MainMenu
    {
        EditTables edit = new EditTables();

        public void ExitToMainMenu(Form currentForm, BindingSource bindingSource, TableAdapterManager tableAdapterManager, HomeApllianceWarehouseDataSet homeApllianceWarehouseDataSet)
        {
            if (!edit.isSaved)
            {
                var result = MessageBox.Show(
                    "Вы хотите сохранить внесенные изменения?",
                    "Сохранение изменений",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    edit.SaveEditings(currentForm, bindingSource, tableAdapterManager, homeApllianceWarehouseDataSet);
                    InitializeMainMenu(currentForm);
                }
                else if (result == DialogResult.No)
                {
                    InitializeMainMenu(currentForm);
                }
            }
            else
            {
                InitializeMainMenu(currentForm);
            }
        }

        public void InitializeMainMenu(Form currentForm)
        {
            Form1 f1 = new Form1();
            f1.Show();
            currentForm.Close();
        }

        public void InitializeNewWindow(Form currentForm, Form newForm)
        {
            newForm.Show();
            currentForm.Hide();
        }
    }
}
