using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL.Respositories
{
    internal class KhuyenMaiRes
    {
        DUAN1NHOMContext db = new();

        public List<Km> getAllKhuyenMaiRes()
        {
            return db.Kms.ToList();
        }

        public bool CreateKMRes(Km khuyenmai)
        {
            db.Kms.Add(khuyenmai);
            return db.SaveChanges() > 0;
        }

        public bool UpdateKM(Km khuyenmai)
        {
            db.Kms.Update(khuyenmai);
            return db.SaveChanges() > 0;
        }
    }
}
