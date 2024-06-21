using Dự_án_1.DAL.Models;
using Dự_án_1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL
{
    internal class MauSer
    {
        MauSacRes MauSacSer = new();

        public List<M> getAllColorSer()
        {
            return MauSacSer.getAllColorRes();
        }
    }
}
