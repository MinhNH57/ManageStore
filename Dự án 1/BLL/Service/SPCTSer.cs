using Dự_án_1.BLL.Service;
using Dự_án_1.DAL;
using Dự_án_1.DAL.Models;
using Dự_án_1.DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL
{
    internal class SPCTSer
    {
        SPCTRes SPCTser = new();
        KMCTRes KMCTser = new ();

        public List<Spct> getAllSPCTSer()
        {
            return SPCTser.getAllSPCTRes();
        }

        public string CreateSPCTSer(string ma , string ten , string masize , string mamau , string masp ,decimal dongia , int soluong , byte[] hinhAnh)
        {
            // Kiểm tra độ dài của chuỗi 'masp'
            if (masp.Length <= 50) // Điều chỉnh 50 cho độ dài mong muốn
            {
                Spct newspct = new()
                {
                    Maspct = ma,
                    Tenspct = ten,
                    Masize = masize,
                    Mamau = mamau,
                    Masp = masp,
                    Dongia = dongia,
                    Soluong = soluong,
                    HinhAnh = hinhAnh
                };
                if (SPCTser.CreateSPCTRes(newspct))
                {
                    return "Them thanh cong";
                }
                else
                {
                    return "Them that bai";
                }
            }
            else
            {
                return "Độ dài của MASP vượt quá giới hạn cho phép.";
            }
        }

        public string UpdateSPCTSer(string ma, string ten, string masize, string mamau, string masp, decimal dongia, int soluong, byte[] hinhAnh)
        {
            Spct upSPCT = SPCTser.findbyID(ma);
            upSPCT.Maspct = ma;
            upSPCT.Tenspct = ten;
            upSPCT.Masize = masize;
            upSPCT.Mamau = mamau;
            upSPCT.Masp=masp;
            upSPCT.Dongia = dongia;
            upSPCT.Soluong = soluong;
            upSPCT.HinhAnh = hinhAnh;
            if (SPCTser.UpdateSPCTRes(upSPCT))
            {
                return "Sua thanh cong";
            }
            else
            {
                return "Sua that bai";
            }
        }

        public string voHieuSPCT(string masp , string tt)
        {
            var spctList = SPCTser.getAllSPCTRes().Where(x => x.Masp == masp).ToList();

            if (spctList.Any())
            {
                foreach (var voHieuSPCT in spctList)
                {
                    voHieuSPCT.Tt = tt;
                    if (!SPCTser.voHieuSPCT(voHieuSPCT))
                    {
                        return "Sản phẩm chi tiết không thể vô hiệu hóa.";
                    }
                }

                return "Tất cả sản phẩm chi tiết đã được sửa.";
            }
            else
            {
                return "Không tìm thấy sản phẩm chi tiết với mã sản phẩm đã cho.";
            }
        }
        public string voHIeuHoaSPCT1(string masp, string tt)
        {
            Spct vohieuspct = SPCTser.getAllSPCTRes().Find(x => x.Maspct == masp);
            if (vohieuspct != null)
            {
                vohieuspct.Tt = tt;
                if (!SPCTser.voHieuSPCT(vohieuspct))
                {
                    return "Sản phẩm chi tiết vô hiệu hóa thất bại";
                }
                else
                {
                    return "Vô hiệu hóa sản phẩm chi tiết thành công";
                }
            }
            else
            {
                return "Không tìm thấy sản phẩm nào cần vô hiệu hóa";
            }
        }
        public Spct FindbyIDSer(string id)
        {
            return SPCTser.findbyID(id);
        }

        public int tinhToanSl(int slcon , int slmua)
        {
            return slcon - slmua;
        }
        public string updateSL(string mapct , int sl)
        {
            Spct upSPCT = SPCTser.findbyID(mapct);
            upSPCT.Soluong = sl;
            if (SPCTser.UpdateSPCTRes(upSPCT))
            {
                return "Cap nhat so luong thanh cong";
            }
            else
            {
                return "Cap nhat so luong that bai";
            }
        }
        DUAN1NHOMContext db = new DUAN1NHOMContext();
        public Kmct findbyID(string id)
        {
            return db.Kmcts.Find(id);
        }
        public string updategia(string mapct, decimal gia)
        {
            Kmct kmct = new Kmct();
            Spct upSPCT = SPCTser.findbyID(mapct);
            upSPCT.Dongia = gia;
           
            if (SPCTser.UpdateSPCTRes(upSPCT))
            {
                return "Cập Nhật Giá Thành Công";
            }
            else
            {
                return "Cap nhat so luong that bai";
            }
        }
    }
}
