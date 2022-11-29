using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.Views
{
    public partial class FormBanHang : Form
    {
        private readonly IQLChiTietGiay _qlChiTietGiay;
        private readonly IQLHoaDonChiTiet _qlHoaDonChiTiet;
        private readonly IQLKhachHang _qlKhachHang;
        private readonly IQLNhanVien _qlNhanVien;
        private readonly IQLHoaDon _qlHoaDon;
        private readonly IQLGiay _qlGiay;
        private readonly IQLMauSac _qlMauSac;
        private readonly IQLHangGiay _qlHangGiay;
        public static Guid idHoaDon;
        private readonly Guid idHoaDonDefaut;
        private readonly ListViewColumnSorter lvwColumnSorter;
        private HoaDon? hoaDon;

        public FormBanHang()
        {
            InitializeComponent();
            _qlChiTietGiay = new QLChiTietGiay();
            _qlHoaDonChiTiet = new QLHoaDonChiTiet();
            _qlKhachHang = new QLKhachHang();
            _qlNhanVien = new QLNhanVien();
            _qlHoaDon = new QLHoaDon();
            _qlGiay = new QLGiay();
            _qlMauSac = new QLMauSac();
            _qlHangGiay = new QLHangGiay();
            LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
            LoadComboBox();
            LoadHoaDon(_qlHoaDon.GetAllView().ToList());
            idHoaDonDefaut = Guid.NewGuid();
            idHoaDon = idHoaDonDefaut;
            if (_lsvHoaDon.Items.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDon.Items[0].Text);
            }
            LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
            lvwColumnSorter = new ListViewColumnSorter();
            _lsvShowSanPham.ListViewItemSorter = lvwColumnSorter;
            _lsvHoaDon.ListViewItemSorter = lvwColumnSorter;
            _lsvGioHang.ListViewItemSorter = lvwColumnSorter;
            _cbxPhuongThucMua.SelectedItem = "Mua tại cửa hàng";
            LoadData(idHoaDon);
            _cbxTimKiemHoaDon.SelectedItem = "Tất cả hóa đơn";
            _cbxTimKiemGioHang.SelectedItem = "Tất cả mã giày";
            _cbxTimKiemTenGiay.SelectedItem = "Tất cả tên giày";
            _cbxTimKiemMauSac.SelectedItem = "Tất cả màu sắc";
            _cbxTimKiemHangGiay.SelectedItem = "Tất cả hãng giày";
            hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == idHoaDon);
        }

        private void LoadChiTietGiay(List<ChiTietGiayView> lstChiTietGiayView)
        {
            _lsvShowSanPham.Items.Clear();
            foreach (B_BUS.View_Models.ChiTietGiayView item in lstChiTietGiayView)
            {
                string[] row = { item.ChiTietGiay.Id.ToString(), item.Giay.TenGiay, item.MauSac.TenMauSac, item.HangGiay.TenHangGiay, item.Nsx.TenNsx, item.Size.TenSize, item.ChieuCaoDeGiay.MaKichCo, item.ChiTietGiay.GiaBan.ToString(), item.ChiTietGiay.SoLuongTon.ToString(), item.ChiTietGiay.MoTa };
                ListViewItem listViewItem = new(row);
                _ = _lsvShowSanPham.Items.Add(listViewItem);
            }
        }

        private void LoadChiTietHoaDon(List<HoaDonChiTietView> lstHoaDonChiTietView)
        {
            _lsvGioHang.Items.Clear();
            foreach (B_BUS.View_Models.HoaDonChiTietView item in lstHoaDonChiTietView)
            {
                string[] row = { item.HoaDonChiTiet.Id.ToString(), _qlGiay.GetAll().Find(c => c.Id == item.ChTietGiay.IdGiay).MaGiay, item.HoaDonChiTiet.DonGia.ToString(), item.HoaDonChiTiet.SoLuong.ToString(), (item.HoaDonChiTiet.DonGia * item.HoaDonChiTiet.SoLuong).ToString() };
                ListViewItem listViewItem = new(row);
                _ = _lsvGioHang.Items.Add(listViewItem);
            }
        }

        private void LoadHoaDon(List<HoaDonView> lstHoaDonView)
        {
            _lsvHoaDon.Items.Clear();
            foreach (B_BUS.View_Models.HoaDonView item in lstHoaDonView)
            {
                string[] row = { item.HoaDon.Id.ToString(), item.HoaDon.MaHoaDon, item.HoaDon.PhuongThucMua == 0 ? "Mua tại cửa hàng" : "Đặt hàng online", item.HoaDon.TrangThai == 0 ? "Hóa đơn chờ" : item.HoaDon.TrangThai == 1 ? "Hóa đơn đã thanh toán" : item.HoaDon.TrangThai == 2 ? "Hóa đơn đã ship" : "Hóa đơn đã hủy", item.HoaDon.GhiChu };
                ListViewItem listViewItem = new(row);
                _ = _lsvHoaDon.Items.Add(listViewItem);
            }
            if (_lsvHoaDon.Items.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDon.Items[0].Text);
            }
            hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == idHoaDon);
            LoadData(idHoaDon);
        }

        private void LoadComboBox()
        {
            foreach (KhachHang item in _qlKhachHang.GetAll())
            {
                _ = _cbxKhachHang.Items.Add(item.SoCCCD);
            }
            foreach (Giay item in _qlGiay.GetAll())
            {
                _ = _cbxTimKiemGioHang.Items.Add(item.MaGiay);
            }
            foreach (Giay item in _qlGiay.GetAll())
            {
                _ = _cbxTimKiemTenGiay.Items.Add(item.TenGiay);
            }
            foreach (MauSac item in _qlMauSac.GetAll())
            {
                _ = _cbxTimKiemMauSac.Items.Add(item.TenMauSac);
            }
            foreach (HangGiay item in _qlHangGiay.GetAll())
            {
                _ = _cbxTimKiemHangGiay.Items.Add(item.TenHangGiay);
            }
        }

        private void _btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (_cbxKhachHang.SelectedItem != null)
            {
                string maHoaDon = "HD0";
                if (_qlHoaDon.GetAll().Count > 0)
                {
                    maHoaDon = "HD" + _qlHoaDon.GetAll().Max(c => Convert.ToInt32(c.MaHoaDon[2..]) + 1);
                }
                Guid idKhachHang = _qlKhachHang.GetAll().FirstOrDefault(c => c.SoCCCD == _cbxKhachHang.SelectedItem.ToString()).Id;
                Guid idNhanVien = TrangChu.NhanVienLogin.Id;
                int phuongThucMua = _cbxPhuongThucMua.SelectedItem.ToString() == "Đặt hàng online" ? 1 : 0;
                bool thongBao = _qlHoaDon.Add(new HoaDon() { MaHoaDon = maHoaDon, IdKhachHang = idKhachHang, IdNhanVien = idNhanVien, PhuongThucMua = phuongThucMua });
                if (thongBao)
                {
                    _ = MessageBox.Show("Thêm thành công");
                    LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                }
            }
        }

        private void _lsvShowSanPham_DoubleClick(object sender, EventArgs e)
        {
            if (idHoaDon != idHoaDonDefaut)
            {
                if (_qlHoaDon.GetAll().Find(c => c.Id == idHoaDon).TrangThai == 0)
                {
                    if (_lsvShowSanPham.SelectedItems.Count > 0)
                    {
                        Guid idGiay = new(_lsvShowSanPham.SelectedItems[0].Text);
                        ChiTietGiay? chiTietGiay = _qlChiTietGiay.GetAll().FirstOrDefault(c => c.Id == idGiay);
                        HoaDonChiTiet? hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().FirstOrDefault(c => c.IdHoaDon == idHoaDon && c.IdChiTietGiay == idGiay);
                        if (hoaDonChiTiet == null)
                        {
                            _ = _qlHoaDonChiTiet.Add(new HoaDonChiTiet() { IdHoaDon = idHoaDon, IdChiTietGiay = idGiay, SoLuong = 1, DonGia = Convert.ToSingle(_lsvShowSanPham.SelectedItems[0].SubItems[7].Text) });
                        }
                        else
                        {
                            hoaDonChiTiet.SoLuong++;
                            chiTietGiay.SoLuongTon--;
                            _ = _qlChiTietGiay.Update(chiTietGiay);
                            _ = _qlHoaDonChiTiet.Update(hoaDonChiTiet);
                            LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
                        }
                        LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                        LoadData(idHoaDon);
                    }
                }
            }
        }

        private void _lsvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            if (_lsvHoaDon.SelectedItems.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDon.SelectedItems[0].Text);
                hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == idHoaDon);
                LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                LoadData(idHoaDon);
            }
        }

        private void _lsvGioHang_DoubleClick(object sender, EventArgs e)
        {
            if (_qlHoaDon.GetAll().Find(c => c.Id == idHoaDon).TrangThai == 0)
            {
                Guid idHoaDonChiTiet = new(_lsvGioHang.SelectedItems[0].Text);
                HoaDonChiTiet hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().Find(c => c.Id == idHoaDonChiTiet);
                ChiTietGiay? chiTietGiay = _qlChiTietGiay.GetAll().FirstOrDefault(c => c.Id == hoaDonChiTiet.IdChiTietGiay);
                if (hoaDonChiTiet.SoLuong > 1)
                {
                    hoaDonChiTiet.SoLuong--;
                    _ = _qlHoaDonChiTiet.Update(hoaDonChiTiet);
                }
                else
                {
                    _ = _qlHoaDonChiTiet.Delete(hoaDonChiTiet);
                }
                chiTietGiay.SoLuongTon++;
                _ = _qlChiTietGiay.Update(chiTietGiay);
                LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
                LoadData(idHoaDon);
            }
        }

        private void _btnThanhToan_Click(object sender, EventArgs e)
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
            if (idHoaDon != idHoaDonDefaut)
            {
                if (_qlHoaDon.GetAll().Find(c => c.Id == idHoaDon).TrangThai is not 1 and not (-1))
                {
                    if (Convert.ToSingle(_tbxTienThua.Texts) >= 0)
                    {

                        if (hoaDon.PhuongThucMua == 1 && hoaDon.TrangThai != 2)
                        {
                            DialogResult result = MessageBox.Show("Đây là hóa đơn đặt hàng online khi thanh toán sẽ thực hiện ship cho khách. Hãy chắc chắn rằng khách hàng đã đồng ý với các điều khoản của cửa hàng về sản phẩm và đồng ý với phí ship đã định", "Thông báo", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                hoaDon.TrangThai = 1;
                                hoaDon.ThoiGianThanhToan = DateTime.Now;
                                hoaDon.GiamGia = Convert.ToSingle(_tbxGiamGia.Texts);
                                hoaDon.GhiChu = _tbxGhiChu.Texts;
                                _ = _qlHoaDon.Update(hoaDon);
                                _ = MessageBox.Show("Thanh toán thành công");
                                LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                                return;
                            }
                        }
                        hoaDon.TrangThai = 1;
                        hoaDon.ThoiGianThanhToan = DateTime.Now;
                        hoaDon.GiamGia = Convert.ToSingle(_tbxGiamGia.Texts);
                        hoaDon.GhiChu = _tbxGhiChu.Texts;
                        _ = _qlHoaDon.Update(hoaDon);
                        _ = MessageBox.Show("Thanh toán thành công");
                        LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                    }
                }
            }
        }

        private void LoadData(Guid? idHoaDon)
        {

            _tbxMaHoaDon.Texts = hoaDon.MaHoaDon;
            float tongTien = 0;
            foreach (HoaDonChiTiet? item in _qlHoaDonChiTiet.GetAll().Where(c => c.IdHoaDon == idHoaDon))
            {
                tongTien += item.SoLuong * item.DonGia;
            }
            _tbxTongTien.Texts = tongTien.ToString();
            _tbxTienKhachDua.Texts = "0";
            _tbxTienThua.Texts = (Convert.ToSingle(_tbxTienKhachDua.Texts) - Convert.ToSingle(_tbxTongTien.Texts)).ToString();
        }

        private void _lsvShowSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            _lsvShowSanPham.Sort();
        }

        private void _lsvGioHang_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            _lsvGioHang.Sort();
        }

        private void _lsvHoaDon_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            _lsvHoaDon.Sort();
        }

        private void _btnShipHang_Click(object sender, EventArgs e)
        {
            if (idHoaDon != idHoaDonDefaut)
            {
                if (hoaDon.TrangThai == 0)
                {
                    if (hoaDon.PhuongThucMua == 1)
                    {
                        DialogResult result = MessageBox.Show("Hãy chắc chắn rằng khách hàng đã đồng ý với các điều khoản của cửa hàng về sản phẩm và đồng ý với phí ship đã định", "Thông báo", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            hoaDon.ThoiGianShip = DateTime.Now;
                            hoaDon.TrangThai = 2;
                            _ = _qlHoaDon.Update(hoaDon);
                            _ = MessageBox.Show("Đã gửi yêu cầu ship hàng hóa đơn này");
                            LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                        }
                    }
                    else
                    {
                        _ = MessageBox.Show("Hóa đơn mua tại cửa hàng không cần ship");
                    }
                }
                else
                {
                    _ = MessageBox.Show("Đơn hàng đã ship");
                }
            }
        }

        private void _tbxTienKhachDua__TextChanged(object sender, EventArgs e)
        {
            try
            {
                float tienKhachDua = Convert.ToSingle(_tbxTienKhachDua.Texts);
            }
            catch (Exception)
            {
                return;
            }
            _tbxTienThua.Texts = (Convert.ToSingle(_tbxTienKhachDua.Texts) - Convert.ToSingle(_tbxTongTien.Texts)).ToString();
        }

        private void _tbxGiamGia__TextChanged(object sender, EventArgs e)
        {
            try
            {
                float giamGia = Convert.ToSingle(_tbxGiamGia.Texts);
            }
            catch (Exception)
            {
                return;
            }
            float tongTien = 0;
            foreach (HoaDonChiTiet? item in _qlHoaDonChiTiet.GetAll().Where(c => c.IdHoaDon == idHoaDon))
            {
                tongTien += item.SoLuong * item.DonGia;
            }
            tongTien -= Convert.ToSingle(_tbxGiamGia.Texts);
            if (tongTien < 0)
            {
                tongTien = 0;
            }
            _tbxTongTien.Texts = tongTien.ToString();
            _tbxTienThua.Texts = (Convert.ToSingle(_tbxTienKhachDua.Texts) - Convert.ToSingle(_tbxTongTien.Texts)).ToString();
        }

        private void _cbxTimKiemHoaDon_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int trangThai = _cbxTimKiemHoaDon.SelectedItem == "Tất cả hóa đơn" ? -2 : _cbxTimKiemHoaDon.SelectedItem == "Hóa đơn chờ" ? 0 : _cbxTimKiemHoaDon.SelectedItem == "Hóa đơn đã ship" ? 2 : _cbxTimKiemHoaDon.SelectedItem == "Hóa đơn đã thanh toán" ? 1 : -1;
            if (trangThai == -2)
            {
                LoadHoaDon(_qlHoaDon.GetAllView().ToList());
            }
            else
            {
                LoadHoaDon(_qlHoaDon.GetAllView().Where(c => c.HoaDon.TrangThai == trangThai).ToList());
            }
        }

        private void _cbxTimKiemGioHang_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string maGiay = _cbxTimKiemGioHang.SelectedItem == "Tất cả mã giày" ? "-1" : _cbxTimKiemGioHang.SelectedItem.ToString();
            if (maGiay == "-1")
            {
                LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
            }
            else
            {
                LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon && _qlGiay.GetAll().Find(d => d.Id == c.ChTietGiay.IdGiay).MaGiay == maGiay).ToList());
            }
        }

        private void LocChiTietGiay()
        {
            if (_cbxTimKiemTenGiay.SelectedItem == null || _cbxTimKiemMauSac.SelectedItem == null || _cbxTimKiemHangGiay.SelectedItem == null)
            {
                return;
            }

            List<ChiTietGiayView> lstChiTietGiayView = _qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList();
            string tenGiay = _cbxTimKiemTenGiay.SelectedItem == "Tất cả tên giày" ? "-1" : _cbxTimKiemTenGiay.SelectedItem.ToString();
            if (tenGiay != "-1")
            {
                lstChiTietGiayView = lstChiTietGiayView.Where(c => c.Giay.TenGiay == tenGiay).ToList();
            }
            string tenMauSac = _cbxTimKiemMauSac.SelectedItem == "Tất cả màu sắc" ? "-1" : _cbxTimKiemMauSac.SelectedItem.ToString();
            if (tenMauSac != "-1")
            {
                lstChiTietGiayView = lstChiTietGiayView.Where(c => c.MauSac.TenMauSac == tenMauSac).ToList();
            }
            string tenHangGiay = _cbxTimKiemHangGiay.SelectedItem == "Tất cả hãng giày" ? "-1" : _cbxTimKiemHangGiay.SelectedItem.ToString();
            if (tenHangGiay != "-1")
            {
                lstChiTietGiayView = lstChiTietGiayView.Where(c => c.HangGiay.TenHangGiay == tenHangGiay).ToList();
            }
            LoadChiTietGiay(lstChiTietGiayView);
        }

        private void _cbxTimKiemTenGiay_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LocChiTietGiay();
        }

        private void _cbxTimKiemMauSac_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LocChiTietGiay();
        }

        private void _cbxTimKiemHangGiay_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LocChiTietGiay();
        }

        private void _btnBoLoc_Click(object sender, EventArgs e)
        {
            _cbxTimKiemTenGiay.SelectedItem = "Tất cả tên giày";
            _cbxTimKiemMauSac.SelectedItem = "Tất cả màu sắc";
            _cbxTimKiemHangGiay.SelectedItem = "Tất cả hãng giày";
        }

        private void _btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            if (hoaDon.TrangThai is not 1 and not (-1))
            {
                hoaDon.TrangThai = -1;
                _ = _qlHoaDon.Update(hoaDon);
                _ = MessageBox.Show("Đã hủy hóa đơn");
                LoadHoaDon(_qlHoaDon.GetAllView().ToList());
            }
        }
    }
}
