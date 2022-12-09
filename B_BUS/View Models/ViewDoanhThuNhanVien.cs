namespace B_BUS.View_Models
{
    public class ViewDoanhThuNhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public double? TongSoTien { get; set; }
        public string Months { get; set; }
        public string Years { get; set; }
        public DateTime? NgayLap { get; set; }
        public ViewDoanhThuNhanVien(string manv, string tennv, double? tongtien, string Month, string Year, DateTime? ngaylap)
        {
            MaNhanVien = manv;
            TenNhanVien = tennv;
            TongSoTien = tongtien;
            Months = Month;
            Years = Year;
            NgayLap = ngaylap;
        }
    }
}
