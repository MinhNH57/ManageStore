using Dự_án_1.BLL;
using Dự_án_1.BLL.Service;
using Dự_án_1.DAL.Models;
using Dự_án_1.Properties;
using Dự_án_1.Valiable;
using Sunny.UI;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Login : UIForm2
    {
        NhanVienSer nv = new();
        VATSer v = new();
        public Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VAT.mucVAT = (double)v.getAllVatSer().Find(x => x.TinhTrang == "Hoạt động").MucVat;
        }
        private bool checkUser(string tk, string mk)
        {
            var q = (from i in nv.getAllnhanvienSer()
                     where i.Taikhoan == tk && i.Matkhau == mk
                     select i).FirstOrDefault();
            if (q != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string FindManvbyTK(string tk)
        {
            var i = nv.getAllnhanvienSer().Find(x => x.Taikhoan == tk);
            MaNhanVien.MANV = i.Manv;
            return MaNhanVien.MANV;
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            if (checkUser(txt_taiKhoan.Text, txt_matKhau.Text))
            {
                FindManvbyTK(txt_taiKhoan.Text);
                TrangChu trangChu = new TrangChu();
                this.Hide();
                trangChu.ShowDialog();
                this.Show();
                this.Dispose();
            }
            else
            {
                if (nv.getAllnhanvienSer().Any(x => x.Taikhoan != txt_taiKhoan.Text))
                {
                    txt_taiKhoan.RectColor = Color.Red;
                }
                else if (nv.getAllnhanvienSer().Any(x => x.Matkhau != txt_matKhau.Text))
                {
                    txt_matKhau.RectColor = Color.Red;
                }
            }
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {

        }
        private void btn_showpass_Click(object sender, EventArgs e)
        {
            Image image1 = Image.FromFile(@"C:\Users\Dell\Desktop\Duan1-Nhom2 (2) (1)\Dự án 1\Resources\eyes-icon-vector-vision-symbol-260nw-1708357366-fotor-bg-remover-2024042114333.png");
            Image image2;

            if (!ImageEquals(btn_showpass.Image, image1))
            {
                btn_showpass.Image = image1;
            }
            else
            {
                image2 = Image.FromFile(@"C:\Users\Dell\Desktop\Duan1-Nhom2 (2) (1)\Dự án 1\Resources\images-fotor-bg-remover-20240421144231.png");
                btn_showpass.Image = image2;
                image1 = null;
            }
        }

        private bool ImageEquals(Image image1, Image image2)
        {
            // Tìm hiệu kích thước của hai hình ảnh
            if (image1.Size != image2.Size)
                return false;

            // Tạo các mảng byte chứa dữ liệu hình ảnh
            byte[] bytes1, bytes2;
            using (MemoryStream ms1 = new MemoryStream())
            using (MemoryStream ms2 = new MemoryStream())
            {
                image1.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                image2.Save(ms2, System.Drawing.Imaging.ImageFormat.Png);
                bytes1 = ms1.ToArray();
                bytes2 = ms2.ToArray();
            }

            // So sánh nội dung của hai mảng byte
            return Enumerable.SequenceEqual(bytes1, bytes2);
        }

        private void txt_taiKhoan_TextChanged(object sender, EventArgs e)
        {
            txt_taiKhoan.RectColor = Color.White;
        }

        private void txt_matKhau_TextChanged(object sender, EventArgs e)
        {
            txt_matKhau.RectColor = Color.White;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            nv = null;
        }
    }
}
