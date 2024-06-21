using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL
{
    internal class NhanVienRes
    {
        DUAN1NHOMContext db = new();

        public List<Nhanvien> getAllnhanvienrespo()
        {
            return db.Nhanviens.ToList();
        }
        public bool Createnvres(Nhanvien nv)
        {
            db.Nhanviens.Add(nv);
            return db.SaveChanges() > 0;
        }
        public bool Updatenvser(Nhanvien nv)
        {
            db.Nhanviens.Update(nv);
            return db.SaveChanges() > 0;
        }
        public List<Nhanvien> findbyMa(string name)
        {
            return db.Nhanviens.Where(x => x.Manv == name).ToList();
        }
        public List<Nhanvien> findbyName(string name)
        {
            return db.Nhanviens.Where(x => x.Tennv == name).ToList();
        }
        public List<Nhanvien> findbysdt(string name)
        {
            return db.Nhanviens.Where(x => x.Sdt == name).ToList();
        }
        public List<Nhanvien> findbycccd(string name)
        {
            return db.Nhanviens.Where(x => x.Cccd == name).ToList();
        }
        public List<Nhanvien> findbyquyen(string name)
        {
            return db.Nhanviens.Where(x => x.Quyen == name).ToList();
        }
        public List<Nhanvien> findbydiachi(string name)
        {
            return db.Nhanviens.Where(x => x.Diachi == name).ToList();
        }
        public List<Nhanvien> findbygt(string name)
        {
            return db.Nhanviens.Where(x => x.Gioitinh == name).ToList();
        }
        public List<Nhanvien> findbytinhtrang(string name)
        {
            return db.Nhanviens.Where(x => x.Tinhtrang == name).ToList();
        }
    }
}
