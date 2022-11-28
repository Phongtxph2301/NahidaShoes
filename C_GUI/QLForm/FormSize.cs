using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;
using Size = A_DAL.Entities.Size;

namespace C_GUI.QLForm
{
    public partial class FormSize : Form
    {

        public IQLSize _IQLSize;
        private Guid _ID;



        public FormSize()
        {
            _IQLSize = new QLSize();
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_showSize.ColumnCount = 4;
            dgrid_showSize.Columns[0].Name = "stt";

            dgrid_showSize.Columns[2].Name = "ma";
            dgrid_showSize.Columns[3].Name = "ten";
            dgrid_showSize.Columns[1].Visible = true;
            foreach (SizeView a in _IQLSize.GetAllView())
            {

                _ = dgrid_showSize.Rows.Add(stt++, a.Size.MaSize, a.Size.TenSize, a.Size.TrangThai == 1 ? "hoạt động" : "Không hoạt động");
            }

        }

        public Size GetvaluaContro()
        {
            return new Size()
            {
                MaSize = txt_ma.Text,
                TenSize = txt_ten.Text,
                TrangThai = cbx_hoatdong.Checked == true ? 1 : 0,
            };
        }
        private void dgrid_showGiay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_showSize.Rows[index].Cells[1].Value.ToString());
            txt_ma.Text = dgrid_showSize.Rows[index].Cells[2].Value.ToString();
            txt_ten.Text = dgrid_showSize.Rows[index].Cells[3].Value.ToString();
            if (dgrid_showSize.Rows[index].Cells[4].Value.ToString() == "hoat dong")
            {
                cbx_hoatdong.Checked = true;
            }
            if (dgrid_showSize.Rows[index].Cells[4].Value.ToString() == "khong hoat dong")
            {
                cbx_khonghoatdong.Checked = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _ = _IQLSize.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQLSize.Update(new A_DAL.Entities.Size() { Id = _ID, MaSize = txt_ma.Text, TenSize = txt_ten.Text, TrangThai = cbx_hoatdong.Checked == true ? 1 : 0 });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQLSize.Delete(_IQLSize.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

    }
}

