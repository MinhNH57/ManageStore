using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL
{
    internal class SizeRes
    {
        DUAN1NHOMContext db = new();

        public List<Dự_án_1.DAL.Models.Size> GetAllSize()
        {
            return db.Sizes.ToList();
        }
    }
}
