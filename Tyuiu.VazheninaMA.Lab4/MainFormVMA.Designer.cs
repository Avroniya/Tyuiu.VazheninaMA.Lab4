namespace Tyuiu.VazheninaMA.Lab4
{
    partial class MainFormVMA
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
            this.panelShowVMA = new System.Windows.Forms.SplitContainer();
            this.textBoxShowResultVMA = new System.Windows.Forms.TextBox();
            this.menuStripOfCalcVMA = new System.Windows.Forms.MenuStrip();
            this.типToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переводЕдиницToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нормаВодыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelChooseFunction = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFindFactorial = new System.Windows.Forms.Button();
            this.buttonFindTn = new System.Windows.Forms.Button();
            this.buttonFindExp = new System.Windows.Forms.Button();
            this.buttonFindSin = new System.Windows.Forms.Button();
            this.buttonFindPi = new System.Windows.Forms.Button();
            this.buttonFindCos = new System.Windows.Forms.Button();
            this.buttonFindLogarithm = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonOperationMultyplycation = new System.Windows.Forms.Button();
            this.buttonSixVMA = new System.Windows.Forms.Button();
            this.buttonFiveVMA = new System.Windows.Forms.Button();
            this.buttonFourVMA = new System.Windows.Forms.Button();
            this.buttonOperationQuotient = new System.Windows.Forms.Button();
            this.buttonNineVMA = new System.Windows.Forms.Button();
            this.buttonEightVMA = new System.Windows.Forms.Button();
            this.buttonSevenVMA = new System.Windows.Forms.Button();
            this.buttonFindReciprocal = new System.Windows.Forms.Button();
            this.buttonFindSquarrel = new System.Windows.Forms.Button();
            this.buttonThreeVMA = new System.Windows.Forms.Button();
            this.buttonTwoVMA = new System.Windows.Forms.Button();
            this.buttonZeroVMA = new System.Windows.Forms.Button();
            this.buttonOneVMA = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonFindSqrt = new System.Windows.Forms.Button();
            this.buttonChangeSignVMA = new System.Windows.Forms.Button();
            this.buttonFindPowerOfNumbers = new System.Windows.Forms.Button();
            this.buttonFindPowerOfTen = new System.Windows.Forms.Button();
            this.buttonOperationResult = new System.Windows.Forms.Button();
            this.buttonFindAbs = new System.Windows.Forms.Button();
            this.buttonOperationSumma = new System.Windows.Forms.Button();
            this.buttonOperationDifference = new System.Windows.Forms.Button();
            this.buttonOperationPercent = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelShowVMA)).BeginInit();
            this.panelShowVMA.Panel1.SuspendLayout();
            this.panelShowVMA.Panel2.SuspendLayout();
            this.panelShowVMA.SuspendLayout();
            this.menuStripOfCalcVMA.SuspendLayout();
            this.tableLayoutPanelChooseFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShowVMA
            // 
            this.panelShowVMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowVMA.Location = new System.Drawing.Point(0, 0);
            this.panelShowVMA.Name = "panelShowVMA";
            this.panelShowVMA.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // panelShowVMA.Panel1
            // 
            this.panelShowVMA.Panel1.Controls.Add(this.textBoxShowResultVMA);
            this.panelShowVMA.Panel1.Controls.Add(this.menuStripOfCalcVMA);
            // 
            // panelShowVMA.Panel2
            // 
            this.panelShowVMA.Panel2.Controls.Add(this.tableLayoutPanelChooseFunction);
            this.panelShowVMA.Size = new System.Drawing.Size(663, 444);
            this.panelShowVMA.SplitterDistance = 105;
            this.panelShowVMA.TabIndex = 1;
            // 
            // textBoxShowResultVMA
            // 
            this.textBoxShowResultVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxShowResultVMA.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxShowResultVMA.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShowResultVMA.Location = new System.Drawing.Point(0, 27);
            this.textBoxShowResultVMA.Multiline = true;
            this.textBoxShowResultVMA.Name = "textBoxShowResultVMA";
            this.textBoxShowResultVMA.ReadOnly = true;
            this.textBoxShowResultVMA.Size = new System.Drawing.Size(663, 79);
            this.textBoxShowResultVMA.TabIndex = 1;
            this.textBoxShowResultVMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxShowResultVMA.TextChanged += new System.EventHandler(this.textBoxShowResultVMA_TextChanged);
            // 
            // menuStripOfCalcVMA
            // 
            this.menuStripOfCalcVMA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStripOfCalcVMA.Location = new System.Drawing.Point(0, 0);
            this.menuStripOfCalcVMA.Name = "menuStripOfCalcVMA";
            this.menuStripOfCalcVMA.Size = new System.Drawing.Size(663, 24);
            this.menuStripOfCalcVMA.TabIndex = 0;
            this.menuStripOfCalcVMA.Text = "menuStrip1";
            // 
            // типToolStripMenuItem
            // 
            this.типToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйToolStripMenuItem,
            this.инженерныйToolStripMenuItem,
            this.переводЕдиницToolStripMenuItem,
            this.нормаВодыToolStripMenuItem});
            this.типToolStripMenuItem.Name = "типToolStripMenuItem";
            this.типToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.типToolStripMenuItem.Text = "Вид";
            // 
            // обычныйToolStripMenuItem
            // 
            this.обычныйToolStripMenuItem.Name = "обычныйToolStripMenuItem";
            this.обычныйToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.обычныйToolStripMenuItem.Text = "Стандартный";
            this.обычныйToolStripMenuItem.Click += new System.EventHandler(this.обычныйToolStripMenuItem_Click);
            // 
            // инженерныйToolStripMenuItem
            // 
            this.инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            this.инженерныйToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.инженерныйToolStripMenuItem.Text = "Расширенный";
            this.инженерныйToolStripMenuItem.Click += new System.EventHandler(this.инженерныйToolStripMenuItem_Click);
            // 
            // переводЕдиницToolStripMenuItem
            // 
            this.переводЕдиницToolStripMenuItem.Name = "переводЕдиницToolStripMenuItem";
            this.переводЕдиницToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.переводЕдиницToolStripMenuItem.Text = "Перевод единиц";
            this.переводЕдиницToolStripMenuItem.Click += new System.EventHandler(this.переводЕдиницToolStripMenuItem_Click);
            // 
            // нормаВодыToolStripMenuItem
            // 
            this.нормаВодыToolStripMenuItem.Name = "нормаВодыToolStripMenuItem";
            this.нормаВодыToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.нормаВодыToolStripMenuItem.Text = "Норма воды";
            this.нормаВодыToolStripMenuItem.Click += new System.EventHandler(this.нормаВодыToolStripMenuItem_Click_1);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // tableLayoutPanelChooseFunction
            // 
            this.tableLayoutPanelChooseFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanelChooseFunction.ColumnCount = 7;
            this.tableLayoutPanelChooseFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelChooseFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelChooseFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelChooseFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelChooseFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelChooseFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelChooseFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindFactorial, 5, 3);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindTn, 6, 2);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindExp, 5, 2);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindSin, 6, 1);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindPi, 5, 1);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindCos, 6, 0);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindLogarithm, 5, 0);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonClear, 4, 0);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonOperationMultyplycation, 3, 2);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonSixVMA, 2, 2);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFiveVMA, 1, 2);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFourVMA, 0, 2);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonOperationQuotient, 3, 1);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonNineVMA, 2, 1);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonEightVMA, 1, 1);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonSevenVMA, 0, 1);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindReciprocal, 2, 0);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindSquarrel, 1, 0);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonThreeVMA, 2, 3);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonTwoVMA, 1, 3);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonZeroVMA, 1, 4);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonOneVMA, 0, 3);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonPoint, 2, 4);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindSqrt, 3, 0);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonChangeSignVMA, 0, 4);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindPowerOfNumbers, 5, 4);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindPowerOfTen, 6, 4);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonOperationResult, 4, 3);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonFindAbs, 6, 3);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonOperationSumma, 3, 4);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonOperationDifference, 3, 3);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonOperationPercent, 0, 0);
            this.tableLayoutPanelChooseFunction.Controls.Add(this.buttonClearAll, 4, 1);
            this.tableLayoutPanelChooseFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChooseFunction.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelChooseFunction.MinimumSize = new System.Drawing.Size(90, 67);
            this.tableLayoutPanelChooseFunction.Name = "tableLayoutPanelChooseFunction";
            this.tableLayoutPanelChooseFunction.RowCount = 5;
            this.tableLayoutPanelChooseFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.5873F));
            this.tableLayoutPanelChooseFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.4127F));
            this.tableLayoutPanelChooseFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanelChooseFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanelChooseFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelChooseFunction.Size = new System.Drawing.Size(663, 335);
            this.tableLayoutPanelChooseFunction.TabIndex = 1;
            // 
            // buttonFindFactorial
            // 
            this.buttonFindFactorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindFactorial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindFactorial.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindFactorial.Location = new System.Drawing.Point(473, 204);
            this.buttonFindFactorial.Name = "buttonFindFactorial";
            this.buttonFindFactorial.Size = new System.Drawing.Size(88, 62);
            this.buttonFindFactorial.TabIndex = 65;
            this.buttonFindFactorial.Text = "x!";
            this.buttonFindFactorial.UseVisualStyleBackColor = false;
            // 
            // buttonFindTn
            // 
            this.buttonFindTn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindTn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindTn.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindTn.Location = new System.Drawing.Point(567, 137);
            this.buttonFindTn.Name = "buttonFindTn";
            this.buttonFindTn.Size = new System.Drawing.Size(93, 61);
            this.buttonFindTn.TabIndex = 60;
            this.buttonFindTn.Text = "Tn(x)";
            this.buttonFindTn.UseVisualStyleBackColor = false;
            // 
            // buttonFindExp
            // 
            this.buttonFindExp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindExp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindExp.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindExp.Location = new System.Drawing.Point(473, 137);
            this.buttonFindExp.Name = "buttonFindExp";
            this.buttonFindExp.Size = new System.Drawing.Size(88, 61);
            this.buttonFindExp.TabIndex = 59;
            this.buttonFindExp.Text = "Exp(x)";
            this.buttonFindExp.UseVisualStyleBackColor = false;
            // 
            // buttonFindSin
            // 
            this.buttonFindSin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindSin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindSin.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindSin.Location = new System.Drawing.Point(567, 72);
            this.buttonFindSin.Name = "buttonFindSin";
            this.buttonFindSin.Size = new System.Drawing.Size(93, 59);
            this.buttonFindSin.TabIndex = 57;
            this.buttonFindSin.Text = "Sin(x)";
            this.buttonFindSin.UseVisualStyleBackColor = false;
            // 
            // buttonFindPi
            // 
            this.buttonFindPi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindPi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindPi.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindPi.Location = new System.Drawing.Point(473, 72);
            this.buttonFindPi.Name = "buttonFindPi";
            this.buttonFindPi.Size = new System.Drawing.Size(88, 59);
            this.buttonFindPi.TabIndex = 56;
            this.buttonFindPi.Text = "Pi";
            this.buttonFindPi.UseVisualStyleBackColor = false;
            // 
            // buttonFindCos
            // 
            this.buttonFindCos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindCos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindCos.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindCos.Location = new System.Drawing.Point(567, 3);
            this.buttonFindCos.Name = "buttonFindCos";
            this.buttonFindCos.Size = new System.Drawing.Size(93, 63);
            this.buttonFindCos.TabIndex = 54;
            this.buttonFindCos.Text = "Cos(x)";
            this.buttonFindCos.UseVisualStyleBackColor = false;
            // 
            // buttonFindLogarithm
            // 
            this.buttonFindLogarithm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindLogarithm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindLogarithm.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindLogarithm.Location = new System.Drawing.Point(473, 3);
            this.buttonFindLogarithm.Name = "buttonFindLogarithm";
            this.buttonFindLogarithm.Size = new System.Drawing.Size(88, 63);
            this.buttonFindLogarithm.TabIndex = 53;
            this.buttonFindLogarithm.Text = "Ln(x)";
            this.buttonFindLogarithm.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonClear.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(379, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(88, 63);
            this.buttonClear.TabIndex = 52;
            this.buttonClear.Text = "←";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonOperationMultyplycation
            // 
            this.buttonOperationMultyplycation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOperationMultyplycation.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOperationMultyplycation.Font = new System.Drawing.Font("MS Gothic", 20.25F);
            this.buttonOperationMultyplycation.Location = new System.Drawing.Point(285, 137);
            this.buttonOperationMultyplycation.Name = "buttonOperationMultyplycation";
            this.buttonOperationMultyplycation.Size = new System.Drawing.Size(88, 61);
            this.buttonOperationMultyplycation.TabIndex = 42;
            this.buttonOperationMultyplycation.Text = "×";
            this.buttonOperationMultyplycation.UseVisualStyleBackColor = false;
            // 
            // buttonSixVMA
            // 
            this.buttonSixVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSixVMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSixVMA.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSixVMA.Location = new System.Drawing.Point(191, 137);
            this.buttonSixVMA.Name = "buttonSixVMA";
            this.buttonSixVMA.Size = new System.Drawing.Size(88, 61);
            this.buttonSixVMA.TabIndex = 41;
            this.buttonSixVMA.Text = "6";
            this.buttonSixVMA.UseVisualStyleBackColor = false;
            // 
            // buttonFiveVMA
            // 
            this.buttonFiveVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFiveVMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFiveVMA.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiveVMA.Location = new System.Drawing.Point(97, 137);
            this.buttonFiveVMA.Name = "buttonFiveVMA";
            this.buttonFiveVMA.Size = new System.Drawing.Size(88, 61);
            this.buttonFiveVMA.TabIndex = 40;
            this.buttonFiveVMA.Text = "5";
            this.buttonFiveVMA.UseVisualStyleBackColor = false;
            // 
            // buttonFourVMA
            // 
            this.buttonFourVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFourVMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFourVMA.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFourVMA.Location = new System.Drawing.Point(3, 137);
            this.buttonFourVMA.Name = "buttonFourVMA";
            this.buttonFourVMA.Size = new System.Drawing.Size(88, 61);
            this.buttonFourVMA.TabIndex = 39;
            this.buttonFourVMA.Text = "4";
            this.buttonFourVMA.UseVisualStyleBackColor = false;
            // 
            // buttonOperationQuotient
            // 
            this.buttonOperationQuotient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOperationQuotient.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOperationQuotient.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperationQuotient.Location = new System.Drawing.Point(285, 72);
            this.buttonOperationQuotient.Name = "buttonOperationQuotient";
            this.buttonOperationQuotient.Size = new System.Drawing.Size(88, 59);
            this.buttonOperationQuotient.TabIndex = 35;
            this.buttonOperationQuotient.Text = "÷";
            this.buttonOperationQuotient.UseVisualStyleBackColor = false;
            // 
            // buttonNineVMA
            // 
            this.buttonNineVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNineVMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonNineVMA.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNineVMA.Location = new System.Drawing.Point(191, 72);
            this.buttonNineVMA.Name = "buttonNineVMA";
            this.buttonNineVMA.Size = new System.Drawing.Size(88, 59);
            this.buttonNineVMA.TabIndex = 34;
            this.buttonNineVMA.Text = "9";
            this.buttonNineVMA.UseVisualStyleBackColor = false;
            // 
            // buttonEightVMA
            // 
            this.buttonEightVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEightVMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonEightVMA.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEightVMA.Location = new System.Drawing.Point(97, 72);
            this.buttonEightVMA.Name = "buttonEightVMA";
            this.buttonEightVMA.Size = new System.Drawing.Size(88, 59);
            this.buttonEightVMA.TabIndex = 33;
            this.buttonEightVMA.Text = "8";
            this.buttonEightVMA.UseVisualStyleBackColor = false;
            // 
            // buttonSevenVMA
            // 
            this.buttonSevenVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSevenVMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSevenVMA.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSevenVMA.Location = new System.Drawing.Point(3, 72);
            this.buttonSevenVMA.Name = "buttonSevenVMA";
            this.buttonSevenVMA.Size = new System.Drawing.Size(88, 59);
            this.buttonSevenVMA.TabIndex = 32;
            this.buttonSevenVMA.Text = "7";
            this.buttonSevenVMA.UseVisualStyleBackColor = false;
            // 
            // buttonFindReciprocal
            // 
            this.buttonFindReciprocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindReciprocal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindReciprocal.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindReciprocal.Location = new System.Drawing.Point(191, 3);
            this.buttonFindReciprocal.Name = "buttonFindReciprocal";
            this.buttonFindReciprocal.Size = new System.Drawing.Size(88, 63);
            this.buttonFindReciprocal.TabIndex = 27;
            this.buttonFindReciprocal.Text = "⅟x";
            this.buttonFindReciprocal.UseVisualStyleBackColor = false;
            // 
            // buttonFindSquarrel
            // 
            this.buttonFindSquarrel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindSquarrel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindSquarrel.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindSquarrel.Location = new System.Drawing.Point(97, 3);
            this.buttonFindSquarrel.Name = "buttonFindSquarrel";
            this.buttonFindSquarrel.Size = new System.Drawing.Size(88, 63);
            this.buttonFindSquarrel.TabIndex = 26;
            this.buttonFindSquarrel.Text = " x²";
            this.buttonFindSquarrel.UseVisualStyleBackColor = false;
            // 
            // buttonThreeVMA
            // 
            this.buttonThreeVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThreeVMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonThreeVMA.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThreeVMA.Location = new System.Drawing.Point(191, 204);
            this.buttonThreeVMA.Name = "buttonThreeVMA";
            this.buttonThreeVMA.Size = new System.Drawing.Size(88, 62);
            this.buttonThreeVMA.TabIndex = 24;
            this.buttonThreeVMA.Text = "3";
            this.buttonThreeVMA.UseVisualStyleBackColor = false;
            // 
            // buttonTwoVMA
            // 
            this.buttonTwoVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTwoVMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonTwoVMA.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwoVMA.Location = new System.Drawing.Point(97, 204);
            this.buttonTwoVMA.Name = "buttonTwoVMA";
            this.buttonTwoVMA.Size = new System.Drawing.Size(88, 62);
            this.buttonTwoVMA.TabIndex = 23;
            this.buttonTwoVMA.Text = "2";
            this.buttonTwoVMA.UseVisualStyleBackColor = false;
            // 
            // buttonZeroVMA
            // 
            this.buttonZeroVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZeroVMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonZeroVMA.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZeroVMA.Location = new System.Drawing.Point(97, 272);
            this.buttonZeroVMA.Name = "buttonZeroVMA";
            this.buttonZeroVMA.Size = new System.Drawing.Size(88, 60);
            this.buttonZeroVMA.TabIndex = 0;
            this.buttonZeroVMA.Text = "0";
            this.buttonZeroVMA.UseVisualStyleBackColor = false;
            this.buttonZeroVMA.Click += new System.EventHandler(this.buttonZeroVMA_Click);
            // 
            // buttonOneVMA
            // 
            this.buttonOneVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOneVMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOneVMA.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOneVMA.Location = new System.Drawing.Point(3, 204);
            this.buttonOneVMA.Name = "buttonOneVMA";
            this.buttonOneVMA.Size = new System.Drawing.Size(88, 62);
            this.buttonOneVMA.TabIndex = 1;
            this.buttonOneVMA.Text = "1";
            this.buttonOneVMA.UseVisualStyleBackColor = false;
            this.buttonOneVMA.Click += new System.EventHandler(this.buttonOneVMA_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPoint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonPoint.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoint.Location = new System.Drawing.Point(191, 272);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(88, 60);
            this.buttonPoint.TabIndex = 50;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = false;
            // 
            // buttonFindSqrt
            // 
            this.buttonFindSqrt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindSqrt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindSqrt.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindSqrt.Location = new System.Drawing.Point(285, 3);
            this.buttonFindSqrt.Name = "buttonFindSqrt";
            this.buttonFindSqrt.Size = new System.Drawing.Size(88, 63);
            this.buttonFindSqrt.TabIndex = 25;
            this.buttonFindSqrt.Text = "√";
            this.buttonFindSqrt.UseVisualStyleBackColor = false;
            // 
            // buttonChangeSignVMA
            // 
            this.buttonChangeSignVMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeSignVMA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonChangeSignVMA.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeSignVMA.Location = new System.Drawing.Point(3, 272);
            this.buttonChangeSignVMA.Name = "buttonChangeSignVMA";
            this.buttonChangeSignVMA.Size = new System.Drawing.Size(88, 60);
            this.buttonChangeSignVMA.TabIndex = 58;
            this.buttonChangeSignVMA.Text = "±";
            this.buttonChangeSignVMA.UseVisualStyleBackColor = false;
            // 
            // buttonFindPowerOfNumbers
            // 
            this.buttonFindPowerOfNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindPowerOfNumbers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindPowerOfNumbers.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindPowerOfNumbers.Location = new System.Drawing.Point(473, 272);
            this.buttonFindPowerOfNumbers.Name = "buttonFindPowerOfNumbers";
            this.buttonFindPowerOfNumbers.Size = new System.Drawing.Size(88, 60);
            this.buttonFindPowerOfNumbers.TabIndex = 62;
            this.buttonFindPowerOfNumbers.Text = "x^n";
            this.buttonFindPowerOfNumbers.UseVisualStyleBackColor = false;
            // 
            // buttonFindPowerOfTen
            // 
            this.buttonFindPowerOfTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindPowerOfTen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindPowerOfTen.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindPowerOfTen.Location = new System.Drawing.Point(567, 272);
            this.buttonFindPowerOfTen.Name = "buttonFindPowerOfTen";
            this.buttonFindPowerOfTen.Size = new System.Drawing.Size(93, 60);
            this.buttonFindPowerOfTen.TabIndex = 63;
            this.buttonFindPowerOfTen.Text = "x^10";
            this.buttonFindPowerOfTen.UseVisualStyleBackColor = false;
            // 
            // buttonOperationResult
            // 
            this.buttonOperationResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOperationResult.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOperationResult.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperationResult.Location = new System.Drawing.Point(379, 204);
            this.buttonOperationResult.Name = "buttonOperationResult";
            this.buttonOperationResult.Size = new System.Drawing.Size(88, 62);
            this.buttonOperationResult.TabIndex = 61;
            this.buttonOperationResult.Text = "=";
            this.buttonOperationResult.UseVisualStyleBackColor = false;
            // 
            // buttonFindAbs
            // 
            this.buttonFindAbs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindAbs.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFindAbs.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindAbs.Location = new System.Drawing.Point(567, 204);
            this.buttonFindAbs.Name = "buttonFindAbs";
            this.buttonFindAbs.Size = new System.Drawing.Size(93, 62);
            this.buttonFindAbs.TabIndex = 64;
            this.buttonFindAbs.Text = "|x|";
            this.buttonFindAbs.UseVisualStyleBackColor = false;
            // 
            // buttonOperationSumma
            // 
            this.buttonOperationSumma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOperationSumma.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOperationSumma.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperationSumma.Location = new System.Drawing.Point(285, 272);
            this.buttonOperationSumma.Name = "buttonOperationSumma";
            this.buttonOperationSumma.Size = new System.Drawing.Size(88, 60);
            this.buttonOperationSumma.TabIndex = 46;
            this.buttonOperationSumma.Text = "+";
            this.buttonOperationSumma.UseVisualStyleBackColor = false;
            // 
            // buttonOperationDifference
            // 
            this.buttonOperationDifference.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOperationDifference.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOperationDifference.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperationDifference.Location = new System.Drawing.Point(285, 204);
            this.buttonOperationDifference.Name = "buttonOperationDifference";
            this.buttonOperationDifference.Size = new System.Drawing.Size(88, 62);
            this.buttonOperationDifference.TabIndex = 51;
            this.buttonOperationDifference.Text = "-";
            this.buttonOperationDifference.UseVisualStyleBackColor = false;
            // 
            // buttonOperationPercent
            // 
            this.buttonOperationPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOperationPercent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOperationPercent.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperationPercent.Location = new System.Drawing.Point(3, 3);
            this.buttonOperationPercent.Name = "buttonOperationPercent";
            this.buttonOperationPercent.Size = new System.Drawing.Size(88, 63);
            this.buttonOperationPercent.TabIndex = 55;
            this.buttonOperationPercent.Text = "%";
            this.buttonOperationPercent.UseVisualStyleBackColor = false;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearAll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonClearAll.Font = new System.Drawing.Font("MS Gothic", 20.25F);
            this.buttonClearAll.Location = new System.Drawing.Point(379, 72);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(88, 59);
            this.buttonClearAll.TabIndex = 28;
            this.buttonClearAll.Text = "C";
            this.buttonClearAll.UseVisualStyleBackColor = false;
            // 
            // MainFormVMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 444);
            this.Controls.Add(this.panelShowVMA);
            this.MainMenuStrip = this.menuStripOfCalcVMA;
            this.Name = "MainFormVMA";
            this.Text = "Калькулятор| Важенина М. А. МКМб 22-1";
            this.Load += new System.EventHandler(this.MainFormVMA_Load);
            this.panelShowVMA.Panel1.ResumeLayout(false);
            this.panelShowVMA.Panel1.PerformLayout();
            this.panelShowVMA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelShowVMA)).EndInit();
            this.panelShowVMA.ResumeLayout(false);
            this.menuStripOfCalcVMA.ResumeLayout(false);
            this.menuStripOfCalcVMA.PerformLayout();
            this.tableLayoutPanelChooseFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer panelShowVMA;
        private System.Windows.Forms.MenuStrip menuStripOfCalcVMA;
        private System.Windows.Forms.ToolStripMenuItem типToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инженерныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переводЕдиницToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нормаВодыToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxShowResultVMA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChooseFunction;
        private System.Windows.Forms.Button buttonZeroVMA;
        private System.Windows.Forms.Button buttonOneVMA;
        private System.Windows.Forms.Button buttonThreeVMA;
        private System.Windows.Forms.Button buttonTwoVMA;
        private System.Windows.Forms.Button buttonOperationSumma;
        private System.Windows.Forms.Button buttonOperationMultyplycation;
        private System.Windows.Forms.Button buttonSixVMA;
        private System.Windows.Forms.Button buttonFiveVMA;
        private System.Windows.Forms.Button buttonFourVMA;
        private System.Windows.Forms.Button buttonOperationQuotient;
        private System.Windows.Forms.Button buttonNineVMA;
        private System.Windows.Forms.Button buttonEightVMA;
        private System.Windows.Forms.Button buttonSevenVMA;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonFindReciprocal;
        private System.Windows.Forms.Button buttonFindSquarrel;
        private System.Windows.Forms.Button buttonFindSqrt;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonOperationDifference;
        private System.Windows.Forms.Button buttonOperationPercent;
        private System.Windows.Forms.Button buttonFindCos;
        private System.Windows.Forms.Button buttonFindLogarithm;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonFindPowerOfTen;
        private System.Windows.Forms.Button buttonFindPowerOfNumbers;
        private System.Windows.Forms.Button buttonOperationResult;
        private System.Windows.Forms.Button buttonFindTn;
        private System.Windows.Forms.Button buttonFindExp;
        private System.Windows.Forms.Button buttonChangeSignVMA;
        private System.Windows.Forms.Button buttonFindSin;
        private System.Windows.Forms.Button buttonFindPi;
        private System.Windows.Forms.Button buttonFindFactorial;
        private System.Windows.Forms.Button buttonFindAbs;
    }
}

