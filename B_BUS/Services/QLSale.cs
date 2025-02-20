﻿using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLSale : IQLSale
    {
        //bien
        public IGenericRepository<Sale> igsale;

        public QLSale()
        {
            igsale = new GenericRepository<Sale>();
        }
        public bool Add(Sale obj)
        {
            //add
            return igsale.Add(obj);
        }

        public bool Update(Sale obj)
        {
            //update
            return igsale.Update(obj);
        }

        public bool Delete(Sale obj)
        {
            //delete
            return igsale.Delete(obj);
        }

        public List<Sale> GetAll()
        {
            //GetAll
            return igsale.GetAll();
        }

        public Sale? GetByMa(string? ma)
        {
            //GetByMa
            return igsale.GetAll().Find(c => c.MaGiamGia == ma);
        }

        public bool CheckMa(string ma)
        {
            //checkma

            return !igsale.GetAll().Any(c => c.MaGiamGia == ma);
        }

        public List<SaleView> GetAllView()
        {
            // getall
            List<SaleView> lst = (from a in igsale.GetAll()
                                  select new SaleView()
                                  {
                                      Sale = a,
                                  }).ToList();
            return lst;
        }
    }
}
