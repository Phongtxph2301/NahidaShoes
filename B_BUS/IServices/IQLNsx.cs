using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLNsx
    {
        bool Add(Nsx obj);
        bool Update(Nsx obj);
        bool Delete(Nsx obj);
        List<Nsx> GetAll();
        Guid IdNsx(Nsx nsx);
        Nsx? GetByMa(string? ma);
        bool CheckMa(string ma);
        List<NsxView> GetAllView();
    }
}
