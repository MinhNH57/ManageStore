using Dự_án_1.DAL;
using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL
{
    internal class NhanVienSer
    {
        NhanVienRes nvSer = new();

        public List<Nhanvien> getAllnhanvienSer()
        {
            return nvSer.getAllnhanvienrespo();
        }
        public string createnvSer(string ma , string hoten ,DateTime ngaySinh,string diachi,string sdt,string tk , string mk,string quyen,string cccd,string tinhtrang,string gioitinh)
        {
            Nhanvien nvmoi = new()
            {
                Manv = ma,
                Tennv = hoten,
                Ngaysinh = ngaySinh,
                Diachi = diachi,
                Sdt = sdt,
                Taikhoan = tk,
                Matkhau = mk,
                Quyen = quyen,
                Cccd = cccd,
                Tinhtrang = tinhtrang,
                Gioitinh = gioitinh
            };
            if(nvSer.Createnvres(nvmoi))
            {
                return "Them moi nhan vien thanh cong";
            }
            else
            {
                return "Them moi nhan vien that bai";
            }
        }
        public string updatenvSer(string ma, string hoten, DateTime ngaySinh, string diachi, string sdt, string tk, string mk, string quyen, string cccd, string tinhtrang, string gioitinh)
        {
            Nhanvien nvsau = nvSer.getAllnhanvienrespo().Find(x => x.Manv == ma);
            nvsau.Tennv = hoten;
            nvsau.Ngaysinh = ngaySinh;
            nvsau.Diachi = diachi;
            nvsau.Sdt = sdt;
            nvsau.Matkhau = mk;
            nvsau.Quyen = quyen;
            nvsau.Tinhtrang = tinhtrang;
            if(nvSer.Updatenvser(nvsau))
            {
                return "Sua thanh cong";
            }
            else
            {
                return "Sua that bai";
            }
        }
        public string vohieuhoanv(string ma , string tinhtrang)
        {
            Nhanvien nvxoa = nvSer.getAllnhanvienrespo().Find(x => x.Manv== ma);
            nvxoa.Tinhtrang = tinhtrang;
            if(nvSer.Updatenvser(nvxoa))
            {
                return "Vo hieu hoa thanh cong";
            }
            else
            {
                return "Vo hieu hoa that bai";
            }
        }
    }
}
