namespace ApplianceWarehouse
{
    partial class Form4
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label label3;
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.appWholesalePriceTextBox = new System.Windows.Forms.TextBox();
            this.applianceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeApllianceWarehouseDataSet = new ApplianceWarehouse.HomeApllianceWarehouseDataSet();
            this.appNameTextBox = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.applianceTableAdapter = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.applianceTableAdapter();
            this.tableAdapterManager = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager();
            this.applianceTypeTableAdapter = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.applianceTypeTableAdapter();
            this.appRetailPriceTextBox = new System.Windows.Forms.TextBox();
            this.appTypeComboBox = new System.Windows.Forms.ComboBox();
            this.applianceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyUpdate = new System.Windows.Forms.Timer(this.components);
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applianceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeApllianceWarehouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applianceTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(11, 143);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(161, 33);
            label2.TabIndex = 18;
            label2.Text = "Оптовая цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(11, 104);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(172, 33);
            label1.TabIndex = 16;
            label1.Text = "Наименование";
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            vendorNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            vendorNameLabel.Location = new System.Drawing.Point(11, 65);
            vendorNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(51, 33);
            vendorNameLabel.TabIndex = 13;
            vendorNameLabel.Text = "Тип";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(11, 182);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(188, 33);
            label3.TabIndex = 18;
            label3.Text = "Розничная цена";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DimGray;
            this.btnNext.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(313, 333);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.btnBack.Location = new System.Drawing.Point(12, 333);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.btnFirst.Location = new System.Drawing.Point(12, 277);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.btnDelete.Location = new System.Drawing.Point(12, 389);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.btnExitToMainMenu.Location = new System.Drawing.Point(491, 9);
            this.btnExitToMainMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(118, 45);
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
            this.btnSave.Location = new System.Drawing.Point(12, 445);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.btnAddNew.Location = new System.Drawing.Point(12, 221);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.btnLast.Location = new System.Drawing.Point(313, 277);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(295, 50);
            this.btnLast.TabIndex = 27;
            this.btnLast.Text = "Последний";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // appWholesalePriceTextBox
            // 
            this.appWholesalePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applianceBindingSource, "appWholesalePrice", true));
            this.appWholesalePriceTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appWholesalePriceTextBox.Location = new System.Drawing.Point(178, 143);
            this.appWholesalePriceTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appWholesalePriceTextBox.Name = "appWholesalePriceTextBox";
            this.appWholesalePriceTextBox.Size = new System.Drawing.Size(430, 33);
            this.appWholesalePriceTextBox.TabIndex = 19;
            this.appWholesalePriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.appWholesalePriceTextBox_KeyPress);
            // 
            // applianceBindingSource
            // 
            this.applianceBindingSource.DataMember = "appliance";
            this.applianceBindingSource.DataSource = this.homeApllianceWarehouseDataSet;
            // 
            // homeApllianceWarehouseDataSet
            // 
            this.homeApllianceWarehouseDataSet.DataSetName = "HomeApllianceWarehouseDataSet";
            this.homeApllianceWarehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appNameTextBox
            // 
            this.appNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applianceBindingSource, "appName", true));
            this.appNameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appNameTextBox.Location = new System.Drawing.Point(190, 104);
            this.appNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appNameTextBox.Name = "appNameTextBox";
            this.appNameTextBox.Size = new System.Drawing.Size(419, 33);
            this.appNameTextBox.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(473, 45);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "ТАБЛИЦА \"БЫТОВАЯ ТЕХНИКА\"";
            // 
            // applianceTableAdapter
            // 
            this.applianceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.applianceTableAdapter = this.applianceTableAdapter;
            this.tableAdapterManager.applianceTypeTableAdapter = this.applianceTypeTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.deliveriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendorsTableAdapter = null;
            // 
            // applianceTypeTableAdapter
            // 
            this.applianceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // appRetailPriceTextBox
            // 
            this.appRetailPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applianceBindingSource, "appRetailPrice", true));
            this.appRetailPriceTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appRetailPriceTextBox.Location = new System.Drawing.Point(205, 182);
            this.appRetailPriceTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appRetailPriceTextBox.Name = "appRetailPriceTextBox";
            this.appRetailPriceTextBox.Size = new System.Drawing.Size(402, 33);
            this.appRetailPriceTextBox.TabIndex = 19;
            this.appRetailPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.appRetailPriceTextBox_KeyPress);
            // 
            // appTypeComboBox
            // 
            this.appTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.applianceBindingSource, "appType", true));
            this.appTypeComboBox.DataSource = this.applianceTypeBindingSource;
            this.appTypeComboBox.DisplayMember = "appTypeName";
            this.appTypeComboBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appTypeComboBox.FormattingEnabled = true;
            this.appTypeComboBox.Location = new System.Drawing.Point(68, 65);
            this.appTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appTypeComboBox.Name = "appTypeComboBox";
            this.appTypeComboBox.Size = new System.Drawing.Size(539, 33);
            this.appTypeComboBox.TabIndex = 28;
            this.appTypeComboBox.ValueMember = "appTypeID";
            this.appTypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.appTypeComboBox_KeyPress);
            // 
            // applianceTypeBindingSource
            // 
            this.applianceTypeBindingSource.DataMember = "applianceType";
            this.applianceTypeBindingSource.DataSource = this.homeApllianceWarehouseDataSet;
            // 
            // MyUpdate
            // 
            this.MyUpdate.Enabled = true;
            this.MyUpdate.Tick += new System.EventHandler(this.MyUpdate_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(619, 502);
            this.ControlBox = false;
            this.Controls.Add(this.appTypeComboBox);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExitToMainMenu);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.appRetailPriceTextBox);
            this.Controls.Add(this.appWholesalePriceTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.appNameTextBox);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(vendorNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТАБЛИЦА \"БЫТОВАЯ ТЕХНИКА\"";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applianceBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox appWholesalePriceTextBox;
        private System.Windows.Forms.TextBox appNameTextBox;
        private System.Windows.Forms.Label lblTitle;
        private HomeApllianceWarehouseDataSet homeApllianceWarehouseDataSet;
        private System.Windows.Forms.BindingSource applianceBindingSource;
        private HomeApllianceWarehouseDataSetTableAdapters.applianceTableAdapter applianceTableAdapter;
        private HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox appRetailPriceTextBox;
        private HomeApllianceWarehouseDataSetTableAdapters.applianceTypeTableAdapter applianceTypeTableAdapter;
        private System.Windows.Forms.ComboBox appTypeComboBox;
        private System.Windows.Forms.BindingSource applianceTypeBindingSource;
        private System.Windows.Forms.Timer MyUpdate;
    }
}