using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.Views
{
    public partial class Login : Form
    {
        private readonly IQLNhanVien _qlNhanVien;
        public Login()
        {
            InitializeComponent();
            _qlNhanVien = new QLNhanVien();
        }

        private void _btnDangNhap_Click(object sender, EventArgs e)
        {
            string maNhanVien = _tbxMaNhanVien.Texts;
            string matKhau = _tbxMatKhau.Texts;
            foreach (var item in _qlNhanVien.GetAll())
            {
                if (item.MaNhanVien == maNhanVien && item.MatKhau == matKhau)
                {
                    TrangChu.NhanVienLogin = _qlNhanVien.GetAll().FirstOrDefault(c => c.MaNhanVien == maNhanVien);
                    TrangChu trangChu = new();
                    trangChu.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Sai mã nhân viên hoặc mật khẩu");
        }
    }
}
