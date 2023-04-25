namespace ApplianceWarehouse
{
    partial class Form3
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
            System.Windows.Forms.Label vendorNameLabel;
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.appTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.homeApllianceWarehouseDataSet = new ApplianceWarehouse.HomeApllianceWarehouseDataSet();
            this.applianceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applianceTypeTableAdapter = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.applianceTypeTableAdapter();
            this.tableAdapterManager = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager();
            this.MyUpdate = new System.Windows.Forms.Timer(this.components);
            vendorNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homeApllianceWarehouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applianceTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DimGray;
            this.btnNext.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(313, 216);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(295, 50);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Следующий";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(12, 216);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(295, 50);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Предыдущий";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.DimGray;
            this.btnFirst.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFirst.Location = new System.Drawing.Point(12, 160);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(295, 50);
            this.btnFirst.TabIndex = 22;
            this.btnFirst.Text = "Первый";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(12, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(596, 50);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExitToMainMenu
            // 
            this.btnExitToMainMenu.BackColor = System.Drawing.Color.DarkRed;
            this.btnExitToMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitToMainMenu.Location = new System.Drawing.Point(380, 9);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(228, 45);
            this.btnExitToMainMenu.TabIndex = 24;
            this.btnExitToMainMenu.Text = "ВЫХОД";
            this.btnExitToMainMenu.UseVisualStyleBackColor = false;
            this.btnExitToMainMenu.Click += new System.EventHandler(this.btnExitToMainMenu_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(12, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(596, 50);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Orange;
            this.btnAddNew.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNew.Location = new System.Drawing.Point(12, 104);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(596, 50);
            this.btnAddNew.TabIndex = 26;
            this.btnAddNew.Text = "Добавить";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.DimGray;
            this.btnLast.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLast.Location = new System.Drawing.Point(313, 160);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(295, 50);
            this.btnLast.TabIndex = 27;
            this.btnLast.Text = "Последний";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 45);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "ТАБЛИЦА \"КАТЕГОРИИ\"";
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            vendorNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            vendorNameLabel.Location = new System.Drawing.Point(11, 65);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(285, 33);
            vendorNameLabel.TabIndex = 13;
            vendorNameLabel.Text = "Наименование категории";
            // 
            // appTypeNameTextBox
            // 
            this.appTypeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applianceTypeBindingSource, "appTypeName", true));
            this.appTypeNameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appTypeNameTextBox.Location = new System.Drawing.Point(302, 65);
            this.appTypeNameTextBox.Name = "appTypeNameTextBox";
            this.appTypeNameTextBox.Size = new System.Drawing.Size(306, 33);
            this.appTypeNameTextBox.TabIndex = 14;
            // 
            // homeApllianceWarehouseDataSet
            // 
            this.homeApllianceWarehouseDataSet.DataSetName = "HomeApllianceWarehouseDataSet";
            this.homeApllianceWarehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applianceTypeBindingSource
            // 
            this.applianceTypeBindingSource.DataMember = "applianceType";
            this.applianceTypeBindingSource.DataSource = this.homeApllianceWarehouseDataSet;
            // 
            // applianceTypeTableAdapter
            // 
            this.applianceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.applianceTableAdapter = null;
            this.tableAdapterManager.applianceTypeTableAdapter = this.applianceTypeTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.deliveriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendorsTableAdapter = null;
            // 
            // MyUpdate
            // 
            this.MyUpdate.Enabled = true;
            this.MyUpdate.Tick += new System.EventHandler(this.MyUpdate_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(619, 383);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExitToMainMenu);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(vendorNameLabel);
            this.Controls.Add(this.appTypeNameTextBox);
            this.Name = "Form3";
            this.Text = "ТАБЛИЦА \"КАТЕГОРИИ\"";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeApllianceWarehouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applianceTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExitToMainMenu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox appTypeNameTextBox;
        private HomeApllianceWarehouseDataSet homeApllianceWarehouseDataSet;
        private System.Windows.Forms.BindingSource applianceTypeBindingSource;
        private HomeApllianceWarehouseDataSetTableAdapters.applianceTypeTableAdapter applianceTypeTableAdapter;
        private HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer MyUpdate;
    }
}