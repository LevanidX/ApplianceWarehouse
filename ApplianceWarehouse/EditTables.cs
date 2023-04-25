using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
