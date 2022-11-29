namespace C_GUI.QLForm
{
    partial class FormMauSac
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
            this.txt_ten = new C_GUI.RJControls.RJTextBox();
            this.txt_ma = new C_GUI.RJControls.RJTextBox();
            this.rbtn_khonghoatdong = new C_GUI.RJControls.RJRadioButton();
            this.rbtn_hoatdong = new C_GUI.RJControls.RJRadioButton();
            this.btn_xoa = new C_GUI.RJControls.RJButton();
            this.btn_sua = new C_GUI.RJControls.RJButton();
            this.btn_them = new C_GUI.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_show = new System.Windows.Forms.DataGridView();
            this._tbxTimKiem = new C_GUI.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).BeginInit();
            this.SuspendLayout();
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
            this.txt_ten.Location = new System.Drawing.Point(106, 75);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ten.MaxLength = 20;
            this.txt_ten.Multiline = false;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ten.PasswordChar = false;
            this.txt_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ten.PlaceholderText = "";
            this.txt_ten.Size = new System.Drawing.Size(273, 27);
            this.txt_ten.TabIndex = 32;
            this.txt_ten.Texts = "";
            this.txt_ten.UnderlinedStyle = false;
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
            this.txt_ma.Location = new System.Drawing.Point(106, 35);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ma.MaxLength = 20;
            this.txt_ma.Multiline = false;
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ma.PasswordChar = false;
            this.txt_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ma.PlaceholderText = "";
            this.txt_ma.Size = new System.Drawing.Size(273, 27);
            this.txt_ma.TabIndex = 31;
            this.txt_ma.Texts = "";
            this.txt_ma.UnderlinedStyle = false;
            // 
            // rbtn_khonghoatdong
            // 
            this.rbtn_khonghoatdong.AutoSize = true;
            this.rbtn_khonghoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtn_khonghoatdong.Location = new System.Drawing.Point(181, 152);
            this.rbtn_khonghoatdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_khonghoatdong.MinimumSize = new System.Drawing.Size(0, 16);
            this.rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
            this.rbtn_khonghoatdong.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.rbtn_khonghoatdong.Size = new System.Drawing.Size(130, 19);
            this.rbtn_khonghoatdong.TabIndex = 30;
            this.rbtn_khonghoatdong.TabStop = true;
            this.rbtn_khonghoatdong.Text = "Không Hoạt Động";
            this.rbtn_khonghoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // rbtn_hoatdong
            // 
            this.rbtn_hoatdong.AutoSize = true;
            this.rbtn_hoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtn_hoatdong.Location = new System.Drawing.Point(181, 123);
            this.rbtn_hoatdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_hoatdong.MinimumSize = new System.Drawing.Size(0, 16);
            this.rbtn_hoatdong.Name = "rbtn_hoatdong";
            this.rbtn_hoatdong.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.rbtn_hoatdong.Size = new System.Drawing.Size(92, 19);
            this.rbtn_hoatdong.TabIndex = 29;
            this.rbtn_hoatdong.TabStop = true;
            this.rbtn_hoatdong.Text = "Hoạt Động";
            this.rbtn_hoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn_hoatdong.UseVisualStyleBackColor = true;
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
            this.btn_xoa.Location = new System.Drawing.Point(258, 187);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(116, 29);
            this.btn_xoa.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoa.TabIndex = 28;
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
            this.btn_sua.Location = new System.Drawing.Point(137, 187);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(116, 29);
            this.btn_sua.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_sua.TabIndex = 27;
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
            this.btn_them.Location = new System.Drawing.Point(10, 187);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(116, 29);
            this.btn_them.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_them.TabIndex = 26;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.Black;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(58, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Trạng Thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Màu Sắc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã";
            // 
            // dgrid_show
            // 
            this.dgrid_show.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_show.Location = new System.Drawing.Point(0, 234);
            this.dgrid_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_show.Name = "dgrid_show";
            this.dgrid_show.RowHeadersWidth = 51;
            this.dgrid_show.RowTemplate.Height = 29;
            this.dgrid_show.Size = new System.Drawing.Size(700, 142);
            this.dgrid_show.TabIndex = 20;
            this.dgrid_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show_CellContentClick);
            // 
            // _tbxTimKiem
            // 
            this._tbxTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this._tbxTimKiem.BorderColor = System.Drawing.Color.Black;
            this._tbxTimKiem.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxTimKiem.BorderRadius = 15;
            this._tbxTimKiem.BorderSize = 2;
            this._tbxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxTimKiem.Location = new System.Drawing.Point(381, 187);
            this._tbxTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this._tbxTimKiem.MaxLength = 20;
            this._tbxTimKiem.Multiline = false;
            this._tbxTimKiem.Name = "_tbxTimKiem";
            this._tbxTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this._tbxTimKiem.PasswordChar = false;
            this._tbxTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxTimKiem.PlaceholderText = "";
            this._tbxTimKiem.Size = new System.Drawing.Size(319, 31);
            this._tbxTimKiem.TabIndex = 33;
            this._tbxTimKiem.Texts = "";
            this._tbxTimKiem.UnderlinedStyle = false;
            this._tbxTimKiem._TextChanged += new System.EventHandler(this._tbxTimKiem__TextChanged);
            // 
            // FormMauSac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 376);
            this.Controls.Add(this._tbxTimKiem);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.rbtn_khonghoatdong);
            this.Controls.Add(this.rbtn_hoatdong);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_show);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMauSac";
            this.Text = "FormMauSac";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.RJTextBox txt_ten;
        private RJControls.RJTextBox txt_ma;
        private RJControls.RJRadioButton rbtn_khonghoatdong;
        private RJControls.RJRadioButton rbtn_hoatdong;
        private RJControls.RJButton btn_xoa;
        private RJControls.RJButton btn_sua;
        private RJControls.RJButton btn_them;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgrid_show;
        private RJControls.RJTextBox _tbxTimKiem;
    }
}