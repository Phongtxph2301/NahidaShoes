namespace A_DAL.Entities
{
    public class Nsx
    {
        public Nsx()
        {
            ChiTietGiays = new HashSet<ChiTietGiay>();
        }
        public Guid Id { get; set; }
        public string MaNsx { get; set; } = null!;
        public string TenNsx { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;
        public ICollection<ChiTietGiay> ChiTietGiays { get; set; }
    }
}
