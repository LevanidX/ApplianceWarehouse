using System.Drawing;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    internal class ViewTables
    {
        public int itemsFound;

        public void Searching(DataGridView dataGridView, TextBox searchTextBox)
        {
            if (searchTextBox.Text != "")
            {
                SetCellsColor(dataGridView, searchTextBox, Color.White, Color.Black, false);
                SetCellsColor(dataGridView, searchTextBox, Color.Black, Color.White, true);

                if (itemsFound > 0)
                {
                    MessageBox.Show(
                        "По вашему запросу найдено результатов: " + itemsFound,
                        "Результат запроса",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "По вашему запросу результатов не найдено!",
                        "Результат запроса",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                itemsFound = 0;
            }
            else
            {
                MessageBox.Show(
                    "Введите запрос в текстовом поле!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void Filtering(BindingSource bindingSource, ComboBox comboBox, string columnName)
        {
            bindingSource.Filter = $"[{columnName}]='" + comboBox.Text + "'";
        }

        public void ClearAll(DataGridView dataGridView, BindingSource bindingSource, TextBox searchTextBox)
        {
            SetCellsColor(dataGridView, searchTextBox, Color.White, Color.Black, false);
            bindingSource.Filter = "";
            searchTextBox.Text = "";

            itemsFound = 0;
        }

        private void SetCellsColor(DataGridView dataGridView, TextBox searchTextBox, Color backColor, Color foreColor, bool isSearching)
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount; j++)
                {
                    if (isSearching)
                    {
                        if (dataGridView[i, j].Value.ToString().IndexOf(searchTextBox.Text) != -1)
                        {
                            dataGridView[i, j].Style.BackColor = backColor;
                            dataGridView[i, j].Style.ForeColor = foreColor;

                            itemsFound++;
                        }
                    }
                    else
                    {
                        dataGridView[i, j].Style.BackColor = backColor;
                        dataGridView[i, j].Style.ForeColor = foreColor;
                    }
                }
            }
        }
    }
}
