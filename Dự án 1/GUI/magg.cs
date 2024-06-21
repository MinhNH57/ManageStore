using Dự_án_1.BLL.Service;
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
    public partial class magg : Form
    {
        KhuyenMaiSer km = new();

        public void loadmaKM()
        {
            var kq = km.getAllKhuyenMaiSer().Select(x => new
            {
                x.Makm,
                x.Tenkm,
                x.Ngaybatdau,
                x.Ngayketthuc,
                x.Slgiam
            });
            dgvDanhSachMaGiamGia.DataSource = kq.ToList();
        }
        public magg()
        {
            InitializeComponent();
            loadmaKM();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = DateTime.Parse(dtpNgayBatDau.Text);
            DateTime ngayKetThuc = DateTime.Parse(dtpNgayKetThuc.Text);
            if (string.IsNullOrEmpty(txt_tenKM.Text) || string.IsNullOrEmpty(txtMaGiamGia.Text))
            {
                MessageBox.Show("Vui lòng điển thông tin.");
                return;
            }
            if (string.IsNullOrEmpty(txt_tyleGiam.Text))
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
            if (string.IsNullOrEmpty(txtMaGiamGia.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return; // Dừng thực thi tiếp theo nếu không có dữ liệu
            }

            // Kiểm tra mã voucher đã tồn tại
            bool check = km.getAllKhuyenMaiSer().Any(x => x.Makm == txtMaGiamGia.Text);
            if (check)
            {
                MessageBox.Show("Mã đã tồn tại");
                return;
            }
            if (float.TryParse(txt_tyleGiam.Text, out float tyle))
            {
               
                if (tyle >= 1 && tyle <= 80)
                {
                    string mess = km.CreateKMSer(txtMaGiamGia.Text, txt_tenKM.Text, DateTime.Parse(dtpNgayBatDau.Text), DateTime.Parse(dtpNgayKetThuc.Text), tyle);
                    MessageBox.Show(mess, "Thông báo");
                    loadmaKM();
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

        private void dgvDanhSachMaGiamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaGiamGia.Text = dgvDanhSachMaGiamGia.Rows[i].Cells[0].Value.ToString();
                txt_tenKM.Text = dgvDanhSachMaGiamGia.Rows[i].Cells[1].Value.ToString();

                /* dtpNgayBatDau.Value = Convert.ToDateTime(dgvDanhSachMaGiamGia.CurrentRow.Cells[2].Value);*/
                dtpNgayBatDau.Value = Convert.ToDateTime(dgvDanhSachMaGiamGia.Rows[i].Cells[2].Value);
                dtpNgayKetThuc.Value = Convert.ToDateTime(dgvDanhSachMaGiamGia.Rows[i].Cells[3].Value);
                txt_tyleGiam.Text = dgvDanhSachMaGiamGia.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenKM.Text) || string.IsNullOrEmpty(txtMaGiamGia.Text))
            {
                MessageBox.Show("Vui lòng điển thông tin.");
                return;
            }
            if (string.IsNullOrEmpty(txt_tyleGiam.Text))
            {
                MessageBox.Show("Vui lòng điển thông tin");
                return;
            }
            string mess = km.UpdateKMSer(txtMaGiamGia.Text, txt_tenKM.Text, DateTime.Parse(dtpNgayBatDau.Text), DateTime.Parse(dtpNgayKetThuc.Text), float.Parse(txt_tyleGiam.Text),null);
            MessageBox.Show(mess, "Thong bao");
            loadmaKM();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            txtMaGiamGia.Text = "";
            txt_tenKM.Text = "";
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            txt_tyleGiam.Text = "";
        }
    }
}
