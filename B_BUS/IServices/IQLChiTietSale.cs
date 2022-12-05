using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChiTietSale
    {
        bool Add(ChiTietSale obj);
        bool Update(ChiTietSale obj);
        bool Delete(ChiTietSale obj);
        List<ChiTietSale> GetAll();
        List<ChiTietSaleView> GetAllView();
    }
}
