﻿using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using OfficeOpenXml;
using System.Data;
using Size = A_DAL.Entities.Size;

namespace C_GUI.Views
{
    public partial class FormImport : Form
    {
        public string TenMausac;
        public string TenNSX;
        public string TenSize;
        public string TenHangGiay;
        public int KichCo;
        public string TenGiay;
        public string Mota;
        public int GiaNhap;
        public int GiaBan;
        public int SoluongTon;
        private readonly IQLChiTietGiay _ChiTietGiay;
        private readonly IQLMauSac _MauSac;
        private readonly IQLNsx _Nsx;
        private readonly IQLSize _Size;
        private readonly IQLHangGiay _hangGiay;
        private readonly IQLChieuCaoDeGiay _ChieuCaoDeGiay;
        private readonly IQLGiay _Giay;
        public FormImport()
        {
            InitializeComponent();
            _ChiTietGiay = new QLChiTietGiay();
            _MauSac = new QLMauSac();
            _Nsx = new QLNsx();
            _Size = new QLSize();
            _hangGiay = new QLHangGiay();
            _ChieuCaoDeGiay = new QLChieuCaoDeGiay();
            _Giay = new QLGiay();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn chọn Nguồn Excel Ko", "Thông Báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {


                OpenFileDialog openFileDialog = new()
                {
                    FileName = btn_link.Text,
                    Filter = "Excel Spreadsheet (*.XLSX;*.XLSM)|*.XLSX;*.XLSM"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    btn_link.Text = openFileDialog.FileName;
                }

                DataTable dt = new();

                _ = dt.Columns.Add("Tên Màu Sắc");
                _ = dt.Columns.Add("Tên NSX");
                _ = dt.Columns.Add("Tên Size");
                _ = dt.Columns.Add("Hãng Giày");
                _ = dt.Columns.Add("Kích Cỡ");
                _ = dt.Columns.Add("Tên Giày");
                _ = dt.Columns.Add("Mô Tả");
                _ = dt.Columns.Add("Giá Nhập");
                _ = dt.Columns.Add("Giá bán");
                _ = dt.Columns.Add("Số Lượng tồn");
                dt.Rows.Clear();
                _dgrvThongTinSanPham.AllowUserToAddRows = false;

                try
                {
                    // mo file excel
                    ExcelPackage package = new(new FileInfo(btn_link.Text));
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                    {
                        try
                        {
                            int j = 1;
                            object tenmausac = worksheet.Cells[i, j++].Value;
                            object tennsx = worksheet.Cells[i, j++].Value;
                            object namsize = worksheet.Cells[i, j++].Value;
                            object hanggiay = worksheet.Cells[i, j++].Value;
                            object kichco = worksheet.Cells[i, j++].Value;
                            object tengiay = worksheet.Cells[i, j++].Value;
                            object mota = worksheet.Cells[i, j++].Value;
                            object gianhap = worksheet.Cells[i, j++].Value;
                            object giaban = worksheet.Cells[i, j++].Value;
                            object soluongton = worksheet.Cells[i, j++].Value;

                            _ = dt.Rows.Add(tenmausac, tennsx, namsize, hanggiay, kichco, tengiay, mota, gianhap, giaban,
                                soluongton);
                        }
                        catch (Exception)
                        {
                            _ = MessageBox.Show("Error");
                            throw;
                        }
                    }
                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Error");
                    throw;
                }

                _dgrvThongTinSanPham.DataSource = dt.DefaultView;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Muốn Lưu Dữ Liệu chứ ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < _dgrvThongTinSanPham.Rows.Count; i++)
                {
                    try
                    {

                        TenMausac = _dgrvThongTinSanPham.Rows[i].Cells[0].Value.ToString();
                        TenNSX = _dgrvThongTinSanPham.Rows[i].Cells[1].Value.ToString();
                        TenSize = _dgrvThongTinSanPham.Rows[i].Cells[2].Value.ToString();
                        TenHangGiay = _dgrvThongTinSanPham.Rows[i].Cells[3].Value.ToString();
                        KichCo = int.Parse(_dgrvThongTinSanPham.Rows[i].Cells[4].Value.ToString());
                        TenGiay = _dgrvThongTinSanPham.Rows[i].Cells[5].Value.ToString();
                        Mota = _dgrvThongTinSanPham.Rows[i].Cells[6].Value.ToString();
                        GiaBan = int.Parse(_dgrvThongTinSanPham.Rows[i].Cells[7].Value.ToString());
                        GiaNhap = int.Parse(_dgrvThongTinSanPham.Rows[i].Cells[8].Value.ToString());
                        SoluongTon = int.Parse(_dgrvThongTinSanPham.Rows[i].Cells[9].Value.ToString());

                        Nsx n = new()
                        {
                            MaNsx = (_Nsx.GetAll().Count + 1).ToString(),
                            TenNsx = TenNSX,
                            DiaChi = "Ha Noi",
                            TrangThai = 1
                        };

                        Guid IdNsx = _Nsx.IdNsx(n);
                        //  MessageBox.Show(IdNsx.ToString());


                        MauSac m = new()
                        {
                            MaMauSac = (_MauSac.GetAll().Count + 1).ToString(),
                            TenMauSac = TenMausac,
                            TrangThai = 1
                        };
                        Guid idMauSac = _MauSac.IdMauSac(m);

                        Size s = new()
                        {
                            MaSize = (_Size.GetAll().Count + 1).ToString(),
                            TenSize = TenSize,
                            SoSize = 42,
                            TrangThai = 1
                        };
                        Guid idSize = _Size.IdSize(s);

                        HangGiay h = new()
                        {
                            MaHangGiay = (_hangGiay.GetAll().Count + 1).ToString(),
                            TenHangGiay = TenHangGiay,
                            TrangThai = 1
                        };
                        Guid IdHangGiay = _hangGiay.IdHangGiay(h);

                        ChieuCaoDeGiay k = new()
                        {
                            MaKichCo = (_ChieuCaoDeGiay.GetAll().Count + 1).ToString(),
                            KichCo = KichCo,
                            TrangThai = 1
                        };
                        Guid IdKichCo = _ChieuCaoDeGiay.IdChieuCaoDeGiay(k);

                        Giay l = new()
                        {
                            MaGiay = (_Giay.GetAll().Count + 1).ToString(),
                            TenGiay = TenGiay,
                            TrangThai = 1,

                        };
                        Guid giay = _Giay.idGiay(l);
                        //  MessageBox.Show(giay.ToString());
                        ChiTietGiay spCt = new()
                        {
                            Id = Guid.NewGuid(),
                            MoTa = Mota,
                            TrangThai = 1,
                            SoLuongTon = SoluongTon,
                            GiaBan = GiaBan,
                            GiaNhap = GiaNhap,
                            IdGiay = giay,
                            IdHangGiay = IdHangGiay,
                            IdNsx = IdNsx,
                            IdMauSac = idMauSac,
                            IdChieuCaoDeGiay = IdKichCo,
                            IdSize = idSize,

                        };
                        _ = _ChiTietGiay.Add(spCt);
                        // MessageBox.Show("ID ChiTietSanPham");

                    }
                    catch (Exception)
                    {

                        _ = MessageBox.Show("Lỗi");
                    }
                }
                _ = MessageBox.Show("Thêm Thanh Công");



            }
        }
    }
}


