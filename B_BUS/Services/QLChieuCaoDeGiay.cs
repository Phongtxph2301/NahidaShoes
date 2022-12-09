using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLChieuCaoDeGiay : IQLChieuCaoDeGiay
    {

        public IGenericRepository<ChieuCaoDeGiay> igChieuCaoDeGiay;
        public QLChieuCaoDeGiay()
        {
            igChieuCaoDeGiay = new GenericRepository<ChieuCaoDeGiay>();
        }

        public bool Add(ChieuCaoDeGiay obj)
        {
            return igChieuCaoDeGiay.Add(obj);
        }

        public bool Update(ChieuCaoDeGiay obj)
        {
            return igChieuCaoDeGiay.Update(obj);
        }

        public bool Delete(ChieuCaoDeGiay obj)
        {
            return igChieuCaoDeGiay.Delete(obj);
        }

        public List<ChieuCaoDeGiay> GetAll()
        {
            return igChieuCaoDeGiay.GetAll();
        }

        public Guid IdChieuCaoDeGiay(ChieuCaoDeGiay obj)
        {
            ChieuCaoDeGiay x = new()
            {
                Id = Guid.NewGuid(),
                MaKichCo = obj.MaKichCo,
                KichCo = obj.KichCo,
                TrangThai = obj.TrangThai
            };
            return igChieuCaoDeGiay.Add(x) ? x.Id : Guid.Empty;
        }

        public ChieuCaoDeGiay? GetByMa(string? ma)
        {
            return igChieuCaoDeGiay.GetAll().Find(c => c.MaKichCo == ma);
        }

        public bool CheckMa(string ma)
        {
            return !igChieuCaoDeGiay.GetAll().Any(c => c.MaKichCo == ma);
        }

        public List<ChieuCaoDeGiayView> GetAllView()
        {
            List<ChieuCaoDeGiayView> lst = (from a in igChieuCaoDeGiay.GetAll()
                                            select new ChieuCaoDeGiayView()
                                            {
                                                ChieuCaoDeGiay = a,
                                            }).ToList();
            return lst;
        }
    }
}
