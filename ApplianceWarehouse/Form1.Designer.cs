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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVendorsEdit = new System.Windows.Forms.Button();
            this.btnApplianceTypeEdit = new System.Windows.Forms.Button();
            this.btnApplianceEdit = new System.Windows.Forms.Button();
            this.btnDeliveriesEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeliveriesView = new System.Windows.Forms.Button();
            this.btnApplianceView = new System.Windows.Forms.Button();
            this.btnApplianceTypeView = new System.Windows.Forms.Button();
            this.btnVendorsView = new System.Windows.Forms.Button();
            this.btnExitProgramm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(440, 90);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "   ПРОГРАММНЫЙ МОДУЛЬ\r\n\"СКЛАД БЫТОВОЙ ТЕХНИКИ\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeliveriesEdit);
            this.groupBox1.Controls.Add(this.btnApplianceEdit);
            this.groupBox1.Controls.Add(this.btnApplianceTypeEdit);
            this.groupBox1.Controls.Add(this.btnVendorsEdit);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование таблиц";
            // 
            // btnVendorsEdit
            // 
            this.btnVendorsEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVendorsEdit.Location = new System.Drawing.Point(6, 39);
            this.btnVendorsEdit.Name = "btnVendorsEdit";
            this.btnVendorsEdit.Size = new System.Drawing.Size(422, 50);
            this.btnVendorsEdit.TabIndex = 0;
            this.btnVendorsEdit.Text = "Производители";
            this.btnVendorsEdit.UseVisualStyleBackColor = false;
            this.btnVendorsEdit.Click += new System.EventHandler(this.btnVendorsEdit_Click);
            // 
            // btnApplianceTypeEdit
            // 
            this.btnApplianceTypeEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApplianceTypeEdit.Location = new System.Drawing.Point(6, 95);
            this.btnApplianceTypeEdit.Name = "btnApplianceTypeEdit";
            this.btnApplianceTypeEdit.Size = new System.Drawing.Size(422, 50);
            this.btnApplianceTypeEdit.TabIndex = 0;
            this.btnApplianceTypeEdit.Text = "Категории";
            this.btnApplianceTypeEdit.UseVisualStyleBackColor = false;
            this.btnApplianceTypeEdit.Click += new System.EventHandler(this.btnApplianceTypeEdit_Click);
            // 
            // btnApplianceEdit
            // 
            this.btnApplianceEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApplianceEdit.Location = new System.Drawing.Point(6, 151);
            this.btnApplianceEdit.Name = "btnApplianceEdit";
            this.btnApplianceEdit.Size = new System.Drawing.Size(422, 50);
            this.btnApplianceEdit.TabIndex = 0;
            this.btnApplianceEdit.Text = "Бытовая техника";
            this.btnApplianceEdit.UseVisualStyleBackColor = false;
            this.btnApplianceEdit.Click += new System.EventHandler(this.btnApplianceEdit_Click);
            // 
            // btnDeliveriesEdit
            // 
            this.btnDeliveriesEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeliveriesEdit.Location = new System.Drawing.Point(6, 207);
            this.btnDeliveriesEdit.Name = "btnDeliveriesEdit";
            this.btnDeliveriesEdit.Size = new System.Drawing.Size(422, 50);
            this.btnDeliveriesEdit.TabIndex = 0;
            this.btnDeliveriesEdit.Text = "Поставки";
            this.btnDeliveriesEdit.UseVisualStyleBackColor = false;
            this.btnDeliveriesEdit.Click += new System.EventHandler(this.btnDeliveriesEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeliveriesView);
            this.groupBox2.Controls.Add(this.btnApplianceView);
            this.groupBox2.Controls.Add(this.btnApplianceTypeView);
            this.groupBox2.Controls.Add(this.btnVendorsView);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 264);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Просмотр таблиц";
            // 
            // btnDeliveriesView
            // 
            this.btnDeliveriesView.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeliveriesView.Location = new System.Drawing.Point(6, 207);
            this.btnDeliveriesView.Name = "btnDeliveriesView";
            this.btnDeliveriesView.Size = new System.Drawing.Size(422, 50);
            this.btnDeliveriesView.TabIndex = 0;
            this.btnDeliveriesView.Text = "Поставки";
            this.btnDeliveriesView.UseVisualStyleBackColor = false;
            // 
            // btnApplianceView
            // 
            this.btnApplianceView.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApplianceView.Location = new System.Drawing.Point(6, 151);
            this.btnApplianceView.Name = "btnApplianceView";
            this.btnApplianceView.Size = new System.Drawing.Size(422, 50);
            this.btnApplianceView.TabIndex = 0;
            this.btnApplianceView.Text = "Бытовая техника";
            this.btnApplianceView.UseVisualStyleBackColor = false;
            // 
            // btnApplianceTypeView
            // 
            this.btnApplianceTypeView.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApplianceTypeView.Location = new System.Drawing.Point(6, 95);
            this.btnApplianceTypeView.Name = "btnApplianceTypeView";
            this.btnApplianceTypeView.Size = new System.Drawing.Size(422, 50);
            this.btnApplianceTypeView.TabIndex = 0;
            this.btnApplianceTypeView.Text = "Категории";
            this.btnApplianceTypeView.UseVisualStyleBackColor = false;
            this.btnApplianceTypeView.Click += new System.EventHandler(this.btnApplianceTypeView_Click);
            // 
            // btnVendorsView
            // 
            this.btnVendorsView.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVendorsView.Location = new System.Drawing.Point(6, 39);
            this.btnVendorsView.Name = "btnVendorsView";
            this.btnVendorsView.Size = new System.Drawing.Size(422, 50);
            this.btnVendorsView.TabIndex = 0;
            this.btnVendorsView.Text = "Производители";
            this.btnVendorsView.UseVisualStyleBackColor = false;
            this.btnVendorsView.Click += new System.EventHandler(this.btnVendorsView_Click);
            // 
            // btnExitProgramm
            // 
            this.btnExitProgramm.BackColor = System.Drawing.Color.DarkRed;
            this.btnExitProgramm.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitProgramm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitProgramm.Location = new System.Drawing.Point(12, 642);
            this.btnExitProgramm.Name = "btnExitProgramm";
            this.btnExitProgramm.Size = new System.Drawing.Size(434, 76);
            this.btnExitProgramm.TabIndex = 13;
            this.btnExitProgramm.Text = "ВЫХОД";
            this.btnExitProgramm.UseVisualStyleBackColor = false;
            this.btnExitProgramm.Click += new System.EventHandler(this.btnExitProgramm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(452, 722);
            this.Controls.Add(this.btnExitProgramm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "ПРОГРАММНЫЙ МОДУЛЬ \"СКЛАД БЫТОВОЙ ТЕХНИКИ\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeliveriesEdit;
        private System.Windows.Forms.Button btnApplianceEdit;
        private System.Windows.Forms.Button btnApplianceTypeEdit;
        private System.Windows.Forms.Button btnVendorsEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeliveriesView;
        private System.Windows.Forms.Button btnApplianceView;
        private System.Windows.Forms.Button btnApplianceTypeView;
        private System.Windows.Forms.Button btnVendorsView;
        private System.Windows.Forms.Button btnExitProgramm;
    }
}

