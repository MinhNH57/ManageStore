using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL.Repositories
{
    internal class KhachHang
    {
        DUAN1NHOMContext db = new();

        public List<Kh> GetAllKhachHangRes()
        {
            return db.Khs.ToList();
        }
        public bool CreateKHres(Kh KH)
        {
            db.Khs.Add(KH);
            return db.SaveChanges() > 0;
        }

        public bool UpdateKHres(Kh KH)
        {
            db.Khs.Update(KH);
            return db.SaveChanges() > 0;
        }
    }
}
