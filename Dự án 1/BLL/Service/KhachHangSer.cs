using Dự_án_1.DAL.Models;
using Dự_án_1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL.Service
{
    internal class KhachHangSer
    {
        KhachHang KHSer = new();

        public List<Kh> getAllKhachHangSer()
        {
            return KHSer.GetAllKhachHangRes();
        }

        public string CreateKHSer(string makh , string tenkh  , string sdt , string diachi)
        {
            Kh khachhang = new()
            {
                Makh = makh,
                Tenkh = tenkh,
                Sdt = sdt,
                Diachi = diachi
            };
            if(KHSer.CreateKHres(khachhang))
            {
                return "Them thanh cong";
            }
            else
            {
                return "Them that bai";
            }
        }
        public string updateKHSer(string makh, string tenkh, string sdt, string diachi)
        {
            Kh KhachHang = KHSer.GetAllKhachHangRes().Find(x => x.Makh == makh);
            if(KhachHang != null)
            {
                KhachHang.Tenkh = tenkh;
                KhachHang.Sdt = sdt;
                KhachHang.Diachi = diachi;
            }
            if (KHSer.UpdateKHres(KhachHang))
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
