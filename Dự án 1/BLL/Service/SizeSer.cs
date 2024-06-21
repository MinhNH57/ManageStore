using Dự_án_1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL
{
    internal class SizeSer
    {
        SizeRes kichThuocSer = new();

        public List<Dự_án_1.DAL.Models.Size> getAllSizeSer()
        {
            return kichThuocSer.GetAllSize();
        }
    }
}
