using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChieuCaoDeGiay
    {
        bool Add(ChieuCaoDeGiay obj);
        bool Update(ChieuCaoDeGiay obj);
        bool Delete(ChieuCaoDeGiay obj);
        List<ChieuCaoDeGiay> GetAll();
        Guid IdChieuCaoDeGiay(ChieuCaoDeGiay obj);
        ChieuCaoDeGiay? GetByMa(string? ma);
        bool CheckMa(string ma);
        List<ChieuCaoDeGiayView> GetAllView();
    }
}
