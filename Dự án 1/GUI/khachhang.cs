using Dự_án_1.BLL.Service;
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

namespace Dự_án_1.GUI
{
    public partial class khachhang : UIForm
    {
        KhachHangSer kh = new();
        public khachhang()
        {
            InitializeComponent();
            loadKH();
        }

        public string createMAKH()
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

        public void loadKH()
        {
            var q = kh.getAllKhachHangSer().ToList().Select(x => new
            {
                x.Makh,
                x.Tenkh,
                x.Sdt,
                x.Diachi
            }).ToList();
            dgv_KH.DataSource = q;
            dgv_KH.Columns[0].HeaderText = "Mã khách hàng";
            dgv_KH.Columns[1].HeaderText = "Tên khách hàng";
            dgv_KH.Columns[2].HeaderText = "Số điện thoại";
            dgv_KH.Columns[3].HeaderText = "Địa chỉ";
        }

        private void dgv_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txt_maKH.Text = dgv_KH.Rows[i].Cells[0].Value.ToString();
                txt_tenKH.Text = dgv_KH.Rows[i].Cells[1].Value.ToString();
                txt_diaChi.Text = dgv_KH.Rows[i].Cells[3].Value.ToString();
                txt_sdt.Text = dgv_KH.Rows[i].Cells[2].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_sdt.Text))
                {
                    if (kh.getAllKhachHangSer().Find(x => x.Makh == txt_maKH.Text) == null)
                    {
                        if (!kh.getAllKhachHangSer().Any(a => a.Tenkh == txt_tenKH.Text && a.Sdt == txt_sdt.Text && a.Diachi == txt_diaChi.Text))
                        {
                            if (txt_sdt.Text.Length != 10 || !Regex.IsMatch(txt_sdt.Text, "^(09|07|03|08)[0-9]{8}$"))
                            {
                                MessageBox.Show("Vui lòng kiểm tra lại sdt", "Thong bao");
                                return;
                            }
                            string mess = kh.CreateKHSer(createMAKH(), txt_tenKH.Text, txt_sdt.Text, txt_diaChi.Text);
                            MessageBox.Show(mess, "Thông báo");
                            loadKH();
                            txt_maKH.Text = null;
                            txt_tenKH.Clear();
                            txt_sdt.Clear();
                            txt_diaChi.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Tên số điện thoại và địa chỉ đã tồn tại trong hệ thống", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại trong hệ thống", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại của khách ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }


        private void khachhang_Load(object sender, EventArgs e)
        {

        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            txtTimKiem.RectColor = Color.Blue;
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            var q = from i in kh.getAllKhachHangSer()
                    where i.Sdt.Contains(txtTimKiem.Text)
                    select new
                    {
                        i.Makh,
                        i.Tenkh,
                        i.Sdt,
                        i.Diachi
                    };
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                loadKH();
            }
            else
            {
                dgv_KH.DataSource = q.ToList();
            }
        }

        private void dgv_KH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_KH.Columns[0].Width = 200;
            dgv_KH.Columns[1].Width = 300;
            dgv_KH.Columns[2].Width = 200;
            dgv_KH.Columns[3].Width = 400;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                string mess = kh.updateKHSer(txt_maKH.Text, txt_tenKH.Text, txt_sdt.Text, txt_diaChi.Text);
                MessageBox.Show(mess, "Thong bao");
                loadKH();
                txt_maKH.Text = null;
                txt_tenKH.Clear();
                txt_sdt.Clear();
                txt_diaChi.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
