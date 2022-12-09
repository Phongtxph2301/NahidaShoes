using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class ChiTietSaleView
    {
        public ChiTietSale ChiTietSale { get; set; } = new();
        public Sale Sale { get; set; } = new();
        public ChiTietGiay ChiTietGiay { get; set; } = new();

        public Giay Giay { get; set; } = new();
    }
}
