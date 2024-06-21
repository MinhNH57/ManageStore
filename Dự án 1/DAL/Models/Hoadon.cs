using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Hdcts = new HashSet<Hdct>();
        }

        public string Mahd { get; set; } = null!;
        public DateTime Ngaythang { get; set; }
        public string Manv { get; set; } = null!;
        public decimal Thanhtoan { get; set; }
        public string? Makh { get; set; }
        public double Vat { get; set; }
        public string? TinhTrang { get; set; }
        public DateTime? Thoigiancapnhat { get; set; }

        public virtual Kh? MakhNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; } = null!;
        public virtual ICollection<Hdct> Hdcts { get; set; }
    }
}
