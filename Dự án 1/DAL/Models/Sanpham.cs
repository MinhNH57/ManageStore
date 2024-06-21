using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Spcts = new HashSet<Spct>();
        }

        public string Masp { get; set; } = null!;
        public string Tensp { get; set; } = null!;
        public string Loaisp { get; set; } = null!;
        public string Chatlieu { get; set; } = null!;
        public string Math { get; set; } = null!;
        public string? Tt { get; set; }
        public string LoaiCoAo { get; set; } = null!;
        public string Loaichanquan { get; set; } = null!;

        public virtual Th MathNavigation { get; set; } = null!;
        public virtual ICollection<Spct> Spcts { get; set; }
    }
}
