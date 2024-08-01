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
            DetermBtn = new Button();
            TrpBtn = new Button();
            InvBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(14, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(74, 32);
            button2.TabIndex = 8;
            button2.TabStop = false;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DetermBtn
            // 
            DetermBtn.Anchor = AnchorStyles.Top;
            DetermBtn.Location = new Point(366, 4);
            DetermBtn.Margin = new Padding(3, 4, 3, 4);
            DetermBtn.Name = "DetermBtn";
            DetermBtn.Size = new Size(187, 31);
            DetermBtn.TabIndex = 19;
            DetermBtn.Text = "Calculate determinant";
            DetermBtn.UseVisualStyleBackColor = true;
            DetermBtn.Click += DetermBtn_Click;
            // 
            // TrpBtn
            // 
            TrpBtn.Anchor = AnchorStyles.Top;
            TrpBtn.Location = new Point(366, 46);
            TrpBtn.Margin = new Padding(3, 4, 3, 4);
            TrpBtn.Name = "TrpBtn";
            TrpBtn.Size = new Size(187, 31);
            TrpBtn.TabIndex = 20;
            TrpBtn.Text = "Transpose the matrix";
            TrpBtn.UseVisualStyleBackColor = true;
            TrpBtn.Click += TrpBtn_Click;
            // 
            // InvBtn
            // 
            InvBtn.Anchor = AnchorStyles.Top;
            InvBtn.Location = new Point(366, 88);
            InvBtn.Margin = new Padding(3, 4, 3, 4);
            InvBtn.Name = "InvBtn";
            InvBtn.Size = new Size(187, 31);
            InvBtn.TabIndex = 21;
            InvBtn.Text = "Inverse the matrix";
            InvBtn.UseVisualStyleBackColor = true;
            InvBtn.Click += InvBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(DetermBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(InvBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(TrpBtn, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 723);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(919, 125);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // MatrixCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 927);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MatrixCalculator";
            Text = "MatrixCalculator";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button DetermBtn;
        private Button TrpBtn;
        private Button InvBtn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}