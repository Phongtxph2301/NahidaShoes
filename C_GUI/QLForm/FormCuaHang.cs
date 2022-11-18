using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.QLForm
{
    public partial class FormCuaHang : Form
    {
        public IQLCuaHang _IQlCuaHang;
        private Guid _ID;
        public FormCuaHang()
        {
            _IQlCuaHang = new QLCuaHang();
            InitializeComponent();
            LoadData();
        }

        private void FormCuaHang_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_show.ColumnCount = 6;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "ma";
            dgrid_show.Columns[3].Name = "ten";
            dgrid_show.Columns[4].Name = "dia chi";
            dgrid_show.Columns[5].Name = "trang thai";
            dgrid_show.Rows.Clear();
            dgrid_show.Columns[1].Visible = true;
            foreach (CuaHangView a in _IQlCuaHang.GetAllView())
            {
                _ = dgrid_show.Rows.Add(stt++, a.CuaHang.Id, a.CuaHang.MaCuaHang, a.CuaHang.TenCuaHang, a.CuaHang.DiaChi, a.CuaHang.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }

        public CuaHang GetvaluaContro()
        {
            return new CuaHang()
            {
                MaCuaHang = txt_ma.Texts,
                TenCuaHang = txt_ten.Texts,
                DiaChi = txt_diachi.Texts,
                TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0,
            };
        }

        private void dgrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
            txt_ma.Texts = dgrid_show.Rows[index].Cells[2].Value.ToString();
            txt_ten.Texts = dgrid_show.Rows[index].Cells[3].Value.ToString();
            txt_diachi.Texts = dgrid_show.Rows[index].Cells[4].Value.ToString();
            if (dgrid_show.Rows[index].Cells[5].Value.ToString() == "hoat dong")
            {
                rbtn_hoatdong.Checked = true;
            }
            if (dgrid_show.Rows[index].Cells[5].Value.ToString() == "khong hoat dong")
            {
                rbtn_khonghoatdong.Checked = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _ = _IQlCuaHang.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //<<<<<<< HEAD
            CuaHang a = GetvaluaContro();
            a.Id = _ID;
            _ = _IQlCuaHang.Update(a);
            LoadData();
            //=======
            bool thongBao = _IQlCuaHang.Update(new A_DAL.Entities.CuaHang() { Id = _ID, MaCuaHang = txt_ma.Texts, TenCuaHang = txt_ten.Texts, DiaChi = txt_diachi.Texts, TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0 });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
            //>>>>>>> parent of 5be5ccb (Thieu)
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //<<<<<<< HEAD
            CuaHang a = GetvaluaContro();
            a.Id = _ID;
            _ = _IQlCuaHang.Update(a);
            LoadData();
            //=======

            bool thongBao = _IQlCuaHang.Delete(_IQlCuaHang.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void dgrid_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //>>>>>>> parent of 5be5ccb (Thieu)
        }
    }
}
