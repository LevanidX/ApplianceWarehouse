namespace ApplianceWarehouse
{
    partial class Form7
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
            this.applianceTypeViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applianceTypeViewTableAdapter = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.applianceTypeViewTableAdapter();
            this.tableAdapterManager = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager();
            this.applianceTypeViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.homeApllianceWarehouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applianceTypeViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applianceTypeViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // homeApllianceWarehouseDataSet
            // 
            this.homeApllianceWarehouseDataSet.DataSetName = "HomeApllianceWarehouseDataSet";
            this.homeApllianceWarehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applianceTypeViewBindingSource
            // 
            this.applianceTypeViewBindingSource.DataMember = "applianceTypeView";
            this.applianceTypeViewBindingSource.DataSource = this.homeApllianceWarehouseDataSet;
            // 
            // applianceTypeViewTableAdapter
            // 
            this.applianceTypeViewTableAdapter.ClearBeforeFill = true;
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
            // applianceTypeViewDataGridView
            // 
            this.applianceTypeViewDataGridView.AllowUserToAddRows = false;
            this.applianceTypeViewDataGridView.AllowUserToDeleteRows = false;
            this.applianceTypeViewDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.applianceTypeViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.applianceTypeViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applianceTypeViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.applianceTypeViewDataGridView.DataSource = this.applianceTypeViewBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.applianceTypeViewDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.applianceTypeViewDataGridView.Location = new System.Drawing.Point(12, 57);
            this.applianceTypeViewDataGridView.Name = "applianceTypeViewDataGridView";
            this.applianceTypeViewDataGridView.ReadOnly = true;
            this.applianceTypeViewDataGridView.Size = new System.Drawing.Size(745, 361);
            this.applianceTypeViewDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Наименование типа";
            this.dataGridViewTextBoxColumn1.HeaderText = "Наименование типа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(4, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(477, 45);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "ТАБЛИЧНЫЙ ВИД \"КАТЕГОРИИ\"";
            // 
            // btnExitToMainMenu
            // 
            this.btnExitToMainMenu.BackColor = System.Drawing.Color.DarkRed;
            this.btnExitToMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitToMainMenu.Location = new System.Drawing.Point(487, 9);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(270, 45);
            this.btnExitToMainMenu.TabIndex = 14;
            this.btnExitToMainMenu.Text = "ВЫХОД";
            this.btnExitToMainMenu.UseVisualStyleBackColor = false;
            this.btnExitToMainMenu.Click += new System.EventHandler(this.btnExitToMainMenu_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Brown;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(612, 424);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 50);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Очистка";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 427);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(443, 47);
            this.searchTextBox.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(461, 424);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 50);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form7
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
            this.Controls.Add(this.applianceTypeViewDataGridView);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeApllianceWarehouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applianceTypeViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applianceTypeViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HomeApllianceWarehouseDataSet homeApllianceWarehouseDataSet;
        private System.Windows.Forms.BindingSource applianceTypeViewBindingSource;
        private HomeApllianceWarehouseDataSetTableAdapters.applianceTypeViewTableAdapter applianceTypeViewTableAdapter;
        private HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView applianceTypeViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExitToMainMenu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button btnSearch;
    }
}