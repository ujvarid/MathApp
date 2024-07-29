namespace MathApp
{
    partial class MatrixCalculator
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
            button2 = new Button();
            button3 = new Button();
            DetermBtn = new Button();
            TrpBtn = new Button();
            InvBtn = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(65, 24);
            button2.TabIndex = 8;
            button2.TabStop = false;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(762, 11);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(54, 22);
            button3.TabIndex = 9;
            button3.TabStop = false;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DetermBtn
            // 
            DetermBtn.Location = new Point(336, 381);
            DetermBtn.Name = "DetermBtn";
            DetermBtn.Size = new Size(164, 23);
            DetermBtn.TabIndex = 19;
            DetermBtn.Text = "Calculate determinant";
            DetermBtn.UseVisualStyleBackColor = true;
            DetermBtn.Click += DetermBtn_Click;
            // 
            // TrpBtn
            // 
            TrpBtn.Location = new Point(336, 410);
            TrpBtn.Name = "TrpBtn";
            TrpBtn.Size = new Size(164, 23);
            TrpBtn.TabIndex = 20;
            TrpBtn.Text = "Transpose the matrix";
            TrpBtn.UseVisualStyleBackColor = true;
            TrpBtn.Click += TrpBtn_Click;
            // 
            // InvBtn
            // 
            InvBtn.Location = new Point(336, 439);
            InvBtn.Name = "InvBtn";
            InvBtn.Size = new Size(164, 23);
            InvBtn.TabIndex = 21;
            InvBtn.Text = "Inverse the matrix";
            InvBtn.UseVisualStyleBackColor = true;
            InvBtn.Click += InvBtn_Click;
            // 
            // MatrixCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 698);
            Controls.Add(InvBtn);
            Controls.Add(TrpBtn);
            Controls.Add(DetermBtn);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "MatrixCalculator";
            Text = "MatrixCalculator";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button3;
        private Button DetermBtn;
        private Button TrpBtn;
        private Button InvBtn;
    }
}