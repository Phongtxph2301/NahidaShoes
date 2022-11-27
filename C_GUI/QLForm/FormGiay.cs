using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI.QLForm
{
    public partial class FormGiay : Form
    {
        public IQLGiay _IQLGiay;
        private Guid _ID;
      

        public FormGiay()
        {
            _IQLGiay= new QLGiay();    
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_showGiay.ColumnCount = 3;
            dgrid_showGiay.Columns[0].Name = "stt";
         
            dgrid_showGiay.Columns[1].Name = "ma";
            dgrid_showGiay.Columns[2].Name = "ten";       
            dgrid_showGiay.Columns[1].Visible = true;
            foreach (GiayView a in _IQLGiay.GetAllView())
            {

                _ = dgrid_showGiay.Rows.Add(stt++, a.Giay.MaGiay, a.Giay.TenGiay, a.Giay.TrangThai == 1 ? "hoạt động" : "Không hoạt động");
            }

        }

        public Giay GetvaluaContro()
        {
            return new Giay()
            {
                MaGiay = txt_ma.Text,
                TenGiay = txt_ten.Text,
                TrangThai = cbx_hoatdong.Checked == true ? 1 : 0,
            };
        }
        private void dgrid_showGiay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_showGiay.Rows[index].Cells[1].Value.ToString());
            txt_ma.Text = dgrid_showGiay.Rows[index].Cells[2].Value.ToString();
            txt_ten.Text = dgrid_showGiay.Rows[index].Cells[3].Value.ToString();
            if (dgrid_showGiay.Rows[index].Cells[4].Value.ToString() == "hoat dong")
            {
                cbx_hoatdong.Checked = true;
            }
            if (dgrid_showGiay.Rows[index].Cells[4].Value.ToString() == "khong hoat dong")
            {
                cbx_khonghoatdong.Checked = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            _ = _IQLGiay.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQLGiay.Update(new A_DAL.Entities.Giay() { Id = _ID, MaGiay = txt_ma.Text, TenGiay = txt_ten.Text, TrangThai = cbx_hoatdong.Checked == true ? 1 : 0 });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQLGiay.Delete(_IQLGiay.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

    }
}
