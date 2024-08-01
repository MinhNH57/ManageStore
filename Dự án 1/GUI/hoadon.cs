using Dự_án_1.BLL;
using Dự_án_1.BLL.Service;
using Dự_án_1.DAL.Models;
using Dự_án_1.DAL.Repositories;
using Dự_án_1.Valiable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dự_án_1.GUI
{
    public partial class hoadon : Form
    {
        public hoadon()
        {
            InitializeComponent();
        }
        #region // Bien
        HoaDonSer hd = new();
        HDCTSer hdct = new();
        KhachHangSer kh = new();
        SanPhamSer sp = new();
        SPCTSer spct = new();
        MauSer ms = new();
        SizeSer ss = new();
        NhanVienSer nv = new();
        #endregion
        #region // Loading
        public void loadHoaDon()
        {
            var i = from a in hd.getAllHoaDonSer()
                    join k in kh.getAllKhachHangSer() on a.Makh equals k.Makh
                    join n in nv.getAllnhanvienSer() on a.Manv equals n.Manv
                    join h in hdct.getAllHDCTSer() on a.Mahd equals h.Mahd into hGroup
                    where a.TinhTrang == "Đã thanh toán"
                    select new
                    {
                        a.Mahd,
                        a.Ngaythang,
                        k.Tenkh,
                        n.Tennv,
                        TongTien = hGroup.Sum(x => (x.Dongia) * (x.Soluong)),
                        a.TinhTrang
                    };
            var hoaDonWithVAT = i.Select(hds => new
            {
                hds.Mahd,
                hds.Ngaythang,
                hds.Tenkh,
                hds.Tennv,
                tongtien = hds.TongTien.ToString("#,##0"),
                VAT = (VAT.mucVAT).ToString(),
                TongTienVAT = (hds.TongTien + (hds.TongTien * 0.1m)).ToString("#,##0"),
                hds.TinhTrang
            });
            dgv_HOADON.DataSource = hoaDonWithVAT.ToList();
        }

        private void hoadon_Load(object sender, EventArgs e)
        {
            loadHoaDon();
        }
        #endregion

        private void dgv_HOADON_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                var q = from a in hdct.getAllHDCTSer()
                        join
                        s in spct.getAllSPCTSer() on a.Maspct equals s.Maspct
                        join m in ms.getAllColorSer() on s.Mamau equals m.Mamau
                        join k in ss.getAllSizeSer() on s.Masize equals k.Masize
                        where a.Mahd == dgv_HOADON.Rows[i].Cells[0].Value.ToString()
                        select new
                        {
                            a.Mahd,
                            a.Idhdct,
                            s.Tenspct,
                            m.Tenmau,
                            k.Tensize, 
                            a.Soluong,
                            a.Dongia,
                            thanhtien = (a.Soluong) * (a.Dongia)
                        };
                dgv_HDCT.DataSource = q.ToList();
            }
        }

        private void dgv_HOADON_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                MaHD.maHD = dgv_HOADON.Rows[index].Cells[0].Value.ToString();
            }
        }

        public void inHoaDon()
        {
            ppdhd.Document = pdhd;
            ppdhd.ShowDialog();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            inHoaDon();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            var i = from a in hd.getAllHoaDonSer()
                    join k in kh.getAllKhachHangSer() on a.Makh equals k.Makh
                    join n in nv.getAllnhanvienSer() on a.Manv equals n.Manv
                    join h in hdct.getAllHDCTSer() on a.Mahd equals h.Mahd into hGroup
                    where k.Tenkh.ToLower().Contains(txt_timKiem.Text.ToLower())
                    select new
                    {
                        a.Mahd,
                        a.Ngaythang,
                        k.Tenkh,
                        n.Tennv,
                        TongTien = hGroup.Sum(x => (x.Dongia) * (x.Soluong)),
                        a.TinhTrang
                    };
            var hoaDonWithVAT = i.Select(hds => new
            {
                hds.Mahd,
                hds.Ngaythang,
                hds.Tenkh,
                hds.Tennv,
                tongtien = hds.TongTien.ToString("#,##0"),
                VAT = (VAT.mucVAT).ToString(),
                TongTienVAT = (hds.TongTien + (hds.TongTien * 0.1m)).ToString("#,##0"),
                hds.TinhTrang
            });
            dgv_HOADON.DataSource = hoaDonWithVAT.ToList();
        }

        private void pdhd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var hoadon = hd.getAllHoaDonSer().FirstOrDefault(x => x.Mahd == MaHD.maHD);
            if (hoadon != null)
            {
                var kh1 = kh.getAllKhachHangSer().FirstOrDefault(k => k.Makh == hoadon.Makh);
                var nv1 = nv.getAllnhanvienSer().FirstOrDefault(n => n.Manv == hoadon.Manv);
                var w = pdhd.DefaultPageSettings.PaperSize.Width;
                //Tên cửa hàng
                string text = "Cửa hàng thời trang Ryo";
                Font font = new Font("Times New Roman", 30, FontStyle.Bold);
                Brush brush = Brushes.Black;
                SizeF textSize = e.Graphics.MeasureString(text, font);

                int x = (int)((e.PageBounds.Width - textSize.Width) / 2);
                int y = 20; // Điểm y không thay đổi

                e.Graphics.DrawString(text, font, brush, new PointF(x, y));
                // địa chỉ 
                string address = "Số nhà 99 - Vĩnh Lộc - Thạch Thất - Hà Nội";
                Font addressFont = new Font("Times New Roman", 12, FontStyle.Bold);
                Brush addressBrush = Brushes.Black;
                SizeF addressSize = e.Graphics.MeasureString(address, addressFont);

                int addressX = (int)((e.PageBounds.Width - addressSize.Width) / 2);
                int addressY = 80;

                e.Graphics.DrawString(address, addressFont, addressBrush, new PointF(addressX, addressY));
                // Tiều đề 
                string tieude = "HÓA ĐƠN BÁN QUẦN ÁO";
                Font tieudeFont = new Font("Times New Roman", 30, FontStyle.Bold);
                Brush tieudeBrush = Brushes.Black;
                SizeF tieudeSize = e.Graphics.MeasureString(tieude, tieudeFont);

                int tieudeX = (int)((e.PageBounds.Width - tieudeSize.Width) / 2);
                int tieudeY = 170;

                e.Graphics.DrawString(tieude, tieudeFont, tieudeBrush, new PointF(tieudeX, tieudeY));
                // Mã Hóa Đơn
                string hdon = "Mã Hóa Đơn: " + (hoadon?.Mahd ?? "");
                Font hdFont = new Font("Times New Roman", 15, FontStyle.Bold);
                Brush hdBrush = Brushes.Black;
                SizeF hdSize = e.Graphics.MeasureString(hdon, hdFont);

                int hdX = (int)((e.PageBounds.Width - hdSize.Width) / 2);
                int hdY = 230; // Điểm y giống với dòng tiêu đề

                e.Graphics.DrawString(hdon, hdFont, hdBrush, new PointF(hdX, hdY));

                // Thời gian
                string currentTime = DateTime.Now.ToString();
                Font timeFont = new Font("Times New Roman", 15, FontStyle.Bold);
                Brush timeBrush = Brushes.Black;
                SizeF timeSize = e.Graphics.MeasureString(currentTime, timeFont);

                int timeX = (int)((e.PageBounds.Width - timeSize.Width) / 2);
                int timeY = hdY + (int)hdSize.Height + 15; // Thêm khoảng cách 20 pixel giữa dòng mã hóa đơn và dòng thời gian

                e.Graphics.DrawString(currentTime, timeFont, timeBrush, new PointF(timeX, timeY));

                // Ngày Mua
                y += 20;
                e.Graphics.DrawString(string.Format("Ngày Mua : {0}", ((DateTime)hoadon.Ngaythang).ToString("dd/MM/yyyy HH:mm")),
                    new System.Drawing.Font("Times New Roman", 15),
                    System.Drawing.Brushes.Black,
                    new System.Drawing.Point(40, y + 280));
                e.Graphics.DrawString(string.Format("Tên Khách Hàng : {0}", kh1.Tenkh),
                    new System.Drawing.Font("Times New Roman", 15),
                    System.Drawing.Brushes.Black,
                    new System.Drawing.Point(40, y + 320));
                e.Graphics.DrawString(string.Format("Tên Nhân Viên : {0}", nv1.Tennv),
                    new System.Drawing.Font("Times New Roman", 15),
                    System.Drawing.Brushes.Black,
                    new System.Drawing.Point(40, y + 360));
                e.Graphics.DrawString(string.Format("SĐT : {0}", kh1.Sdt),
                   new System.Drawing.Font("Times New Roman", 15),
                   System.Drawing.Brushes.Black,
                   new System.Drawing.Point(40, y + 400));
                y += 50;
                e.Graphics.DrawString(string.Format("STT"), new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold), Brushes.Red, new System.Drawing.Point(40, y + 400));
                e.Graphics.DrawString(string.Format("Tên Sản Phẩm"), new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold), Brushes.Red, new System.Drawing.Point(80, y + 400));
                e.Graphics.DrawString(string.Format("Size"), new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold), Brushes.Red, new System.Drawing.Point(w / 2 - 140, y + 400));
                e.Graphics.DrawString(string.Format("Màu Sắc"), new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold), Brushes.Red, new System.Drawing.Point(w / 2 - 70, y + 400));
                e.Graphics.DrawString(string.Format("Số Lượng"), new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold), Brushes.Red, new System.Drawing.Point(w / 2 + 35, y + 400));
                e.Graphics.DrawString(string.Format("Đơn Giá"), new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold), Brushes.Red, new System.Drawing.Point(w / 2 + 150, y + 400));
                e.Graphics.DrawString(string.Format("Thành Tiền"), new System.Drawing.Font("Times New Roman", 12, FontStyle.Bold), Brushes.Red, new System.Drawing.Point(w / 2 + 300, y + 400));

                int stt = 1;
                y += 20;

                foreach (var hct in hdct.getAllHDCTSer().Where(c => c.Mahd == MaHD.maHD))
                {
                    var thanhtien = hct.Soluong * hct.Dongia;
                    // Tìm sản phẩm chi tiết có mã sản phẩm chi tiết trùng với mã sản phẩm chi tiết trong chi tiết hóa đơn
                    var tensp = spct.getAllSPCTSer().Where(x => x.Maspct == hct.Maspct).FirstOrDefault();
                    var q = from s in spct.getAllSPCTSer()
                            join m in ms.getAllColorSer() on s.Mamau equals m.Mamau
                            join k in ss.getAllSizeSer() on s.Masize equals k.Masize
                            select new
                            {
                                s.Maspct,
                                k.Tensize,
                                m.Tenmau
                            };
                    if (tensp != null)
                    {
                        string t = tensp.Tenspct;

                        // Lấy thông tin về kích thước và màu sắc của sản phẩm chi tiết hiện tại
                        var spctInfo = q.FirstOrDefault(item => item.Maspct == hct.Maspct);
                        if (spctInfo != null)
                        {
                            string size = spctInfo.Tensize;
                            string mauSac = spctInfo.Tenmau;

                            e.Graphics.DrawString(string.Format("{0}", stt++), new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(40, y + 400));
                            e.Graphics.DrawString(string.Format("{0}", t), new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(80, y + 400));
                            e.Graphics.DrawString(string.Format("{0}", size), new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 - 140, y + 400));
                            e.Graphics.DrawString(string.Format("{0}", mauSac), new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 - 70, y + 400));
                            e.Graphics.DrawString(string.Format("{0}", hct.Soluong), new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 35, y + 400));
                            e.Graphics.DrawString(string.Format("{0}", hct.Dongia), new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 150, y + 400));
                            e.Graphics.DrawString(string.Format("{0}", thanhtien), new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 300, y + 400));
                            y += 20;
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào ", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var i = from a in hd.getAllHoaDonSer()
                    join k in kh.getAllKhachHangSer() on a.Makh equals k.Makh
                    join n in nv.getAllnhanvienSer() on a.Manv equals n.Manv
                    join h in hdct.getAllHDCTSer() on a.Mahd equals h.Mahd into hGroup
                    where (a.TinhTrang == "Đã thanh toán") && (a.Ngaythang >= dtp_tuNgay.Value && a.Ngaythang < dtp_denNgay.Value)
                    select new
                    {
                        a.Mahd,
                        a.Ngaythang,
                        k.Tenkh,
                        n.Tennv,
                        TongTien = hGroup.Sum(x => (x.Dongia) * (x.Soluong)),
                        a.TinhTrang
                    };
            var hoaDonWithVAT = i.Select(hds => new
            {
                hds.Mahd,
                hds.Ngaythang,
                hds.Tenkh,
                hds.Tennv,
                TongTienVAT = (hds.TongTien) * 1.1m,
                hds.TinhTrang
            });
            dgv_HOADON.DataSource = hoaDonWithVAT.ToList();
        }
    }
}

