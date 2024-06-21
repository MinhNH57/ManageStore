using Dự_án_1.DAL.Models;
using Dự_án_1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL.Service
{
    internal class VATSer
    {
        VATRes vat = new();
        public List<Vat> getAllVatSer()
        {
            return vat.getAllVatres();
        }

        public string CreateVAt(int maVAT , float mucVAT , string tt)
        {
            Vat v = new()
            {
                MaVat = maVAT,
                MucVat = mucVAT,
                TinhTrang = tt,
            };
            if(vat.createVATRes(v))
            {
                return "Tao thanh cong";
            }
            else
            {
                return "Tao that bai";
            }
        }

        public string updateVatser(int maVAT,string tt)
        {
            Vat v = vat.getAllVatres().Find(x => x.MaVat == maVAT);
            if(v != null)
            {
                v.TinhTrang = tt;
                if (vat.updateVatRes(v))
                {
                    return "Sua thanh cong";
                }
                else
                {
                    return "Sua that bai";
                }
            }
            else
            {
                return "Khong tim thay";
            }
        }
    }
}
