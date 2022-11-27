namespace C_GUI.QLForm
{
    partial class FormGiay
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
            this.txt_ten = new C_GUI.RJControls.RJTextBox();
            this.txt_ma = new C_GUI.RJControls.RJTextBox();
            this.dgrid_showGiay = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new C_GUI.RJControls.RJButton();
            this.btn_sua = new C_GUI.RJControls.RJButton();
            this.btn_them = new C_GUI.RJControls.RJButton();
            this.cbx_hoatdong = new C_GUI.RJControls.RJRadioButton();
            this.cbx_khonghoatdong = new C_GUI.RJControls.RJRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_showGiay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.dgrid_showGiay);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.cbx_hoatdong);
            this.groupBox1.Controls.Add(this.cbx_khonghoatdong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 711);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN GIÀY";
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
            this.txt_ten.Location = new System.Drawing.Point(232, 168);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ten.MaxLength = 20;
            this.txt_ten.Multiline = false;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ten.PasswordChar = false;
            this.txt_ten.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ten.PlaceholderText = "";
            this.txt_ten.Size = new System.Drawing.Size(285, 35);
            this.txt_ten.TabIndex = 25;
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
            this.txt_ma.Location = new System.Drawing.Point(232, 66);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma.MaxLength = 20;
            this.txt_ma.Multiline = false;
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ma.PasswordChar = false;
            this.txt_ma.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ma.PlaceholderText = "";
            this.txt_ma.Size = new System.Drawing.Size(285, 35);
            this.txt_ma.TabIndex = 24;
            this.txt_ma.Texts = "";
            this.txt_ma.UnderlinedStyle = false;
            // 
            // dgrid_showGiay
            // 
            this.dgrid_showGiay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgrid_showGiay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_showGiay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_showGiay.Location = new System.Drawing.Point(3, 493);
            this.dgrid_showGiay.Name = "dgrid_showGiay";
            this.dgrid_showGiay.RowHeadersWidth = 51;
            this.dgrid_showGiay.RowTemplate.Height = 29;
            this.dgrid_showGiay.Size = new System.Drawing.Size(862, 215);
            this.dgrid_showGiay.TabIndex = 23;
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
            this.btn_xoa.Location = new System.Drawing.Point(485, 419);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(132, 39);
            this.btn_xoa.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
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
            this.btn_sua.Location = new System.Drawing.Point(261, 419);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(132, 39);
            this.btn_sua.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_sua.TabIndex = 21;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.Black;
            this.btn_sua.UseVisualStyleBackColor = false;
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
            this.btn_them.Location = new System.Drawing.Point(53, 419);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(132, 39);
            this.btn_them.SizeImage = new System.Drawing.Size(20, 20);
            this.btn_them.TabIndex = 20;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.Black;
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // cbx_hoatdong
            // 
            this.cbx_hoatdong.AutoSize = true;
            this.cbx_hoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.cbx_hoatdong.Location = new System.Drawing.Point(232, 267);
            this.cbx_hoatdong.MinimumSize = new System.Drawing.Size(0, 21);
            this.cbx_hoatdong.Name = "cbx_hoatdong";
            this.cbx_hoatdong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cbx_hoatdong.Size = new System.Drawing.Size(114, 24);
            this.cbx_hoatdong.TabIndex = 19;
            this.cbx_hoatdong.TabStop = true;
            this.cbx_hoatdong.Text = "Hoạt Động";
            this.cbx_hoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.cbx_hoatdong.UseVisualStyleBackColor = true;
            // 
            // cbx_khonghoatdong
            // 
            this.cbx_khonghoatdong.AutoSize = true;
            this.cbx_khonghoatdong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.cbx_khonghoatdong.Location = new System.Drawing.Point(232, 327);
            this.cbx_khonghoatdong.MinimumSize = new System.Drawing.Size(0, 21);
            this.cbx_khonghoatdong.Name = "cbx_khonghoatdong";
            this.cbx_khonghoatdong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cbx_khonghoatdong.Size = new System.Drawing.Size(161, 24);
            this.cbx_khonghoatdong.TabIndex = 18;
            this.cbx_khonghoatdong.TabStop = true;
            this.cbx_khonghoatdong.Text = "Không Hoạt Động";
            this.cbx_khonghoatdong.UnCheckedColor = System.Drawing.Color.Gray;
            this.cbx_khonghoatdong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng Thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Giày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giày";
            // 
            // FormGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 704);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGiay";
            this.Text = "FormGiay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_showGiay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private RJControls.RJRadioButton cbx_khonghoatdong;
        private RJControls.RJRadioButton cbx_hoatdong;
        private RJControls.RJButton btn_xoa;
        private RJControls.RJButton btn_sua;
        private RJControls.RJButton btn_them;
        private RJControls.RJTextBox txt_ten;
        private RJControls.RJTextBox txt_ma;
        private DataGridView dgrid_showGiay;
    }
}