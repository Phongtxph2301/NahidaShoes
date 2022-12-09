using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLDoanhThuNhanVien : IQlDoanhThuServices
    {
        private readonly IGenericRepository<NhanVien> _nhanvienrp;
        private readonly IGenericRepository<HoaDon> _HoaDonrp;
        private readonly List<ViewDoanhThuNhanVien> _lstdoanhthu;
        private readonly string manv;
        private double tong;
        private readonly NhanVien _nv;
        private ViewDoanhThuNhanVien _viewdoanhthu;
        private DateTime? day;
        private DateTime? nam;
        private string mon;
        private string year;

        public QLDoanhThuNhanVien()
        {
            _nhanvienrp = new GenericRepository<NhanVien>();
            _HoaDonrp = new GenericRepository<HoaDon>();
            _nv = new NhanVien();

            _lstdoanhthu = new List<ViewDoanhThuNhanVien>();
            _ = Getlistviewdoanhthu();
        }

        public List<ViewDoanhThuNhanVien> Getlistviewdoanhthu()
        {
            var listcommit = (from a in _nhanvienrp.GetAll()
                              join b in _HoaDonrp.GetAll() on a.Id equals b.IdNhanVien
                              select new { a.MaNhanVien, a.TenNhanVien, b.TongSoTien, b.ThoiGianTao }).ToList();
            // Gán giá trị
            foreach (var x in listcommit)
            {
                tong = Convert.ToDouble(_HoaDonrp.GetAll().Where(c => c.Id == _nv.Id).Select(c => c.TongSoTien).Sum());
                day = x.ThoiGianTao;
                nam = x.ThoiGianTao;
                mon = day.Value.Month.ToString();
                year = nam.Value.Year.ToString();
                _viewdoanhthu = new ViewDoanhThuNhanVien(manv, x.TenNhanVien, tong, mon, year, x.ThoiGianTao);
                _lstdoanhthu.Add(_viewdoanhthu);
            }
            List<ViewDoanhThuNhanVien> lisfinal = listcommit.OrderBy(c => c.TongSoTien).GroupBy(c => c.MaNhanVien)
                .Select(g => new ViewDoanhThuNhanVien(g.Key, g.Where(c => c.MaNhanVien == g.Key).Select(c => c.TenNhanVien).FirstOrDefault(), g.Sum(c => c.TongSoTien), mon, year, g.Where(c => c.MaNhanVien == g.Key).Select(c => c.ThoiGianTao).FirstOrDefault())).ToList();
            return lisfinal;
        }
    }
}
