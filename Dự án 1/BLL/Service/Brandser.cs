using Dự_án_1.DAL;
using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL
{
    internal class Brandser
    {
        Brandres BrandSer = new();

        public List<Th> getAllBrandSer()
        {
            return BrandSer.getAllBrandRes();
        }

        public string CreateSer(string ma , string ten , int namtl , string qg)
        {
            Th th = new Th()
            {
                Math = ma ,
                Tenth = ten ,
                Namtl = namtl ,
                Quocgia = qg
            };

            if(BrandSer.Create_Brandres(th))
            {
                return "Thanh cong";
            }
            else
            {
                return "That bai";
            }
        }

        public string UpdateSer(string ma, string ten, int namtl, string qg)
        {
            Th upProducts = BrandSer.getAllBrandRes().Find(x => x.Math == ma);
            if (upProducts != null)
            {
                upProducts.Tenth = ten;
                upProducts.Namtl = namtl;
                upProducts.Quocgia= qg;
                 
            }
            if (BrandSer.Update_Branda(upProducts))
            {
                return "Sua thanh cong";
            }
            else
            {
                return "Sua that bai";
            }
        }
    }
}
