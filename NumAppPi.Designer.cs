namespace MathApp
{
    partial class NumAppPi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumAppPi));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            RamanujanNumUpD = new NumericUpDown();
            RamanujanTextBox = new TextBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            midAgePiUpD = new NumericUpDown();
            MidAgePiValue = new TextBox();
            limELabel = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            WallisNumUpDwn = new NumericUpDown();
            WallisPiTextBox = new TextBox();
            label1 = new Label();
            title = new Label();
            story = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RamanujanNumUpD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)midAgePiUpD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WallisNumUpDwn).BeginInit();
            SuspendLayout();
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
            tableLayoutPanel1.Location = new Point(9, 11);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 115F));
            tableLayoutPanel1.Size = new Size(804, 568);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(RamanujanNumUpD, 0, 1);
            tableLayoutPanel4.Controls.Add(RamanujanTextBox, 1, 0);
            tableLayoutPanel4.Controls.Add(label2, 1, 1);
            tableLayoutPanel4.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 453);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 68.3333359F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 31.666666F));
            tableLayoutPanel4.Size = new Size(798, 113);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // RamanujanNumUpD
            // 
            RamanujanNumUpD.Location = new Point(3, 79);
            RamanujanNumUpD.Margin = new Padding(3, 2, 3, 2);
            RamanujanNumUpD.Name = "RamanujanNumUpD";
            RamanujanNumUpD.Size = new Size(58, 23);
            RamanujanNumUpD.TabIndex = 3;
            RamanujanNumUpD.ValueChanged += RamanujanNumUpD_ValueChanged;
            // 
            // RamanujanTextBox
            // 
            RamanujanTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RamanujanTextBox.Location = new Point(402, 52);
            RamanujanTextBox.Margin = new Padding(3, 2, 3, 2);
            RamanujanTextBox.Name = "RamanujanTextBox";
            RamanujanTextBox.ReadOnly = true;
            RamanujanTextBox.Size = new Size(393, 23);
            RamanujanTextBox.TabIndex = 4;
            RamanujanTextBox.TextAlign = HorizontalAlignment.Center;
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
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(267, 73);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(midAgePiUpD, 0, 1);
            tableLayoutPanel2.Controls.Add(MidAgePiValue, 1, 0);
            tableLayoutPanel2.Controls.Add(limELabel, 1, 1);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 178);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 72.6495743F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.3504276F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(798, 126);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // midAgePiUpD
            // 
            midAgePiUpD.Location = new Point(3, 87);
            midAgePiUpD.Margin = new Padding(3, 2, 3, 2);
            midAgePiUpD.Name = "midAgePiUpD";
            midAgePiUpD.Size = new Size(58, 23);
            midAgePiUpD.TabIndex = 3;
            midAgePiUpD.ValueChanged += midAgePiUpD_ValueChanged;
            // 
            // MidAgePiValue
            // 
            MidAgePiValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MidAgePiValue.Location = new Point(402, 60);
            MidAgePiValue.Margin = new Padding(3, 2, 3, 2);
            MidAgePiValue.Name = "MidAgePiValue";
            MidAgePiValue.ReadOnly = true;
            MidAgePiValue.Size = new Size(393, 23);
            MidAgePiValue.TabIndex = 4;
            MidAgePiValue.TextAlign = HorizontalAlignment.Center;
            // 
            // limELabel
            // 
            limELabel.Anchor = AnchorStyles.Top;
            limELabel.AutoSize = true;
            limELabel.Location = new Point(541, 85);
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
            pictureBox1.Size = new Size(141, 70);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel3.Controls.Add(WallisNumUpDwn, 0, 1);
            tableLayoutPanel3.Controls.Add(WallisPiTextBox, 1, 0);
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
            pictureBox2.Size = new Size(122, 74);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // WallisNumUpDwn
            // 
            WallisNumUpDwn.Location = new Point(3, 84);
            WallisNumUpDwn.Margin = new Padding(3, 2, 3, 2);
            WallisNumUpDwn.Name = "WallisNumUpDwn";
            WallisNumUpDwn.Size = new Size(58, 23);
            WallisNumUpDwn.TabIndex = 3;
            WallisNumUpDwn.ValueChanged += WallisNumUpDwn_ValueChanged;
            // 
            // WallisPiTextBox
            // 
            WallisPiTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            WallisPiTextBox.Location = new Point(402, 57);
            WallisPiTextBox.Margin = new Padding(3, 2, 3, 2);
            WallisPiTextBox.Name = "WallisPiTextBox";
            WallisPiTextBox.ReadOnly = true;
            WallisPiTextBox.Size = new Size(393, 23);
            WallisPiTextBox.TabIndex = 4;
            WallisPiTextBox.TextAlign = HorizontalAlignment.Center;
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
            // title
            // 
            title.Anchor = AnchorStyles.Top;
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 12F);
            title.Location = new Point(338, 0);
            title.Name = "title";
            title.Size = new Size(127, 21);
            title.TabIndex = 0;
            title.Text = "Approximating π";
            // 
            // story
            // 
            story.Anchor = AnchorStyles.Top;
            story.AutoSize = true;
            story.Location = new Point(8, 96);
            story.Name = "story";
            story.Size = new Size(788, 37);
            story.TabIndex = 1;
            story.Text = resources.GetString("story.Text");
            story.TextAlign = ContentAlignment.MiddleCenter;
            story.UseCompatibleTextRendering = true;
            // 
            // NumAppPi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 695);
            Controls.Add(tableLayoutPanel1);
            Name = "NumAppPi";
            Text = "NumAppPi";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RamanujanNumUpD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)midAgePiUpD).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)WallisNumUpDwn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox3;
        private NumericUpDown RamanujanNumUpD;
        private TextBox RamanujanTextBox;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private NumericUpDown midAgePiUpD;
        private TextBox MidAgePiValue;
        private Label limELabel;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox2;
        private NumericUpDown WallisNumUpDwn;
        private TextBox WallisPiTextBox;
        private Label label1;
        private Label title;
        private Label story;
    }
}