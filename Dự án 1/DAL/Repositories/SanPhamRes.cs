using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL
{
    internal class SanPhamRes
    {
        DUAN1NHOMContext db = new();

        public List<Sanpham> getAllSanPhamres()
        {
            return db.Sanphams.ToList();
        }

        public bool CreateProducts(Sanpham sp)
        {
            if (sp != null)
            {
                db.Sanphams.Add(sp);
                return db.SaveChanges() > 0;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateProducts(Sanpham sp)
        {
            db.Sanphams.Update(sp);
            return db.SaveChanges() > 0;
        }

        public bool DeleteProducts(Sanpham sp)
        {
            db.Sanphams.Remove(sp);
            return db.SaveChanges() > 0;
        }

        public bool voHieu(Sanpham sp)
        {
            db.Sanphams.Update(sp);
            return db.SaveChanges() > 0;
        }

        public Sanpham FindbyID(string ma)
        {
            return db.Sanphams.Find(ma);
        }
    }
}
