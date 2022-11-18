using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A_DAL.Entities;
using Accessibility;
using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.QLForm
{
    public partial class FormChiTietThanhToan : Form
    {
        private IQLHoaDon _HoaDon;
        private IQLPhuongThucThanhToan _Pttt;
        private IQLChiTietThanhToan _CTTT;
        Guid idwhenclick;
        public FormChiTietThanhToan()
        {
            InitializeComponent();
            _HoaDon = new QLHoaDon();
            _CTTT = new QLChiTietThanhToan();
            _Pttt = new QlPhuongThucThanhToan();
            combo();
            LoadData();
        }

        public void combo()
        {
            foreach (var d in _Pttt.GetAllView())
            {
                dgrv_show.Rows.Add(d.PhuongThucThanhToan.MaPhuongThucThanhToan);
            }

            foreach (var a in _HoaDon.GetAll())
            {
                dgrv_show.Rows.Add(a.MaHoaDon);
            }
        }
        public void LoadData()
        {
            dgrv_show.ColumnCount = 6;
            dgrv_show.Columns[0].Name = "Id";
            dgrv_show.Columns[0].Visible = false;
            dgrv_show.Columns[1].Name = "Mã Phương Thức Thanh Toán";
            dgrv_show.Columns[2].Name = "Mã Hoa Dơn";
            dgrv_show.Columns[3].Name = "Số Tiền Thanh Toán";
            dgrv_show.Columns[4].Name = "Ghi Chú";
            dgrv_show.Columns[5].Name = "Trạng Thái";
            dgrv_show.Rows.Clear();
            foreach (var c in _CTTT.GetAllView())
            {
                dgrv_show.Rows.Add(c.ChiTietThanhToan.Id, c.PhuongThucThanhToan.MaPhuongThucThanhToan,
                    c.HoaDon.MaHoaDon, c.ChiTietThanhToan.SoTienThanhToan, c.ChiTietThanhToan.GhiChu,
                    c.ChiTietThanhToan.TrangThai);
            }

        }

        private void dgrv_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idwhenclick = Guid.Parse(dgrv_show.CurrentRow.Cells[0].Value.ToString());
            cmb_MaThanhToan.Texts = dgrv_show.CurrentRow.Cells[1].Value.ToString();
            cmb_MaHoaDon.Texts = dgrv_show.CurrentRow.Cells[2].Value.ToString();
            tbx_sotienthanhtoan.Texts = dgrv_show.CurrentRow.Cells[3].Value.ToString();
            tbx_ghichu.Texts = dgrv_show.CurrentRow.Cells[4].Value.ToString();
            if (dgrv_show.CurrentRow.Cells[5].Value.ToString()=="Hoạt Động")
            {
                rdtn_hoatdong.Checked = true;
                rdtn_khonghoatdong.Checked = false;
            }
            if (dgrv_show.CurrentRow.Cells[5].Value.ToString() == "Không Hoạt Động")
            {
                rdtn_hoatdong.Checked = false;
                rdtn_khonghoatdong.Checked = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var x = _Pttt.GetAllView()
                .FirstOrDefault(c => c.PhuongThucThanhToan.MaPhuongThucThanhToan == cmb_MaThanhToan.Texts);
            var y = _HoaDon.GetAllView().FirstOrDefault(c => c.HoaDon.MaHoaDon == cmb_MaHoaDon.Texts);
            if (_CTTT.Add(new ChiTietThanhToan()
                {
                    Id = Guid.NewGuid(),
                    IdPhuongThucThanhToan = x.PhuongThucThanhToan.Id,
                    IdHoaDon = y.HoaDon.Id,
                    SoTienThanhToan = int.Parse(tbx_sotienthanhtoan.Texts),
                    GhiChu = tbx_ghichu.Text,
                    TrangThai = rdtn_hoatdong.Checked == true ? 1 : 0

                }))
            {
                MessageBox.Show("Thêm Thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var x = _Pttt.GetAllView()
                .FirstOrDefault(c => c.PhuongThucThanhToan.MaPhuongThucThanhToan == cmb_MaThanhToan.Texts);
            var y = _HoaDon.GetAllView().FirstOrDefault(c => c.HoaDon.MaHoaDon == cmb_MaHoaDon.Texts);
            if (_CTTT.Add(new ChiTietThanhToan()
                {
                    Id = idwhenclick,
                    IdPhuongThucThanhToan = x.PhuongThucThanhToan.Id,
                    IdHoaDon = y.HoaDon.Id,
                    SoTienThanhToan = int.Parse(tbx_sotienthanhtoan.Texts),
                    GhiChu = tbx_ghichu.Text,
                    TrangThai = rdtn_hoatdong.Checked == true ? 1 : 0

                }))
            {
                MessageBox.Show("Thêm Thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }

        }
    
    
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongbao = _CTTT.Delete(_CTTT.GetAll().Find(c => c.Id == idwhenclick)) ;
            if (thongbao)
            {
                MessageBox.Show("Xóa thành công");
                LoadData();
            }

            MessageBox.Show("Xóa Thất Bại");
        }
    }
}
