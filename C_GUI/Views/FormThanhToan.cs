using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.Views
{
    public partial class FormThanhToan : Form
    {
        private readonly IQLHoaDonChiTiet _qlHoaDonChiTiet;
        private readonly IQLHoaDon _qlHoaDon;
        private readonly IQLGiay _qlGiay;

        public FormThanhToan()
        {
            InitializeComponent();
            _qlHoaDonChiTiet = new QLHoaDonChiTiet();
            _qlGiay = new QLGiay();
            _qlHoaDon = new QLHoaDon();
            LoadChiTietHoaDon(FormBanHang.idHoaDon);
            LoadData();
        }

        private void LoadChiTietHoaDon(Guid? idHoaDon)
        {
            _lsvGioHang.Items.Clear();
            foreach (B_BUS.View_Models.HoaDonChiTietView item in _qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon))
            {
                string[] row = { item.HoaDonChiTiet.Id.ToString(), _qlGiay.GetAll().Find(c => c.Id == item.ChTietGiay.IdGiay).MaGiay, item.HoaDonChiTiet.DonGia.ToString(), item.HoaDonChiTiet.SoLuong.ToString() };
                ListViewItem listViewItem = new(row);
                _ = _lsvGioHang.Items.Add(listViewItem);
            }
        }

        private void LoadData()
        {
            HoaDonView hoaDon = _qlHoaDon.GetAllView().Find(c => c.HoaDon.Id == FormBanHang.idHoaDon);
            _tbxMaHoaDon.Texts = hoaDon.HoaDon.MaHoaDon;
            _tbxMaKhachHang.Texts = hoaDon.KhachHang.MaKhachHang;
            _tbxMaNhanVien.Texts = hoaDon.NhanVien.MaNhanVien;
            float tongTien = 0;
            foreach (HoaDonChiTiet? item in _qlHoaDonChiTiet.GetAll().Where(c => c.IdHoaDon == FormBanHang.idHoaDon))
            {
                tongTien += item.SoLuong * item.DonGia;
            }
            _tbxTongTien.Texts = tongTien.ToString();
        }

        private void _btnThanhToan_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == FormBanHang.idHoaDon);
            if (hoaDon.PhuongThucMua == 1 && hoaDon.TrangThai != 2)
            {
                DialogResult result = MessageBox.Show("Đây là hóa đơn đặt hàng online khi thanh toán sẽ thực hiện ship cho khách. Hãy chắc chắn rằng khách hàng đã đồng ý với các điều khoản của cửa hàng về sản phẩm và đồng ý với phí ship đã định", "Thông báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    thanhToan(hoaDon);
                    return;
                }
            }
            thanhToan(hoaDon);
        }

        private void thanhToan(HoaDon hoaDon)
        {
            try
            {
                float giamGia = Convert.ToSingle(_tbxGiamGia.Texts);
                float tienKhachDua = Convert.ToSingle(_tbxTienKhachDua.Texts);
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                return;
            }
            if (Convert.ToSingle(_tbxTienKhachDua.Texts) < Convert.ToSingle(_tbxTongTien.Texts))
            {
                _ = MessageBox.Show("Chưa đủ tiền");
            }
            else if (Convert.ToSingle(_tbxTienKhachDua.Texts) == Convert.ToSingle(_tbxTongTien.Texts))
            {

                hoaDon.TrangThai = 1;
                hoaDon.ThoiGianThanhToan = DateTime.Now;
                hoaDon.GiamGia = Convert.ToSingle(_tbxGiamGia.Texts);
                hoaDon.GhiChu = _tbxGhiChu.Texts;
                _ = _qlHoaDon.Update(hoaDon);
                _ = MessageBox.Show("Thanh toán thành công");
                Close();
            }
            else
            {
                float soDu = Convert.ToSingle(_tbxTienKhachDua.Texts) - Convert.ToSingle(_tbxTongTien.Texts);
                _ = MessageBox.Show($"Còn dư {soDu}");
                hoaDon.TrangThai = 1;
                hoaDon.ThoiGianThanhToan = DateTime.Now;
                hoaDon.GiamGia = Convert.ToSingle(_tbxGiamGia.Texts);
                hoaDon.GhiChu = _tbxGhiChu.Texts;
                _ = _qlHoaDon.Update(hoaDon);
                _ = MessageBox.Show("Thanh toán thành công");
                Close();
            }
        }

        private void _tbxGiamGia__TextChanged(object sender, EventArgs e)
        {
            try
            {
                float giamGia = Convert.ToSingle(_tbxGiamGia.Texts);
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                return;
            }
            float tongTien = 0;
            foreach (HoaDonChiTiet? item in _qlHoaDonChiTiet.GetAll().Where(c => c.IdHoaDon == FormBanHang.idHoaDon))
            {
                tongTien += item.SoLuong * item.DonGia;
            }
            tongTien -= Convert.ToSingle(_tbxGiamGia.Texts);
            if (tongTien < 0)
            {
                tongTien = 0;
            }

            _tbxTongTien.Texts = tongTien.ToString();
        }
    }
}
