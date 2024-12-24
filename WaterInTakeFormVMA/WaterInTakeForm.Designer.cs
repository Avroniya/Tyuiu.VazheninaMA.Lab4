namespace WaterInTakeFormVMA
{
    partial class WaterInTakeCalcFormVMA
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
            this.labelChooseGenderVMA = new System.Windows.Forms.Label();
            this.comboBoxChooseGenderVMA = new System.Windows.Forms.ComboBox();
            this.labelWeightVMA = new System.Windows.Forms.Label();
            this.textBoxWeightVMA = new System.Windows.Forms.TextBox();
            this.labelkg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPAVMA = new System.Windows.Forms.TextBox();
            this.labelhour = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResultVMA = new System.Windows.Forms.TextBox();
            this.labelL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelChooseGenderVMA
            // 
            this.labelChooseGenderVMA.AutoSize = true;
            this.labelChooseGenderVMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseGenderVMA.Location = new System.Drawing.Point(72, 39);
            this.labelChooseGenderVMA.Name = "labelChooseGenderVMA";
            this.labelChooseGenderVMA.Size = new System.Drawing.Size(78, 20);
            this.labelChooseGenderVMA.TabIndex = 0;
            this.labelChooseGenderVMA.Text = "Ваш пол:";
            // 
            // comboBoxChooseGenderVMA
            // 
            this.comboBoxChooseGenderVMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxChooseGenderVMA.FormattingEnabled = true;
            this.comboBoxChooseGenderVMA.Location = new System.Drawing.Point(193, 39);
            this.comboBoxChooseGenderVMA.Name = "comboBoxChooseGenderVMA";
            this.comboBoxChooseGenderVMA.Size = new System.Drawing.Size(121, 28);
            this.comboBoxChooseGenderVMA.TabIndex = 1;
            this.comboBoxChooseGenderVMA.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseGenderVMA_SelectedIndexChanged);
            // 
            // labelWeightVMA
            // 
            this.labelWeightVMA.AutoSize = true;
            this.labelWeightVMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeightVMA.Location = new System.Drawing.Point(72, 104);
            this.labelWeightVMA.Name = "labelWeightVMA";
            this.labelWeightVMA.Size = new System.Drawing.Size(76, 20);
            this.labelWeightVMA.TabIndex = 2;
            this.labelWeightVMA.Text = "Ваш вес:";
            // 
            // textBoxWeightVMA
            // 
            this.textBoxWeightVMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxWeightVMA.Location = new System.Drawing.Point(193, 101);
            this.textBoxWeightVMA.Name = "textBoxWeightVMA";
            this.textBoxWeightVMA.Size = new System.Drawing.Size(121, 26);
            this.textBoxWeightVMA.TabIndex = 3;
            // 
            // labelkg
            // 
            this.labelkg.AutoSize = true;
            this.labelkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelkg.Location = new System.Drawing.Point(320, 107);
            this.labelkg.Name = "labelkg";
            this.labelkg.Size = new System.Drawing.Size(28, 20);
            this.labelkg.TabIndex = 4;
            this.labelkg.Text = "кг.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Физичесая нагрузка:";
            // 
            // textBoxPAVMA
            // 
            this.textBoxPAVMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPAVMA.Location = new System.Drawing.Point(193, 163);
            this.textBoxPAVMA.Name = "textBoxPAVMA";
            this.textBoxPAVMA.Size = new System.Drawing.Size(121, 26);
            this.textBoxPAVMA.TabIndex = 6;
            this.textBoxPAVMA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelhour
            // 
            this.labelhour.AutoSize = true;
            this.labelhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelhour.Location = new System.Drawing.Point(320, 166);
            this.labelhour.Name = "labelhour";
            this.labelhour.Size = new System.Drawing.Size(22, 20);
            this.labelhour.TabIndex = 7;
            this.labelhour.Text = "ч.";
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonResult.Location = new System.Drawing.Point(126, 210);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(118, 36);
            this.buttonResult.TabIndex = 8;
            this.buttonResult.Text = "Расчитать";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(16, 272);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(193, 20);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Дневная норма воды:";
            // 
            // textBoxResultVMA
            // 
            this.textBoxResultVMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultVMA.Location = new System.Drawing.Point(214, 266);
            this.textBoxResultVMA.Name = "textBoxResultVMA";
            this.textBoxResultVMA.Size = new System.Drawing.Size(100, 26);
            this.textBoxResultVMA.TabIndex = 10;
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelL.Location = new System.Drawing.Point(323, 272);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(25, 20);
            this.labelL.TabIndex = 11;
            this.labelL.Text = "л.";
            // 
            // WaterInTakeCalcFormVMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.textBoxResultVMA);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.labelhour);
            this.Controls.Add(this.textBoxPAVMA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelkg);
            this.Controls.Add(this.textBoxWeightVMA);
            this.Controls.Add(this.labelWeightVMA);
            this.Controls.Add(this.comboBoxChooseGenderVMA);
            this.Controls.Add(this.labelChooseGenderVMA);
            this.Name = "WaterInTakeCalcFormVMA";
            this.Text = "Норма воды| Важенина М.А.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseGenderVMA;
        private System.Windows.Forms.ComboBox comboBoxChooseGenderVMA;
        private System.Windows.Forms.Label labelWeightVMA;
        private System.Windows.Forms.TextBox textBoxWeightVMA;
        private System.Windows.Forms.Label labelkg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPAVMA;
        private System.Windows.Forms.Label labelhour;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResultVMA;
        private System.Windows.Forms.Label labelL;
    }
}

