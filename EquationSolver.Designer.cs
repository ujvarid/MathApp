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
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(379, 241);
            button1.Name = "button1";
            button1.Size = new Size(95, 37);
            button1.TabIndex = 2;
            button1.Text = "Solve it!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(305, 160);
            label1.Name = "label1";
            label1.Size = new Size(263, 28);
            label1.TabIndex = 2;
            label1.Text = "Enter an equation set to zero";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(759, 11);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(54, 22);
            button3.TabIndex = 5;
            button3.TabStop = false;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            // EquationSolver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            //BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(825, 695);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "EquationSolver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EquationSolver";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private Button button2;
    }
}
