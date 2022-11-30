<<<<<<< Updated upstream
﻿namespace C_GUI.Views
=======
﻿using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using C_GUI.QLForm;

using System.Data;
using OfficeOpenXml;

namespace C_GUI.Views
>>>>>>> Stashed changes
{
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }
<<<<<<< Updated upstream
=======

        public void LoadComBo()
        {
            foreach (var mauSac in _MauSac.GetAll())
            {
                cmb_mausac.Items.Add(mauSac.TenMauSac);
            }

            foreach (var nsx in _Nsx.GetAll())
            {
                _rjcmbNSX.Items.Add(nsx.TenNsx);
            }

            foreach (var siz in _Size.GetAll())
            {
                _rjcmbSize.Items.Add(siz.TenSize);
            }

            foreach (var hangGiay in _hangGiay.GetAll())
            {
                _rjcmbHangGiay.Items.Add(hangGiay.TenHangGiay);
            }

            foreach (var chieuCaoDeGiay in _ChieuCaoDeGiay.GetAll())
            {
                _rjcmbCCDeGiay.Items.Add(chieuCaoDeGiay.KichCo);
            }

            foreach (var VARIABLE in _Giay.GetAll())
            {
                _rjcmbTenGiay.Items.Add(VARIABLE.TenGiay);
            }

            foreach (var a in _theloai.GetAll())
            {
                cmb_theloai.Items.Add(a.TenTheLoai);
            }
        }

        public void LoadData()
        {
            _dgrvThongTinSanPham.ColumnCount = 20;
            _dgrvThongTinSanPham.Columns[0].Name = "ID";
            _dgrvThongTinSanPham.Columns[0].Visible=false;
            _dgrvThongTinSanPham.Columns[1].Name="Tên Màu Sắc";
            _dgrvThongTinSanPham.Columns[2].Name = "Tên Nhà Sản Xuất";
            _dgrvThongTinSanPham.Columns[3].Name = "Tên Size";
            _dgrvThongTinSanPham.Columns[4].Name = "Tên hãng Giày";
            _dgrvThongTinSanPham.Columns[5].Name = " Kich Co";
            _dgrvThongTinSanPham.Columns[6].Name = "Tên giày";
            _dgrvThongTinSanPham.Columns[7].Name = "Mô Tả ";
            _dgrvThongTinSanPham.Columns[8].Name = "Gia Bán";
            _dgrvThongTinSanPham.Columns[9].Name = "Giá Nhập";
            _dgrvThongTinSanPham.Columns[10].Name = "Số Lương Tồn";
            _dgrvThongTinSanPham.Rows.Clear();
            foreach (var VARIABLE in _ChiTietGiay.GetAllView())
            {
                _dgrvThongTinSanPham.Rows.Add(VARIABLE.ChiTietGiay.Id, VARIABLE.MauSac.TenMauSac,VARIABLE.Nsx.TenNsx,VARIABLE.Size.TenSize,VARIABLE.HangGiay.TenHangGiay,VARIABLE.ChieuCaoDeGiay.KichCo,VARIABLE.Giay.TenGiay,VARIABLE.ChiTietGiay.MoTa,VARIABLE.ChiTietGiay.GiaBan,VARIABLE.ChiTietGiay.GiaNhap,VARIABLE.ChiTietGiay.SoLuongTon);
            }
        }

        private void btn_nsx_Click(object sender, EventArgs e)
        {
            this.Hide();
            c.ShowDialog();
            
        }

        private void btn_size_Click(object sender, EventArgs e)
        {
            this.Hide();
            size.ShowDialog();
        }

        private void Btn_hanggiay_Click(object sender, EventArgs e)
        {
            this.Hide();
            HangGiay.ShowDialog();
        }

        private void btn_chieuCaodegiay_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChieuCaoDeGiay.ShowDialog();
        }

        private void btn_mausac_Click(object sender, EventArgs e)
        {
            this.Hide();
            MauSac.ShowDialog();
        }

        private void btn_theloai_Click(object sender, EventArgs e)
        {
            this.Hide();
            TheLoai.ShowDialog();
        }

        private void btn_giay_Click(object sender, EventArgs e)
        {this.Hide();
            Giay.ShowDialog();
        }

        private void _rjbtnRemove_Click(object sender, EventArgs e)
        {
            var xoa = _ChiTietGiay.GetAll().FirstOrDefault(c => c.Id == Idwhenclick);
            var a = MessageBox.Show("Thông Báo", "Bạn Có Muốn Sửa Không", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {

                if (_ChiTietGiay.Delete(xoa))
                {
                    MessageBox.Show("Xóa Thành Công");
                    LoadData();
                }
            }
        }

        private void _rjbtnAdd_Click(object sender, EventArgs e)
        {
            var mausac = _MauSac.GetAll().FirstOrDefault(c => c.TenMauSac == cmb_mausac.Texts);
            var nsx = _Nsx.GetAll().FirstOrDefault(c => c.TenNsx == _rjcmbNSX.Texts);
            var hanggiay = _hangGiay.GetAll().FirstOrDefault(c => c.TenHangGiay == _rjcmbHangGiay.Texts);
            var size = _Size.GetAll().FirstOrDefault(c => c.TenSize == _rjcmbSize.Texts);
            var giay = _Giay.GetAll().FirstOrDefault(c => c.TenGiay == _rjcmbTenGiay.Texts);
            var ccDeGiay = _ChieuCaoDeGiay.GetAll().FirstOrDefault(c => c.KichCo == int.Parse(_rjcmbCCDeGiay.Texts));
            bool thongbao = _ChiTietGiay.Add(new ChiTietGiay()
            {
                Id = Guid.NewGuid(),
                IdMauSac = mausac.Id,
                IdNsx = nsx.Id,
                IdSize = size.Id,
                IdHangGiay = hanggiay.Id,
                IdChieuCaoDeGiay = ccDeGiay.Id,
                IdGiay = giay.Id,
                MoTa = _rtbxMota.Text,
                GiaBan = int.Parse(_rjtbxGiaBan.Texts),
                GiaNhap = int.Parse(_rjtbxGiaNhap.Texts),
                SoLuongTon = int.Parse(_rjtbxSoLuongTon.Texts),
                TrangThai = 1
            });
          var hoi = MessageBox.Show(" Thông Báo", "Bạn có Muốn thêm ko", MessageBoxButtons.YesNo);
          if (hoi == DialogResult.Yes)
          {
              if (thongbao)
              {
                  MessageBox.Show("Thêm Thành Công");
                  LoadData();
              }
              else
              {
                  MessageBox.Show("Thêm Thất Bại");
              }
          }
        }

        private void _dgrvThongTinSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Idwhenclick = Guid.Parse(_dgrvThongTinSanPham.CurrentRow.Cells[0].Value.ToString());
            cmb_mausac.SelectedItem = _dgrvThongTinSanPham.CurrentRow.Cells[1].Value.ToString();
            _rjcmbNSX.SelectedItem = _dgrvThongTinSanPham.CurrentRow.Cells[2].Value.ToString();
            _rjcmbSize.SelectedItem = _dgrvThongTinSanPham.CurrentRow.Cells[3].Value.ToString();
            _rjcmbHangGiay.SelectedItem = _dgrvThongTinSanPham.CurrentRow.Cells[4].Value.ToString();
            _rjcmbCCDeGiay.Texts = _dgrvThongTinSanPham.CurrentRow.Cells[5].Value.ToString();
            _rjcmbTenGiay.Texts = _dgrvThongTinSanPham.CurrentRow.Cells[6].Value.ToString();
            //_rtbxMota.Text = _dgrvThongTinSanPham.CurrentRow.Cells[7].Value.ToString();
            _rjtbxGiaBan.Texts = _dgrvThongTinSanPham.CurrentRow.Cells[8].Value.ToString();
            _rjtbxGiaNhap.Texts = _dgrvThongTinSanPham.CurrentRow.Cells[9].Value.ToString();
            _rjtbxSoLuongTon.Texts = _dgrvThongTinSanPham.CurrentRow.Cells[10].Value.ToString();
        }

        private void _rjbtnEdit_Click(object sender, EventArgs e)
        {
            var mausac = _MauSac.GetAll().FirstOrDefault(c => c.TenMauSac == cmb_mausac.Texts);
            var nsx = _Nsx.GetAll().FirstOrDefault(c => c.TenNsx == _rjcmbNSX.Texts);
            var hanggiay = _hangGiay.GetAll().FirstOrDefault(c => c.TenHangGiay == _rjcmbHangGiay.Texts);
            var size = _Size.GetAll().FirstOrDefault(c => c.TenSize == _rjcmbSize.Texts);
            var giay = _Giay.GetAll().FirstOrDefault(c => c.TenGiay == _rjcmbTenGiay.Texts);
            var ccDeGiay = _ChieuCaoDeGiay.GetAll().FirstOrDefault(c => c.KichCo == int.Parse(_rjcmbCCDeGiay.Texts));
            bool thongbao = _ChiTietGiay.Update(new ChiTietGiay()
            {
                Id = Idwhenclick,
                IdMauSac = mausac.Id,
                IdNsx = nsx.Id,
                IdSize = size.Id,
                IdHangGiay = hanggiay.Id,
                IdChieuCaoDeGiay = ccDeGiay.Id,
                IdGiay = giay.Id,
                MoTa = _rtbxMota.Text,
                GiaBan = int.Parse(_rjtbxGiaBan.Texts),
                GiaNhap = int.Parse(_rjtbxGiaNhap.Texts),
                SoLuongTon = int.Parse(_rjtbxSoLuongTon.Texts),
                TrangThai = 1
            });
            var hoi = MessageBox.Show(" Thông Báo", "Bạn có Muốn Sửa ko", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                if (thongbao)
                {
                    MessageBox.Show("Sửa Thành Công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = btn_link.Text;
            openFileDialog.Filter = "Excel Spreadsheet (*.XLSX;*.XLSM)|*.XLSX;*.XLSM";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btn_link.Text = openFileDialog.FileName;
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã SP");
            dt.Columns.Add("Tên SP");
            dt.Columns.Add("Năm BH");
            dt.Columns.Add("Mô tả");
            dt.Columns.Add("Gía Nhập");
            dt.Columns.Add("Gía Bán");
            dt.Columns.Add("Số Lượng Ton");
            dt.Columns.Add("Màu Sắc");
            dt.Columns.Add("Sản Phẩm Tương Tự");
            dt.Columns.Add("Nhà Sản Xuất");
            try
            {
                // mo file excel
                var package = new ExcelPackage(new FileInfo(btn_link.Text));
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                {
                    try
                    {
                        int j = 1;
                        var stt = worksheet.Cells[i, j++].Value;
                        var maSp = worksheet.Cells[i, j++].Value;
                        var tenSp = worksheet.Cells[i, j++].Value;
                        var namBH = worksheet.Cells[i, j++].Value;
                        var moTa = worksheet.Cells[i, j++].Value;
                        var giaNhap = worksheet.Cells[i, j++].Value;
                        var giaBan = worksheet.Cells[i, j++].Value;
                        var soLuong = worksheet.Cells[i, j++].Value;
                        var mauSac = worksheet.Cells[i, j++].Value;
                        var sanPhamTuongTu = worksheet.Cells[i, j++].Value;
                        var Nsx = worksheet.Cells[i, j++].Value;
                        dt.Rows.Add(stt, maSp, tenSp, namBH, moTa, giaNhap, giaBan, soLuong, mauSac, sanPhamTuongTu, Nsx);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error");
                        throw;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
               
            }
            _dgrvThongTinSanPham.DataSource = dt.DefaultView;
        }
>>>>>>> Stashed changes
    }
}
