using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLGiay
    {
        bool Add(Giay obj);
        bool Update(Giay obj);
        bool Delete(Giay obj);
        List<Giay> GetAll();
        Guid idGiay(Giay obj);
        Giay? GetByMa(string? ma);
        bool CheckMa(string ma);
        List<GiayView> GetAllView();
    }
}
