namespace DemoWinform
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
            label2 = new Label();
            txtNhapPassword = new TextBox();
            txtHienThi = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnDong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(117, 50);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(180, 125);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "Hiển thị:";
            // 
            // txtNhapPassword
            // 
            txtNhapPassword.AccessibleName = "txtNhapPassword";
            txtNhapPassword.Location = new Point(287, 47);
            txtNhapPassword.Name = "txtNhapPassword";
            txtNhapPassword.PasswordChar = '*';
            txtNhapPassword.Size = new Size(195, 31);
            txtNhapPassword.TabIndex = 2;
            // 
            // txtHienThi
            // 
            txtHienThi.AccessibleName = "txtHienThi";
            txtHienThi.Location = new Point(287, 119);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(195, 31);
            txtHienThi.TabIndex = 3;
            // 
            // button1
            // 
            button1.AccessibleName = "btnHienThi";
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(64, 234);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Hiển thị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnHienThi_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "btnTiep";
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(251, 234);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Tiếp";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnTiep_Click;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDong.Location = new Point(444, 234);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(112, 34);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 339);
            Controls.Add(btnDong);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtHienThi);
            Controls.Add(txtNhapPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sử dụng Label";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNhapPassword;
        private TextBox txtHienThi;
        private Button button1;
        private Button button2;
        private Button btnDong;
    }
}
