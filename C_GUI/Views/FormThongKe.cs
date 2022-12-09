using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.Views
{
    public partial class FormThongKe : Form
    {
        private readonly IQlDoanhThuServices _qldoanthu;

        public FormThongKe()
        {
            InitializeComponent();
            _qldoanthu = new QLDoanhThuNhanVien();
            loaddoanhthu();
            loadcbo();
            loadnam();
            loadngay();
            cmb_ngay.Visible = false;
            cmb_loc.Visible = false;
        }

        public string[] Getnam()
        {
            string[] TempNs = new string[2030 - 1999];
            for (int i = 0; i < TempNs.Length; i++)
            {
                TempNs[i] = Convert.ToString(1999 + i);
            }

            return TempNs;
        }

        public string[] Getngay()
        {
            string[] TempNs = new string[32 - 1];
            for (int i = 0; i < TempNs.Length; i++)
            {
                TempNs[i] = Convert.ToString(1 + i);
            }

            return TempNs;
        }

        private void loadngay()
        {
            foreach (string x in Getngay())
            {
                _ = cmb_ngay.Items.Add(x);
            }

        }

        private void loadnam()
        {
            foreach (string x in Getnam())
            {
                _ = cmb_nam.Items.Add(x);
            }

        }

        private void loadcbo()
        {

            string[] lstmon = new string[12];
            lstmon[0] = "1";
            lstmon[1] = "2";
            lstmon[2] = "3";
            lstmon[3] = "4";
            lstmon[4] = "5";
            lstmon[5] = "6";
            lstmon[6] = "7";
            lstmon[7] = "8";
            lstmon[8] = "9";
            lstmon[9] = "10";
            lstmon[10] = "11";
            lstmon[11] = "12";

            foreach (string x in lstmon)
            {
                _ = cmb_loc.Items.Add(x);
            }

        }

        private void loaddoanhthu()
        {
            _dgrv_doanhthu.ColumnCount = 3;
            _dgrv_doanhthu.Columns[0].Name = "Mã Nhân Viên";
            _dgrv_doanhthu.Columns[1].Name = "Tên Nhân Viên";
            _dgrv_doanhthu.Columns[2].Name = "Tổng Doanh Thu";
            _dgrv_doanhthu.Rows.Clear();
            foreach (B_BUS.View_Models.ViewDoanhThuNhanVien? x in _qldoanthu.Getlistviewdoanhthu().OrderByDescending(c => c.TongSoTien))
            {
                _ = _dgrv_doanhthu.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.TongSoTien);
            }
        }

        private void loaddoanhthuforlocall(string ngay, string thang, string nam)
        {
            _dgrv_doanhthu.ColumnCount = 3;
            _dgrv_doanhthu.Columns[0].Name = "Mã Nhân Viên";
            _dgrv_doanhthu.Columns[1].Name = "Tên Nhân Viên";
            _dgrv_doanhthu.Columns[2].Name = "Tổng Doanh Thu";
            _dgrv_doanhthu.Rows.Clear();
            foreach (B_BUS.View_Models.ViewDoanhThuNhanVien? x in _qldoanthu.Getlistviewdoanhthu()
                         .Where(c => c.NgayLap.Value.Day.ToString() == ngay &&
                                     c.NgayLap.Value.Month.ToString() == thang &&
                                     c.NgayLap.Value.Year.ToString() == nam).OrderByDescending(c => c.TongSoTien))
            {
                _ = _dgrv_doanhthu.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.TongSoTien);
            }
        }

        //ngày
        private void loaddataforlocngay(string ngay)
        {
            _dgrv_doanhthu.ColumnCount = 3;
            _dgrv_doanhthu.Columns[0].Name = "Mã Nhân Viên";
            _dgrv_doanhthu.Columns[1].Name = "Tên Nhân Viên";
            _dgrv_doanhthu.Columns[2].Name = "Tổng Doanh Thu";
            _dgrv_doanhthu.Rows.Clear();
            foreach (B_BUS.View_Models.ViewDoanhThuNhanVien? x in _qldoanthu.Getlistviewdoanhthu().Where(c => c.NgayLap.Value.Day.ToString() == ngay)
                         .OrderByDescending(c => c.TongSoTien))
            {
                _ = _dgrv_doanhthu.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.TongSoTien);
            }
        }

        //tháng
        private void loaddataforlocthang(string thang)
        {
            _dgrv_doanhthu.ColumnCount = 3;
            _dgrv_doanhthu.Columns[0].Name = "Mã Nhân Viên";
            _dgrv_doanhthu.Columns[1].Name = "Tên Nhân Viên";
            _dgrv_doanhthu.Columns[2].Name = "Tổng Doanh Thu";
            _dgrv_doanhthu.Rows.Clear();
            foreach (B_BUS.View_Models.ViewDoanhThuNhanVien? x in _qldoanthu.Getlistviewdoanhthu().Where(c => c.NgayLap.Value.Month.ToString() == thang)
                         .OrderByDescending(c => c.TongSoTien))
            {
                _ = _dgrv_doanhthu.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.TongSoTien);
            }
        }

        //năm   
        private void loaddataforlocnam(string nam)
        {
            _dgrv_doanhthu.ColumnCount = 3;
            _dgrv_doanhthu.Columns[0].Name = "Mã Nhân Viên";
            _dgrv_doanhthu.Columns[1].Name = "Tên Nhân Viên";
            _dgrv_doanhthu.Columns[2].Name = "Tổng Doanh Thu";
            _dgrv_doanhthu.Rows.Clear();
            foreach (B_BUS.View_Models.ViewDoanhThuNhanVien? x in _qldoanthu.Getlistviewdoanhthu().Where(c => c.NgayLap.Value.Year.ToString() == nam)
                         .OrderByDescending(c => c.TongSoTien))
            {
                _ = _dgrv_doanhthu.Rows.Add(x.MaNhanVien, x.TenNhanVien, x.TongSoTien);
            }
        }

        private void cmb_nam_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ngay.Text == "" && cmb_loc.Text == "")
            {
                loaddataforlocnam(cmb_nam.Text);
                return;
            }
            else
            {
                loaddoanhthuforlocall(cmb_ngay.Text, cmb_loc.Text, cmb_nam.Text);
                return;
            }
        }

        private void cbo_ngay_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_loc.Text == "" && cmb_nam.Text == "")
            {
                loaddataforlocngay(cmb_ngay.Text);
                return;
            }
            else
            {
                loaddoanhthuforlocall(cmb_ngay.Text, cmb_loc.Text, cmb_nam.Text);
                return;
            }
        }
        private void cbo_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ngay.Text == "" && cmb_nam.Text == "")
            {
                loaddataforlocthang(cmb_loc.Text);
                return;
            }
            else
            {
                loaddoanhthuforlocall(cmb_ngay.Text, cmb_loc.Text, cmb_nam.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_nam.SelectedIndex = 0;
        }
    }
}
