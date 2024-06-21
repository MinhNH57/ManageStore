using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL.Repositories
{
    internal class HoaDonRes
    {
        DUAN1NHOMContext db = new();
        public List<Hoadon> getAllHoaDonRes()
        {
            return db.Hoadons.ToList();
        }

        public bool CreateHoaDonRes(Hoadon hd)
        {
            db.Hoadons.Add(hd);
            return db.SaveChanges() > 0;
        }
        public bool UpdateHoaDonRes(Hoadon hd)
        {
            db.Hoadons.Update(hd);
            return db.SaveChanges() > 0;
        }
        public bool DeleteHoadonRes(Hoadon hd)
        {
            db.Hoadons.Remove(hd);
            return db.SaveChanges() > 0;
        }
    }
}
