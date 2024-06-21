using Dự_án_1.DAL.Models;
using Dự_án_1.DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL.Service
{
    internal class KhuyenMaiSer
    {
        KhuyenMaiRes KMSer = new();
        public List<Km> getAllKhuyenMaiSer()
        {
            return KMSer.getAllKhuyenMaiRes();
        }

        public string CreateKMSer(string makm , string tenkm , DateTime ngayBatdau , DateTime ngayKetthuc,float phanTram)
        {
            Km khuyenmai = new()
            {
                Makm = makm ,Tenkm = tenkm ,Ngaybatdau=DateTime.Parse(ngayBatdau.ToString()),Ngayketthuc=DateTime.Parse(ngayKetthuc.ToString()),Slgiam=phanTram
            };
            if(KMSer.CreateKMRes(khuyenmai))
            {
                return "Tao ma thanh cong";
            }
            else
            {
                return "Tao ma that bai";
            }
        }

        public string UpdateKMSer(string makm, string tenkm, DateTime ngayBatdau, DateTime ngayKetthuc, float phanTram , string tt)
        {
            Km upkm = KMSer.getAllKhuyenMaiRes().Find(x => x.Makm == makm);
            upkm.Tenkm = tenkm;
            upkm.Ngaybatdau = DateTime.Parse(ngayBatdau.ToString());
            upkm.Ngayketthuc= DateTime.Parse(ngayKetthuc.ToString());
            upkm.Slgiam = phanTram;
            upkm.TinhTrang = tt;
            if(KMSer.UpdateKM(upkm))
            {
                return "Cap ma khuyen mai thanh cong";
            }
            else
            {
                return "Cap ma khuyen mai that bai";
            }
        }
        public string CapNhatKhuyenMai(string makm , string tt)
        {
            Km upkm = KMSer.getAllKhuyenMaiRes().Find(x => x.Makm == makm);
            upkm.TinhTrang = tt;
            if( KMSer.UpdateKM(upkm))
            {
                return "Cap nhat thanh cong";
            }
            else
            {
                return "Cap nhat that bai";
            }
        }
    }
}
