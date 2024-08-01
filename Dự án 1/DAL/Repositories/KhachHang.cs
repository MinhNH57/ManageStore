using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL.Repositories
{
    public class KhachHang
    {
        DUAN1NHOMContext db = new();

        public KhachHang(DUAN1NHOMContext context)
        {
            db = context;
        }

        public KhachHang ()
        {

        }
        public List<Kh> GetAllKhachHangRes()
        {
            return db.Khs.ToList();
        }
        public bool CreateKHres(Kh KH)
        {
            if(KH.Sdt.Length < 10)
            {
                throw new ArgumentOutOfRangeException(nameof(KH.Sdt), "Số điện thoại phải có ít nhất 10 ký tự.");
            }

            if(KH.Sdt.Length > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(KH.Sdt), "Số điện thoại phải có ít nhất 10 ký tự.");
            }
            db.Khs.Add(KH);
            return db.SaveChanges() > 0;
        }

        public bool UpdateKHres(Kh KH)
        {
            db.Khs.Update(KH);
            return db.SaveChanges() > 0;
        }
    }
}
