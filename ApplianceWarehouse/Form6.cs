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
    public partial class Form6 : Form
    {
        private int _itemsFound;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "homeApllianceWarehouseDataSet.vendorView". При необходимости она может быть перемещена или удалена.
            this.vendorViewTableAdapter.Fill(this.homeApllianceWarehouseDataSet.vendorView);

            _itemsFound = 0;
        }

        private void btnExitToMainMenu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "")
            {
                SetCellsColor(Color.White, Color.Black, false);
                SetCellsColor(Color.Black, Color.White, true);

                if (_itemsFound > 0)
                {
                    MessageBox.Show(
                        "По вашему запросу найдено результатов: " + _itemsFound,
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

                _itemsFound = 0;
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

        private void SetCellsColor(Color backColor, Color foreColor, bool isSearching)
        {
            for (int i = 0; i < vendorViewDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < vendorViewDataGridView.RowCount; j++)
                {
                    if (isSearching)
                    {
                        if (vendorViewDataGridView[i, j].Value.ToString().IndexOf(searchTextBox.Text) != -1)
                        {
                            vendorViewDataGridView[i, j].Style.BackColor = backColor;
                            vendorViewDataGridView[i, j].Style.ForeColor = foreColor;

                            _itemsFound++;
                        }
                    }
                    else
                    {
                        vendorViewDataGridView[i, j].Style.BackColor = backColor;
                        vendorViewDataGridView[i, j].Style.ForeColor = foreColor;
                    }
                    
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetCellsColor(Color.White, Color.Black, false);
            searchTextBox.Text = "";

            _itemsFound = 0;
        }
    }
}
