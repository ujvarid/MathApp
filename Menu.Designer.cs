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
            //CenterControls();
            //ResizeControls();
        }

        //private void CenterControls()
        //{
        //    // Center label1
        //    //label1.Left = (this.ClientSize.Width - label1.Width) / 2;
        //    //label1.Top = (this.ClientSize.Height - label1.Height) / 3;

        //    // Center textBox1
        //    EqSolBtn.Left = (this.ClientSize.Width - EqSolBtn.Width) / 2;
        //    EqSolBtn.Top = label1.Bottom + 20;

        //    // Center button1
        //    MtClcBtn.Left = (this.ClientSize.Width - EqSolBtn.Width) / 2;
        //    MtClcBtn.Top = MtClcBtn.Bottom + 20;
        //}

        //private void ResizeControls()
        //{
        //    // Resize controls based on form size
        //    float scaleFactorX = (float)this.ClientSize.Width / 891;
        //    float scaleFactorY = (float)this.ClientSize.Height / 879;

        //    label1.Font = new Font(label1.Font.FontFamily, 12 * scaleFactorY);
        //    EqSolBtn.Font = new Font(EqSolBtn.Font.FontFamily, 10 * scaleFactorY);
        //    MtClcBtn.Font = new Font(MtClcBtn.Font.FontFamily, 10 * scaleFactorY);

        //    label1.Size = new Size((int)(200 * scaleFactorX), (int)(20 * scaleFactorY));
        //    EqSolBtn.Size = new Size((int)(86 * scaleFactorX), (int)(31 * scaleFactorY));
        //    MtClcBtn.Size = new Size((int)(86 * scaleFactorX), (int)(31 * scaleFactorY));

        //    CenterControls();
        //}

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
            EqSolBtn = new Button();
            MtClcBtn = new Button();
            button2 = new Button();
            NumAppBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            TwoVarBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // EqSolBtn
            // 
            EqSolBtn.Anchor = AnchorStyles.Top;
            EqSolBtn.Location = new Point(350, 3);
            EqSolBtn.Name = "EqSolBtn";
            EqSolBtn.Size = new Size(219, 52);
            EqSolBtn.TabIndex = 1;
            EqSolBtn.Text = "Equation Solver";
            EqSolBtn.UseVisualStyleBackColor = true;
            EqSolBtn.Click += EqSolBtn_Click;
            // 
            // MtClcBtn
            // 
            MtClcBtn.Anchor = AnchorStyles.Top;
            MtClcBtn.Location = new Point(350, 193);
            MtClcBtn.Name = "MtClcBtn";
            MtClcBtn.Size = new Size(219, 52);
            MtClcBtn.TabIndex = 3;
            MtClcBtn.Text = "Matrix Calculator";
            MtClcBtn.UseVisualStyleBackColor = true;
            MtClcBtn.Click += MtClcBtn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(14, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(74, 32);
            button2.TabIndex = 7;
            button2.TabStop = false;
            button2.Text = "Help";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NumAppBtn
            // 
            NumAppBtn.Anchor = AnchorStyles.Top;
            NumAppBtn.Location = new Point(350, 285);
            NumAppBtn.Name = "NumAppBtn";
            NumAppBtn.Size = new Size(219, 52);
            NumAppBtn.TabIndex = 4;
            NumAppBtn.Text = "Numerical Approximations";
            NumAppBtn.UseVisualStyleBackColor = true;
            NumAppBtn.Click += NumAppBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(EqSolBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(NumAppBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(MtClcBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(TwoVarBtn, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 282);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 122F));
            tableLayoutPanel1.Size = new Size(919, 405);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // TwoVarBtn
            // 
            TwoVarBtn.Anchor = AnchorStyles.Top;
            TwoVarBtn.Location = new Point(350, 98);
            TwoVarBtn.Name = "TwoVarBtn";
            TwoVarBtn.Size = new Size(219, 52);
            TwoVarBtn.TabIndex = 2;
            TwoVarBtn.Text = "Two Variable Equation Solver";
            TwoVarBtn.UseVisualStyleBackColor = true;
            TwoVarBtn.Click += TwoVarBtn_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 927);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button2);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button EqSolBtn;
        private Button MtClcBtn;
        private Button button2;
        private Button NumAppBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Button TwoVarBtn;
    }
}
