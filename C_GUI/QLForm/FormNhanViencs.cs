using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.QLForm
{
    public partial class FormNhanViencs : Form
    {
        public IQLNhanVien _IQlNhanVien;
        public IQLCuaHang _IQlCuaHang;
        public IQLChucVu _IQlChucVu;
        private Guid _ID;
        public FormNhanViencs()
        {
            _IQlNhanVien = new QLNhanVien();
            _IQlChucVu = new QLChucVu();
            _IQlCuaHang = new QLCuaHang();
            InitializeComponent();
            LoadcmbChucVu();
            LoadcmbCuaHang();
            LoadData();
        }
        public void LoadcmbChucVu()
        {
            foreach (NhanVienView a in _IQlNhanVien.GetAllView())
            {
                _ = cmb_chucvu.Items.Add(a.ChucVu.TenChucVu);
            }
        }
        public void LoadcmbCuaHang()
        {

            foreach (NhanVienView a in _IQlNhanVien.GetAllView())
            {
                _ = cmb_cuahang.Items.Add(a.CuaHang.TenCuaHang);
            }
        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_shownhanvien.ColumnCount = 13;
            dgrid_shownhanvien.Columns[0].Name = "stt";
            dgrid_shownhanvien.Columns[1].Name = "id";
            dgrid_shownhanvien.Columns[2].Name = "ma";
            dgrid_shownhanvien.Columns[3].Name = "ten";
            dgrid_shownhanvien.Columns[4].Name = "email";
            dgrid_shownhanvien.Columns[5].Name = "gioi tinh";
            dgrid_shownhanvien.Columns[6].Name = "ngay sinh";
            dgrid_shownhanvien.Columns[7].Name = "sdt";
            dgrid_shownhanvien.Columns[8].Name = "dia chi";
            dgrid_shownhanvien.Columns[9].Name = "mat khau";
            dgrid_shownhanvien.Columns[10].Name = "chuc vu";
            dgrid_shownhanvien.Columns[11].Name = "cua hang";
            dgrid_shownhanvien.Columns[12].Name = "trang thai";
            dgrid_shownhanvien.Rows.Clear();
            dgrid_shownhanvien.Columns[1].Visible = true;
            foreach (NhanVienView a in _IQlNhanVien.GetAllView())
            {

                _ = dgrid_shownhanvien.Rows.Add(stt++, a.NhanVien.Id, a.NhanVien.MaNhanVien, a.NhanVien.TenNhanVien, a.NhanVien.Email, a.NhanVien.GioiTinh == 1 ? "nam" : "nu", a.NhanVien.NgaySinh, a.NhanVien.Sdt, a.NhanVien.DiaChi, a.NhanVien.MatKhau, a.ChucVu.TenChucVu, a.CuaHang.TenCuaHang, a.NhanVien.TrangThai == 1 ? "hoạt động" : "Không hoạt động");
            }

        }

        public NhanVien GetvaluaContro()
        {
            ChucVuView? x = _IQlChucVu.GetAllView().FirstOrDefault(c => c.ChucVu.TenChucVu == cmb_chucvu.Texts);

            CuaHangView? y = _IQlCuaHang.GetAllView().FirstOrDefault(c => c.CuaHang.TenCuaHang == cmb_cuahang.Texts);
            return new NhanVien()
            {
                MaNhanVien = txt_ma.Texts,
                TenNhanVien = txt_ten.Texts,
                Email = txt_email.Texts,
                NgaySinh = dtt_ngaysinh.Value,
                GioiTinh = rbtn_nam.Checked == true ? 1 : 0,
                Sdt = txt_sdt.Texts,
                DiaChi = txt_diachi.Texts,
                MatKhau = txt_matkhau.Texts,
                TrangThai = cbx_hoatdong.Checked == true ? 1 : 0,
                IdChucVu = x.ChucVu.Id,
                IdCuaHang = y.CuaHang.Id,
            };
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void dgrid_shownhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_shownhanvien.Rows[index].Cells[1].Value.ToString());
            txt_ma.Texts = dgrid_shownhanvien.Rows[index].Cells[2].Value.ToString();
            txt_ten.Texts = dgrid_shownhanvien.Rows[index].Cells[3].Value.ToString();
            //txt_email.Texts = dgrid_shownhanvien.Rows[index].Cells[4].Value.ToString();
            if (dgrid_shownhanvien.Rows[index].Cells[5].Value.ToString() == "nam")
            {
                rbtn_nam.Checked = true;
            }
            if (dgrid_shownhanvien.Rows[index].Cells[5].Value.ToString() == "nu")
            {
                rbtn_nu.Checked = true;
            }
            dtt_ngaysinh.Value = (DateTime)dgrid_shownhanvien.Rows[index].Cells[6].Value;
            txt_sdt.Texts = dgrid_shownhanvien.Rows[index].Cells[7].Value.ToString();
            txt_diachi.Texts = dgrid_shownhanvien.Rows[index].Cells[8].Value.ToString();
            txt_matkhau.Texts = dgrid_shownhanvien.Rows[index].Cells[9].Value.ToString();

            NhanVien a = _IQlNhanVien.GetAllView().FirstOrDefault(c => c.NhanVien.Id == _ID).NhanVien;
            cmb_chucvu.SelectedItem = _IQlNhanVien.GetAllView().FirstOrDefault(c => c.NhanVien.IdChucVu == a.IdChucVu).ChucVu.TenChucVu;
            cmb_cuahang.SelectedItem = _IQlNhanVien.GetAllView().FirstOrDefault(c => c.NhanVien.IdCuaHang == a.IdCuaHang).CuaHang.TenCuaHang;

            ;
            if (dgrid_shownhanvien.Rows[index].Cells[12].Value.ToString() == "hoạt động")
            {
                cbx_hoatdong.Checked = true;
                cbx_khonghoatdong.Checked = false;
            }
            if (dgrid_shownhanvien.Rows[index].Cells[12].Value.ToString() == "không hoạt động")
            {
                cbx_hoatdong.Checked = false;
                cbx_khonghoatdong.Checked = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _ = _IQlNhanVien.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ChucVuView? x = _IQlChucVu.GetAllView().FirstOrDefault(c => c.ChucVu.TenChucVu == cmb_chucvu.Texts);

            CuaHangView? y = _IQlCuaHang.GetAllView().FirstOrDefault(c => c.CuaHang.TenCuaHang == cmb_cuahang.Texts);
            bool thongBao = _IQlNhanVien.Update(new A_DAL.Entities.NhanVien()
            {
                Id = _ID,
                MaNhanVien = txt_ma.Texts,
                TenNhanVien = txt_ten.Texts,
                Email = txt_email.Texts,
                NgaySinh = dtt_ngaysinh.Value,
                GioiTinh = rbtn_nam.Checked == true ? 1 : 0,
                Sdt = txt_sdt.Texts,
                DiaChi = txt_diachi.Texts,
                MatKhau = txt_matkhau.Texts,
                TrangThai = cbx_hoatdong.Checked == true ? 1 : 0,
                IdChucVu = x.ChucVu.Id,
                IdCuaHang = y.CuaHang.Id,
            });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQlNhanVien.Delete(_IQlNhanVien.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }
    }
}
