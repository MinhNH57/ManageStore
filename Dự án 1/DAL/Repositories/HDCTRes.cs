using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL.Repositories
{
    internal class HDCTRes
    {
        DUAN1NHOMContext db = new();
        public List<Hdct> getAllhoaDonCTRes()
        {
            return db.Hdcts.ToList();
        }
        public bool CreateHDCTRes(Hdct HDCT)
        {
            db.Hdcts.Add(HDCT);
            return db.SaveChanges() >0;
        }
        public bool UpdateHDCTRes(Hdct HDCT)
        {
            db.Hdcts.Update(HDCT);
            return db.SaveChanges() >0;
        }
        public bool RemoveHDCTRes(Hdct HDCT)
        {
            db.Hdcts.Remove(HDCT);
            return db.SaveChanges() > 0;
        }
    }
}
