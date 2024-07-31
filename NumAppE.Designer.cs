namespace MathApp
{
    partial class NumAppE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumAppE));
            story = new Label();
            title = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            Series2NumUpD = new NumericUpDown();
            Series2TextBox = new TextBox();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            limENumUpD = new NumericUpDown();
            limAppEValue = new TextBox();
            limELabel = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            SeriesNumUpDwn = new NumericUpDown();
            SeriesTextBox = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Series2NumUpD).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)limENumUpD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SeriesNumUpDwn).BeginInit();
            SuspendLayout();
            // 
            // story
            // 
            story.Anchor = AnchorStyles.Top;
            story.AutoSize = true;
            story.Location = new Point(85, 96);
            story.Name = "story";
            story.Size = new Size(633, 37);
            story.TabIndex = 1;
            story.Text = "The number e is a mathematical constant approximately equal to 2.71828 that can be characterized in many ways. \r\nIt is the base of the natural logarithm function. It is the limit of compound interest.";
            story.TextAlign = ContentAlignment.MiddleCenter;
            story.UseCompatibleTextRendering = true;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 12F);
            title.Location = new Point(339, 0);
            title.Name = "title";
            title.Size = new Size(125, 21);
            title.TabIndex = 0;
            title.Text = "Approximating e";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 804F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(title, 0, 0);
            tableLayoutPanel1.Controls.Add(story, 0, 1);
            tableLayoutPanel1.Location = new Point(10, 9);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            tableLayoutPanel1.Size = new Size(804, 568);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel4.Controls.Add(Series2NumUpD, 0, 1);
            tableLayoutPanel4.Controls.Add(Series2TextBox, 1, 0);
            tableLayoutPanel4.Controls.Add(label2, 1, 1);
            tableLayoutPanel4.Location = new Point(3, 453);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 68.3333359F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 31.666666F));
            tableLayoutPanel4.Size = new Size(798, 113);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(165, 73);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Series2NumUpD
            // 
            Series2NumUpD.Location = new Point(3, 79);
            Series2NumUpD.Margin = new Padding(3, 2, 3, 2);
            Series2NumUpD.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            Series2NumUpD.Name = "Series2NumUpD";
            Series2NumUpD.Size = new Size(58, 23);
            Series2NumUpD.TabIndex = 3;
            Series2NumUpD.ValueChanged += Series2NumUpD_ValueChanged;
            // 
            // Series2TextBox
            // 
            Series2TextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Series2TextBox.Location = new Point(402, 52);
            Series2TextBox.Margin = new Padding(3, 2, 3, 2);
            Series2TextBox.Name = "Series2TextBox";
            Series2TextBox.ReadOnly = true;
            Series2TextBox.Size = new Size(393, 23);
            Series2TextBox.TabIndex = 4;
            Series2TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(541, 77);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 5;
            label2.Text = "Approximated value";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(limENumUpD, 0, 1);
            tableLayoutPanel2.Controls.Add(limAppEValue, 1, 0);
            tableLayoutPanel2.Controls.Add(limELabel, 1, 1);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 178);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 81.19658F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.80342F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(798, 126);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // limENumUpD
            // 
            limENumUpD.Location = new Point(3, 97);
            limENumUpD.Margin = new Padding(3, 2, 3, 2);
            limENumUpD.Name = "limENumUpD";
            limENumUpD.Size = new Size(58, 23);
            limENumUpD.TabIndex = 3;
            limENumUpD.ValueChanged += limENumUpD_ValueChanged;
            // 
            // limAppEValue
            // 
            limAppEValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            limAppEValue.Location = new Point(402, 70);
            limAppEValue.Margin = new Padding(3, 2, 3, 2);
            limAppEValue.Name = "limAppEValue";
            limAppEValue.ReadOnly = true;
            limAppEValue.Size = new Size(393, 23);
            limAppEValue.TabIndex = 4;
            limAppEValue.TextAlign = HorizontalAlignment.Center;
            // 
            // limELabel
            // 
            limELabel.Anchor = AnchorStyles.Top;
            limELabel.AutoSize = true;
            limELabel.Location = new Point(541, 95);
            limELabel.Name = "limELabel";
            limELabel.Size = new Size(114, 15);
            limELabel.TabIndex = 5;
            limELabel.Text = "Approximated value";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 80);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel3.Controls.Add(SeriesNumUpDwn, 0, 1);
            tableLayoutPanel3.Controls.Add(SeriesTextBox, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 1, 1);
            tableLayoutPanel3.Location = new Point(3, 308);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 68.3333359F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 31.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(798, 141);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 74);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // SeriesNumUpDwn
            // 
            SeriesNumUpDwn.Location = new Point(3, 84);
            SeriesNumUpDwn.Margin = new Padding(3, 2, 3, 2);
            SeriesNumUpDwn.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            SeriesNumUpDwn.Name = "SeriesNumUpDwn";
            SeriesNumUpDwn.Size = new Size(58, 23);
            SeriesNumUpDwn.TabIndex = 3;
            SeriesNumUpDwn.ValueChanged += SeriesNumUpDwn_ValueChanged;
            // 
            // SeriesTextBox
            // 
            SeriesTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SeriesTextBox.Location = new Point(402, 57);
            SeriesTextBox.Margin = new Padding(3, 2, 3, 2);
            SeriesTextBox.Name = "SeriesTextBox";
            SeriesTextBox.ReadOnly = true;
            SeriesTextBox.Size = new Size(393, 23);
            SeriesTextBox.TabIndex = 4;
            SeriesTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(541, 82);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 5;
            label1.Text = "Approximated value";
            // 
            // NumAppE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 695);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NumAppE";
            Text = "NumAppE";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Series2NumUpD).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)limENumUpD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SeriesNumUpDwn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label story;
        private Label title;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private NumericUpDown limENumUpD;
        private TextBox limAppEValue;
        private Label limELabel;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox2;
        private NumericUpDown SeriesNumUpDwn;
        private TextBox SeriesTextBox;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox3;
        private NumericUpDown Series2NumUpD;
        private TextBox Series2TextBox;
        private Label label2;
    }
}