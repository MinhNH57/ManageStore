using Dự_án_1.DAL.Models;
using Dự_án_1.DAL.Respositories;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL.Service
{
    internal class KMCTSer
    {
        KMCTRes kmctser = new();
        public List<Kmct> getAllKMCTSer()
        {
            return kmctser.getAllKMCTRes();
        }
        public string CreateKMCTSer(string makmct, string tenspct, string makm, string gichu)
        {
            Kmct khuyenmai = new()
            {
                Makmct = makmct,
                Maspct = tenspct,
                Makm =makm,
                Ghichu = gichu,

                
            };
            if (kmctser.CreateKMCTRes(khuyenmai))
            {
                return "Tao ma thanh cong";
            }
            else
            {
                return "Tao ma that bai";
            }
        }
        public string UpdateKMctSer(string makmct, string tenspct, string makm)
        {
            Kmct upkm = kmctser.getAllKMCTRes().Find(x => x.Makmct == makmct);
            upkm.Makmct = makmct;
            upkm.Maspct = tenspct;
            upkm.Makm = makm;
            
            if (kmctser.UpdateKMCTRes(upkm))
            {
                return "Cap nhat ma san pham thanh cong";
            }
            else
            {
                return "Cap nhat ma san pham that bai";
            }
        }
        public void gia(string makmct, string gichu)
        {
            Kmct upkm = kmctser.getAllKMCTRes().Find(x => x.Makm == makmct);
            upkm.Makmct = makmct;
            upkm.Ghichu = gichu;
            if (kmctser.UpdateKMCTRes(upkm))
            {
                return ;
            }
            else
            {
                return;
            }
        }
    }
}
