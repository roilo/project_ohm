
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
            this.bandDigit1 = new System.Windows.Forms.ComboBox();
            this.bandMultiplier = new System.Windows.Forms.ComboBox();
            this.bandTolerance = new System.Windows.Forms.ComboBox();
            this.digit1 = new System.Windows.Forms.Label();
            this.multiplier = new System.Windows.Forms.Label();
            this.tolerance = new System.Windows.Forms.Label();
            this.digit2 = new System.Windows.Forms.Label();
            this.digit3 = new System.Windows.Forms.Label();
            this.bandDigit2 = new System.Windows.Forms.ComboBox();
            this.bandDigit3 = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tempCoefficient = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanel1.Controls.Add(this.tolerance, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.bandTolerance, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.bandMultiplier, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.multiplier, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bandDigit3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.digit3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.digit2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bandDigit2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bandDigit1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.digit1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.calculateButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tempCoefficient, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 404);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bandDigit1
            // 
            this.bandDigit1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bandDigit1.BackColor = System.Drawing.SystemColors.Window;
            this.bandDigit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bandDigit1.FormattingEnabled = true;
            this.bandDigit1.Items.AddRange(new object[] {
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.bandDigit1.Location = new System.Drawing.Point(189, 46);
            this.bandDigit1.Name = "bandDigit1";
            this.bandDigit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bandDigit1.Size = new System.Drawing.Size(121, 28);
            this.bandDigit1.TabIndex = 0;
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
            "White"});
            this.bandMultiplier.Location = new System.Drawing.Point(189, 166);
            this.bandMultiplier.Name = "bandMultiplier";
            this.bandMultiplier.Size = new System.Drawing.Size(121, 28);
            this.bandMultiplier.TabIndex = 1;
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
            this.bandTolerance.Location = new System.Drawing.Point(189, 206);
            this.bandTolerance.Name = "bandTolerance";
            this.bandTolerance.Size = new System.Drawing.Size(121, 28);
            this.bandTolerance.TabIndex = 2;
            // 
            // digit1
            // 
            this.digit1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.digit1.AutoSize = true;
            this.digit1.Location = new System.Drawing.Point(116, 50);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(67, 20);
            this.digit1.TabIndex = 3;
            this.digit1.Text = "1st Digit";
            // 
            // multiplier
            // 
            this.multiplier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.multiplier.AutoSize = true;
            this.multiplier.Location = new System.Drawing.Point(112, 170);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(71, 20);
            this.multiplier.TabIndex = 4;
            this.multiplier.Text = "Multiplier";
            // 
            // tolerance
            // 
            this.tolerance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tolerance.AutoSize = true;
            this.tolerance.Location = new System.Drawing.Point(104, 210);
            this.tolerance.Name = "tolerance";
            this.tolerance.Size = new System.Drawing.Size(79, 20);
            this.tolerance.TabIndex = 5;
            this.tolerance.Text = "Tolerance";
            // 
            // digit2
            // 
            this.digit2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.digit2.AutoSize = true;
            this.digit2.Location = new System.Drawing.Point(111, 90);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(72, 20);
            this.digit2.TabIndex = 6;
            this.digit2.Text = "2nd Digit";
            // 
            // digit3
            // 
            this.digit3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.digit3.AutoSize = true;
            this.digit3.Location = new System.Drawing.Point(115, 130);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(68, 20);
            this.digit3.TabIndex = 8;
            this.digit3.Text = "3rd Digit";
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
            this.bandDigit2.Location = new System.Drawing.Point(189, 83);
            this.bandDigit2.Name = "bandDigit2";
            this.bandDigit2.Size = new System.Drawing.Size(121, 28);
            this.bandDigit2.TabIndex = 9;
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
            this.bandDigit3.Location = new System.Drawing.Point(189, 126);
            this.bandDigit3.Name = "bandDigit3";
            this.bandDigit3.Size = new System.Drawing.Size(121, 28);
            this.bandDigit3.TabIndex = 10;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.calculateButton, 2);
            this.calculateButton.Location = new System.Drawing.Point(136, 284);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 32);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.bandsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // bandsToolStripMenuItem
            // 
            this.bandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.bandsToolStripMenuItem.Name = "bandsToolStripMenuItem";
            this.bandsToolStripMenuItem.Size = new System.Drawing.Size(76, 32);
            this.bandsToolStripMenuItem.Text = "Bands";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem2.Text = "Three (3)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem3.Text = "Four (4)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem4.Text = "Five (5)";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem5.Text = "Six (6)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Temperature Coefficient";
            // 
            // tempCoefficient
            // 
            this.tempCoefficient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tempCoefficient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tempCoefficient.FormattingEnabled = true;
            this.tempCoefficient.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Grey"});
            this.tempCoefficient.Location = new System.Drawing.Point(189, 246);
            this.tempCoefficient.Name = "tempCoefficient";
            this.tempCoefficient.Size = new System.Drawing.Size(121, 28);
            this.tempCoefficient.TabIndex = 13;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Interface";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "Color Banded Resistor Calculator";
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tempCoefficient;
    }
}