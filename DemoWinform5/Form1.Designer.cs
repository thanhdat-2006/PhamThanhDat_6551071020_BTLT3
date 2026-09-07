namespace Bai_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            txtNhapTen = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            groupBox2 = new GroupBox();
            chkUnderline = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            label3 = new Label();
            lblLapTrinh = new Label();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(41, 20);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(139, 15);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(353, 27);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 93);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(radBlack);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radRed);
            groupBox1.Location = new Point(26, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 177);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            radBlack.Location = new Point(23, 122);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 21);
            radBlack.TabIndex = 3;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(23, 92);
            radBlue.Name = "radBlue";
            radBlue.RightToLeft = RightToLeft.No;
            radBlue.Size = new Size(60, 21);
            radBlue.TabIndex = 2;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(23, 59);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(70, 21);
            radGreen.TabIndex = 1;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Checked = true;
            radRed.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(23, 32);
            radRed.Name = "radRed";
            radRed.Size = new Size(56, 21);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGoldenrodYellow;
            groupBox2.Controls.Add(chkUnderline);
            groupBox2.Controls.Add(chkItalic);
            groupBox2.Controls.Add(chkBold);
            groupBox2.Location = new Point(308, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(184, 177);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Times New Roman", 9F, FontStyle.Underline, GraphicsUnit.Point, 163);
            chkUnderline.ForeColor = Color.Blue;
            chkUnderline.Location = new Point(40, 123);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(93, 21);
            chkUnderline.TabIndex = 2;
            chkUnderline.Text = "Gạch chân";
            chkUnderline.UseVisualStyleBackColor = true;
            chkUnderline.CheckedChanged += chkUnderline_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            chkItalic.ForeColor = Color.Blue;
            chkItalic.Location = new Point(40, 76);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(119, 21);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            chkBold.ForeColor = Color.Blue;
            chkBold.Location = new Point(40, 30);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(95, 21);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(12, 257);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 5;
            label3.Text = "Lập trình bởi";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BackColor = Color.Transparent;
            lblLapTrinh.BorderStyle = BorderStyle.Fixed3D;
            lblLapTrinh.ForeColor = Color.Green;
            lblLapTrinh.Location = new Point(139, 257);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(227, 25);
            lblLapTrinh.TabIndex = 6;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ButtonFace;
            btnThoat.Location = new Point(386, 252);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 69);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 333);
            Controls.Add(btnThoat);
            Controls.Add(lblLapTrinh);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(txtNhapTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Định dạng (Formater)";
            Load += Form1_Load;
            DoubleClick += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapTen;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private Label lblLapTrinh;
        private Button btnThoat;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private CheckBox chkUnderline;
        private CheckBox chkItalic;
        private CheckBox chkBold;
    }
}
