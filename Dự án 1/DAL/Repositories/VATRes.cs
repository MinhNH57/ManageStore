using Dự_án_1.DAL.Models;
using Dự_án_1.Valiable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL.Repositories
{
    internal class VATRes
    {
        DUAN1NHOMContext db = new();
        public List<Vat> getAllVatres()
        {
            return db.Vats.ToList();
        }

        public bool createVATRes(Vat vat)
        {
            db.Vats.Add(vat);
            return db.SaveChanges() > 0;
        }

        public bool updateVatRes(Vat vat)
        {
            db.Vats.Update(vat);
            return db.SaveChanges() > 0;
        }
    }
}
