
using ClassLibrary1;
using Dự_án_1.BLL;
using Dự_án_1.BLL.Service;
using Dự_án_1.DAL.Models;
using Dự_án_1.Valiable;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Dự_án_1.GUI
{
    public partial class BanHang : UIForm
    {
        #region
        SanPhamSer sp;
        SPCTSer spct;
        Brandser bra;
        MauSer ms;
        SizeSer ss;
        HoaDonSer hd;
        HDCTSer hdct;
        KhachHangSer kh;
        NhanVienSer nv;
        #endregion
        #region
        string maspct;
        string mahdct;
        private bool scanning = false;
        #endregion
        public BanHang()
        {
            InitializeComponent();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            spct = new SPCTSer();
            sp = new SanPhamSer();
            ms = new MauSer();
            ss = new SizeSer();
            bra = new Brandser();
            hd = new HoaDonSer();
            hdct = new HDCTSer();
            kh = new();
            nv = new();
            lb_VAT.Text = (VAT.mucVAT * 100).ToString() + "%";
            loadSP();
            loafHD();
            loadHDCT();
            textBox1.Hide();
        }
        public string CreateKH()
        {
            Random random = new Random();
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";

            // Tạo hai chữ cái ngẫu nhiên
            char letter1 = letters[random.Next(letters.Length)];
            char letter2 = letters[random.Next(letters.Length)];

            // Tạo ba chữ số ngẫu nhiên
            int number1 = random.Next(10);
            int number2 = random.Next(10);
            int number3 = random.Next(10);

            // Ghép các ký tự lại thành mã khách hàng
            string customerCode = $"{letter1}{letter2}{number1}{number2}{number3}";

            return customerCode;
        }
        public string CreateMaHD()
        {
            while (true)
            {
                // Tạo phần đầu của mã hóa đơn từ một chuỗi ngẫu nhiên, ví dụ: 3 ký tự
                Random rnd = new Random();
                string prefix = rnd.Next(100, 999).ToString();

                // Tạo phần cuối của mã hóa đơn từ một chuỗi ngẫu nhiên, ví dụ: 2 ký tự
                string suffix = rnd.Next(10, 99).ToString();

                // Kết hợp phần đầu và phần cuối để tạo mã hóa đơn hoàn chỉnh
                string maHD = prefix + suffix;

                // Kiểm tra xem mã hóa đơn đã tồn tại trong danh sách các mã đã có hay chưa
                if (!hd.getAllHoaDonSer().Any(x => x.Mahd == maHD))
                {
                    // Mã hóa đơn duy nhất, trả về mã này
                    return maHD;
                }
            }
        }
        public string CreateMaHDCT()
        {
            // Tạo một mảng chứa tất cả các chữ cái trong bảng chữ cái tiếng Anh
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            // Thêm 3 chữ cái ngẫu nhiên vào chuỗi
            for (int i = 0; i < 3; i++)
            {
                int index = random.Next(0, letters.Length);
                sb.Append(letters[index]);
            }

            // Thêm 3 chữ số ngẫu nhiên vào chuỗi
            for (int i = 0; i < 3; i++)
            {
                sb.Append(random.Next(0, 10));
            }

            return sb.ToString();
        }
        public void loadSP()
        {
            var q = from i in spct.getAllSPCTSer()
                    join ms in ms.getAllColorSer() on i.Mamau equals ms.Mamau
                    join kt in ss.getAllSizeSer() on i.Masize equals kt.Masize
                    join s in sp.getAllSanPhamSer() on i.Masp equals s.Masp
                    where (i.Tt == null || !i.Tt.Contains("Out")) && i.Soluong > 0
                    select new
                    {
                        i.Maspct,
                        i.Tenspct,
                        kt.Tensize,
                        ms.Tenmau,
                        i.Soluong,
                        DonGia = i.Dongia.ToString("#,##0"),
                        i.Tt
                    };
            dgv_sanPham.DataSource = q.ToList();
            dgv_sanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgv_sanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_sanPham.Columns[2].HeaderText = "Size";
            dgv_sanPham.Columns[3].HeaderText = "Màu sắc";
            dgv_sanPham.Columns[4].HeaderText = "Số lượng";
            dgv_sanPham.Columns[5].HeaderText = "Đơn giá (VND)";
            dgv_sanPham.Columns[6].HeaderText = "Tình trạng";
        }
        private void dgv_sanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_sanPham.Columns[0].Width = 150;
            dgv_sanPham.Columns[1].Width = 200;
            dgv_sanPham.Columns[2].Width = 50;
            dgv_sanPham.Columns[3].Width = 70;
            dgv_sanPham.Columns[4].Width = 100;
            dgv_sanPham.Columns[5].Width = 100;
        }
        public void loafHD()
        {
            var q = from i in hd.getAllHoaDonSer()
                    join
                    n in kh.getAllKhachHangSer() on i.Makh equals n.Makh
                    where i.TinhTrang == "Chưa thanh toán"
                    select new
                    {
                        i.Mahd,
                        n.Tenkh,
                        i.Ngaythang,
                        i.TinhTrang,
                    };
            dgv_hoadon.DataSource = q.ToList();
            dgv_hoadon.Columns[0].HeaderText = "Mã hóa đơn";
            dgv_hoadon.Columns[1].HeaderText = "Tên khách hàng";
            dgv_hoadon.Columns[2].HeaderText = "Ngày lập hóa đơn";
            dgv_hoadon.Columns[3].HeaderText = "Tình trạng thanh toán";
        }
        private void dgv_hoadon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_hoadon.Columns[0].Width = 150;
            dgv_hoadon.Columns[1].Width = 200;
            dgv_hoadon.Columns[2].Width = 200;
            dgv_hoadon.Columns[3].Width = 200;
        }
        public void loadHDCT()
        {
            var q = from i in hdct.getAllHDCTSer()
                    join a in hd.getAllHoaDonSer() on i.Mahd equals a.Mahd
                    join k in spct.getAllSPCTSer() on i.Maspct equals k.Maspct
                    join m in ms.getAllColorSer() on k.Mamau equals m.Mamau
                    join s in ss.getAllSizeSer() on k.Masize equals s.Masize
                    join p in sp.getAllSanPhamSer() on k.Masp equals p.Masp
                    join t in bra.getAllBrandSer() on p.Math equals t.Math
                    where a.Mahd == i.Mahd && a.TinhTrang == "Chưa thanh toán"
                    select new
                    {
                        i.Idhdct,
                        k.Tenspct,
                        i.Soluong,
                        m.Tenmau,
                        s.Tensize,
                        t.Tenth,
                        DonGia = i.Dongia.ToString("#,##0"),
                    };
            dgv_HDCT.DataSource = q.ToList();
            dgv_HDCT.Columns[0].HeaderText = "Mã hóa đơn chi tiết";
            dgv_HDCT.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_HDCT.Columns[2].HeaderText = "Số lượng mua";
            dgv_HDCT.Columns[3].HeaderText = "Màu sắc";
            dgv_HDCT.Columns[4].HeaderText = "Size";
            dgv_HDCT.Columns[5].HeaderText = "Thương hiệu";
            dgv_HDCT.Columns[6].HeaderText = "Đơn giá";
        }
        private void dgv_HDCT_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_HDCT.Columns[0].Width = 200;
            dgv_HDCT.Columns[1].Width = 150;
            dgv_HDCT.Columns[2].Width = 150;
            dgv_HDCT.Columns[3].Width = 100;
            dgv_HDCT.Columns[4].Width = 50;
            dgv_HDCT.Columns[5].Width = 150;
            dgv_HDCT.Columns[6].Width = 100;
        }
        private void dgv_sanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                maspct = dgv_sanPham.Rows[i].Cells[0].Value.ToString();
                var q = spct.getAllSPCTSer().Find(x => x.Maspct == maspct);
                lbl_tenSP.Text = q.Tenspct;
                lbl_size.Text = ss.getAllSizeSer().Find(a => a.Masize == q.Masize).Tensize;
                lbl_mau.Text = ms.getAllColorSer().Find(x => x.Mamau == q.Mamau).Tenmau;
                var s = spct.FindbyIDSer(maspct);
                object img = s.HinhAnh;
                pic_spct.Image?.Dispose();
                byte[] imageData = (byte[])img;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    pic_spct.Image = image;
                }
            }
        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                lbl_maHD.Text = dgv_hoadon.Rows[i].Cells[0].Value.ToString();
                lbl_maKH.Text = hd.getAllHoaDonSer().FirstOrDefault(x => x.Mahd == lbl_maHD.Text).Makh;
                txt_tenKH.Text = kh.getAllKhachHangSer().FirstOrDefault(x => x.Makh == lbl_maKH.Text).Tenkh;
                txt_SDT.Text = kh.getAllKhachHangSer().FirstOrDefault(x => x.Makh == lbl_maKH.Text).Sdt;
                var j = hdct.getAllHDCTSer().Find(x => x.Mahd == lbl_maHD.Text);
                var z = from o in hdct.getAllHDCTSer()
                        join a in hd.getAllHoaDonSer() on o.Mahd equals a.Mahd
                        join k in spct.getAllSPCTSer() on o.Maspct equals k.Maspct
                        join m in ms.getAllColorSer() on k.Mamau equals m.Mamau
                        join s in ss.getAllSizeSer() on k.Masize equals s.Masize
                        join p in sp.getAllSanPhamSer() on k.Masp equals p.Masp
                        join t in bra.getAllBrandSer() on p.Math equals t.Math
                        where a.Mahd == lbl_maHD.Text && a.TinhTrang == "Chưa thanh toán"
                        select new
                        {
                            o.Idhdct,
                            k.Tenspct,
                            o.Soluong,
                            m.Tenmau,
                            s.Tensize,
                            t.Tenth,
                            DonGia = o.Dongia.ToString("#,##0"),
                        };
                dgv_HDCT.DataSource = z.ToList();
            }
            var q = from hdcts in hdct.getAllHDCTSer() where hdcts.Mahd == lbl_maHD.Text select hdcts;
            decimal tongTien = q.Sum(hdct => hdct.Soluong * hdct.Dongia);
            lbl_tongTien2.Text = tongTien.ToString("#,##0");
            decimal thanhToan = tongTien + (decimal.Parse(lbl_tongTien2.Text) * (decimal)VAT.mucVAT);
            lbl_thanhTian.Text = thanhToan.ToString("#,##0");
        }

        private void txt_maKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string input = txt_SDT.Text;
                if (Regex.IsMatch(input, @"^0\d+$"))
                {
                    var q = kh.getAllKhachHangSer().Find(x => x.Sdt == input);
                    if (q != null)
                    {
                        lbl_maKH.Text = q.Makh.ToString();
                        txt_tenKH.Text = q.Tenkh.ToString();
                    }
                    else if (txt_SDT.Text.Length >= 10)
                    {
                        try
                        {
                            DialogResult result = MessageBox.Show("Bạn không cần điền tiên của khách hàng ?", "Thông báo", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                string mess = kh.CreateKHSer(CreateKH(), txt_tenKH.Text, input, "--");
                                MessageBox.Show(mess, "Thông báo");
                            }
                            else
                            {
                                txt_tenKH.Focus();
                                if (!string.IsNullOrEmpty(txt_tenKH.Text))
                                {
                                    string mess = kh.CreateKHSer(CreateKH(), txt_tenKH.Text, input, "--");
                                    MessageBox.Show(mess, "Thông báo");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ");
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại bắt đầu bằng số 0 và chỉ chứa các chữ số.", "Thông báo");
                }
            }
        }

        #region HOADON
        private void btn_themHDC_Click(object sender, EventArgs e)
        {
            int slHDCT = hd.getAllHoaDonSer().Where(x => x.TinhTrang == "Chưa thanh toán").Count();
            if (slHDCT <= 4)
            {
                if (string.IsNullOrEmpty(lbl_maKH.Text))
                {
                    hd.CreateHoadonSer(CreateMaHD(), DateTime.Now, MaNhanVien.MANV, 0, "VL", 0.1f, "Chưa thanh toán");
                    loafHD();
                }
                else
                {
                    hd.CreateHoadonSer(CreateMaHD(), DateTime.Now, MaNhanVien.MANV, 0, lbl_maKH.Text, 0.1f, "Chưa thanh toán");
                    loafHD();
                    lbl_maKH.Text = null;
                    txt_tenKH.Clear();
                    txt_SDT.Clear();
                }
            }
            else
            {
                MessageBox.Show("Số lượng hóa đơn chờ đã vượt quá ngưỡng là 5 hóa đơn", "Thông báo");
            }
        }

        private void dgv_hoadon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult reslut = MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này chứ ?", "Thông báo", MessageBoxButtons.OKCancel);
                if (reslut == DialogResult.OK)
                {
                    var q = hdct.getAllHDCTSer().Where(x => x.Mahd == lbl_maHD.Text).Select(x => x.Idhdct).ToList();
                    if (q.Count > 0)
                    {
                        foreach (string i in q)
                        {
                            int slchuyenve = hdct.getAllHDCTSer().Find(x => x.Idhdct == i).Soluong;
                            maspct = hdct.getAllHDCTSer().Find(x => x.Idhdct == i).Maspct;
                            int slconlai = spct.getAllSPCTSer().Find(x => x.Maspct == maspct).Soluong;
                            int soluongmoi = slchuyenve + slconlai;
                            spct.updateSL(maspct, soluongmoi);
                            hdct.RemoveHDCTSer(i);
                            loadSP();
                            loadHDCT();
                        }
                        hd.deleteHDcho(lbl_maHD.Text);
                        loafHD();
                        lbl_maHD.Text = null;
                        lbl_maKH.Text = null;
                        txt_tenKH.Clear();
                        txt_SDT.Clear();
                        lbl_tongTien2.Text = null;
                        lbl_thanhTian.Text = null;
                        lbl_tienKH.Text = null;
                        lbl_tienThua.Text = null;
                    }
                    else
                    {
                        hd.deleteHDcho(lbl_maHD.Text);
                        loafHD();
                        lbl_maHD.Text = null;
                        lbl_maKH.Text = null;
                        txt_tenKH.Clear();
                        txt_SDT.Clear();
                        lbl_tongTien2.Text = null;
                        lbl_thanhTian.Text = null;
                        lbl_tienKH.Text = null;
                        lbl_tienThua.Text = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_đinhanhHD_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult reslut = MessageBox.Show("Bạn chắc chắn muốn định danh hóa đơn này ?", "Thông báo", MessageBoxButtons.OKCancel);
                if (reslut == DialogResult.OK)
                {
                    if (lbl_maKH.Text != "VL")
                    {
                        hd.UpdateHoaDonSer(lbl_maHD.Text, "Chưa thanh toán", decimal.Parse(lbl_thanhTian.Text), lbl_maKH.Text, DateTime.Now);
                        MessageBox.Show("Định danh hóa đơn chờ thành công", "Thông báo");
                        loafHD();
                        txt_SDT.Clear();
                        txt_tenKH.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa điền thông tin của khách hàng , vì thế không định danh hóa đơn được", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        #endregion

        #region HDCT
        private void btn_addHDCT_Click(object sender, EventArgs e)
        {
            DialogForm frm = new();
            frm.ShowDialog();
            lbl_sl.Text = frm.soLuongmua.ToString();
            DataGridViewRow selectedRow = dgv_sanPham.CurrentRow;
            int i = selectedRow.Index;
            maspct = dgv_sanPham.Rows[i].Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(lbl_maHD.Text))
            {
                if (spct.getAllSPCTSer().Find(x => x.Maspct == maspct).Soluong >= int.Parse(lbl_sl.Text))
                {
                    var exeHDCT = hdct.getAllHDCTSer().FirstOrDefault(x => x.Mahd == lbl_maHD.Text && x.Maspct == maspct);
                    if (exeHDCT != null)
                    {
                        int slcong = int.Parse(lbl_sl.Text);
                        int slThucTe = exeHDCT.Soluong + slcong;
                        hdct.UpdateHDCTSer(exeHDCT.Idhdct, maspct, lbl_maHD.Text, slThucTe, exeHDCT.Dongia);
                        loadHDCT();
                        var spctItem = spct.getAllSPCTSer().Find(x => x.Maspct == maspct);
                        if (spctItem != null)
                        {
                            int slcon = spctItem.Soluong;
                            int slconlai = spct.tinhToanSl(slcon, int.Parse(lbl_sl.Text));
                            string mess1 = spct.updateSL(maspct, slconlai);
                            loadSP();
                        }
                    }
                    else
                    {
                        decimal donGia = spct.getAllSPCTSer().Find(x => x.Maspct == maspct).Dongia;
                        hdct.CreateHDCTSer(CreateMaHDCT(), maspct, lbl_maHD.Text, int.Parse(lbl_sl.Text), donGia);
                        loadHDCT();

                        var spctItem = spct.getAllSPCTSer().Find(x => x.Maspct == maspct);
                        if (spctItem != null)
                        {
                            int slcon = spctItem.Soluong;
                            int slconlai = spct.tinhToanSl(slcon, int.Parse(lbl_sl.Text));
                            string mess1 = spct.updateSL(maspct, slconlai);
                            loadSP();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng hàng còn lại không đủ ", "Thông báo");
                    lbl_sl.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa có hóa đơn", "Thông báo");
            }
        }
        private void dgv_HDCT_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này ra khỏi hóa đơn chứ ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DataGridViewRow selectedRow = dgv_HDCT.CurrentRow;
                int i = selectedRow.Index;
                mahdct = dgv_HDCT.Rows[i].Cells[0].Value.ToString();
                int slchuyenve = hdct.getAllHDCTSer().Find(x => x.Idhdct == mahdct).Soluong;
                maspct = hdct.getAllHDCTSer().Find(x => x.Idhdct == mahdct).Maspct;
                int slconlai = spct.getAllSPCTSer().Find(x => x.Maspct == maspct).Soluong;
                int soluongcapnhat = slconlai + slchuyenve;
                hdct.RemoveHDCTSer(mahdct);
                spct.updateSL(maspct, soluongcapnhat);
                loadSP();
                loadHDCT();
                var q = from hdcts in hdct.getAllHDCTSer() where hdcts.Mahd == lbl_maHD.Text select hdcts;
                decimal tongTien = q.Sum(hdct => hdct.Soluong * hdct.Dongia);
                lbl_tongTien2.Text = tongTien.ToString("#,##0");
                decimal thanhToan = tongTien + (decimal.Parse(lbl_tongTien2.Text) * decimal.Parse("0.1"));
                lbl_thanhTian.Text = thanhToan.ToString("#,##0");
                if (!string.IsNullOrEmpty(lbl_tienKH.Text))
                {
                    lbl_tienThua.Text = (decimal.Parse(lbl_tienKH.Text) - decimal.Parse(lbl_thanhTian.Text)).ToString("#,##0");
                }
            }
        }
        private void dgv_sanPham_DoubleClick(object sender, EventArgs e)
        {
            lbl_sl.Text = 1.ToString();
            DataGridViewRow selectedRow = dgv_sanPham.CurrentRow;
            int i = selectedRow.Index;
            maspct = dgv_sanPham.Rows[i].Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(lbl_maHD.Text))
            {
                var exeHDCT = hdct.getAllHDCTSer().FirstOrDefault(x => x.Mahd == lbl_maHD.Text && x.Maspct == maspct);
                if (exeHDCT != null)
                {
                    int slcong = int.Parse(lbl_sl.Text);
                    int slThucTe = exeHDCT.Soluong + slcong;
                    hdct.UpdateHDCTSer(exeHDCT.Idhdct, maspct, lbl_maHD.Text, slThucTe, exeHDCT.Dongia);
                    loadHDCT();

                    var q = from hdcts in hdct.getAllHDCTSer() where hdcts.Mahd == lbl_maHD.Text select hdcts;
                    decimal tongTien = q.Sum(hdct => hdct.Soluong * hdct.Dongia);
                    lbl_tongTien2.Text = tongTien.ToString("#,##0");
                    decimal thanhToan = tongTien + (decimal.Parse(lbl_tongTien2.Text) * decimal.Parse("0.1"));
                    lbl_thanhTian.Text = thanhToan.ToString("#,##0");
                    if (!string.IsNullOrEmpty(lbl_tienKH.Text))
                    {
                        decimal tienthua = decimal.Parse(lbl_tienKH.Text) - decimal.Parse(lbl_thanhTian.Text);
                        if (tienthua < 0)
                        {
                            lbl_tienThua.Text = null;
                            lbl_tienKH.Text = null;
                        }
                        else
                        {
                            lbl_tienThua.Text = tienthua.ToString("#,##0");
                        }
                    }
                    else
                    {
                        lbl_tienThua.Text = null;
                    }

                    var spctItem = spct.getAllSPCTSer().Find(x => x.Maspct == maspct);
                    if (spctItem != null)
                    {
                        int slcon = spctItem.Soluong;
                        int slconlai = spct.tinhToanSl(slcon, int.Parse(lbl_sl.Text));
                        string mess1 = spct.updateSL(maspct, slconlai);
                        loadSP();
                    }
                }
                else
                {
                    decimal donGia = spct.getAllSPCTSer().Find(x => x.Maspct == maspct).Dongia;
                    hdct.CreateHDCTSer(CreateMaHDCT(), maspct, lbl_maHD.Text, int.Parse(lbl_sl.Text), donGia);
                    loadHDCT();
                    var q = from hdcts in hdct.getAllHDCTSer() where hdcts.Mahd == lbl_maHD.Text select hdcts;
                    decimal tongTien = q.Sum(hdct => hdct.Soluong * hdct.Dongia);
                    lbl_tongTien2.Text = tongTien.ToString("#,##0");
                    decimal thanhToan = tongTien + (decimal.Parse(lbl_tongTien2.Text) * decimal.Parse("0.1"));
                    lbl_thanhTian.Text = thanhToan.ToString("#,##0");
                    if (!string.IsNullOrEmpty(lbl_tienKH.Text))
                    {
                        decimal tienthua = decimal.Parse(lbl_tienKH.Text) - decimal.Parse(lbl_thanhTian.Text);
                        if (tienthua < 0)
                        {
                            lbl_tienThua.Text = null;
                            lbl_tienKH.Text = null;
                        }
                        else
                        {
                            lbl_tienThua.Text = tienthua.ToString("#,##0");
                        }
                    }
                    else
                    {
                        lbl_tienThua.Text = null;
                    }

                    var spctItem = spct.getAllSPCTSer().Find(x => x.Maspct == maspct);
                    if (spctItem != null)
                    {
                        int slcon = spctItem.Soluong;
                        int slconlai = spct.tinhToanSl(slcon, int.Parse(lbl_sl.Text));
                        string mess1 = spct.updateSL(maspct, slconlai);
                        loadSP();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa có hóa đơn", "Thông báo");
            }
        }

        #endregion

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            if (hd.getAllHoaDonSer().Where(x => x.TinhTrang == "Chưa thanh toán").Count() > 0)
            {
                if (!string.IsNullOrEmpty(lbl_maHD.Text))
                {
                    if (decimal.Parse(lbl_thanhTian.Text) > 0)
                    {
                        if (lbl_maKH.Text == "VL")
                        {
                            frmthanhToan frm = new();
                            frm.ShowDialog();
                            if (frm.tienKH >= decimal.Parse(lbl_thanhTian.Text))
                            {
                                lbl_tienKH.Text = frm.tienKH.ToString();
                                decimal tienThua = decimal.Parse(lbl_tienKH.Text) - decimal.Parse(lbl_thanhTian.Text);
                                lbl_tienThua.Text = tienThua >= 0 ? tienThua.ToString("#,##0") : null;
                                lbl_tienKH.Text = tienThua >= 0 ? frm.tienKH.ToString("#,##0") : null;
                                DialogResult result = MessageBox.Show("Bạn sẽ thanh toán mà không cần thông tin của khách hàng ? ", "Thông báo", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    hd.UpdateHoaDonSer(lbl_maHD.Text, "Đã thanh toán", decimal.Parse(lbl_thanhTian.Text), lbl_maKH.Text, DateTime.Now);
                                    loafHD();
                                    loadHDCT();
                                    inHoaDon();
                                    lbl_maHD.Text = null;
                                    lbl_tongTien2.Text = null;
                                    lbl_thanhTian.Text = null;
                                    lbl_tienKH.Text = null;
                                    lbl_tienThua.Text = null;
                                    lbl_maKH.Text = null;
                                    txt_tenKH.Clear();
                                    txt_SDT.Clear();
                                }
                                else
                                {
                                    txt_tenKH.Clear();
                                    txt_SDT.Text = null;
                                    txt_SDT.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Số tiền khách đưa không đủ để chi trả hóa đơn", "Thông báo");
                            }
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(lbl_tienKH.Text))
                            {
                                frmthanhToan frm = new();
                                frm.ShowDialog();
                                if (frm.tienKH >= decimal.Parse(lbl_thanhTian.Text))
                                {
                                    lbl_tienKH.Text = frm.tienKH.ToString();
                                    decimal tienThua = decimal.Parse(lbl_tienKH.Text) - decimal.Parse(lbl_thanhTian.Text);
                                    lbl_tienThua.Text = tienThua >= 0 ? tienThua.ToString("#,##0") : null;
                                    lbl_tienKH.Text = tienThua >= 0 ? frm.tienKH.ToString("#,##0") : null;
                                    DialogResult result = MessageBox.Show("Ban chắc chắn muốn thanh toán ? ", "Thông báo", MessageBoxButtons.YesNo);
                                    if (result == DialogResult.Yes)
                                    {
                                        hd.UpdateHoaDonSer(lbl_maHD.Text, "Đã thanh toán", decimal.Parse(lbl_thanhTian.Text), lbl_maKH.Text, DateTime.Now);
                                        loafHD();
                                        loadHDCT();
                                        inHoaDon();
                                        lbl_maHD.Text = null;
                                        lbl_tongTien2.Text = null;
                                        lbl_thanhTian.Text = null;
                                        lbl_tienKH.Text = null;
                                        lbl_tienThua.Text = null;
                                        lbl_maKH.Text = null;
                                        txt_tenKH.Clear();
                                        txt_SDT.Clear();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Số tiền khách đưa không đủ để chi trả hóa đơn", "Thông báo");
                                }
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Ban chắc chắn muốn thanh toán ? ", "Thông báo", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    hd.UpdateHoaDonSer(lbl_maHD.Text, "Đã thanh toán", decimal.Parse(lbl_thanhTian.Text), lbl_maKH.Text, DateTime.Now);
                                    loafHD();
                                    loadHDCT();
                                    inHoaDon();
                                    lbl_maHD.Text = null;
                                    lbl_tongTien2.Text = null;
                                    lbl_thanhTian.Text = null;
                                    lbl_tienKH.Text = null;
                                    lbl_tienThua.Text = null;
                                    lbl_maKH.Text = null;
                                    txt_tenKH.Clear();
                                    txt_SDT.Clear();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể thanh toán hóa đơn có giá trị 0 đồng");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần thanh toán", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Không có hóa đơn cần thanh toán nào", "Thông báo");
            }
        }
        #region INHOADON
        public void inHoaDon()
        {
            ppdhd.Document = pdhd;
            ppdhd.ShowDialog();
            //ppdhd.Dispose();
        }
        private void pdhd_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var hoadon = hd.getAllHoaDonSer().FirstOrDefault(x => x.Mahd == lbl_maHD.Text);
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
                e.Graphics.DrawString(string.Format("Tổng tiền : {0}", decimal.Parse(lbl_tongTien2.Text).ToString("#,##0")),
                    new System.Drawing.Font("Times New Roman", 15),
                    System.Drawing.Brushes.DarkRed,
                    new System.Drawing.Point(500, y + 800));
                e.Graphics.DrawString(string.Format("VAT : {0}", lb_VAT.Text),
                    new System.Drawing.Font("Times New Roman", 15),
                    System.Drawing.Brushes.DarkRed,
                    new System.Drawing.Point(500, y + 840));
                e.Graphics.DrawString(string.Format("Thanh toán : {0}", decimal.Parse(lbl_thanhTian.Text).ToString("#,##0")),
                    new System.Drawing.Font("Times New Roman", 15),
                    System.Drawing.Brushes.DarkRed,
                    new System.Drawing.Point(500, y + 880));
                e.Graphics.DrawString(string.Format("Tiền khách đưa : {0}", decimal.Parse(lbl_tienKH.Text).ToString("#,##0")),
                    new System.Drawing.Font("Times New Roman", 15),
                    System.Drawing.Brushes.DarkRed,
                    new System.Drawing.Point(500, y + 920));
                e.Graphics.DrawString(string.Format("Tiền thừa : {0}", decimal.Parse(lbl_tienThua.Text).ToString("#,##0")),
                    new System.Drawing.Font("Times New Roman", 15),
                    System.Drawing.Brushes.DarkRed,
                    new System.Drawing.Point(500, y + 960));
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
                foreach (var hct in hdct.getAllHDCTSer().Where(c => c.Mahd == lbl_maHD.Text))
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
                            e.Graphics.DrawString(string.Format("{0}", hct.Dongia.ToString("#,##0")), new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 150, y + 400));
                            e.Graphics.DrawString(string.Format("{0}", thanhtien.ToString("#,##0")), new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(w / 2 + 300, y + 400));
                            y += 20;
                        }
                    }
                }
            }
        }
        #endregion

        #region Quet ma QR
        #endregion

        private void BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp = null;
            spct = null;
            bra = null;
            ms = null;
            ss = null;
            hd = null;
            hdct = null;
            kh = null;
            nv = null;
            string maspct = null;
            string mahdct = null;
        }

        private void dgv_sanPham_MouseEnter(object sender, EventArgs e)
        {
            tt1.SetToolTip(dgv_sanPham, "Double Click để thêm sản phẩm");
        }

        private void dgv_hoadon_MouseEnter(object sender, EventArgs e)
        {
            tt1.SetToolTip(dgv_hoadon, "Double Click để xóa hóa đơn chờ");
        }

        private void dgv_HDCT_MouseEnter(object sender, EventArgs e)
        {
            tt1.SetToolTip(dgv_HDCT, "Double Click để xóa hóa đơn chi tiết");
        }

        private void btn_addHDCT_MouseEnter(object sender, EventArgs e)
        {
            tt1.SetToolTip(btn_addHDCT, "Thêm sản phẩm vào hóa đơn");
        }

        private void btn_sacnQR_MouseEnter(object sender, EventArgs e)
        {
            tt1.SetToolTip(btn_sacnQR, "Quét mã QR để thêm sản phẩm vào hóa đơn");
        }

        private void btn_themHDC_MouseEnter(object sender, EventArgs e)
        {
            tt1.SetToolTip(btn_themHDC, "Thêm hóa đơn chờ");
        }

        private void btn_đinhanhHD_MouseEnter(object sender, EventArgs e)
        {
            tt1.SetToolTip(btn_đinhanhHD, "Định danh hóa đơn");
        }

        private void btn_thanhToan_MouseEnter(object sender, EventArgs e)
        {
            tt1.SetToolTip(btn_thanhToan, "Thanh toán hóa đơn");
        }

        private void uiImageButton3_Click(object sender, EventArgs e)
        {
            if (!textBox1.Visible)
            {
                textBox1.Show();
            }
            else
            {
                textBox1.Hide();
            }
        }

        private void uiImageButton3_MouseEnter(object sender, EventArgs e)
        {
            tt1.SetToolTip(uiImageButton3, "Tìm kiếm sản phẩm");
        }

        private void btn_sacnQR_Click(object sender, EventArgs e)
        {
            ScanQR();
        }

        protected void ScanQR()
        {
            Class1 class1 = new Class1();
            string maspct = class1.TurnCamera();

            if( maspct == null)
            {
                var product = (from i in spct.getAllSPCTSer()
                               join ms in ms.getAllColorSer() on i.Mamau equals ms.Mamau
                               join kt in ss.getAllSizeSer() on i.Masize equals kt.Masize
                               where i.Maspct == maspct
                               select new
                               {
                                   Product = i,
                                   Color = ms,
                                   Size = kt
                               }).FirstOrDefault();
                lbl_tenSP.Text = product?.Product.Tenspct;
                lbl_mau.Text = product?.Color.Tenmau;
                lbl_size.Text = product?.Size.Tensize;
                decimal giaTien = product?.Product.Dongia ?? 0;
                lbl_giaTien.Text = giaTien.ToString();
                object img = product?.Product.HinhAnh;
                pic_spct.Image?.Dispose();
                byte[] imageData = (byte[])img;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    pic_spct.Image = image;
                }
                lbl_sl.Text = 1.ToString();

                // Them hoa don
                if (!string.IsNullOrEmpty(lbl_maHD.Text))
                {
                    if (spct.getAllSPCTSer().Find(x => x.Maspct == maspct).Soluong >= int.Parse(lbl_sl.Text))
                    {
                        var exeHDCT = hdct.getAllHDCTSer().FirstOrDefault(x => x.Mahd == lbl_maHD.Text && x.Maspct == maspct);
                        if (exeHDCT != null)
                        {
                            int slcong = int.Parse(lbl_sl.Text);
                            int slThucTe = exeHDCT.Soluong + slcong;
                            hdct.UpdateHDCTSer(exeHDCT.Idhdct, maspct, lbl_maHD.Text, slThucTe, exeHDCT.Dongia);
                            loadHDCT();
                            var spctItem = spct.getAllSPCTSer().Find(x => x.Maspct == maspct);
                            if (spctItem != null)
                            {
                                int slcon = spctItem.Soluong;
                                int slconlai = spct.tinhToanSl(slcon, int.Parse(lbl_sl.Text));
                                string mess1 = spct.updateSL(maspct, slconlai);
                                loadSP();
                            }
                        }
                        else
                        {
                            decimal donGia = spct.getAllSPCTSer().Find(x => x.Maspct == maspct).Dongia;
                            hdct.CreateHDCTSer(CreateMaHDCT(), maspct, lbl_maHD.Text, int.Parse(lbl_sl.Text), donGia);
                            loadHDCT();

                            var spctItem = spct.getAllSPCTSer().Find(x => x.Maspct == maspct);
                            if (spctItem != null)
                            {
                                int slcon = spctItem.Soluong;
                                int slconlai = spct.tinhToanSl(slcon, int.Parse(lbl_sl.Text));
                                string mess1 = spct.updateSL(maspct, slconlai);
                                loadSP();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng hàng còn lại không đủ ", "Thông báo");
                        lbl_sl.Text = null;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa có hóa đơn", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Khong tim thay ma QR");
            }
        }
        private void lb_VAT_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lấy văn bản từ textBox1 và đảm bảo rằng nó không phải là null
            string tensp_serching = textBox1.Text ?? string.Empty;

            // Lấy danh sách sản phẩm chi tiết từ spct
            var allSPCT = spct.getAllSPCTSer();
            if (allSPCT == null)
            {
                // Xử lý tình huống khi danh sách sản phẩm chi tiết trả về null
                MessageBox.Show("Danh sách sản phẩm không thể tải.");
                return;
            }

            // Kiểm tra nếu trường nhập liệu là trống
            if (string.IsNullOrWhiteSpace(tensp_serching))
            {
                // Nếu trống, hiển thị toàn bộ danh sách sản phẩm
                dgv_sanPham.DataSource = allSPCT;
            }
            else
            {
                // Tìm sản phẩm chi tiết dựa trên tên
                var filteredList = allSPCT.FindAll(x => x.Tenspct != null && x.Tenspct.ToLower().Contains(tensp_serching.ToLower()));

                // Hiển thị danh sách sản phẩm phù hợp
                dgv_sanPham.DataSource = filteredList;
            }
        }


    }
}
