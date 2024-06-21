using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models
{
    public partial class Kh
    {
        public Kh()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        public string Makh { get; set; } = null!;
        public string Tenkh { get; set; } = null!;
        public string Diachi { get; set; } = null!;
        public string Sdt { get; set; } = null!;

        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
