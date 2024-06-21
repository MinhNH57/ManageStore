using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models
{
    public partial class Hdct
    {
        public string Idhdct { get; set; } = null!;
        public string Maspct { get; set; } = null!;
        public string Mahd { get; set; } = null!;
        public int Soluong { get; set; }
        public decimal Dongia { get; set; }
        public string? Makm { get; set; }

        public virtual Hoadon MahdNavigation { get; set; } = null!;
        public virtual Km? MakmNavigation { get; set; }
        public virtual Spct MaspctNavigation { get; set; } = null!;
    }
}
