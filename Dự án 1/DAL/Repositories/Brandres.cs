using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL
{
    internal class Brandres
    {
        DUAN1NHOMContext db = new();

        public List<Th> getAllBrandRes()
        {
            return db.Ths.ToList(); 
        }
    }
}
