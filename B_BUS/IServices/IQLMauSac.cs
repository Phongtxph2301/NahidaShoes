using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLMauSac
    {
        bool Add(MauSac obj);
        bool Update(MauSac obj);
        bool Delete(MauSac obj);
        List<MauSac> GetAll();
        Guid IdMauSac(MauSac obj);
        MauSac? GetByMa(string? ma);
        bool CheckMa(string ma);
        List<MauSacView> GetAllView();
    }
}
