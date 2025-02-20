﻿using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChiTietThanhToan
    {
        bool Add(ChiTietThanhToan obj);
        bool Update(ChiTietThanhToan obj);
        bool Delete(ChiTietThanhToan obj);
        List<ChiTietThanhToan> GetAll();
        List<ChiTietThanhToanView> GetAllView();
    }
}
