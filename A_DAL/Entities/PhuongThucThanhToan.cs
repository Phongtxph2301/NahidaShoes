namespace A_DAL.Entities
{
    public class PhuongThucThanhToan
    {
        public PhuongThucThanhToan()
        {
            ChiTietThanhToans = new HashSet<ChiTietThanhToan>();
        }
        public Guid Id { get; set; }
        public string MaPhuongThucThanhToan { get; set; } = null!;
        public string TenPhuongThucThanhToan { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;
        public ICollection<ChiTietThanhToan> ChiTietThanhToans { get; set; }
    }
}
