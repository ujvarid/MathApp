namespace EquationSolverApp
{
    partial class EquationSolver
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterControls();
            ResizeControls();
        }

        private void CenterControls()
        {
            // Center label1
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height) / 3;

            // Center textBox1
            textBox1.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            textBox1.Top = label1.Bottom + 20;

            // Center button1
            button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            button1.Top = textBox1.Bottom + 20;
        }

        private void ResizeControls()
        {
            // Resize controls based on form size
            float scaleFactorX = (float)this.ClientSize.Width / 891;
            float scaleFactorY = (float)this.ClientSize.Height / 879;

            label1.Font = new Font(label1.Font.FontFamily, 12 * scaleFactorY);
            textBox1.Font = new Font(textBox1.Font.FontFamily, 10 * scaleFactorY);
            button1.Font = new Font(button1.Font.FontFamily, 10 * scaleFactorY);
            button2.Font = new Font(button1.Font.FontFamily, 10 * scaleFactorY);

            label1.Size = new Size((int)(200 * scaleFactorX), (int)(20 * scaleFactorY));
            textBox1.Size = new Size((int)(388 * scaleFactorX), (int)(27 * scaleFactorY));
            button1.Size = new Size((int)(86 * scaleFactorX), (int)(31 * scaleFactorY));
            button2.Size = new Size((int)(86 * scaleFactorX), (int)(31 * scaleFactorY));

            CenterControls();
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(167, 359);
            button1.Name = "button1";
            button1.Size = new Size(95, 30);
            button1.TabIndex = 2;
            button1.Text = "Solve it!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Location = new Point(42, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(111, 244);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 2;
            label1.Text = "Enter an equation set to zero";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(65, 24);
            button2.TabIndex = 6;
            button2.TabStop = false;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Location = new Point(206, 9);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.57143F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4285717F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.Size = new Size(430, 392);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // EquationSolver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 695);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button2);
            Name = "EquationSolver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EquationSolver";
            Load += Form1_Load;
            Resize += Form1_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
