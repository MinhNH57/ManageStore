using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models
{
    public partial class Size
    {
        public Size()
        {
            Spcts = new HashSet<Spct>();
        }

        public string Masize { get; set; } = null!;
        public string Tensize { get; set; } = null!;
        public double Hangcan { get; set; }
        public string? Mota { get; set; }

        public virtual ICollection<Spct> Spcts { get; set; }
    }
}
