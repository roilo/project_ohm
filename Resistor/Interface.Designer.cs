
namespace Resistor
{
    partial class Interface
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resultTempCo = new System.Windows.Forms.TextBox();
            this.resultTolerance = new System.Windows.Forms.TextBox();
            this.digit1 = new System.Windows.Forms.Label();
            this.bandDigit1 = new System.Windows.Forms.ComboBox();
            this.digit2 = new System.Windows.Forms.Label();
            this.bandDigit2 = new System.Windows.Forms.ComboBox();
            this.digit3 = new System.Windows.Forms.Label();
            this.bandDigit3 = new System.Windows.Forms.ComboBox();
            this.multiplier = new System.Windows.Forms.Label();
            this.bandMultiplier = new System.Windows.Forms.ComboBox();
            this.tolerance = new System.Windows.Forms.Label();
            this.bandTolerance = new System.Windows.Forms.ComboBox();
            this.tempCo = new System.Windows.Forms.Label();
            this.bandTempCo = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultR = new System.Windows.Forms.Label();
            this.resultT = new System.Windows.Forms.Label();
            this.resultTC = new System.Windows.Forms.Label();
            this.resultResistance = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeBands = new System.Windows.Forms.ToolStripMenuItem();
            this.fourBands = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveBands = new System.Windows.Forms.ToolStripMenuItem();
            this.sixBands = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.resultTempCo, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.resultTolerance, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.digit1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bandDigit1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.digit2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bandDigit2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.digit3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bandDigit3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.multiplier, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bandMultiplier, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tolerance, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bandTolerance, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tempCo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.bandTempCo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.resultR, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.resultT, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.resultTC, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.resultResistance, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.calculateButton, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // resultTempCo
            // 
            this.resultTempCo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resultTempCo.Location = new System.Drawing.Point(232, 367);
            this.resultTempCo.Name = "resultTempCo";
            this.resultTempCo.ReadOnly = true;
            this.resultTempCo.Size = new System.Drawing.Size(219, 26);
            this.resultTempCo.TabIndex = 19;
            // 
            // resultTolerance
            // 
            this.resultTolerance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resultTolerance.Location = new System.Drawing.Point(232, 327);
            this.resultTolerance.Name = "resultTolerance";
            this.resultTolerance.ReadOnly = true;
            this.resultTolerance.Size = new System.Drawing.Size(219, 26);
            this.resultTolerance.TabIndex = 18;
            // 
            // digit1
            // 
            this.digit1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.digit1.AutoSize = true;
            this.digit1.Location = new System.Drawing.Point(159, 10);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(67, 20);
            this.digit1.TabIndex = 3;
            this.digit1.Text = "1st Digit";
            // 
            // bandDigit1
            // 
            this.bandDigit1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bandDigit1.BackColor = System.Drawing.SystemColors.Window;
            this.bandDigit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bandDigit1.FormattingEnabled = true;
            this.bandDigit1.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.bandDigit1.Location = new System.Drawing.Point(232, 6);
            this.bandDigit1.Name = "bandDigit1";
            this.bandDigit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bandDigit1.Size = new System.Drawing.Size(219, 28);
            this.bandDigit1.TabIndex = 0;
            // 
            // digit2
            // 
            this.digit2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.digit2.AutoSize = true;
            this.digit2.Location = new System.Drawing.Point(154, 50);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(72, 20);
            this.digit2.TabIndex = 6;
            this.digit2.Text = "2nd Digit";
            // 
            // bandDigit2
            // 
            this.bandDigit2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bandDigit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bandDigit2.FormattingEnabled = true;
            this.bandDigit2.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.bandDigit2.Location = new System.Drawing.Point(232, 46);
            this.bandDigit2.Name = "bandDigit2";
            this.bandDigit2.Size = new System.Drawing.Size(219, 28);
            this.bandDigit2.TabIndex = 9;
            // 
            // digit3
            // 
            this.digit3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.digit3.AutoSize = true;
            this.digit3.Location = new System.Drawing.Point(158, 90);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(68, 20);
            this.digit3.TabIndex = 8;
            this.digit3.Text = "3rd Digit";
            // 
            // bandDigit3
            // 
            this.bandDigit3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bandDigit3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bandDigit3.FormattingEnabled = true;
            this.bandDigit3.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.bandDigit3.Location = new System.Drawing.Point(232, 86);
            this.bandDigit3.Name = "bandDigit3";
            this.bandDigit3.Size = new System.Drawing.Size(219, 28);
            this.bandDigit3.TabIndex = 10;
            // 
            // multiplier
            // 
            this.multiplier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.multiplier.AutoSize = true;
            this.multiplier.Location = new System.Drawing.Point(155, 130);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(71, 20);
            this.multiplier.TabIndex = 4;
            this.multiplier.Text = "Multiplier";
            // 
            // bandMultiplier
            // 
            this.bandMultiplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bandMultiplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bandMultiplier.FormattingEnabled = true;
            this.bandMultiplier.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White",
            "Gold",
            "Silver"});
            this.bandMultiplier.Location = new System.Drawing.Point(232, 126);
            this.bandMultiplier.Name = "bandMultiplier";
            this.bandMultiplier.Size = new System.Drawing.Size(219, 28);
            this.bandMultiplier.TabIndex = 1;
            // 
            // tolerance
            // 
            this.tolerance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tolerance.AutoSize = true;
            this.tolerance.Location = new System.Drawing.Point(147, 170);
            this.tolerance.Name = "tolerance";
            this.tolerance.Size = new System.Drawing.Size(79, 20);
            this.tolerance.TabIndex = 5;
            this.tolerance.Text = "Tolerance";
            this.tolerance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bandTolerance
            // 
            this.bandTolerance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bandTolerance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bandTolerance.FormattingEnabled = true;
            this.bandTolerance.Items.AddRange(new object[] {
            "Brown",
            "Red",
            "Gold",
            "Silver",
            "None"});
            this.bandTolerance.Location = new System.Drawing.Point(232, 166);
            this.bandTolerance.Name = "bandTolerance";
            this.bandTolerance.Size = new System.Drawing.Size(219, 28);
            this.bandTolerance.TabIndex = 2;
            // 
            // tempCo
            // 
            this.tempCo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tempCo.AutoSize = true;
            this.tempCo.Location = new System.Drawing.Point(46, 210);
            this.tempCo.Name = "tempCo";
            this.tempCo.Size = new System.Drawing.Size(180, 20);
            this.tempCo.TabIndex = 12;
            this.tempCo.Text = "Temperature Coefficient";
            this.tempCo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bandTempCo
            // 
            this.bandTempCo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bandTempCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bandTempCo.FormattingEnabled = true;
            this.bandTempCo.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Grey"});
            this.bandTempCo.Location = new System.Drawing.Point(232, 206);
            this.bandTempCo.Name = "bandTempCo";
            this.bandTempCo.Size = new System.Drawing.Size(219, 28);
            this.bandTempCo.TabIndex = 13;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.calculateButton.Location = new System.Drawing.Point(232, 244);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(219, 32);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // resultR
            // 
            this.resultR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resultR.AutoSize = true;
            this.resultR.Location = new System.Drawing.Point(137, 290);
            this.resultR.Name = "resultR";
            this.resultR.Size = new System.Drawing.Size(89, 20);
            this.resultR.TabIndex = 14;
            this.resultR.Text = "Resistance";
            // 
            // resultT
            // 
            this.resultT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resultT.AutoSize = true;
            this.resultT.Location = new System.Drawing.Point(147, 330);
            this.resultT.Name = "resultT";
            this.resultT.Size = new System.Drawing.Size(79, 20);
            this.resultT.TabIndex = 15;
            this.resultT.Text = "Tolerance";
            // 
            // resultTC
            // 
            this.resultTC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resultTC.AutoSize = true;
            this.resultTC.Location = new System.Drawing.Point(46, 370);
            this.resultTC.Name = "resultTC";
            this.resultTC.Size = new System.Drawing.Size(180, 20);
            this.resultTC.TabIndex = 16;
            this.resultTC.Text = "Temperature Coefficient";
            // 
            // resultResistance
            // 
            this.resultResistance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.resultResistance.Location = new System.Drawing.Point(232, 287);
            this.resultResistance.Name = "resultResistance";
            this.resultResistance.ReadOnly = true;
            this.resultResistance.Size = new System.Drawing.Size(219, 26);
            this.resultResistance.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bandsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bandsToolStripMenuItem
            // 
            this.bandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threeBands,
            this.fourBands,
            this.fiveBands,
            this.sixBands});
            this.bandsToolStripMenuItem.Name = "bandsToolStripMenuItem";
            this.bandsToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.bandsToolStripMenuItem.Text = "Bands";
            // 
            // threeBands
            // 
            this.threeBands.Name = "threeBands";
            this.threeBands.Size = new System.Drawing.Size(182, 34);
            this.threeBands.Text = "Three (3)";
            this.threeBands.Click += new System.EventHandler(this.ThreeBands_Click);
            // 
            // fourBands
            // 
            this.fourBands.Name = "fourBands";
            this.fourBands.Size = new System.Drawing.Size(182, 34);
            this.fourBands.Text = "Four (4)";
            this.fourBands.Click += new System.EventHandler(this.FourBands_Click);
            // 
            // fiveBands
            // 
            this.fiveBands.Name = "fiveBands";
            this.fiveBands.Size = new System.Drawing.Size(182, 34);
            this.fiveBands.Text = "Five (5)";
            this.fiveBands.Click += new System.EventHandler(this.FiveBands_Click);
            // 
            // sixBands
            // 
            this.sixBands.Name = "sixBands";
            this.sixBands.Size = new System.Drawing.Size(182, 34);
            this.sixBands.Text = "Six (6)";
            this.sixBands.Click += new System.EventHandler(this.SixBands_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Interface";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "Resistor Calculator";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label tolerance;
        private System.Windows.Forms.ComboBox bandTolerance;
        private System.Windows.Forms.ComboBox bandMultiplier;
        private System.Windows.Forms.Label multiplier;
        private System.Windows.Forms.ComboBox bandDigit3;
        private System.Windows.Forms.Label digit3;
        private System.Windows.Forms.Label digit2;
        private System.Windows.Forms.ComboBox bandDigit2;
        private System.Windows.Forms.ComboBox bandDigit1;
        private System.Windows.Forms.Label digit1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeBands;
        private System.Windows.Forms.ToolStripMenuItem fourBands;
        private System.Windows.Forms.ToolStripMenuItem fiveBands;
        private System.Windows.Forms.ToolStripMenuItem sixBands;
        private System.Windows.Forms.Label tempCo;
        private System.Windows.Forms.ComboBox bandTempCo;
        private System.Windows.Forms.TextBox resultTempCo;
        private System.Windows.Forms.TextBox resultTolerance;
        private System.Windows.Forms.Label resultR;
        private System.Windows.Forms.Label resultT;
        private System.Windows.Forms.Label resultTC;
        private System.Windows.Forms.TextBox resultResistance;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}