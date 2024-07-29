namespace MathApp
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            EqSolBtn.Left = (this.ClientSize.Width - EqSolBtn.Width) / 2;
            EqSolBtn.Top = label1.Bottom + 20;

            // Center button1
            MtClcBtn.Left = (this.ClientSize.Width - EqSolBtn.Width) / 2;
            MtClcBtn.Top = MtClcBtn.Bottom + 20;
        }

        private void ResizeControls()
        {
            // Resize controls based on form size
            float scaleFactorX = (float)this.ClientSize.Width / 891;
            float scaleFactorY = (float)this.ClientSize.Height / 879;

            label1.Font = new Font(label1.Font.FontFamily, 12 * scaleFactorY);
            EqSolBtn.Font = new Font(EqSolBtn.Font.FontFamily, 10 * scaleFactorY);
            MtClcBtn.Font = new Font(MtClcBtn.Font.FontFamily, 10 * scaleFactorY);

            label1.Size = new Size((int)(200 * scaleFactorX), (int)(20 * scaleFactorY));
            EqSolBtn.Size = new Size((int)(86 * scaleFactorX), (int)(31 * scaleFactorY));
            MtClcBtn.Size = new Size((int)(86 * scaleFactorX), (int)(31 * scaleFactorY));

            CenterControls();
        }

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            EqSolBtn = new Button();
            MtClcBtn = new Button();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(316, 127);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome to MathApp";
            // 
            // EqSolBtn
            // 
            EqSolBtn.Location = new Point(330, 271);
            EqSolBtn.Margin = new Padding(3, 2, 3, 2);
            EqSolBtn.Name = "EqSolBtn";
            EqSolBtn.Size = new Size(179, 39);
            EqSolBtn.TabIndex = 1;
            EqSolBtn.Text = "Equation Solver";
            EqSolBtn.UseVisualStyleBackColor = true;
            EqSolBtn.Click += EqSolBtn_Click;
            // 
            // MtClcBtn
            // 
            MtClcBtn.Location = new Point(330, 330);
            MtClcBtn.Margin = new Padding(3, 2, 3, 2);
            MtClcBtn.Name = "MtClcBtn";
            MtClcBtn.Size = new Size(179, 39);
            MtClcBtn.TabIndex = 2;
            MtClcBtn.Text = "Matrix Calculator";
            MtClcBtn.UseVisualStyleBackColor = true;
            MtClcBtn.Click += MtClcBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(761, 11);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(54, 22);
            button3.TabIndex = 6;
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
            button2.TabIndex = 7;
            button2.TabStop = false;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 697);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(MtClcBtn);
            Controls.Add(EqSolBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button EqSolBtn;
        private Button MtClcBtn;
        private Button button3;
        private Button button2;
    }
}
