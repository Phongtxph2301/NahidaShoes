﻿using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLGiaoCa : IQLGiaoCa
    {
        //bien
        public IGenericRepository<GiaoCa> igGiaoCa;
        //bien
        public IGenericRepository<NhanVien> igNhanvien;

        public QLGiaoCa()
        {
            igGiaoCa = new GenericRepository<GiaoCa>();
        }
        public bool Add(GiaoCa obj)
        {
            //add
            return igGiaoCa.Add(obj);
        }

        public bool Update(GiaoCa obj)
        {
            //update
            return igGiaoCa.Update(obj);
        }

        public bool Delete(GiaoCa obj)
        {
            //delete
            return igGiaoCa.Delete(obj);
        }

        public List<GiaoCa> GetAll()
        {
            //GetAll
            return igGiaoCa.GetAll();
        }

        public GiaoCa? GetByMa(string? ma)
        {
            //GetByMa
            return igGiaoCa.GetAll().Find(c => c.MaGiaoCa == ma);
        }

        public bool CheckMa(string ma)
        {
            //checkma

            return !igGiaoCa.GetAll().Any(c => c.MaGiaoCa == ma);
        }

        public List<GiaoCaView> GetAllView()
        {
            // getall
            List<GiaoCaView> lst = (from a in igGiaoCa.GetAll()
                                    join b in igNhanvien.GetAll() on a.IdNhanVien equals b.Id
                                    select new GiaoCaView()
                                    {
                                        GiaoCa = a,
                                        NhanVien = b
                                    }).ToList();
            return lst;
        }
    }
}
