using Dự_án_1.BLL;
using Dự_án_1.BLL.Service;
using Dự_án_1.DAL.Models;
using Dự_án_1.DAL.Respositories;
using Dự_án_1.GUI;
using Dự_án_1.Properties;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using QRCoder;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WF.Form_Chức_Năng.Form_Chức_Năng___ADMIN
{
    public partial class SanPham : Form
    {
        SanPhamSer sp = new();
        SPCTSer spct = new();
        Brandser thuongHieu = new();
        MauSer mauSac = new();
        SizeSer kichThuoc = new();
        KMCTSer kmctser = new();
        KhuyenMaiSer KMSer = new();
        string pathimg;
        public SanPham()
        {
            InitializeComponent();
            tt.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        public void loadSP()
        {
            var q = from i in sp.getAllSanPhamSer()
                    join
                    a in thuongHieu.getAllBrandSer() on i.Math equals a.Math
                    //where i.Tt == null /*|| !i.Tt.Contains("Out")*/
                    select new
                    {
                        i.Masp,
                        i.Tensp,
                        a.Tenth,
                        i.Loaisp,
                        i.Chatlieu,
                        i.LoaiCoAo,
                        i.Loaichanquan,
                        i.Tt
                    };
            dgv_dataSP.DataSource = q.ToList();
            dgv_dataSP.Columns[0].HeaderText = "Mã sản phẩm";
            dgv_dataSP.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_dataSP.Columns[2].HeaderText = "Thương hiệu";
            dgv_dataSP.Columns[3].HeaderText = "Loại sản phẩm";
            dgv_dataSP.Columns[4].HeaderText = "Chất liệu";
            dgv_dataSP.Columns[5].HeaderText = "Loại cổ áo";
            dgv_dataSP.Columns[6].HeaderText = "Loại chân quần";
            dgv_dataSP.Columns[7].HeaderText = "Tình trạng";
        }

        public void loadcb_Brand()
        {
            var q = from i in thuongHieu.getAllBrandSer() select i;
            cb_thuongHieu.DataSource = q.ToList();
            cb_thuongHieu.DisplayMember = "Tenth";
            cb_thuongHieu.ValueMember = "Math";
        }

        public void loadcb_Color()
        {
            var q = from i in mauSac.getAllColorSer() select i;
            cb_mau.DataSource = q.ToList();
            cb_mau.DisplayMember = "Tenmau";
            cb_mau.ValueMember = "Mamau";
        }


        public void loadcb_KichThuoc()
        {
            var q = from i in kichThuoc.getAllSizeSer() select i;
            cb_size.DataSource = q.ToList();
            cb_size.DisplayMember = "Tensize";
            cb_size.ValueMember = "Masize";
        }

        public void loadMaSP()
        {
            var q = from i in sp.getAllSanPhamSer() select i;
            cb_maSP.DataSource = q.ToList();
            cb_maSP.DisplayMember = "Masp";
        }

        public void loadSPCT()
        {
            var q = from i in spct.getAllSPCTSer()
                    join ms in mauSac.getAllColorSer() on i.Mamau equals ms.Mamau
                    join kt in kichThuoc.getAllSizeSer() on i.Masize equals kt.Masize
                    join s in sp.getAllSanPhamSer() on i.Masp equals s.Masp
                    where i.Tt == null || !i.Tt.Contains("Out")
                    select new
                    {
                        i.Maspct,
                        i.Tenspct,
                        kt.Tensize,
                        ms.Tenmau,
                        s.Masp,
                        i.Soluong,
                        DonGia = i.Dongia.ToString("#,##0"),
                        i.Tt
                    };
            dvg_sPCT.DataSource = q.ToList();
            dvg_sPCT.Columns[0].HeaderText = "ID sản phẩm CT";
            dvg_sPCT.Columns[1].HeaderText = "Tên";
            dvg_sPCT.Columns[2].HeaderText = "Size";
            dvg_sPCT.Columns[3].HeaderText = "Màu";
            dvg_sPCT.Columns[4].HeaderText = "Mã sản phẩm";
            dvg_sPCT.Columns[5].HeaderText = "Số lượng";
            dvg_sPCT.Columns[6].HeaderText = "Đơn giá";
            dvg_sPCT.Columns[7].HeaderText = "Tình trạng";
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            loadSP();
            loadcb_Brand();
            loadMaSP();
            loadSPCT();
            loadcb_Color();
            loadcb_KichThuoc();
        }
        #region
        public string CreateMaSanPham()
        {
            Random random = new Random();
            string id = "";

            for (int i = 0; i < 4; i++)
            {
                char randomChar = (char)(random.Next(26) + 65);
                id += randomChar;
            }
            for (int i = 0; i < 2; i++)
            {
                id += random.Next(10);
            }

            return id;
        }
        public string CreateMaSanPhamCT()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Random random = new Random();

            string id = "SPCT";
            for (int i = 0; i < 5; i++)
            {
                id += alphabet[random.Next(0, alphabet.Length)];
            }

            return id;
        }
        #endregion

        private bool checkInsertSPCT(string msp)
        {
            var maSanPhamOut = sp.getAllSanPhamSer()
                    .Where(sp => sp.Tt == "Out")
                    .Select(sp => sp.Masp)
                    .ToList();

            if (maSanPhamOut.Contains(msp))
            {
                MessageBox.Show("Mã sản phẩm này đã ngừng bán.", "Thông báo");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txt_tenSPCT_TextChanged(object sender, EventArgs e)
        {
            string input = txt_Gia.Text;
            if (decimal.TryParse(input, out decimal amount))
            {
                string formattedAmount = string.Format("{0:#,##0}", amount);

                txt_Gia.Text = formattedAmount;
                txt_Gia.SelectionStart = formattedAmount.Length;
            }

        }

        private void dgv_dataSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_maSP.Text = dgv_dataSP.Rows[i].Cells[0].Value.ToString();
                txt_tenSP.Text = dgv_dataSP.Rows[i].Cells[1].Value.ToString();
                cb_thuongHieu.Text = dgv_dataSP.Rows[i].Cells[2].Value.ToString();
                cb_loaiSP.Text = dgv_dataSP.Rows[i].Cells[3].Value.ToString();
                cb_chatLieu.Text = dgv_dataSP.Rows[i].Cells[4].Value.ToString();
                cb_loaicoAo.Text = dgv_dataSP.Rows[i].Cells[5].Value.ToString();
                cb_loaiChanQuan.Text = dgv_dataSP.Rows[i].Cells[6].Value.ToString();
                cb_maSP.Text = dgv_dataSP.Rows[i].Cells[0].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txt_Gia.Text) > 0 && int.TryParse(txt_soLuong.Text, out int n) && int.Parse(txt_soLuong.Text) > 0)
                {
                    byte[] byteHinhanh = spct.getAllSPCTSer().SelectMany(x => x.HinhAnh).ToArray();
                    string mess = spct.UpdateSPCTSer(txt_maSPCT.Text, txt_tenSPCT.Text, cb_size.SelectedValue.ToString(), cb_mau.SelectedValue.ToString(), cb_maSP.Text, decimal.Parse(txt_Gia.Text), int.Parse(txt_soLuong.Text), byteHinhanh);
                    MessageBox.Show(mess, "Thong bao");
                    loadSPCT();
                }
                else
                {
                    MessageBox.Show("Xem lai so luong hoac don gia", "Thong bao");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dvg_sPCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_maSPCT.Text = dvg_sPCT.Rows[i].Cells[0].Value.ToString();
                txt_tenSPCT.Text = dvg_sPCT.Rows[i].Cells[1].Value.ToString();
                cb_size.Text = dvg_sPCT.Rows[i].Cells[2].Value.ToString();
                cb_mau.Text = dvg_sPCT.Rows[i].Cells[3].Value.ToString();
                cb_maSP.Text = dvg_sPCT.Rows[i].Cells[4].Value.ToString();
                txt_soLuong.Text = dvg_sPCT.Rows[i].Cells[5].Value.ToString();
                txt_Gia.Text = dvg_sPCT.Rows[i].Cells[6].Value.ToString();

                var s = spct.FindbyIDSer(txt_maSPCT.Text);
                object img = s.HinhAnh;
                if (img != null)
                {
                    byte[] imageData = (byte[])img;
                    Image image;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        image = Image.FromStream(ms);
                    }

                    // Giải phóng hình ảnh hiện tại
                    if (pic_spct.Image != null)
                    {
                        pic_spct.Image.Dispose();
                    }

                    pic_spct.Image = image;
                    btn_img.Hide();
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_taoQR_Click(object sender, EventArgs e)
        {

        }

        private void btn_xuatQR_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(QRCodePictureBox.Width, QRCodePictureBox.Height);
            QRCodePictureBox.DrawToBitmap(bmp, QRCodePictureBox.ClientRectangle);
            e.Graphics.DrawImage(bmp, Point.Empty);
            bmp.Dispose();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            pic_spct.Image = null;
            txt_maSPCT.Clear();
            txt_tenSPCT.Clear();
            txt_soLuong.Clear();
            txt_Gia.Clear();
        }

        private void txt_tìmKiem_TextChanged(object sender, EventArgs e)
        {
            var q = from i in sp.getAllSanPhamSer()
                    join
                    a in thuongHieu.getAllBrandSer() on i.Math equals a.Math
                    where i.Tensp.ToLower().Contains(txt_tìmKiem1.Text.ToLower()) || i.Loaisp.ToLower().Contains(txt_tìmKiem1.Text.ToLower())
                    select new
                    {
                        i.Masp,
                        i.Tensp,
                        a.Tenth,
                        i.Loaisp,
                        i.Chatlieu,
                        i.LoaiCoAo,
                        i.Loaichanquan
                    };
            dgv_dataSP.DataSource = q.ToList();
        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_phantram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Cb_tenSP_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_suaSP_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_suaSP_Click_1(object sender, EventArgs e)
        {
            try
            {
                string mess = sp.UpdateSpser(txt_maSP.Text, txt_tenSP.Text, cb_loaiSP.Text, cb_chatLieu.Text, cb_thuongHieu.SelectedValue.ToString(), cb_loaicoAo.Text, cb_loaiChanQuan.Text);
                MessageBox.Show(mess, "thong bao");
                loadSP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_voHIeu_Click_1(object sender, EventArgs e)
        {
            try
            {
                string msp = txt_maSP.Text;
                DialogResult result = MessageBox.Show("bạn chắc chắn muốn vô hiệu hóa sản phẩm này ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string mess1 = sp.voHieuSP(msp, "Out");
                    string mess2 = spct.voHieuSPCT(msp, "Out");
                    MessageBox.Show(mess1, "Thong bao");
                    MessageBox.Show(mess2, "Thong bao");
                    loadSP();
                    loadSPCT();
                    loadSPCT();
                    txt_tenSP.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_themSP_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tenSP.Text) && !string.IsNullOrEmpty(cb_loaiSP.Text) && !string.IsNullOrEmpty(cb_chatLieu.Text))
            {
                var q = sp.getAllSanPhamSer().Find(x => x.Tensp == txt_tenSP.Text && x.Loaisp == cb_loaiSP.Text && x.Chatlieu == cb_chatLieu.Text && x.Loaichanquan == cb_loaiChanQuan.Text && x.LoaiCoAo == cb_loaicoAo.Text);
                if (q != null)
                {
                    MessageBox.Show("Không thể thêm được vì đã có một sản phẩm tương tự");
                }
                else
                {
                    string mess = sp.CreateSpSer(CreateMaSanPham(), txt_tenSP.Text, cb_loaiSP.Text, cb_chatLieu.Text, cb_thuongHieu.SelectedValue.ToString(), cb_loaicoAo.Text, cb_loaiChanQuan.Text);
                    MessageBox.Show(mess, "Thong bao");
                    loadSP();
                    loadcb_Brand();
                    loadMaSP();
                    loadSPCT();
                    loadcb_Color();
                    loadcb_KichThuoc();
                }
            }
            else
            {
                MessageBox.Show("Sản phẩm không thể thêm nếu thiếu tên , chất liệu và loại sản phẩm", "Thông báo");
            }
        }
        private void dgv_dataSP_DoubleClick(object sender, EventArgs e)
        {
            var q = sp.getAllSanPhamSer().Find(x => x.Masp == txt_maSP.Text);
            if (q != null)
            {
                if (q.Tt == "Out")
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn bỏ vô hiệu với loại sản phẩm này", "Thông báo", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        string mess = sp.voHieuSP(q.Masp, null);
                        MessageBox.Show(mess, "Thong bao");
                        spct.getAllSPCTSer().Find(x => x.Masp == q.Masp);
                        string mess1 = spct.voHieuSPCT(q.Masp, null);
                        MessageBox.Show(mess1, "Thong bao");
                        loadSP();
                        loadSPCT();
                        q = null;
                    }
                }
            }
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            if (pic_spct.Image == null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                openFileDialog.Title = "Chọn ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        Image image = Image.FromFile(openFileDialog.FileName);
                        pic_spct.Image = image;
                        btn_img.Hide();
                        pathimg = openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
                    }
                }
            }
        }

        private void uiImageButton1_Click_1(object sender, EventArgs e)
        {
            string maSPCT = txt_maSPCT.Text;
            if (QRCodePictureBox.Image == null)
            {
                if (string.IsNullOrEmpty(maSPCT))
                {
                    MessageBox.Show("Không tìm thấy mã sản phẩm nào", "Thông báo");
                }
                else
                {
                    string combinedInfo = $"{maSPCT}";
                    using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                    using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(combinedInfo, QRCodeGenerator.ECCLevel.M))
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        Bitmap qrCodeImage = qrCode.GetGraphic(20);
                        QRCodePictureBox.Image = qrCodeImage;
                        btn_QR.Hide();
                    }
                    DialogResult t = MessageBox.Show("Bạn có muốn xuất mã QR này không ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (t == DialogResult.Yes)
                    {
                        PrintDialog printDialog = new PrintDialog();
                        PrintDocument printDocument = new PrintDocument();
                        printDocument.PrintPage += PrintDocument_PrintPage;
                        printDialog.Document = printDocument;
                        if (printDialog.ShowDialog() == DialogResult.OK)
                        {
                            printDocument.Print();

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại một mã QR", "Thông báo");
            }
        }

        private void uiImageButton1_Click_2(object sender, EventArgs e)
        {
            //try
            //{
            if (checkInsertSPCT(cb_maSP.SelectedValue.ToString()))
            {
                if (decimal.Parse(txt_Gia.Text) > 0 && int.TryParse(txt_soLuong.Text, out int n) && int.Parse(txt_soLuong.Text) > 0)
                {
                    byte[] imageBytes = File.ReadAllBytes(pathimg);
                    string mess = spct.CreateSPCTSer(CreateMaSanPhamCT(), txt_tenSPCT.Text, cb_size.SelectedValue.ToString(), cb_mau.SelectedValue.ToString(), cb_maSP.Text, decimal.Parse(txt_Gia.Text), int.Parse(txt_soLuong.Text), imageBytes);
                    MessageBox.Show(mess, "Thong bao");
                    loadSPCT();

                }
                else
                {
                    MessageBox.Show("Vui lòng xem lại mục số lượng và đơn giá", "Thông báo");
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Thông báo");
            //}
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(txt_Gia.Text) > 0 && int.TryParse(txt_soLuong.Text, out int n) && int.Parse(txt_soLuong.Text) > 0)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Tạo một đối tượng Bitmap từ hình ảnh
                        Bitmap bitmap = new Bitmap(pic_spct.Image);

                        // Lưu hình ảnh dưới dạng PNG vào MemoryStream
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                        // Lấy mảng byte từ MemoryStream
                        byte[] byteHinhanh = ms.ToArray();
                        string mess = spct.UpdateSPCTSer(txt_maSPCT.Text, txt_tenSPCT.Text, cb_size.SelectedValue.ToString(), cb_mau.SelectedValue.ToString(), cb_maSP.Text, decimal.Parse(txt_Gia.Text), int.Parse(txt_soLuong.Text), byteHinhanh);
                        MessageBox.Show(mess, "Thong bao");
                        loadSPCT();
                    }
                }
                else
                {
                    MessageBox.Show("Xem lai so luong hoac don gia", "Thong bao");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uiImageButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn vô hiệu hóa sản phẩm này chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string msp = txt_maSPCT.Text;
                    string mess2 = spct.voHIeuHoaSPCT1(msp, "Out");
                    MessageBox.Show(mess2, "Thông báo");
                    loadSPCT();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QRCodePictureBox_Click(object sender, EventArgs e)
        {
            if (pic_spct.Image != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xuất mã QR này không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    PrintDialog printDialog = new PrintDialog();
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += PrintDocument_PrintPage;
                    printDialog.Document = printDocument;
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument.Print();

                    }
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiImageButton1_MouseEnter(object sender, EventArgs e)
        {
            tt.SetToolTip(uiImageButton1, "Thêm mới một sản phẩm");
        }

        private void uiImageButton2_MouseEnter(object sender, EventArgs e)
        {
            tt.SetToolTip(uiImageButton2, "Sửa thông tin của sản phẩm");
        }

        private void uiImageButton3_MouseEnter(object sender, EventArgs e)
        {
            tt.SetToolTip(uiImageButton3, "Vô hiệu hóa sản phẩm");
        }

        private void btn_img_MouseEnter(object sender, EventArgs e)
        {
            tt.SetToolTip(btn_img, "Chọn ảnh cho sản phẩm");
        }

        private void btn_QR_MouseEnter(object sender, EventArgs e)
        {
            tt.SetToolTip(btn_QR, "Tạo mã QR cho sản phẩm");
        }

        private void pic_spct_Click(object sender, EventArgs e)
        {
            if (pic_spct != null)
            {
                DialogResult result = MessageBox.Show("Đã tồn tại một hình ảnh , bạn đang muốn thay đổi hình ảnh đúng không ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                    openFileDialog.Title = "Chọn ảnh";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {

                            Image image = Image.FromFile(openFileDialog.FileName);
                            pic_spct.Image = image;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể tải hình ảnh: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void btn_themByexcel_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn muốn xuất danh sách sản phẩm sang Excel", "Question", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                List<Spct> lst_spct = spct.getAllSPCTSer();
                FileInfo newFile = new FileInfo("Products1.xlsx");
                using (ExcelPackage package = new ExcelPackage(newFile))
                {
                    // Thêm một bảng tính vào tệp Excel
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Products");

                    // Thêm tiêu đề cho các cột
                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "Name";
                    worksheet.Cells[1, 3].Value = "Price";
                    worksheet.Cells[1, 4].Value = "Total products";
                    worksheet.Cells[1, 5].Value = "Image";

                    // Ghi dữ liệu sản phẩm vào các dòng tiếp theo
                    int row = 2;
                    foreach (var product in lst_spct)
                    {
                        worksheet.Cells[row, 1].Value = product.Maspct;
                        worksheet.Cells[row, 2].Value = product.Tenspct;
                        worksheet.Cells[row, 3].Value = product.Dongia;
                        worksheet.Cells[row, 4].Value = product.Soluong;
                        if (product.HinhAnh != null && product.HinhAnh.Length > 0)
                        {
                            // Chèn hình ảnh vào tệp Excel từ mảng byte
                            var picture = worksheet.Drawings.AddPicture($"{product.Maspct}_image", new MemoryStream(product.HinhAnh));

                            // Đặt vị trí của hình ảnh vào ô cụ thể
                            picture.SetPosition(row - 1, 0, 4, 0); // Đặt hình ảnh vào ô [row, 4]

                            // Lấy chiều rộng của cột và chiều cao của hàng
                            var columnWidth = worksheet.Column(4).Width;
                            var rowHeight = worksheet.Row(row).Height;

                            // Thiết lập kích thước cho hình ảnh
                            // Giả sử kích thước hình ảnh là 90x90 để làm ví dụ
                            int imageWidth = 90;
                            int imageHeight = 90;

                            // Điều chỉnh kích thước của hàng và cột để phù hợp với hình ảnh
                            worksheet.Column(5).Width = imageWidth / 7.5; // Hệ số 7.5 để chuyển đổi từ điểm sang pixel
                            worksheet.Row(row).Height = imageHeight * 0.75; // Hệ số 0.75 để chuyển đổi từ pixel sang điểm

                            // Thiết lập kích thước cho hình ảnh
                            picture.SetSize(imageWidth, imageHeight);
                        }
                        row++;
                    }

                    // Lưu tệp Excel
                    package.Save();
                }
                MessageBox.Show("Danh sách sản phẩm đã được xuất thành công vào tệp Excel!");
            }
        }

        private void uiImageButton4_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Select an Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                        using (ExcelPackage package = new ExcelPackage(fileInfo))
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy bảng tính đầu tiên
                            int rowCount = worksheet.Dimension.Rows; // Số lượng hàng trong bảng tính

                            for (int row = 2; row <= rowCount; row++) // Bỏ qua tiêu đề cột (hàng 1)
                            {
                                string Maspct = worksheet.Cells[row, 1].Text;
                                if (spct.getAllSPCTSer().Find(x => x.Maspct == Maspct) == null)
                                {
                                    string Tenspct = worksheet.Cells[row, 2].Text;
                                    string Masize = worksheet.Cells[row, 3].Text;
                                    string Mamau = worksheet.Cells[row, 4].Text;
                                    string Masp = worksheet.Cells[row, 5].Text;
                                    decimal Dongia = decimal.Parse(worksheet.Cells[row, 6].Text);
                                    int Soluong = int.Parse(worksheet.Cells[row, 7].Text);
                                    byte[] hinhAnh = null;

                                    spct.CreateSPCTSer(Maspct, Tenspct, Masize, Mamau, Masp, Dongia, Soluong, hinhAnh);
                                    // Thông báo thành công và hiển thị dữ liệu hoặc cập nhật UI
                                    MessageBox.Show("Dữ liệu sản phẩm đã được nạp thành công!");
                                }
                            }
                        }
                        loadSPCT();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi hệ thống");
                    }
                }

            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            var q = from i in spct.getAllSPCTSer()
                    join ms in mauSac.getAllColorSer() on i.Mamau equals ms.Mamau
                    join kt in kichThuoc.getAllSizeSer() on i.Masize equals kt.Masize
                    join s in sp.getAllSanPhamSer() on i.Masp equals s.Masp
                    where i.Tenspct.ToLower().Contains(txt_timKiem.Text.ToLower())
                    select new
                    {
                        i.Maspct,
                        i.Tenspct,
                        kt.Tensize,
                        ms.Tenmau,
                        s.Masp,
                        i.Soluong,
                        DonGia = i.Dongia.ToString("#,##0"),
                        i.Tt
                    };
            dvg_sPCT.DataSource = q.ToList();
        }

        private void dvg_sPCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_suaSP_Click(object sender, EventArgs e)
        {
            Form2 frm = new();
            frm.ShowDialog();
        }
    }
}
