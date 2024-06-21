using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models
{
    public partial class Spct
    {
        public Spct()
        {
            Hdcts = new HashSet<Hdct>();
            Kmcts = new HashSet<Kmct>();
        }

        public string Maspct { get; set; } = null!;
        public string Tenspct { get; set; } = null!;
        public string Masize { get; set; } = null!;
        public string Mamau { get; set; } = null!;
        public string Masp { get; set; } = null!;
        public decimal Dongia { get; set; }
        public int Soluong { get; set; }
        public byte[]? HinhAnh { get; set; }
        public string? Tt { get; set; }

        public virtual M MamauNavigation { get; set; } = null!;
        public virtual Size MasizeNavigation { get; set; } = null!;
        public virtual Sanpham MaspNavigation { get; set; } = null!;
        public virtual ICollection<Hdct> Hdcts { get; set; }
        public virtual ICollection<Kmct> Kmcts { get; set; }
    }
}
