using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models
{
    public partial class M
    {
        public M()
        {
            Spcts = new HashSet<Spct>();
        }

        public string Mamau { get; set; } = null!;
        public string Tenmau { get; set; } = null!;

        public virtual ICollection<Spct> Spcts { get; set; }
    }
}
