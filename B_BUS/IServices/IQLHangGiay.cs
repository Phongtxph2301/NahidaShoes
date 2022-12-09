using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLHangGiay
    {
        bool Add(HangGiay obj);
        bool Update(HangGiay obj);
        bool Delete(HangGiay obj);
        List<HangGiay> GetAll();
        Guid IdHangGiay(HangGiay obj);
        HangGiay? GetByMa(string? ma);
        bool CheckMa(string ma);
        List<HangGiayView> GetAllView();
    }
}
