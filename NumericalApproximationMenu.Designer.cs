namespace MathApp
{
    partial class NumericalApproximationMenu
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            EBtn = new Button();
            PiBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 122);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose something to approximate";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(EBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(PiBtn, 0, 2);
            tableLayoutPanel1.Location = new Point(370, 193);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(90, 105);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // EBtn
            // 
            EBtn.Location = new Point(3, 20);
            EBtn.Margin = new Padding(3, 2, 3, 2);
            EBtn.Name = "EBtn";
            EBtn.Size = new Size(84, 28);
            EBtn.TabIndex = 0;
            EBtn.Text = "e";
            EBtn.UseVisualStyleBackColor = true;
            EBtn.Click += EBtn_Click;
            // 
            // PiBtn
            // 
            PiBtn.Location = new Point(3, 57);
            PiBtn.Margin = new Padding(3, 2, 3, 2);
            PiBtn.Name = "PiBtn";
            PiBtn.Size = new Size(84, 28);
            PiBtn.TabIndex = 1;
            PiBtn.Text = "π\r\n";
            PiBtn.UseVisualStyleBackColor = true;
            PiBtn.Click += PiBtn_Click;
            // 
            // NumericalApproximationMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 695);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NumericalApproximationMenu";
            Text = "NumericalApproximation";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button EBtn;
        private Button PiBtn;
    }
}