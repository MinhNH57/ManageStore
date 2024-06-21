using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models
{
    public partial class Km
    {
        public Km()
        {
            Hdcts = new HashSet<Hdct>();
            Kmcts = new HashSet<Kmct>();
        }

        public string Makm { get; set; } = null!;
        public string Tenkm { get; set; } = null!;
        public DateTime Ngaybatdau { get; set; }
        public DateTime Ngayketthuc { get; set; }
        public double Slgiam { get; set; }
        public string? TinhTrang { get; set; }

        public virtual ICollection<Hdct> Hdcts { get; set; }
        public virtual ICollection<Kmct> Kmcts { get; set; }
    }
}
