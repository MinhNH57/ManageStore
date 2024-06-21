using Dự_án_1.DAL.Models;
using Dự_án_1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL.Service
{
    internal class HDCTSer
    {
        HDCTRes hdctSer = new();
        public List<Hdct> getAllHDCTSer()
        {
            return hdctSer.getAllhoaDonCTRes();
        }
        public string CreateHDCTSer(string mahdct , string maspct,string mahd , int soluong,decimal donGia)
        {
            Hdct newHDCT = new Hdct()
            {
                Idhdct=mahdct,Maspct=maspct,Mahd=mahd,Soluong=soluong,Dongia=donGia
            };
            if(hdctSer.CreateHDCTRes(newHDCT))
            {
                return "Them hoa don thanh cong";
            }
            else
            {
                return "Them hoa don that bai";
            }
        }
        public string UpdateHDCTSer(string mahdct, string maspct, string mahd, int soluong, decimal donGia)
        {
            Hdct updatehdct = hdctSer.getAllhoaDonCTRes().Find(x => x.Idhdct==mahdct);
            updatehdct.Soluong = soluong;
            updatehdct.Dongia= donGia;
            if(hdctSer.UpdateHDCTRes(updatehdct))
            {
                return "Cap nhat hoa don thanh cong";
            }
            else
            {
                return "Cap nhat hoa don that bai";
            }
        }
        public string RemoveHDCTSer(string mahdct)
        {
            Hdct removehdct = hdctSer.getAllhoaDonCTRes().Find(x => x.Idhdct == mahdct);
            if(hdctSer.RemoveHDCTRes(removehdct))
            {
                return "Xoa thanh cong ";
            }
            else
            {
                return "Xoa that bai";
            }
        }
    }
}
