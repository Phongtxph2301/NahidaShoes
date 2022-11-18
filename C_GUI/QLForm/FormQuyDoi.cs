using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.QLForm
{
    public partial class FormQuyDoi : Form
    {
        public IQLQuyDoi _IqlQuyDoi;
        private Guid _ID;
        public FormQuyDoi()
        {
            _IqlQuyDoi = new QLQuyDoi();
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_show.ColumnCount = 5;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "maqd";
            dgrid_show.Columns[3].Name = "ti le quy doi";
            dgrid_show.Columns[4].Name = "trang thai";
            dgrid_show.Rows.Clear();
            dgrid_show.Columns[1].Visible = true;
            foreach (QuyDoi a in _IqlQuyDoi.GetAll())
            {
                _ = dgrid_show.Rows.Add(stt++, a.Id, a.MaQuyDoi, a.TiLeQuyDoi, a.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }

        public QuyDoi GetvaluaContro()
        {
            return new QuyDoi()
            {
                MaQuyDoi = txt_maqd.Texts,
                TiLeQuyDoi = float.Parse(txt_tilequydoi.Texts),
                TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0,
            };
        }

        private void dgrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
            txt_maqd.Texts = dgrid_show.Rows[index].Cells[2].Value.ToString();
            txt_tilequydoi.Texts = dgrid_show.Rows[index].Cells[3].Value.ToString();
            if (dgrid_show.Rows[index].Cells[4].Value.ToString() == "hoat dong")
            {
                rbtn_hoatdong.Checked = true;
            }
            if (dgrid_show.Rows[index].Cells[4].Value.ToString() == "khong hoat dong")
            {
                rbtn_khonghoatdong.Checked = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _ = _IqlQuyDoi.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool thongBao = _IqlQuyDoi.Update(new A_DAL.Entities.QuyDoi()
            {
                Id = _ID,
                MaQuyDoi = txt_maqd.Texts,
                TiLeQuyDoi = float.Parse(txt_tilequydoi.Texts),
                TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0
            });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _IqlQuyDoi.Delete(_IqlQuyDoi.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void dgrid_show_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
            txt_maqd.Texts = dgrid_show.Rows[index].Cells[2].Value.ToString();
            txt_tilequydoi.Texts = dgrid_show.Rows[index].Cells[3].Value.ToString();
            if (dgrid_show.Rows[index].Cells[4].Value.ToString() == "hoat dong")
            {
                rbtn_hoatdong.Checked = true;
            }
            if (dgrid_show.Rows[index].Cells[4].Value.ToString() == "khong hoat dong")
            {
                rbtn_khonghoatdong.Checked = true;
            }
        }
    }
}
