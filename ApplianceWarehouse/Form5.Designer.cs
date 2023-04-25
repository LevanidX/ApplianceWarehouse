namespace ApplianceWarehouse
{
    partial class Form5
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
            this.delApplianceComboBox = new System.Windows.Forms.ComboBox();
            this.deliveriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeApllianceWarehouseDataSet = new ApplianceWarehouse.HomeApllianceWarehouseDataSet();
            this.applianceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExitToMainMenu = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.deliveriesTableAdapter = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.deliveriesTableAdapter();
            this.tableAdapterManager = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager();
            this.applianceTableAdapter = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.applianceTableAdapter();
            this.vendorsTableAdapter = new ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.vendorsTableAdapter();
            this.delDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.delVendorComboBox = new System.Windows.Forms.ComboBox();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyUpdate = new System.Windows.Forms.Timer(this.components);
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeApllianceWarehouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applianceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(11, 143);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(291, 33);
            label2.TabIndex = 34;
            label2.Text = "Дата последней поставки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(11, 104);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 33);
            label1.TabIndex = 31;
            label1.Text = "Поставщик";
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            vendorNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            vendorNameLabel.Location = new System.Drawing.Point(11, 65);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(172, 33);
            vendorNameLabel.TabIndex = 29;
            vendorNameLabel.Text = "Наименование";
            // 
            // delApplianceComboBox
            // 
            this.delApplianceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deliveriesBindingSource, "delAppliance", true));
            this.delApplianceComboBox.DataSource = this.applianceBindingSource;
            this.delApplianceComboBox.DisplayMember = "appName";
            this.delApplianceComboBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delApplianceComboBox.FormattingEnabled = true;
            this.delApplianceComboBox.Location = new System.Drawing.Point(189, 65);
            this.delApplianceComboBox.Name = "delApplianceComboBox";
            this.delApplianceComboBox.Size = new System.Drawing.Size(418, 33);
            this.delApplianceComboBox.TabIndex = 45;
            this.delApplianceComboBox.ValueMember = "appID";
            this.delApplianceComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delApplianceComboBox_KeyPress);
            // 
            // deliveriesBindingSource
            // 
            this.deliveriesBindingSource.DataMember = "deliveries";
            this.deliveriesBindingSource.DataSource = this.homeApllianceWarehouseDataSet;
            // 
            // homeApllianceWarehouseDataSet
            // 
            this.homeApllianceWarehouseDataSet.DataSetName = "HomeApllianceWarehouseDataSet";
            this.homeApllianceWarehouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applianceBindingSource
            // 
            this.applianceBindingSource.DataMember = "appliance";
            this.applianceBindingSource.DataSource = this.homeApllianceWarehouseDataSet;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DimGray;
            this.btnNext.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(313, 294);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(295, 50);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "Следующий";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(12, 294);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(295, 50);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Предыдущий";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.DimGray;
            this.btnFirst.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFirst.Location = new System.Drawing.Point(12, 238);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(295, 50);
            this.btnFirst.TabIndex = 39;
            this.btnFirst.Text = "Первый";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(12, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(596, 50);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExitToMainMenu
            // 
            this.btnExitToMainMenu.BackColor = System.Drawing.Color.DarkRed;
            this.btnExitToMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitToMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitToMainMenu.Location = new System.Drawing.Point(363, 9);
            this.btnExitToMainMenu.Name = "btnExitToMainMenu";
            this.btnExitToMainMenu.Size = new System.Drawing.Size(245, 45);
            this.btnExitToMainMenu.TabIndex = 41;
            this.btnExitToMainMenu.Text = "ВЫХОД";
            this.btnExitToMainMenu.UseVisualStyleBackColor = false;
            this.btnExitToMainMenu.Click += new System.EventHandler(this.btnExitToMainMenu_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(12, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(596, 50);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Orange;
            this.btnAddNew.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNew.Location = new System.Drawing.Point(12, 182);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(596, 50);
            this.btnAddNew.TabIndex = 43;
            this.btnAddNew.Text = "Добавить";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.DimGray;
            this.btnLast.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLast.Location = new System.Drawing.Point(313, 238);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(295, 50);
            this.btnLast.TabIndex = 44;
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
            this.lblTitle.Size = new System.Drawing.Size(345, 45);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "ТАБЛИЦА \"ПОСТАВКИ\"";
            // 
            // deliveriesTableAdapter
            // 
            this.deliveriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.applianceTableAdapter = this.applianceTableAdapter;
            this.tableAdapterManager.applianceTypeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.deliveriesTableAdapter = this.deliveriesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ApplianceWarehouse.HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendorsTableAdapter = this.vendorsTableAdapter;
            // 
            // applianceTableAdapter
            // 
            this.applianceTableAdapter.ClearBeforeFill = true;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // delDateTextBox
            // 
            this.delDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveriesBindingSource, "delDate", true));
            this.delDateTextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delDateTextBox.Location = new System.Drawing.Point(308, 143);
            this.delDateTextBox.Mask = "00/00/0000";
            this.delDateTextBox.Name = "delDateTextBox";
            this.delDateTextBox.Size = new System.Drawing.Size(300, 33);
            this.delDateTextBox.TabIndex = 46;
            this.delDateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // delVendorComboBox
            // 
            this.delVendorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.deliveriesBindingSource, "delVendor", true));
            this.delVendorComboBox.DataSource = this.vendorsBindingSource;
            this.delVendorComboBox.DisplayMember = "vendorName";
            this.delVendorComboBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delVendorComboBox.FormattingEnabled = true;
            this.delVendorComboBox.Location = new System.Drawing.Point(149, 104);
            this.delVendorComboBox.Name = "delVendorComboBox";
            this.delVendorComboBox.Size = new System.Drawing.Size(458, 33);
            this.delVendorComboBox.TabIndex = 45;
            this.delVendorComboBox.ValueMember = "vendorID";
            this.delVendorComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delVendorComboBox_KeyPress);
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "vendors";
            this.vendorsBindingSource.DataSource = this.homeApllianceWarehouseDataSet;
            // 
            // MyUpdate
            // 
            this.MyUpdate.Enabled = true;
            this.MyUpdate.Tick += new System.EventHandler(this.MyUpdate_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(619, 461);
            this.ControlBox = false;
            this.Controls.Add(this.delDateTextBox);
            this.Controls.Add(this.delVendorComboBox);
            this.Controls.Add(this.delApplianceComboBox);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExitToMainMenu);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(vendorNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТАБЛИЦА \"ПОСТАВКИ\"";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeApllianceWarehouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applianceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox delApplianceComboBox;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExitToMainMenu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblTitle;
        private HomeApllianceWarehouseDataSet homeApllianceWarehouseDataSet;
        private System.Windows.Forms.BindingSource deliveriesBindingSource;
        private HomeApllianceWarehouseDataSetTableAdapters.deliveriesTableAdapter deliveriesTableAdapter;
        private HomeApllianceWarehouseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox delDateTextBox;
        private System.Windows.Forms.ComboBox delVendorComboBox;
        private HomeApllianceWarehouseDataSetTableAdapters.applianceTableAdapter applianceTableAdapter;
        private System.Windows.Forms.BindingSource applianceBindingSource;
        private HomeApllianceWarehouseDataSetTableAdapters.vendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private System.Windows.Forms.Timer MyUpdate;
    }
}