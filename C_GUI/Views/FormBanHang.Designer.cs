namespace C_GUI.Views
{
    partial class FormBanHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._tbxTimKiemThongTinSanPham = new C_GUI.RJControls.RJTextBox();
            this._lsvShowSanPham = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.TenGiay = new System.Windows.Forms.ColumnHeader();
            this.MauSac = new System.Windows.Forms.ColumnHeader();
            this.HangGiay = new System.Windows.Forms.ColumnHeader();
            this.Nsx = new System.Windows.Forms.ColumnHeader();
            this.Size = new System.Windows.Forms.ColumnHeader();
            this.ChieuCaoDeGiay = new System.Windows.Forms.ColumnHeader();
            this.GiaBan = new System.Windows.Forms.ColumnHeader();
            this.SoLuongTon = new System.Windows.Forms.ColumnHeader();
            this.MoTa = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._tbxTimKiemGioHang = new C_GUI.RJControls.RJTextBox();
            this._lsvGioHang = new System.Windows.Forms.ListView();
            this._Id = new System.Windows.Forms.ColumnHeader();
            this._TenGiay = new System.Windows.Forms.ColumnHeader();
            this._DonGia = new System.Windows.Forms.ColumnHeader();
            this._SoLuong = new System.Windows.Forms.ColumnHeader();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._tbxTimKiemHoaDonCho = new C_GUI.RJControls.RJTextBox();
            this._lsvHoaDonCho = new System.Windows.Forms.ListView();
            this.IdHoaDon = new System.Windows.Forms.ColumnHeader();
            this.MaHoaDon = new System.Windows.Forms.ColumnHeader();
            this.PhuongThuaMua = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._btnTaoHoaDon = new C_GUI.RJControls.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this._tbxMaHoaDon = new C_GUI.RJControls.RJTextBox();
            this._cbxKhachHang = new C_GUI.RJControls.RJComboBox();
            this._cbxNhanVien = new C_GUI.RJControls.RJComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._btnShipHang = new C_GUI.RJControls.RJButton();
            this._cbxPhuongThucMua = new C_GUI.RJControls.RJComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnThanhToan = new C_GUI.RJControls.RJButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._tbxTimKienHoaDonChuaThanhToan = new C_GUI.RJControls.RJTextBox();
            this._lsvHoaDonChuaThanhToan = new System.Windows.Forms.ListView();
            this._Id_ = new System.Windows.Forms.ColumnHeader();
            this._MaHoaDon_ = new System.Windows.Forms.ColumnHeader();
            this._PhuongThucMua_ = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._tbxTimKiemThongTinSanPham);
            this.groupBox1.Controls.Add(this._lsvShowSanPham);
            this.groupBox1.Location = new System.Drawing.Point(375, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(973, 577);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // _tbxTimKiemThongTinSanPham
            // 
            this._tbxTimKiemThongTinSanPham.BackColor = System.Drawing.SystemColors.Window;
            this._tbxTimKiemThongTinSanPham.BorderColor = System.Drawing.Color.Black;
            this._tbxTimKiemThongTinSanPham.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxTimKiemThongTinSanPham.BorderRadius = 15;
            this._tbxTimKiemThongTinSanPham.BorderSize = 2;
            this._tbxTimKiemThongTinSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxTimKiemThongTinSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxTimKiemThongTinSanPham.Location = new System.Drawing.Point(5, 22);
            this._tbxTimKiemThongTinSanPham.Margin = new System.Windows.Forms.Padding(4);
            this._tbxTimKiemThongTinSanPham.MaxLength = 20;
            this._tbxTimKiemThongTinSanPham.Multiline = false;
            this._tbxTimKiemThongTinSanPham.Name = "_tbxTimKiemThongTinSanPham";
            this._tbxTimKiemThongTinSanPham.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxTimKiemThongTinSanPham.PasswordChar = false;
            this._tbxTimKiemThongTinSanPham.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxTimKiemThongTinSanPham.PlaceholderText = "";
            this._tbxTimKiemThongTinSanPham.Size = new System.Drawing.Size(966, 31);
            this._tbxTimKiemThongTinSanPham.TabIndex = 43;
            this._tbxTimKiemThongTinSanPham.Texts = "";
            this._tbxTimKiemThongTinSanPham.UnderlinedStyle = false;
            this._tbxTimKiemThongTinSanPham._TextChanged += new System.EventHandler(this._tbxTimKiemThongTinSanPham__TextChanged);
            // 
            // _lsvShowSanPham
            // 
            this._lsvShowSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.TenGiay,
            this.MauSac,
            this.HangGiay,
            this.Nsx,
            this.Size,
            this.ChieuCaoDeGiay,
            this.GiaBan,
            this.SoLuongTon,
            this.MoTa});
            this._lsvShowSanPham.FullRowSelect = true;
            this._lsvShowSanPham.Location = new System.Drawing.Point(5, 59);
            this._lsvShowSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lsvShowSanPham.Name = "_lsvShowSanPham";
            this._lsvShowSanPham.Size = new System.Drawing.Size(968, 518);
            this._lsvShowSanPham.TabIndex = 1;
            this._lsvShowSanPham.UseCompatibleStateImageBehavior = false;
            this._lsvShowSanPham.View = System.Windows.Forms.View.Details;
            this._lsvShowSanPham.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this._lsvShowSanPham_ColumnClick);
            this._lsvShowSanPham.DoubleClick += new System.EventHandler(this._lsvShowSanPham_DoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // TenGiay
            // 
            this.TenGiay.Text = "Tên Giày";
            this.TenGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenGiay.Width = 100;
            // 
            // MauSac
            // 
            this.MauSac.Text = "Màu Sắc";
            this.MauSac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MauSac.Width = 100;
            // 
            // HangGiay
            // 
            this.HangGiay.Text = "Hãng Giày";
            this.HangGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HangGiay.Width = 100;
            // 
            // Nsx
            // 
            this.Nsx.Text = "Nsx";
            this.Nsx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nsx.Width = 100;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Size.Width = 100;
            // 
            // ChieuCaoDeGiay
            // 
            this.ChieuCaoDeGiay.Text = "Chiều Cao Đế Giày";
            this.ChieuCaoDeGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChieuCaoDeGiay.Width = 150;
            // 
            // GiaBan
            // 
            this.GiaBan.Text = "Giá Bán";
            this.GiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiaBan.Width = 100;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.Text = "Số Lượng Tồn";
            this.SoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoLuongTon.Width = 100;
            // 
            // MoTa
            // 
            this.MoTa.Text = "Mô Tả";
            this.MoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoTa.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._tbxTimKiemGioHang);
            this.groupBox2.Controls.Add(this._lsvGioHang);
            this.groupBox2.Location = new System.Drawing.Point(12, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(357, 577);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ Hàng";
            // 
            // _tbxTimKiemGioHang
            // 
            this._tbxTimKiemGioHang.BackColor = System.Drawing.SystemColors.Window;
            this._tbxTimKiemGioHang.BorderColor = System.Drawing.Color.Black;
            this._tbxTimKiemGioHang.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxTimKiemGioHang.BorderRadius = 15;
            this._tbxTimKiemGioHang.BorderSize = 2;
            this._tbxTimKiemGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxTimKiemGioHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxTimKiemGioHang.Location = new System.Drawing.Point(7, 18);
            this._tbxTimKiemGioHang.Margin = new System.Windows.Forms.Padding(4);
            this._tbxTimKiemGioHang.MaxLength = 20;
            this._tbxTimKiemGioHang.Multiline = false;
            this._tbxTimKiemGioHang.Name = "_tbxTimKiemGioHang";
            this._tbxTimKiemGioHang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxTimKiemGioHang.PasswordChar = false;
            this._tbxTimKiemGioHang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxTimKiemGioHang.PlaceholderText = "";
            this._tbxTimKiemGioHang.Size = new System.Drawing.Size(343, 31);
            this._tbxTimKiemGioHang.TabIndex = 43;
            this._tbxTimKiemGioHang.Texts = "";
            this._tbxTimKiemGioHang.UnderlinedStyle = false;
            this._tbxTimKiemGioHang._TextChanged += new System.EventHandler(this._tbxTimKiemGioHang__TextChanged);
            // 
            // _lsvGioHang
            // 
            this._lsvGioHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._Id,
            this._TenGiay,
            this._DonGia,
            this._SoLuong});
            this._lsvGioHang.FullRowSelect = true;
            this._lsvGioHang.Location = new System.Drawing.Point(5, 55);
            this._lsvGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lsvGioHang.Name = "_lsvGioHang";
            this._lsvGioHang.Size = new System.Drawing.Size(346, 522);
            this._lsvGioHang.TabIndex = 0;
            this._lsvGioHang.UseCompatibleStateImageBehavior = false;
            this._lsvGioHang.View = System.Windows.Forms.View.Details;
            this._lsvGioHang.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this._lsvGioHang_ColumnClick);
            this._lsvGioHang.DoubleClick += new System.EventHandler(this._lsvGioHang_DoubleClick);
            // 
            // _Id
            // 
            this._Id.Text = "Id";
            this._Id.Width = 0;
            // 
            // _TenGiay
            // 
            this._TenGiay.Text = "Tên Giày ";
            this._TenGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._TenGiay.Width = 100;
            // 
            // _DonGia
            // 
            this._DonGia.Text = "Đơn Giá";
            this._DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._DonGia.Width = 100;
            // 
            // _SoLuong
            // 
            this._SoLuong.Text = "Số Lượng";
            this._SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._SoLuong.Width = 125;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._tbxTimKiemHoaDonCho);
            this.groupBox4.Controls.Add(this._lsvHoaDonCho);
            this.groupBox4.Location = new System.Drawing.Point(12, 599);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(296, 218);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hóa Đơn Chờ";
            // 
            // _tbxTimKiemHoaDonCho
            // 
            this._tbxTimKiemHoaDonCho.BackColor = System.Drawing.SystemColors.Window;
            this._tbxTimKiemHoaDonCho.BorderColor = System.Drawing.Color.Black;
            this._tbxTimKiemHoaDonCho.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxTimKiemHoaDonCho.BorderRadius = 15;
            this._tbxTimKiemHoaDonCho.BorderSize = 2;
            this._tbxTimKiemHoaDonCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxTimKiemHoaDonCho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxTimKiemHoaDonCho.Location = new System.Drawing.Point(6, 18);
            this._tbxTimKiemHoaDonCho.Margin = new System.Windows.Forms.Padding(4);
            this._tbxTimKiemHoaDonCho.MaxLength = 20;
            this._tbxTimKiemHoaDonCho.Multiline = false;
            this._tbxTimKiemHoaDonCho.Name = "_tbxTimKiemHoaDonCho";
            this._tbxTimKiemHoaDonCho.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxTimKiemHoaDonCho.PasswordChar = false;
            this._tbxTimKiemHoaDonCho.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxTimKiemHoaDonCho.PlaceholderText = "";
            this._tbxTimKiemHoaDonCho.Size = new System.Drawing.Size(283, 31);
            this._tbxTimKiemHoaDonCho.TabIndex = 42;
            this._tbxTimKiemHoaDonCho.Texts = "";
            this._tbxTimKiemHoaDonCho.UnderlinedStyle = false;
            this._tbxTimKiemHoaDonCho._TextChanged += new System.EventHandler(this._tbxTimKiemHoaDonCho__TextChanged);
            // 
            // _lsvHoaDonCho
            // 
            this._lsvHoaDonCho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHoaDon,
            this.MaHoaDon,
            this.PhuongThuaMua});
            this._lsvHoaDonCho.FullRowSelect = true;
            this._lsvHoaDonCho.Location = new System.Drawing.Point(6, 55);
            this._lsvHoaDonCho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lsvHoaDonCho.Name = "_lsvHoaDonCho";
            this._lsvHoaDonCho.Size = new System.Drawing.Size(283, 155);
            this._lsvHoaDonCho.TabIndex = 2;
            this._lsvHoaDonCho.UseCompatibleStateImageBehavior = false;
            this._lsvHoaDonCho.View = System.Windows.Forms.View.Details;
            this._lsvHoaDonCho.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this._lsvHoaDonCho_ColumnClick);
            this._lsvHoaDonCho.DoubleClick += new System.EventHandler(this._lsvHoaDonCho_DoubleClick);
            // 
            // IdHoaDon
            // 
            this.IdHoaDon.Text = "Id";
            this.IdHoaDon.Width = 0;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.Text = "Mã hóa đơn";
            this.MaHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaHoaDon.Width = 120;
            // 
            // PhuongThuaMua
            // 
            this.PhuongThuaMua.Text = "Phương thức mua";
            this.PhuongThuaMua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhuongThuaMua.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // _btnTaoHoaDon
            // 
            this._btnTaoHoaDon.BackColor = System.Drawing.Color.Turquoise;
            this._btnTaoHoaDon.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnTaoHoaDon.BorderColor = System.Drawing.Color.Black;
            this._btnTaoHoaDon.BorderRadius = 15;
            this._btnTaoHoaDon.BorderSize = 2;
            this._btnTaoHoaDon.FlatAppearance.BorderSize = 0;
            this._btnTaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnTaoHoaDon.ForeColor = System.Drawing.Color.Black;
            this._btnTaoHoaDon.Location = new System.Drawing.Point(21, 172);
            this._btnTaoHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnTaoHoaDon.Name = "_btnTaoHoaDon";
            this._btnTaoHoaDon.Size = new System.Drawing.Size(388, 29);
            this._btnTaoHoaDon.SizeImage = new System.Drawing.Size(20, 20);
            this._btnTaoHoaDon.TabIndex = 16;
            this._btnTaoHoaDon.Text = "Tạo Hóa Đơn";
            this._btnTaoHoaDon.TextColor = System.Drawing.Color.Black;
            this._btnTaoHoaDon.UseVisualStyleBackColor = false;
            this._btnTaoHoaDon.Click += new System.EventHandler(this._btnTaoHoaDon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // _tbxMaHoaDon
            // 
            this._tbxMaHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this._tbxMaHoaDon.BorderColor = System.Drawing.Color.Black;
            this._tbxMaHoaDon.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxMaHoaDon.BorderRadius = 15;
            this._tbxMaHoaDon.BorderSize = 2;
            this._tbxMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxMaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxMaHoaDon.Location = new System.Drawing.Point(169, 27);
            this._tbxMaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this._tbxMaHoaDon.MaxLength = 20;
            this._tbxMaHoaDon.Multiline = false;
            this._tbxMaHoaDon.Name = "_tbxMaHoaDon";
            this._tbxMaHoaDon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxMaHoaDon.PasswordChar = false;
            this._tbxMaHoaDon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxMaHoaDon.PlaceholderText = "";
            this._tbxMaHoaDon.Size = new System.Drawing.Size(551, 31);
            this._tbxMaHoaDon.TabIndex = 20;
            this._tbxMaHoaDon.Texts = "";
            this._tbxMaHoaDon.UnderlinedStyle = false;
            // 
            // _cbxKhachHang
            // 
            this._cbxKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxKhachHang.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxKhachHang.BorderSize = 1;
            this._cbxKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxKhachHang.ForeColor = System.Drawing.Color.DimGray;
            this._cbxKhachHang.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxKhachHang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxKhachHang.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxKhachHang.Location = new System.Drawing.Point(170, 65);
            this._cbxKhachHang.MinimumSize = new System.Drawing.Size(200, 30);
            this._cbxKhachHang.Name = "_cbxKhachHang";
            this._cbxKhachHang.Padding = new System.Windows.Forms.Padding(1);
            this._cbxKhachHang.Size = new System.Drawing.Size(551, 30);
            this._cbxKhachHang.TabIndex = 21;
            this._cbxKhachHang.Texts = "";
            // 
            // _cbxNhanVien
            // 
            this._cbxNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxNhanVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxNhanVien.BorderSize = 1;
            this._cbxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxNhanVien.ForeColor = System.Drawing.Color.DimGray;
            this._cbxNhanVien.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxNhanVien.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxNhanVien.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxNhanVien.Location = new System.Drawing.Point(169, 101);
            this._cbxNhanVien.MinimumSize = new System.Drawing.Size(200, 30);
            this._cbxNhanVien.Name = "_cbxNhanVien";
            this._cbxNhanVien.Padding = new System.Windows.Forms.Padding(1);
            this._cbxNhanVien.Size = new System.Drawing.Size(552, 30);
            this._cbxNhanVien.TabIndex = 22;
            this._cbxNhanVien.Texts = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._btnShipHang);
            this.groupBox3.Controls.Add(this._cbxPhuongThucMua);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this._btnThanhToan);
            this.groupBox3.Controls.Add(this._cbxNhanVien);
            this.groupBox3.Controls.Add(this._cbxKhachHang);
            this.groupBox3.Controls.Add(this._tbxMaHoaDon);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this._btnTaoHoaDon);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(616, 599);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(730, 218);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin";
            // 
            // _btnShipHang
            // 
            this._btnShipHang.BackColor = System.Drawing.Color.Turquoise;
            this._btnShipHang.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnShipHang.BorderColor = System.Drawing.Color.Black;
            this._btnShipHang.BorderRadius = 15;
            this._btnShipHang.BorderSize = 2;
            this._btnShipHang.FlatAppearance.BorderSize = 0;
            this._btnShipHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnShipHang.ForeColor = System.Drawing.Color.Black;
            this._btnShipHang.Location = new System.Drawing.Point(571, 172);
            this._btnShipHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnShipHang.Name = "_btnShipHang";
            this._btnShipHang.Size = new System.Drawing.Size(150, 29);
            this._btnShipHang.SizeImage = new System.Drawing.Size(20, 20);
            this._btnShipHang.TabIndex = 44;
            this._btnShipHang.Text = "Ship hàng";
            this._btnShipHang.TextColor = System.Drawing.Color.Black;
            this._btnShipHang.UseVisualStyleBackColor = false;
            this._btnShipHang.Click += new System.EventHandler(this._btnShipHang_Click);
            // 
            // _cbxPhuongThucMua
            // 
            this._cbxPhuongThucMua.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxPhuongThucMua.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxPhuongThucMua.BorderSize = 1;
            this._cbxPhuongThucMua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxPhuongThucMua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxPhuongThucMua.ForeColor = System.Drawing.Color.DimGray;
            this._cbxPhuongThucMua.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxPhuongThucMua.Items.AddRange(new object[] {
            "Mua tại cửa hàng",
            "Đặt hàng online"});
            this._cbxPhuongThucMua.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxPhuongThucMua.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxPhuongThucMua.Location = new System.Drawing.Point(169, 137);
            this._cbxPhuongThucMua.MinimumSize = new System.Drawing.Size(200, 30);
            this._cbxPhuongThucMua.Name = "_cbxPhuongThucMua";
            this._cbxPhuongThucMua.Padding = new System.Windows.Forms.Padding(1);
            this._cbxPhuongThucMua.Size = new System.Drawing.Size(552, 30);
            this._cbxPhuongThucMua.TabIndex = 43;
            this._cbxPhuongThucMua.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Phương thức mua";
            // 
            // _btnThanhToan
            // 
            this._btnThanhToan.BackColor = System.Drawing.Color.Turquoise;
            this._btnThanhToan.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnThanhToan.BorderColor = System.Drawing.Color.Black;
            this._btnThanhToan.BorderRadius = 15;
            this._btnThanhToan.BorderSize = 2;
            this._btnThanhToan.FlatAppearance.BorderSize = 0;
            this._btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this._btnThanhToan.Location = new System.Drawing.Point(415, 172);
            this._btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnThanhToan.Name = "_btnThanhToan";
            this._btnThanhToan.Size = new System.Drawing.Size(150, 29);
            this._btnThanhToan.SizeImage = new System.Drawing.Size(20, 20);
            this._btnThanhToan.TabIndex = 41;
            this._btnThanhToan.Text = "Thanh Toán";
            this._btnThanhToan.TextColor = System.Drawing.Color.Black;
            this._btnThanhToan.UseVisualStyleBackColor = false;
            this._btnThanhToan.Click += new System.EventHandler(this._btnThanhToan_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._tbxTimKienHoaDonChuaThanhToan);
            this.groupBox5.Controls.Add(this._lsvHoaDonChuaThanhToan);
            this.groupBox5.Location = new System.Drawing.Point(314, 599);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(296, 218);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hóa đơn chưa thanh toán";
            // 
            // _tbxTimKienHoaDonChuaThanhToan
            // 
            this._tbxTimKienHoaDonChuaThanhToan.BackColor = System.Drawing.SystemColors.Window;
            this._tbxTimKienHoaDonChuaThanhToan.BorderColor = System.Drawing.Color.Black;
            this._tbxTimKienHoaDonChuaThanhToan.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxTimKienHoaDonChuaThanhToan.BorderRadius = 15;
            this._tbxTimKienHoaDonChuaThanhToan.BorderSize = 2;
            this._tbxTimKienHoaDonChuaThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxTimKienHoaDonChuaThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxTimKienHoaDonChuaThanhToan.Location = new System.Drawing.Point(6, 18);
            this._tbxTimKienHoaDonChuaThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this._tbxTimKienHoaDonChuaThanhToan.MaxLength = 20;
            this._tbxTimKienHoaDonChuaThanhToan.Multiline = false;
            this._tbxTimKienHoaDonChuaThanhToan.Name = "_tbxTimKienHoaDonChuaThanhToan";
            this._tbxTimKienHoaDonChuaThanhToan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxTimKienHoaDonChuaThanhToan.PasswordChar = false;
            this._tbxTimKienHoaDonChuaThanhToan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxTimKienHoaDonChuaThanhToan.PlaceholderText = "";
            this._tbxTimKienHoaDonChuaThanhToan.Size = new System.Drawing.Size(283, 31);
            this._tbxTimKienHoaDonChuaThanhToan.TabIndex = 42;
            this._tbxTimKienHoaDonChuaThanhToan.Texts = "";
            this._tbxTimKienHoaDonChuaThanhToan.UnderlinedStyle = false;
            this._tbxTimKienHoaDonChuaThanhToan._TextChanged += new System.EventHandler(this._tbxTimKienHoaDonchuaThanhToan__TextChanged);
            // 
            // _lsvHoaDonChuaThanhToan
            // 
            this._lsvHoaDonChuaThanhToan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._Id_,
            this._MaHoaDon_,
            this._PhuongThucMua_});
            this._lsvHoaDonChuaThanhToan.FullRowSelect = true;
            this._lsvHoaDonChuaThanhToan.Location = new System.Drawing.Point(6, 55);
            this._lsvHoaDonChuaThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._lsvHoaDonChuaThanhToan.Name = "_lsvHoaDonChuaThanhToan";
            this._lsvHoaDonChuaThanhToan.Size = new System.Drawing.Size(283, 155);
            this._lsvHoaDonChuaThanhToan.TabIndex = 2;
            this._lsvHoaDonChuaThanhToan.UseCompatibleStateImageBehavior = false;
            this._lsvHoaDonChuaThanhToan.View = System.Windows.Forms.View.Details;
            this._lsvHoaDonChuaThanhToan.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this._lsvHoaDonChuaThanhToan_ColumnClick);
            this._lsvHoaDonChuaThanhToan.DoubleClick += new System.EventHandler(this._lsvHoaDonChuaThanhToan_DoubleClick);
            // 
            // _Id_
            // 
            this._Id_.Text = "Id";
            this._Id_.Width = 0;
            // 
            // _MaHoaDon_
            // 
            this._MaHoaDon_.Text = "Mã hóa đơn";
            this._MaHoaDon_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._MaHoaDon_.Width = 120;
            // 
            // _PhuongThucMua_
            // 
            this._PhuongThucMua_.Text = "Phương thức mua";
            this._PhuongThucMua_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._PhuongThucMua_.Width = 150;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 828);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private ListView _lsvShowSanPham;
        private ColumnHeader Id;
        private ColumnHeader TenGiay;
        private ColumnHeader MauSac;
        private ColumnHeader HangGiay;
        private ColumnHeader Nsx;
        private ColumnHeader Size;
        private ColumnHeader ChieuCaoDeGiay;
        private ColumnHeader GiaBan;
        private ColumnHeader SoLuongTon;
        private ColumnHeader MoTa;
        private ListView _lsvGioHang;
        private ColumnHeader _Id;
        private ColumnHeader _TenGiay;
        private ColumnHeader _DonGia;
        private ColumnHeader _SoLuong;
        private ListView _lsvHoaDonCho;
        private ColumnHeader IdHoaDon;
        private ColumnHeader MaHoaDon;
        private Label label1;
        private Label label2;
        private RJControls.RJButton _btnTaoHoaDon;
        private Label label3;
        private RJControls.RJTextBox _tbxMaHoaDon;
        private RJControls.RJComboBox _cbxKhachHang;
        private RJControls.RJComboBox _cbxNhanVien;
        private GroupBox groupBox3;
        private RJControls.RJButton _btnThanhToan;
        private RJControls.RJTextBox _tbxTimKiemThongTinSanPham;
        private RJControls.RJTextBox _tbxTimKiemGioHang;
        private RJControls.RJTextBox _tbxTimKiemHoaDonCho;
        private RJControls.RJComboBox _cbxPhuongThucMua;
        private Label label4;
        private ColumnHeader PhuongThuaMua;
        private RJControls.RJButton _btnShipHang;
        private GroupBox groupBox5;
        private RJControls.RJTextBox _tbxTimKienHoaDonChuaThanhToan;
        private ListView _lsvHoaDonChuaThanhToan;
        private ColumnHeader _Id_;
        private ColumnHeader _MaHoaDon_;
        private ColumnHeader _PhuongThucMua_;
    }
}