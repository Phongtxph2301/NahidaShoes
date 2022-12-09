namespace C_GUI.Views
{
    partial class FormChucVu
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
            this.dgrid_show = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_them = new C_GUI.RJControls.RJButton();
            this.btn_sua = new C_GUI.RJControls.RJButton();
            this.btn_xoa = new C_GUI.RJControls.RJButton();
            this.rbtn_hoatdong = new C_GUI.RJControls.RJRadioButton();
            this.rbtn_khonghoatdong = new C_GUI.RJControls.RJRadioButton();
            this.txt_ma = new C_GUI.RJControls.RJTextBox();
            this.txt_ten = new C_GUI.RJControls.RJTextBox();
            this.txt_timkiem = new C_GUI.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_show
            // 
            this.dgrid_show.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_show.Location = new System.Drawing.Point(0, 266);
            this.dgrid_show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_show.Name = "dgrid_show";
            this.dgrid_show.RowHeadersWidth = 51;
            this.dgrid_show.RowTemplate.Height = 29;
            this.dgrid_show.Size = new System.Drawing.Size(625, 142);
            this.dgrid_show.TabIndex = 0;
            this.dgrid_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chức Vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(58, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trạng Thái";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_GUI.Properties.Resources.z3847898028975_5ee7ff05f8092486aaff7b938d3a1083;
            this.pictureBox1.Location = new System.Drawing.Point(398, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.btn_them.Location = new System.Drawing.Point(10, 190);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(116, 29);
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
            this.btn_sua.Location = new System.Drawing.Point(137, 190);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(116, 29);
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
            this.btn_xoa.Location = new System.Drawing.Point(258, 190);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(116, 29);
            this.btn_xoa.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // rbtn_hoatdong
            // 
            this.rbtn_hoatdong.AutoSize = true;
            this.rbtn_hoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtn_hoatdong.Location = new System.Drawing.Point(181, 126);
            this.rbtn_hoatdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_hoatdong.MinimumSize = new System.Drawing.Size(0, 16);
            this.rbtn_hoatdong.Name = "rbtn_hoatdong";
            this.rbtn_hoatdong.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.rbtn_hoatdong.Size = new System.Drawing.Size(92, 19);
            this.rbtn_hoatdong.TabIndex = 16;
            this.rbtn_hoatdong.TabStop = true;
            this.rbtn_hoatdong.Text = "Hoạt Động";
            this.rbtn_hoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rbtn_khonghoatdong
            // 
            this.rbtn_khonghoatdong.AutoSize = true;
            this.rbtn_khonghoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtn_khonghoatdong.Location = new System.Drawing.Point(181, 155);
            this.rbtn_khonghoatdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_khonghoatdong.MinimumSize = new System.Drawing.Size(0, 16);
            this.rbtn_khonghoatdong.Name = "rbtn_khonghoatdong";
            this.rbtn_khonghoatdong.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.rbtn_khonghoatdong.Size = new System.Drawing.Size(130, 19);
            this.rbtn_khonghoatdong.TabIndex = 17;
            this.rbtn_khonghoatdong.TabStop = true;
            this.rbtn_khonghoatdong.Text = "Không Hoạt Động";
            this.rbtn_khonghoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtn_khonghoatdong.UseVisualStyleBackColor = true;
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
            this.txt_ma.Location = new System.Drawing.Point(106, 38);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ma.MaxLength = 20;
            this.txt_ma.Multiline = false;
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ma.PasswordChar = false;
            this.txt_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ma.PlaceholderText = "";
            this.txt_ma.Size = new System.Drawing.Size(273, 27);
            this.txt_ma.TabIndex = 18;
            this.txt_ma.Texts = "";
            this.txt_ma.UnderlinedStyle = false;
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
            this.txt_ten.Location = new System.Drawing.Point(106, 78);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ten.MaxLength = 20;
            this.txt_ten.Multiline = false;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_ten.PasswordChar = false;
            this.txt_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ten.PlaceholderText = "";
            this.txt_ten.Size = new System.Drawing.Size(273, 27);
            this.txt_ten.TabIndex = 19;
            this.txt_ten.Texts = "";
            this.txt_ten.UnderlinedStyle = false;
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
            this.txt_timkiem.Location = new System.Drawing.Point(13, 234);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_timkiem.MaxLength = 20;
            this.txt_timkiem.Multiline = false;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.txt_timkiem.PasswordChar = false;
            this.txt_timkiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_timkiem.PlaceholderText = "";
            this.txt_timkiem.Size = new System.Drawing.Size(273, 27);
            this.txt_timkiem.TabIndex = 20;
            this.txt_timkiem.Texts = "";
            this.txt_timkiem.UnderlinedStyle = false;
            this.txt_timkiem._TextChanged += new System.EventHandler(this.txt_timkiem__TextChanged);
            this.txt_timkiem.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.txt_timkiem_ChangeUICues);
            // 
            // FormChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 408);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.rbtn_khonghoatdong);
            this.Controls.Add(this.rbtn_hoatdong);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_show);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChucVu";
            this.Text = "FormChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgrid_show;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private RJControls.RJButton btn_them;
        private RJControls.RJButton btn_sua;
        private RJControls.RJButton btn_xoa;
        private RJControls.RJRadioButton rbtn_hoatdong;
        private RJControls.RJRadioButton rbtn_khonghoatdong;
        private RJControls.RJTextBox txt_ma;
        private RJControls.RJTextBox txt_ten;
        private RJControls.RJTextBox txt_timkiem;
    }
}