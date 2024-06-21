using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL.Respositories
{
    internal class KMCTRes
    {
        DUAN1NHOMContext db = new();
        public List<Kmct> getAllKMCTRes()
        {
            return db.Kmcts.ToList();
        }
        public bool CreateKMCTRes(Kmct kmct)
        {
            db.Kmcts.Add(kmct);
            return db.SaveChanges() > 0;
        }

        public bool UpdateKMCTRes(Kmct kmct)
        {
            db.Kmcts.Update(kmct);
            return db.SaveChanges() > 0;
        }
    }
}
