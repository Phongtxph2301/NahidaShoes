using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.QLForm
{
    public partial class FormKhachHang : Form
    {
        public IQLKhachHang _IQLKhachHang;
        private Guid _ID;


        public FormKhachHang()
        {
            _IQLKhachHang = new QLKhachHang();
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_showKhachHang.ColumnCount = 9;
            dgrid_showKhachHang.Columns[0].Name = "stt";
            dgrid_showKhachHang.Columns[1].Name = "id";
            dgrid_showKhachHang.Columns[2].Name = "ma";
            dgrid_showKhachHang.Columns[3].Name = "ten";
            dgrid_showKhachHang.Columns[4].Name = "email";
            dgrid_showKhachHang.Columns[5].Name = "ngay sinh";
            dgrid_showKhachHang.Columns[6].Name = "sdt";
            dgrid_showKhachHang.Columns[7].Name = "dia chi";
            dgrid_showKhachHang.Columns[8].Name = "trang thai";
            dgrid_showKhachHang.Rows.Clear();
            dgrid_showKhachHang.Columns[1].Visible = true;
            foreach (KhachHangView a in _IQLKhachHang.GetAllView())
            {

                _ = dgrid_showKhachHang.Rows.Add(stt++, a.Khach.Id, a.Khach.MaKhachHang, a.Khach.TenKhachHang, a.Khach.Email, a.Khach.NgaySinh, a.Khach.Sdt, a.Khach.DiaChi, a.Khach.TrangThai == 1 ? "hoạt động" : "Không hoạt động");
            }

        }
        public KhachHang GetvaluaContro()
        {
            return new KhachHang()
            {
                MaKhachHang = txt_ma.Text,
                TenKhachHang = txt_ten.Text,
                Email = txt_email.Text,
                NgaySinh = dtt_ngaysinh.Value,
                Sdt = txt_sdt.Text,
                DiaChi = txt_diachi.Text,

                TrangThai = cbx_hoatdong.Checked == true ? 1 : 0,

            };
        }
        private void dgrid_showKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_showKhachHang.Rows[index].Cells[1].Value.ToString());
            txt_ma.Text = dgrid_showKhachHang.Rows[index].Cells[2].Value.ToString();
            txt_ten.Text = dgrid_showKhachHang.Rows[index].Cells[3].Value.ToString();

            dtt_ngaysinh.Value = (DateTime)dgrid_showKhachHang.Rows[index].Cells[5].Value;
            txt_sdt.Text = dgrid_showKhachHang.Rows[index].Cells[6].Value.ToString();
            txt_diachi.Text = dgrid_showKhachHang.Rows[index].Cells[7].Value.ToString();


            KhachHang a = _IQLKhachHang.GetAllView().FirstOrDefault(c => c.Khach.Id == _ID).Khach;

            ;
            if (dgrid_showKhachHang.Rows[index].Cells[8].Value.ToString() == "hoạt động")
            {
                cbx_hoatdong.Checked = true;
                cbx_khonghoatdong.Checked = false;
            }
            if (dgrid_showKhachHang.Rows[index].Cells[8].Value.ToString() == "không hoạt động")
            {
                cbx_hoatdong.Checked = false;
                cbx_khonghoatdong.Checked = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _ = _IQLKhachHang.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQLKhachHang.Update(new A_DAL.Entities.KhachHang() { Id = _ID, MaKhachHang = txt_ma.Text, TenKhachHang = txt_ten.Text, TrangThai = cbx_hoatdong.Checked == true ? 1 : 0 });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQLKhachHang.Delete(_IQLKhachHang.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }


    }
}
