using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models
{
    public partial class Kmct
    {
        public string Makm { get; set; } = null!;
        public string Maspct { get; set; } = null!;
        public string? Ghichu { get; set; }
        public string Makmct { get; set; } = null!;

        public virtual Km MakmNavigation { get; set; } = null!;
        public virtual Spct MaspctNavigation { get; set; } = null!;
    }
}
