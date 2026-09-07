namespace DemoWinform3
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
            lblHoLot = new Label();
            lblTen = new Label();
            txtHoLot = new TextBox();
            txtTen = new TextBox();
            btnHoLot = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            lblHoTen = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblHoLot
            // 
            lblHoLot.AccessibleName = "lblHoLot";
            lblHoLot.AutoSize = true;
            lblHoLot.Font = new Font("Segoe UI", 9F);
            lblHoLot.Location = new Point(177, 74);
            lblHoLot.Name = "lblHoLot";
            lblHoLot.Size = new Size(66, 25);
            lblHoLot.TabIndex = 0;
            lblHoLot.Text = "Họ lót:";
            // 
            // lblTen
            // 
            lblTen.AccessibleName = "lblTen";
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 9F);
            lblTen.Location = new Point(201, 121);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(42, 25);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên:";
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(280, 68);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(278, 31);
            txtHoLot.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(280, 121);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(278, 31);
            txtTen.TabIndex = 3;
            // 
            // btnHoLot
            // 
            btnHoLot.Location = new Point(86, 212);
            btnHoLot.Name = "btnHoLot";
            btnHoLot.Size = new Size(112, 34);
            btnHoLot.TabIndex = 4;
            btnHoLot.Text = "Họ lót";
            btnHoLot.UseVisualStyleBackColor = true;
            btnHoLot.Click += btnHoLot_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(318, 212);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(112, 34);
            btnTen.TabIndex = 5;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(569, 212);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(112, 34);
            btnHoTen.TabIndex = 6;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(270, 306);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(197, 34);
            btnKetThuc.TabIndex = 7;
            btnKetThuc.Text = "Thoát chương trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            //  
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Location = new Point(-1, 3);
            label1.Name = "label1";
            label1.Size = new Size(729, 61);
            label1.TabIndex = 9;
            label1.Text = "lblHoTen";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 396);
            Controls.Add(label1);
            Controls.Add(lblHoTen);
            Controls.Add(btnKetThuc);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHoLot);
            Controls.Add(txtTen);
            Controls.Add(txtHoLot);
            Controls.Add(lblTen);
            Controls.Add(lblHoLot);
            Name = "Form1";
            Text = "Bài Tập Họ Tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoLot;
        private Label lblTen;
        private TextBox txtHoLot;
        private TextBox txtTen;
        private Button btnHoLot;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnKetThuc;
        private Label lblHoTen;
        private Label label1;
    }
}
