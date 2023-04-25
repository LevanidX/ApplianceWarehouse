namespace ApplianceWarehouse
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delVendorComboBox = new System.Windows.Forms.ComboBox();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeApllianceWarehouseDataSet = new ApplianceWarehouse.HomeApllianceWarehouseDataSet();
            this.btnChoice = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.deliveriesViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveriesViewTableAdapter = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.deliveriesViewTableAdapter();
            this.tableAdapterManager = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager();
            this.vendorsTableAdapter = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.vendorsTableAdapter();
            this.deliveriesViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeApllianceWarehouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // delVendorComboBox
            // 
            this.delVendorComboBox.DataSource = this.vendorsBindingSource;
            this.delVendorComboBox.DisplayMember = "vendorName";
            this.delVendorComboBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delVendorComboBox.FormattingEnabled = true;
            this.delVendorComboBox.Location = new System.Drawing.Point(11, 446);
            this.delVendorComboBox.Name = "delVendorComboBox";
            this.delVendorComboBox.Size = new System.Drawing.Size(443, 47);
            this.delVendorComboBox.TabIndex = 54;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "vendors";
            this.vendorsBindingSource.DataSource = this.homeApllianceWarehouseDataSet;
            // 
            // homeApllianceWarehouseDataSet
            // 
            this.homeApllianceWarehouseDataSet.DataSetName = "HomeApllianceWarehouseDataSet";
            this.homeApllianceWarehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnChoice
            // 
            this.btnChoice.BackColor = System.Drawing.Color.SeaGreen;
            this.btnChoice.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChoice.Location = new System.Drawing.Point(460, 445);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(145, 50);
            this.btnChoice.TabIndex = 53;
            this.btnChoice.Text = "Выбор";
            this.btnChoice.UseVisualStyleBackColor = false;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Brown;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(611, 445);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 106);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Очистка";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(11, 504);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(443, 47);
            this.searchTextBox.TabIndex = 50;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(460, 501);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 50);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExitToMainMenu
            // 
            this.btnExitToMainMenu.BackColor = System.Drawing.Color.DarkRed;
            this.btnExitToMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitToMainMenu.Location = new System.Drawing.Point(460, 10);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(296, 45);
            this.btnExitToMainMenu.TabIndex = 48;
            this.btnExitToMainMenu.Text = "ВЫХОД";
            this.btnExitToMainMenu.UseVisualStyleBackColor = false;
            this.btnExitToMainMenu.Click += new System.EventHandler(this.btnExitToMainMenu_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(4, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 45);
            this.lblTitle.TabIndex = 47;
            this.lblTitle.Text = "ТАБЛИЧНЫЙ ВИД \"ПОСТАВКИ\"";
            // 
            // deliveriesViewBindingSource
            // 
            this.deliveriesViewBindingSource.DataMember = "deliveriesView";
            this.deliveriesViewBindingSource.DataSource = this.homeApllianceWarehouseDataSet;
            // 
            // deliveriesViewTableAdapter
            // 
            this.deliveriesViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.applianceTableAdapter = null;
            this.tableAdapterManager.applianceTypeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.deliveriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendorsTableAdapter = this.vendorsTableAdapter;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // deliveriesViewDataGridView
            // 
            this.deliveriesViewDataGridView.AllowUserToAddRows = false;
            this.deliveriesViewDataGridView.AllowUserToDeleteRows = false;
            this.deliveriesViewDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deliveriesViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.deliveriesViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveriesViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.deliveriesViewDataGridView.DataSource = this.deliveriesViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deliveriesViewDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.deliveriesViewDataGridView.Location = new System.Drawing.Point(11, 58);
            this.deliveriesViewDataGridView.Name = "deliveriesViewDataGridView";
            this.deliveriesViewDataGridView.ReadOnly = true;
            this.deliveriesViewDataGridView.Size = new System.Drawing.Size(745, 381);
            this.deliveriesViewDataGridView.TabIndex = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Наименование товара";
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование товара";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Поставщик";
            this.dataGridViewTextBoxColumn2.HeaderText = "Поставщик";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата последней поставки";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата последней поставки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(768, 561);
            this.ControlBox = false;
            this.Controls.Add(this.deliveriesViewDataGridView);
            this.Controls.Add(this.delVendorComboBox);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExitToMainMenu);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТАБЛИЧНЫЙ ВИД \"ПОСТАВКИ\"";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeApllianceWarehouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox delVendorComboBox;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExitToMainMenu;
        private System.Windows.Forms.Label lblTitle;
        private HomeApllianceWarehouseDataSet homeApllianceWarehouseDataSet;
        private System.Windows.Forms.BindingSource deliveriesViewBindingSource;
        private HomeApllianceWarehouseDataSetTableAdapters.deliveriesViewTableAdapter deliveriesViewTableAdapter;
        private HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView deliveriesViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private HomeApllianceWarehouseDataSetTableAdapters.vendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
    }
}