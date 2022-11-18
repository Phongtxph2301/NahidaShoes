namespace C_GUI.QLForm
{
    partial class FormChiTietThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_MaThanhToan = new C_GUI.RJControls.RJComboBox();
            this.cmb_MaHoaDon = new C_GUI.RJControls.RJComboBox();
            this.tbx_ghichu = new C_GUI.RJControls.RJTextBox();
            this.rdtn_hoatdong = new C_GUI.RJControls.RJRadioButton();
            this.rdtn_khonghoatdong = new C_GUI.RJControls.RJRadioButton();
            this.tbx_sotienthanhtoan = new C_GUI.RJControls.RJTextBox();
            this.dgrv_show = new System.Windows.Forms.DataGridView();
            this.btn_them = new C_GUI.RJControls.RJButton();
            this.btn_sua = new C_GUI.RJControls.RJButton();
            this.btn_xoa = new C_GUI.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thanh Toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Tiền Thanh Toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi Chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng Thái";
            // 
            // cmb_MaThanhToan
            // 
            this.cmb_MaThanhToan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_MaThanhToan.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_MaThanhToan.BorderSize = 1;
            this.cmb_MaThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_MaThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_MaThanhToan.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_MaThanhToan.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_MaThanhToan.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_MaThanhToan.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_MaThanhToan.Location = new System.Drawing.Point(175, 28);
            this.cmb_MaThanhToan.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_MaThanhToan.Name = "cmb_MaThanhToan";
            this.cmb_MaThanhToan.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_MaThanhToan.Size = new System.Drawing.Size(250, 41);
            this.cmb_MaThanhToan.TabIndex = 5;
            this.cmb_MaThanhToan.Texts = "";
            // 
            // cmb_MaHoaDon
            // 
            this.cmb_MaHoaDon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_MaHoaDon.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_MaHoaDon.BorderSize = 1;
            this.cmb_MaHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_MaHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_MaHoaDon.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_MaHoaDon.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_MaHoaDon.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_MaHoaDon.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_MaHoaDon.Location = new System.Drawing.Point(175, 97);
            this.cmb_MaHoaDon.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_MaHoaDon.Name = "cmb_MaHoaDon";
            this.cmb_MaHoaDon.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_MaHoaDon.Size = new System.Drawing.Size(250, 41);
            this.cmb_MaHoaDon.TabIndex = 6;
            this.cmb_MaHoaDon.Texts = "";
            // 
            // tbx_ghichu
            // 
            this.tbx_ghichu.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_ghichu.BorderColor = System.Drawing.Color.Black;
            this.tbx_ghichu.BorderFocusColor = System.Drawing.Color.Red;
            this.tbx_ghichu.BorderRadius = 15;
            this.tbx_ghichu.BorderSize = 2;
            this.tbx_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_ghichu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbx_ghichu.Location = new System.Drawing.Point(542, 66);
            this.tbx_ghichu.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ghichu.MaxLength = 20;
            this.tbx_ghichu.Multiline = false;
            this.tbx_ghichu.Name = "tbx_ghichu";
            this.tbx_ghichu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbx_ghichu.PasswordChar = false;
            this.tbx_ghichu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbx_ghichu.PlaceholderText = "";
            this.tbx_ghichu.Size = new System.Drawing.Size(312, 35);
            this.tbx_ghichu.TabIndex = 8;
            this.tbx_ghichu.Texts = "";
            this.tbx_ghichu.UnderlinedStyle = false;
            // 
            // rdtn_hoatdong
            // 
            this.rdtn_hoatdong.AutoSize = true;
            this.rdtn_hoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdtn_hoatdong.Location = new System.Drawing.Point(552, 139);
            this.rdtn_hoatdong.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdtn_hoatdong.Name = "rdtn_hoatdong";
            this.rdtn_hoatdong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdtn_hoatdong.Size = new System.Drawing.Size(114, 24);
            this.rdtn_hoatdong.TabIndex = 9;
            this.rdtn_hoatdong.TabStop = true;
            this.rdtn_hoatdong.Text = "Hoạt Động";
            this.rdtn_hoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdtn_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rdtn_khonghoatdong
            // 
            this.rdtn_khonghoatdong.AutoSize = true;
            this.rdtn_khonghoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rdtn_khonghoatdong.Location = new System.Drawing.Point(698, 136);
            this.rdtn_khonghoatdong.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdtn_khonghoatdong.Name = "rdtn_khonghoatdong";
            this.rdtn_khonghoatdong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdtn_khonghoatdong.Size = new System.Drawing.Size(161, 24);
            this.rdtn_khonghoatdong.TabIndex = 10;
            this.rdtn_khonghoatdong.TabStop = true;
            this.rdtn_khonghoatdong.Text = "Không Hoạt Động";
            this.rdtn_khonghoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdtn_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // tbx_sotienthanhtoan
            // 
            this.tbx_sotienthanhtoan.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_sotienthanhtoan.BorderColor = System.Drawing.Color.Black;
            this.tbx_sotienthanhtoan.BorderFocusColor = System.Drawing.Color.Red;
            this.tbx_sotienthanhtoan.BorderRadius = 15;
            this.tbx_sotienthanhtoan.BorderSize = 2;
            this.tbx_sotienthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_sotienthanhtoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbx_sotienthanhtoan.Location = new System.Drawing.Point(175, 166);
            this.tbx_sotienthanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_sotienthanhtoan.MaxLength = 20;
            this.tbx_sotienthanhtoan.Multiline = false;
            this.tbx_sotienthanhtoan.Name = "tbx_sotienthanhtoan";
            this.tbx_sotienthanhtoan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbx_sotienthanhtoan.PasswordChar = false;
            this.tbx_sotienthanhtoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbx_sotienthanhtoan.PlaceholderText = "";
            this.tbx_sotienthanhtoan.Size = new System.Drawing.Size(312, 35);
            this.tbx_sotienthanhtoan.TabIndex = 11;
            this.tbx_sotienthanhtoan.Texts = "";
            this.tbx_sotienthanhtoan.UnderlinedStyle = false;
            // 
            // dgrv_show
            // 
            this.dgrv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_show.Location = new System.Drawing.Point(22, 250);
            this.dgrv_show.Name = "dgrv_show";
            this.dgrv_show.RowHeadersWidth = 51;
            this.dgrv_show.RowTemplate.Height = 29;
            this.dgrv_show.Size = new System.Drawing.Size(1060, 188);
            this.dgrv_show.TabIndex = 12;
            this.dgrv_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_show_CellContentClick);
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
            this.btn_them.Location = new System.Drawing.Point(882, 19);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(188, 39);
            this.btn_them.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.Black;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
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
            this.btn_sua.Location = new System.Drawing.Point(882, 70);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(188, 39);
            this.btn_sua.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Black;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
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
            this.btn_xoa.Location = new System.Drawing.Point(882, 121);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(188, 39);
            this.btn_xoa.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // FormChiTietThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgrv_show);
            this.Controls.Add(this.tbx_sotienthanhtoan);
            this.Controls.Add(this.rdtn_khonghoatdong);
            this.Controls.Add(this.rdtn_hoatdong);
            this.Controls.Add(this.tbx_ghichu);
            this.Controls.Add(this.cmb_MaHoaDon);
            this.Controls.Add(this.cmb_MaThanhToan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChiTietThanhToan";
            this.Text = "FormChiTietThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RJControls.RJComboBox cmb_MaThanhToan;
        private RJControls.RJComboBox cmb_MaHoaDon;
        private RJControls.RJTextBox tbx_ghichu;
        private RJControls.RJRadioButton rdtn_hoatdong;
        private RJControls.RJRadioButton rdtn_khonghoatdong;
        private RJControls.RJTextBox tbx_sotienthanhtoan;
        private DataGridView dgrv_show;
        private RJControls.RJButton btn_them;
        private RJControls.RJButton btn_sua;
        private RJControls.RJButton btn_xoa;
    }
}