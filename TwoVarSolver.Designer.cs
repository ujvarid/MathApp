namespace MathApp
{
    partial class TwoVarSolver
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            TwoVarLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            constant2TextBox = new TextBox();
            y2TextBox = new TextBox();
            x2TextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            x1TextBox = new TextBox();
            y1TextBox = new TextBox();
            constant1TextBox = new TextBox();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            yValueTextBox = new TextBox();
            xValueTextBox = new TextBox();
            SolveBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel1.Controls.Add(TwoVarLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(SolveBtn, 0, 5);
            tableLayoutPanel1.Location = new Point(10, 9);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.3289471F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.67105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 258F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(804, 569);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.0448074F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.9551926F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 306F));
            tableLayoutPanel4.Controls.Add(label6, 2, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 443);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(798, 61);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(615, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 1;
            label6.Text = "value of y";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(113, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 0;
            label5.Text = "value of x";
            // 
            // TwoVarLabel
            // 
            TwoVarLabel.Anchor = AnchorStyles.Bottom;
            TwoVarLabel.AutoSize = true;
            TwoVarLabel.Font = new Font("Segoe UI", 15F);
            TwoVarLabel.Location = new Point(269, 3);
            TwoVarLabel.Name = "TwoVarLabel";
            TwoVarLabel.Size = new Size(265, 28);
            TwoVarLabel.TabIndex = 0;
            TwoVarLabel.Text = "Two Variable Equation Solver";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.4827576F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.5172424F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 167F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 177F));
            tableLayoutPanel2.Controls.Add(constant2TextBox, 4, 2);
            tableLayoutPanel2.Controls.Add(y2TextBox, 2, 2);
            tableLayoutPanel2.Controls.Add(x2TextBox, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 1, 2);
            tableLayoutPanel2.Controls.Add(label4, 3, 2);
            tableLayoutPanel2.Controls.Add(label2, 3, 0);
            tableLayoutPanel2.Controls.Add(x1TextBox, 0, 0);
            tableLayoutPanel2.Controls.Add(y1TextBox, 2, 0);
            tableLayoutPanel2.Controls.Add(constant1TextBox, 4, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 125);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 86.3354F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6645966F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(798, 242);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // constant2TextBox
            // 
            constant2TextBox.Anchor = AnchorStyles.Bottom;
            constant2TextBox.Location = new Point(654, 196);
            constant2TextBox.Margin = new Padding(3, 2, 3, 2);
            constant2TextBox.Name = "constant2TextBox";
            constant2TextBox.Size = new Size(110, 23);
            constant2TextBox.TabIndex = 5;
            constant2TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // y2TextBox
            // 
            y2TextBox.Anchor = AnchorStyles.Bottom;
            y2TextBox.Location = new Point(316, 196);
            y2TextBox.Margin = new Padding(3, 2, 3, 2);
            y2TextBox.Name = "y2TextBox";
            y2TextBox.Size = new Size(110, 23);
            y2TextBox.TabIndex = 4;
            y2TextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // x2TextBox
            // 
            x2TextBox.Anchor = AnchorStyles.Bottom;
            x2TextBox.Location = new Point(26, 196);
            x2TextBox.Margin = new Padding(3, 2, 3, 2);
            x2TextBox.Name = "x2TextBox";
            x2TextBox.Size = new Size(121, 23);
            x2TextBox.TabIndex = 3;
            x2TextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(176, 196);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 4;
            label3.Text = "x        +";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(456, 196);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 5;
            label4.Text = "y                      =";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(456, 107);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 4;
            label2.Text = "y                      =";
            // 
            // x1TextBox
            // 
            x1TextBox.Anchor = AnchorStyles.Bottom;
            x1TextBox.Location = new Point(26, 107);
            x1TextBox.Margin = new Padding(3, 2, 3, 2);
            x1TextBox.Name = "x1TextBox";
            x1TextBox.Size = new Size(121, 23);
            x1TextBox.TabIndex = 0;
            x1TextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // y1TextBox
            // 
            y1TextBox.Anchor = AnchorStyles.Bottom;
            y1TextBox.Location = new Point(316, 107);
            y1TextBox.Margin = new Padding(3, 2, 3, 2);
            y1TextBox.Name = "y1TextBox";
            y1TextBox.Size = new Size(110, 23);
            y1TextBox.TabIndex = 1;
            y1TextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // constant1TextBox
            // 
            constant1TextBox.Anchor = AnchorStyles.Bottom;
            constant1TextBox.Location = new Point(654, 107);
            constant1TextBox.Margin = new Padding(3, 2, 3, 2);
            constant1TextBox.Name = "constant1TextBox";
            constant1TextBox.Size = new Size(110, 23);
            constant1TextBox.TabIndex = 2;
            constant1TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(176, 107);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 3;
            label1.Text = "x        +";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.85124F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.14876F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 305F));
            tableLayoutPanel3.Controls.Add(yValueTextBox, 2, 0);
            tableLayoutPanel3.Controls.Add(xValueTextBox, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 384);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(798, 53);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // yValueTextBox
            // 
            yValueTextBox.Anchor = AnchorStyles.Bottom;
            yValueTextBox.Location = new Point(595, 27);
            yValueTextBox.Name = "yValueTextBox";
            yValueTextBox.ReadOnly = true;
            yValueTextBox.Size = new Size(100, 23);
            yValueTextBox.TabIndex = 7;
            yValueTextBox.TabStop = false;
            yValueTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // xValueTextBox
            // 
            xValueTextBox.Anchor = AnchorStyles.Bottom;
            xValueTextBox.Location = new Point(92, 27);
            xValueTextBox.Name = "xValueTextBox";
            xValueTextBox.ReadOnly = true;
            xValueTextBox.Size = new Size(100, 23);
            xValueTextBox.TabIndex = 6;
            xValueTextBox.TabStop = false;
            xValueTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SolveBtn
            // 
            SolveBtn.Anchor = AnchorStyles.Bottom;
            SolveBtn.Font = new Font("Segoe UI", 12F);
            SolveBtn.Location = new Point(364, 513);
            SolveBtn.Name = "SolveBtn";
            SolveBtn.Size = new Size(75, 32);
            SolveBtn.TabIndex = 8;
            SolveBtn.Text = "Solve it!";
            SolveBtn.UseVisualStyleBackColor = true;
            SolveBtn.Click += SolveBtn_Click;
            // 
            // TwoVarSolver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 695);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TwoVarSolver";
            Text = "TwoVarSolver";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label TwoVarLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox x1TextBox;
        private TextBox y1TextBox;
        private TextBox constant1TextBox;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox constant2TextBox;
        private TextBox y2TextBox;
        private TextBox x2TextBox;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox yValueTextBox;
        private TextBox xValueTextBox;
        private Button SolveBtn;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private Label label5;
    }
}