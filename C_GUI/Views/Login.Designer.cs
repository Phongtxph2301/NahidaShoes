namespace C_GUI.Views
{
    partial class Login
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
            this._tbxMaNhanVien = new C_GUI.RJControls.RJTextBox();
            this._tbxMatKhau = new C_GUI.RJControls.RJTextBox();
            this._btnDangNhap = new C_GUI.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _tbxMaNhanVien
            // 
            this._tbxMaNhanVien.BackColor = System.Drawing.SystemColors.Window;
            this._tbxMaNhanVien.BorderColor = System.Drawing.Color.Black;
            this._tbxMaNhanVien.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxMaNhanVien.BorderRadius = 15;
            this._tbxMaNhanVien.BorderSize = 2;
            this._tbxMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxMaNhanVien.Location = new System.Drawing.Point(13, 81);
            this._tbxMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this._tbxMaNhanVien.MaxLength = 20;
            this._tbxMaNhanVien.Multiline = false;
            this._tbxMaNhanVien.Name = "_tbxMaNhanVien";
            this._tbxMaNhanVien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxMaNhanVien.PasswordChar = false;
            this._tbxMaNhanVien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxMaNhanVien.PlaceholderText = "";
            this._tbxMaNhanVien.Size = new System.Drawing.Size(304, 31);
            this._tbxMaNhanVien.TabIndex = 0;
            this._tbxMaNhanVien.Texts = "";
            this._tbxMaNhanVien.UnderlinedStyle = false;
            // 
            // _tbxMatKhau
            // 
            this._tbxMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this._tbxMatKhau.BorderColor = System.Drawing.Color.Black;
            this._tbxMatKhau.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxMatKhau.BorderRadius = 15;
            this._tbxMatKhau.BorderSize = 2;
            this._tbxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxMatKhau.Location = new System.Drawing.Point(13, 135);
            this._tbxMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this._tbxMatKhau.MaxLength = 20;
            this._tbxMatKhau.Multiline = false;
            this._tbxMatKhau.Name = "_tbxMatKhau";
            this._tbxMatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxMatKhau.PasswordChar = false;
            this._tbxMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxMatKhau.PlaceholderText = "";
            this._tbxMatKhau.Size = new System.Drawing.Size(304, 31);
            this._tbxMatKhau.TabIndex = 1;
            this._tbxMatKhau.Texts = "";
            this._tbxMatKhau.UnderlinedStyle = false;
            // 
            // _btnDangNhap
            // 
            this._btnDangNhap.BackColor = System.Drawing.Color.Turquoise;
            this._btnDangNhap.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnDangNhap.BorderColor = System.Drawing.Color.Black;
            this._btnDangNhap.BorderRadius = 15;
            this._btnDangNhap.BorderSize = 2;
            this._btnDangNhap.FlatAppearance.BorderSize = 0;
            this._btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this._btnDangNhap.Location = new System.Drawing.Point(13, 173);
            this._btnDangNhap.Name = "_btnDangNhap";
            this._btnDangNhap.Size = new System.Drawing.Size(304, 31);
            this._btnDangNhap.SizeImage = new System.Drawing.Size(20, 20);
            this._btnDangNhap.TabIndex = 2;
            this._btnDangNhap.Text = "Đăng nhập";
            this._btnDangNhap.TextColor = System.Drawing.Color.Black;
            this._btnDangNhap.UseVisualStyleBackColor = false;
            this._btnDangNhap.Click += new System.EventHandler(this._btnDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // Login
            // 
            this.AcceptButton = this._btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnDangNhap);
            this.Controls.Add(this._tbxMatKhau);
            this.Controls.Add(this._tbxMaNhanVien);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.RJTextBox _tbxMaNhanVien;
        private RJControls.RJTextBox _tbxMatKhau;
        private RJControls.RJButton _btnDangNhap;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}