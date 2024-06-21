using Dự_án_1.BLL.Service;
using Sunny.UI;
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
    public partial class KhuyenMai : UIForm
    {
        KhuyenMaiSer km;
        public KhuyenMai()
        {
            InitializeComponent();
        }

        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            km = new();
            loadGG();
        }
        public void loadGG()
        {
            var q = km.getAllKhuyenMaiSer().Where(x => x.TinhTrang != "Out").Select(x => new
            {
                x.Makm,
                x.Tenkm,
                x.Ngaybatdau,
                x.Ngayketthuc,
                x.Slgiam
            }).ToList();
            uiDataGridView1.DataSource = q;
        }
        public string CreateMaKM()
        {
            Random random = new Random();

            // Tạo một số ngẫu nhiên từ 100 đến 999
            int so1 = random.Next(9, 100);
            int so2 = random.Next(9, 999);

            // Tạo mã khuyến mãi bằng cách kết hợp "KM" với các số ngẫu nhiên
            string maKM = "KM" + so1.ToString() + so2.ToString();

            return maKM;
        }
        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void uiTableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiImageButton2_MouseEnter(object sender, EventArgs e)
        {
            uiToolTip1.SetToolTip(uiImageButton2, "Sửa chương trình khuyến mại");
        }

        private void uiImageButton1_MouseEnter(object sender, EventArgs e)
        {
            uiToolTip1.SetToolTip(uiImageButton1, "Thêm mới một chương trình khuyến mại mới");
        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = DateTime.Parse(dtp_ngayBatDau.Text);
            DateTime ngayKetThuc = DateTime.Parse(dtp_ngayKetThuc.Text);
            if (string.IsNullOrEmpty(txt_tenKM.Text))
            {
                MessageBox.Show("Vui lòng điển thông tin.");
                return;
            }
            if (string.IsNullOrEmpty(txt_giamGia.Text))
            {
                MessageBox.Show("Vui lòng điển thông tin");
                return;
            }
            // Kiểm tra nếu ngày bắt đầu lớn hơn hoặc bằng ngày kết thúc
            if (ngayBatDau >= ngayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txt_giamGia.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return; // Dừng thực thi tiếp theo nếu không có dữ liệu
            }

            // Kiểm tra mã voucher đã tồn tại
            bool check = km.getAllKhuyenMaiSer().Any(x => x.Makm == txt_giamGia.Text);
            if (check)
            {
                MessageBox.Show("Mã đã tồn tại");
                return;
            }
            if (float.TryParse(txt_giamGia.Text, out float tyle))
            {

                if (tyle >= 1 && tyle <= 80)
                {
                    string mess = km.CreateKMSer(CreateMaKM(), txt_tenKM.Text, DateTime.Parse(dtp_ngayBatDau.Text), DateTime.Parse(dtp_ngayKetThuc.Text), tyle);
                    MessageBox.Show(mess, "Thông báo");
                    
                }
                else
                {
                    MessageBox.Show("Tỉ lệ giảm phải nằm trong khoảng từ 1 đến 80.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số cho tỉ lệ giảm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
