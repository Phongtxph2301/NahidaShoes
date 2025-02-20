﻿using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChucVu
    {
        bool Add(ChucVu obj);
        bool Update(ChucVu obj);
        bool Delete(ChucVu obj);
        List<ChucVu> GetAll();
        ChucVu? GetByMa(string? ma);
        bool CheckMa(string ma);

        List<ChucVuView> GetAllView();
    }
}
