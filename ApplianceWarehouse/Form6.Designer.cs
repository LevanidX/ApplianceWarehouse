namespace ApplianceWarehouse
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.homeApllianceWarehouseDataSet = new ApplianceWarehouse.HomeApllianceWarehouseDataSet();
            this.vendorViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorViewTableAdapter = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.vendorViewTableAdapter();
            this.tableAdapterManager = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager();
            this.vendorViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.homeApllianceWarehouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // homeApllianceWarehouseDataSet
            // 
            this.homeApllianceWarehouseDataSet.DataSetName = "HomeApllianceWarehouseDataSet";
            this.homeApllianceWarehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorViewBindingSource
            // 
            this.vendorViewBindingSource.DataMember = "vendorView";
            this.vendorViewBindingSource.DataSource = this.homeApllianceWarehouseDataSet;
            // 
            // vendorViewTableAdapter
            // 
            this.vendorViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.applianceTableAdapter = null;
            this.tableAdapterManager.applianceTypeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.deliveriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendorsTableAdapter = null;
            // 
            // vendorViewDataGridView
            // 
            this.vendorViewDataGridView.AllowUserToAddRows = false;
            this.vendorViewDataGridView.AllowUserToDeleteRows = false;
            this.vendorViewDataGridView.AutoGenerateColumns = false;
            this.vendorViewDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendorViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.vendorViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.vendorViewDataGridView.DataSource = this.vendorViewBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vendorViewDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.vendorViewDataGridView.Location = new System.Drawing.Point(12, 57);
            this.vendorViewDataGridView.Name = "vendorViewDataGridView";
            this.vendorViewDataGridView.ReadOnly = true;
            this.vendorViewDataGridView.Size = new System.Drawing.Size(744, 369);
            this.vendorViewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Производитель";
            this.dataGridViewTextBoxColumn1.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер телефона производителя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер телефона производителя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Адрес электроной почты производителя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес электроной почты производителя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(566, 45);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "ТАБЛИЧНЫЙ ВИД \"ПРОИЗВОДИТЕЛИ\"";
            // 
            // btnExitToMainMenu
            // 
            this.btnExitToMainMenu.BackColor = System.Drawing.Color.DarkRed;
            this.btnExitToMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitToMainMenu.Location = new System.Drawing.Point(584, 9);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(172, 45);
            this.btnExitToMainMenu.TabIndex = 13;
            this.btnExitToMainMenu.Text = "ВЫХОД";
            this.btnExitToMainMenu.UseVisualStyleBackColor = false;
            this.btnExitToMainMenu.Click += new System.EventHandler(this.btnExitToMainMenu_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(461, 430);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 50);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 433);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(443, 47);
            this.searchTextBox.TabIndex = 15;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Brown;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(612, 430);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 50);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Очистка";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(768, 486);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnExitToMainMenu);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.vendorViewDataGridView);
            this.Name = "Form6";
            this.Text = "ТАБЛИЧНЫЙ ВИД \"ПРОИЗВОДИТЕЛИ\"";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeApllianceWarehouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HomeApllianceWarehouseDataSet homeApllianceWarehouseDataSet;
        private System.Windows.Forms.BindingSource vendorViewBindingSource;
        private HomeApllianceWarehouseDataSetTableAdapters.vendorViewTableAdapter vendorViewTableAdapter;
        private HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vendorViewDataGridView;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExitToMainMenu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button btnClear;
    }
}