using Dự_án_1.DAL;
using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL
{
    internal class SanPhamSer
    {
        SanPhamRes spser = new();

        public List<Sanpham> getAllSanPhamSer()
        {
            return spser.getAllSanPhamres();
        }
        public string CreateSpSer(string maSP , string tenSp ,string loaiSp , string Cl , string mth , string loaico , string loaiong )
        {
            Sanpham newProducts = new()
            {
                Masp = maSP ,Tensp= tenSp ,Loaisp=loaiSp,Chatlieu=Cl , Math = mth , LoaiCoAo=loaico , Loaichanquan = loaiong
            };
            if(spser.CreateProducts(newProducts) )
            {
                return "Them san pham thanh cong";
            }
            else
            {
                return "Them san pham that bai";
            }
        }
        public string UpdateSpser(string maSP, string tenSp, string loaiSp, string Cl , string math, string loaico, string loaiong)
        {
            Sanpham upProducts = spser.getAllSanPhamres().Find(x => x.Masp == maSP);
            if(upProducts != null)
            {
                upProducts.Masp = maSP;
                upProducts.Tensp = tenSp;
                upProducts.Loaisp = loaiSp;
                upProducts.Chatlieu = Cl;
                upProducts.Math = math;
                upProducts.LoaiCoAo = loaico;
                upProducts.Loaichanquan = loaiong;
            }
            if(spser.UpdateProducts(upProducts) )
            {
                return "Sua thanh cong";
            }
            else
            {
                return "Sua that bai";
            }
        }

        public string voHieuSP(string maSP , string tt)
        {
            Sanpham voHieuSP = spser.getAllSanPhamres().Find(x => x.Masp == maSP);
            if(voHieuSP != null)
            {
                voHieuSP.Tt = tt;
            }
            if(spser.voHieu(voHieuSP))
            {
                return "Vo hieu thanh cong";
            }
            else
            {
                return "Thu lai sau";
            }
        }

        public Sanpham FindbyIDSer(string id)
        {
            return spser.FindbyID(id);
        }
    }
}
