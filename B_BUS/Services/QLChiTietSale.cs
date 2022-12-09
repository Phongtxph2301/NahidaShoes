using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLChiTietSale : IQLChiTietSale
    {
        //bien
        public IGenericRepository<ChiTietSale> _igchitietsale;
        public IGenericRepository<Sale> _igsale;
        public IGenericRepository<ChiTietGiay> igchiTietGiay;
        public IGenericRepository<Giay> iGiay;

        public QLChiTietSale()
        {
            _igchitietsale = new GenericRepository<ChiTietSale>();
            _igsale = new GenericRepository<Sale>();
            igchiTietGiay = new GenericRepository<ChiTietGiay>();
            iGiay = new GenericRepository<Giay>();
        }
        public bool Add(ChiTietSale obj)
        {
            //add
            return _igchitietsale.Add(obj);
        }

        public bool Update(ChiTietSale obj)
        {
            //update
            return _igchitietsale.Update(obj);
        }

        public bool Delete(ChiTietSale obj)
        {
            //delete
            return _igchitietsale.Delete(obj);
        }

        public List<ChiTietSale> GetAll()
        {
            return _igchitietsale.GetAll();
        }

        public List<ChiTietSaleView> GetAllView()
        {
            // getall
            List<ChiTietSaleView> lst = (from a in _igchitietsale.GetAll()
                                         join b in _igsale.GetAll() on a.IdSale equals b.Id
                                         join c in igchiTietGiay.GetAll() on a.IdChiTietGiay equals c.Id
                                         join d in iGiay.GetAll() on c.IdGiay equals d.Id
                                         select new ChiTietSaleView()
                                         {
                                             ChiTietSale = a,
                                             Sale = b,
                                             ChiTietGiay = c,
                                             Giay = d,

                                         }).ToList();
            return lst;

        }
    }
}
