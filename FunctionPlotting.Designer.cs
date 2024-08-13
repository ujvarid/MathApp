namespace MathApp
{
    partial class FunctionPlotting
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            button2 = new Button();
            PlotBtn = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(12, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 522);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Location = new Point(280, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
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
            // PlotBtn
            // 
            PlotBtn.Anchor = AnchorStyles.Bottom;
            PlotBtn.Location = new Point(363, 117);
            PlotBtn.Name = "PlotBtn";
            PlotBtn.Size = new Size(75, 23);
            PlotBtn.TabIndex = 9;
            PlotBtn.Text = "Plot it!";
            PlotBtn.UseVisualStyleBackColor = true;
            PlotBtn.Click += PlotBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(355, 39);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 10;
            label1.Text = "Enter a function";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(PlotBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.9230766F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.0769234F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Size = new Size(801, 143);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // FunctionPlotting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 695);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "FunctionPlotting";
            Text = "FunctionPlotting";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button button2;
        private Button PlotBtn;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}