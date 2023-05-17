namespace ApplianceWarehouse
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExitProgramm = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnApplianceType = new System.Windows.Forms.Button();
            this.btnAppliance = new System.Windows.Forms.Button();
            this.btnDeliveries = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(142, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(440, 90);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "   ПРОГРАММНЫЙ МОДУЛЬ\r\n\"СКЛАД БЫТОВОЙ ТЕХНИКИ\"";
            // 
            // btnExitProgramm
            // 
            this.btnExitProgramm.BackColor = System.Drawing.Color.DarkRed;
            this.btnExitProgramm.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitProgramm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitProgramm.Location = new System.Drawing.Point(12, 579);
            this.btnExitProgramm.Name = "btnExitProgramm";
            this.btnExitProgramm.Size = new System.Drawing.Size(682, 85);
            this.btnExitProgramm.TabIndex = 13;
            this.btnExitProgramm.Text = "ВЫХОД";
            this.btnExitProgramm.UseVisualStyleBackColor = false;
            this.btnExitProgramm.Click += new System.EventHandler(this.btnExitProgramm_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.BackColor = System.Drawing.Color.OrangeRed;
            this.btnVendors.Location = new System.Drawing.Point(6, 39);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(422, 84);
            this.btnVendors.TabIndex = 0;
            this.btnVendors.Text = "Производители";
            this.btnVendors.UseVisualStyleBackColor = false;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnApplianceType
            // 
            this.btnApplianceType.BackColor = System.Drawing.Color.OrangeRed;
            this.btnApplianceType.Location = new System.Drawing.Point(6, 129);
            this.btnApplianceType.Name = "btnApplianceType";
            this.btnApplianceType.Size = new System.Drawing.Size(422, 84);
            this.btnApplianceType.TabIndex = 0;
            this.btnApplianceType.Text = "Категории";
            this.btnApplianceType.UseVisualStyleBackColor = false;
            this.btnApplianceType.Click += new System.EventHandler(this.btnApplianceType_Click);
            // 
            // btnAppliance
            // 
            this.btnAppliance.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAppliance.Location = new System.Drawing.Point(6, 219);
            this.btnAppliance.Name = "btnAppliance";
            this.btnAppliance.Size = new System.Drawing.Size(422, 84);
            this.btnAppliance.TabIndex = 0;
            this.btnAppliance.Text = "Бытовая техника";
            this.btnAppliance.UseVisualStyleBackColor = false;
            this.btnAppliance.Click += new System.EventHandler(this.btnAppliance_Click);
            // 
            // btnDeliveries
            // 
            this.btnDeliveries.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeliveries.Location = new System.Drawing.Point(6, 309);
            this.btnDeliveries.Name = "btnDeliveries";
            this.btnDeliveries.Size = new System.Drawing.Size(422, 84);
            this.btnDeliveries.TabIndex = 0;
            this.btnDeliveries.Text = "Поставки";
            this.btnDeliveries.UseVisualStyleBackColor = false;
            this.btnDeliveries.Click += new System.EventHandler(this.btnDeliveries_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDeliveries);
            this.groupBox1.Controls.Add(this.btnAppliance);
            this.groupBox1.Controls.Add(this.btnApplianceType);
            this.groupBox1.Controls.Add(this.btnVendors);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 401);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите действие";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Goldenrod;
            this.btnView.Enabled = false;
            this.btnView.Location = new System.Drawing.Point(434, 219);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(242, 174);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "Просмотр данных";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(434, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(242, 174);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Редактирование\r\nДобавление";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SlateGray;
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(12, 509);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(682, 64);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "НАЗАД";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(702, 667);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExitProgramm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПРОГРАММНЫЙ МОДУЛЬ \"СКЛАД БЫТОВОЙ ТЕХНИКИ\"";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExitProgramm;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnApplianceType;
        private System.Windows.Forms.Button btnAppliance;
        private System.Windows.Forms.Button btnDeliveries;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnView;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnBack;
    }
}

