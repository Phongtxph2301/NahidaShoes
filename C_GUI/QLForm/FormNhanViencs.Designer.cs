namespace C_GUI.QLForm
{
    partial class FormNhanViencs
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
            this.cbx_khonghoatdong = new System.Windows.Forms.CheckBox();
            this.cbx_hoatdong = new System.Windows.Forms.CheckBox();
            this.dtt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.dgrid_shownhanvien = new System.Windows.Forms.DataGridView();
            this.txt_ma = new C_GUI.RJControls.RJTextBox();
            this.rbtn_nu = new C_GUI.RJControls.RJRadioButton();
            this.rbtn_nam = new C_GUI.RJControls.RJRadioButton();
            this.btn_xoa = new C_GUI.RJControls.RJButton();
            this.btn_sua = new C_GUI.RJControls.RJButton();
            this.btn_them = new C_GUI.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_ten = new C_GUI.RJControls.RJTextBox();
            this.txt_email = new C_GUI.RJControls.RJTextBox();
            this.txt_sdt = new C_GUI.RJControls.RJTextBox();
            this.txt_diachi = new C_GUI.RJControls.RJTextBox();
            this.txt_matkhau = new C_GUI.RJControls.RJTextBox();
            this.cmb_cuahang = new C_GUI.RJControls.RJComboBox();
            this.cmb_chucvu = new C_GUI.RJControls.RJComboBox();
            this.txt_timkiem = new C_GUI.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_shownhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_khonghoatdong
            // 
            this.cbx_khonghoatdong.AutoSize = true;
            this.cbx_khonghoatdong.Location = new System.Drawing.Point(700, 141);
            this.cbx_khonghoatdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_khonghoatdong.Name = "cbx_khonghoatdong";
            this.cbx_khonghoatdong.Size = new System.Drawing.Size(119, 19);
            this.cbx_khonghoatdong.TabIndex = 146;
            this.cbx_khonghoatdong.Text = "Không hoạt động";
            this.cbx_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // cbx_hoatdong
            // 
            this.cbx_hoatdong.AutoSize = true;
            this.cbx_hoatdong.Location = new System.Drawing.Point(585, 140);
            this.cbx_hoatdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_hoatdong.Name = "cbx_hoatdong";
            this.cbx_hoatdong.Size = new System.Drawing.Size(83, 19);
            this.cbx_hoatdong.TabIndex = 145;
            this.cbx_hoatdong.Text = "Hoạt động";
            this.cbx_hoatdong.UseVisualStyleBackColor = true;
            // 
            // dtt_ngaysinh
            // 
            this.dtt_ngaysinh.Location = new System.Drawing.Point(128, 197);
            this.dtt_ngaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtt_ngaysinh.Name = "dtt_ngaysinh";
            this.dtt_ngaysinh.Size = new System.Drawing.Size(219, 23);
            this.dtt_ngaysinh.TabIndex = 141;
            // 
            // dgrid_shownhanvien
            // 
            this.dgrid_shownhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrid_shownhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_shownhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_shownhanvien.Location = new System.Drawing.Point(0, 332);
            this.dgrid_shownhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_shownhanvien.Name = "dgrid_shownhanvien";
            this.dgrid_shownhanvien.RowHeadersWidth = 51;
            this.dgrid_shownhanvien.RowTemplate.Height = 29;
            this.dgrid_shownhanvien.Size = new System.Drawing.Size(831, 188);
            this.dgrid_shownhanvien.TabIndex = 116;
            this.dgrid_shownhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_shownhanvien_CellContentClick);
            // 
            // txt_ma
            // 
            this.txt_ma.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ma.BorderColor = System.Drawing.Color.Black;
            this.txt_ma.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_ma.BorderRadius = 15;
            this.txt_ma.BorderSize = 2;
            this.txt_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ma.Location = new System.Drawing.Point(113, 20);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ma.MaxLength = 20;
            this.txt_ma.Multiline = false;
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ma.PasswordChar = false;
            this.txt_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ma.PlaceholderText = "";
            this.txt_ma.Size = new System.Drawing.Size(273, 27);
            this.txt_ma.TabIndex = 156;
            this.txt_ma.Texts = "";
            this.txt_ma.UnderlinedStyle = false;
            // 
            // rbtn_nu
            // 
            this.rbtn_nu.AutoSize = true;
            this.rbtn_nu.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtn_nu.Location = new System.Drawing.Point(233, 235);
            this.rbtn_nu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_nu.MinimumSize = new System.Drawing.Size(0, 16);
            this.rbtn_nu.Name = "rbtn_nu";
            this.rbtn_nu.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.rbtn_nu.Size = new System.Drawing.Size(48, 19);
            this.rbtn_nu.TabIndex = 155;
            this.rbtn_nu.TabStop = true;
            this.rbtn_nu.Text = "nữ";
            this.rbtn_nu.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // rbtn_nam
            // 
            this.rbtn_nam.AutoSize = true;
            this.rbtn_nam.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtn_nam.Location = new System.Drawing.Point(128, 235);
            this.rbtn_nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_nam.MinimumSize = new System.Drawing.Size(0, 16);
            this.rbtn_nam.Name = "rbtn_nam";
            this.rbtn_nam.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.rbtn_nam.Size = new System.Drawing.Size(58, 19);
            this.rbtn_nam.TabIndex = 154;
            this.rbtn_nam.TabStop = true;
            this.rbtn_nam.Text = "nam";
            this.rbtn_nam.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn_nam.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Turquoise;
            this.btn_xoa.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_xoa.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa.BorderRadius = 15;
            this.btn_xoa.BorderSize = 2;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(370, 258);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(116, 29);
            this.btn_xoa.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoa.TabIndex = 153;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Turquoise;
            this.btn_sua.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_sua.BorderColor = System.Drawing.Color.Black;
            this.btn_sua.BorderRadius = 15;
            this.btn_sua.BorderSize = 2;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(242, 257);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(116, 29);
            this.btn_sua.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_sua.TabIndex = 152;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Black;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Turquoise;
            this.btn_them.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btn_them.BorderColor = System.Drawing.Color.Black;
            this.btn_them.BorderRadius = 15;
            this.btn_them.BorderSize = 2;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(112, 257);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(116, 29);
            this.btn_them.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_them.TabIndex = 151;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.Black;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(370, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 149;
            this.label3.Text = "Màu Sắc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(53, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 25);
            this.label6.TabIndex = 147;
            this.label6.Text = "Mã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 157;
            this.label1.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 158;
            this.label4.Text = "email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 160;
            this.label7.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 161;
            this.label8.Text = "Giới Tính";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(497, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 25);
            this.label9.TabIndex = 162;
            this.label9.Text = "SĐT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(470, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 25);
            this.label10.TabIndex = 163;
            this.label10.Text = "Địa chỉ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(445, 96);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 25);
            this.label21.TabIndex = 164;
            this.label21.Text = "Mật khẩu";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(442, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 25);
            this.label22.TabIndex = 165;
            this.label22.Text = "trạng thái";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(453, 170);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 25);
            this.label23.TabIndex = 166;
            this.label23.Text = "Cửa hàng";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(466, 208);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 25);
            this.label24.TabIndex = 167;
            this.label24.Text = "Chức vụ";
            // 
            // txt_ten
            // 
            this.txt_ten.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ten.BorderColor = System.Drawing.Color.Black;
            this.txt_ten.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_ten.BorderRadius = 15;
            this.txt_ten.BorderSize = 2;
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ten.Location = new System.Drawing.Point(113, 64);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ten.MaxLength = 20;
            this.txt_ten.Multiline = false;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ten.PasswordChar = false;
            this.txt_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ten.PlaceholderText = "";
            this.txt_ten.Size = new System.Drawing.Size(273, 27);
            this.txt_ten.TabIndex = 168;
            this.txt_ten.Texts = "";
            this.txt_ten.UnderlinedStyle = false;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email.BorderColor = System.Drawing.Color.Black;
            this.txt_email.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_email.BorderRadius = 15;
            this.txt_email.BorderSize = 2;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_email.Location = new System.Drawing.Point(113, 104);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_email.MaxLength = 20;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_email.PasswordChar = false;
            this.txt_email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_email.PlaceholderText = "";
            this.txt_email.Size = new System.Drawing.Size(273, 27);
            this.txt_email.TabIndex = 169;
            this.txt_email.Texts = "";
            this.txt_email.UnderlinedStyle = false;
            // 
            // txt_sdt
            // 
            this.txt_sdt.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sdt.BorderColor = System.Drawing.Color.Black;
            this.txt_sdt.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_sdt.BorderRadius = 15;
            this.txt_sdt.BorderSize = 2;
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sdt.Location = new System.Drawing.Point(563, 17);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_sdt.MaxLength = 20;
            this.txt_sdt.Multiline = false;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_sdt.PasswordChar = false;
            this.txt_sdt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_sdt.PlaceholderText = "";
            this.txt_sdt.Size = new System.Drawing.Size(232, 27);
            this.txt_sdt.TabIndex = 171;
            this.txt_sdt.Texts = "";
            this.txt_sdt.UnderlinedStyle = false;
            // 
            // txt_diachi
            // 
            this.txt_diachi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_diachi.BorderColor = System.Drawing.Color.Black;
            this.txt_diachi.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_diachi.BorderRadius = 15;
            this.txt_diachi.BorderSize = 2;
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_diachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_diachi.Location = new System.Drawing.Point(563, 50);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_diachi.MaxLength = 20;
            this.txt_diachi.Multiline = false;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_diachi.PasswordChar = false;
            this.txt_diachi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_diachi.PlaceholderText = "";
            this.txt_diachi.Size = new System.Drawing.Size(189, 27);
            this.txt_diachi.TabIndex = 172;
            this.txt_diachi.Texts = "";
            this.txt_diachi.UnderlinedStyle = false;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.SystemColors.Window;
            this.txt_matkhau.BorderColor = System.Drawing.Color.Black;
            this.txt_matkhau.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_matkhau.BorderRadius = 15;
            this.txt_matkhau.BorderSize = 2;
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_matkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_matkhau.Location = new System.Drawing.Point(563, 93);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_matkhau.MaxLength = 20;
            this.txt_matkhau.Multiline = false;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_matkhau.PasswordChar = false;
            this.txt_matkhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_matkhau.PlaceholderText = "";
            this.txt_matkhau.Size = new System.Drawing.Size(200, 27);
            this.txt_matkhau.TabIndex = 173;
            this.txt_matkhau.Texts = "";
            this.txt_matkhau.UnderlinedStyle = false;
            // 
            // cmb_cuahang
            // 
            this.cmb_cuahang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_cuahang.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_cuahang.BorderSize = 1;
            this.cmb_cuahang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_cuahang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_cuahang.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_cuahang.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_cuahang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_cuahang.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_cuahang.Location = new System.Drawing.Point(580, 170);
            this.cmb_cuahang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_cuahang.MinimumSize = new System.Drawing.Size(175, 22);
            this.cmb_cuahang.Name = "cmb_cuahang";
            this.cmb_cuahang.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_cuahang.Size = new System.Drawing.Size(219, 31);
            this.cmb_cuahang.TabIndex = 174;
            this.cmb_cuahang.Texts = "";
            // 
            // cmb_chucvu
            // 
            this.cmb_chucvu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_chucvu.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_chucvu.BorderSize = 1;
            this.cmb_chucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_chucvu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_chucvu.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_chucvu.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_chucvu.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_chucvu.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_chucvu.Location = new System.Drawing.Point(580, 212);
            this.cmb_chucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_chucvu.MinimumSize = new System.Drawing.Size(175, 22);
            this.cmb_chucvu.Name = "cmb_chucvu";
            this.cmb_chucvu.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_chucvu.Size = new System.Drawing.Size(219, 31);
            this.cmb_chucvu.TabIndex = 175;
            this.cmb_chucvu.Texts = "";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.BackColor = System.Drawing.SystemColors.Window;
            this.txt_timkiem.BorderColor = System.Drawing.Color.Black;
            this.txt_timkiem.BorderFocusColor = System.Drawing.Color.Red;
            this.txt_timkiem.BorderRadius = 15;
            this.txt_timkiem.BorderSize = 2;
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_timkiem.Location = new System.Drawing.Point(10, 300);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_timkiem.MaxLength = 20;
            this.txt_timkiem.Multiline = false;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_timkiem.PasswordChar = false;
            this.txt_timkiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_timkiem.PlaceholderText = "";
            this.txt_timkiem.Size = new System.Drawing.Size(273, 27);
            this.txt_timkiem.TabIndex = 176;
            this.txt_timkiem.Texts = "";
            this.txt_timkiem.UnderlinedStyle = false;
            this.txt_timkiem._TextChanged += new System.EventHandler(this.txt_timkiem__TextChanged);
            // 
            // FormNhanViencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 520);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.cmb_chucvu);
            this.Controls.Add(this.cmb_cuahang);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.rbtn_nu);
            this.Controls.Add(this.rbtn_nam);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_khonghoatdong);
            this.Controls.Add(this.cbx_hoatdong);
            this.Controls.Add(this.dtt_ngaysinh);
            this.Controls.Add(this.dgrid_shownhanvien);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNhanViencs";
            this.Text = "FormNhanViencs";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_shownhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbx_khonghoatdong;
        private CheckBox cbx_hoatdong;
        private DateTimePicker dtt_ngaysinh;
        private DataGridView dgrid_shownhanvien;
        private RJControls.RJTextBox txt_ma;
        private RJControls.RJRadioButton rbtn_nu;
        private RJControls.RJRadioButton rbtn_nam;
        private RJControls.RJButton btn_xoa;
        private RJControls.RJButton btn_sua;
        private RJControls.RJButton btn_them;
        private Label label3;
        private Label label6;
        private Label label1;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private RJControls.RJTextBox txt_ten;
        private RJControls.RJTextBox txt_email;
        private RJControls.RJTextBox txt_sdt;
        private RJControls.RJTextBox txt_diachi;
        private RJControls.RJTextBox txt_matkhau;
        private RJControls.RJComboBox cmb_cuahang;
        private RJControls.RJComboBox cmb_chucvu;
        private RJControls.RJTextBox txt_timkiem;
    }
}