using Dự_án_1.DAL.Models;
using Dự_án_1.DAL.Repositories;
using Dự_án_1.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL.Service
{
    internal class HoaDonSer
    {
        HoaDonRes hoadonSe = new();
        public List<Hoadon> getAllHoaDonSer()
        {
            return hoadonSe.getAllHoaDonRes();
        }
        public string CreateHoadonSer(string mahd , DateTime ngaytao , string manv , decimal thanhToan , string makh , float vat , string tt)
        {
            Hoadon createHD = new()
            {
                Mahd = mahd ,Ngaythang = ngaytao,Manv = manv ,Thanhtoan=thanhToan,Makh=makh,Vat=vat,TinhTrang=tt
            };
            if(hoadonSe.CreateHoaDonRes(createHD))
            {
                return "Tao thanh cong";
            }
            else
            {
                return "Tao that bai";
            }
        }
        public string UpdateHoaDonSer(string mahd,string tt , decimal thanhToan , string makh , DateTime thoigiancapnhat)
        {
            Hoadon hdsua = hoadonSe.getAllHoaDonRes().Find(x => x.Mahd == mahd);
            hdsua.TinhTrang = tt;
            hdsua.Thanhtoan = thanhToan;
            hdsua.Makh = makh;
            hdsua.Thoigiancapnhat = thoigiancapnhat;
            if(hoadonSe.UpdateHoaDonRes(hdsua))
            {
                return "Thanh toan thanh cong";
            }
            else
            {
                return "Thanh toan that bai";
            }
        }
        public string deleteHDcho(string mahd)
        {
            Hoadon hd = hoadonSe.getAllHoaDonRes().Find(x => x.Mahd == mahd);
            if(hd != null)
            {
                if (hoadonSe.DeleteHoadonRes(hd))
                {
                    return "Xoa thanh cong";
                }
                else
                {
                    return
                        "Xoa that bai";
                }
            }
            else
            {
                return "Hoa don khong ton tai";
            }
        }
        public string dinhDanhHD(string mahd , string maKH)
        {
            Hoadon hd = hoadonSe.getAllHoaDonRes().Find(x => x.Mahd == mahd);
            if( hd != null)
            {
                hd.Makh = maKH;
                if(hoadonSe.UpdateHoaDonRes(hd))
                {
                    return "Định danh thành công";
                }
                else
                {
                    return "Định danh thất bại";
                }
            }
            else
            {
                return "Không tìm thấy hóa đơn cần định danh nào";
            }
        }
    }
}
