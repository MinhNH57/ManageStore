using Dự_án_1.BLL;
using Dự_án_1.DAL;
using Dự_án_1.DAL.Models;
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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dự_án_1.GUI
{
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }
        NhanVienRes nhavien = new NhanVienRes();

        #region
        NhanVienSer nv = new();
        #endregion
        public void loadnhanVien()
        {
            var kq = nv.getAllnhanvienSer().Select( x => new
            {
                x.Manv , x.Tennv , x.Diachi , x.Cccd , x.Sdt
            });
            dgv_diaChi.DataSource = kq.ToList();
        }
        public string CreatemaNV()
        {
            string id;
            int stt = nv.getAllnhanvienSer().Count;
            if (stt <= 9)
            {
                id = "NV" + "0" + ((stt + 1).ToString());
                return id;
            }
            else
            {
                id = "NV" + ((stt + 1).ToString());
                return id;
            }
        }
        DUAN1NHOMContext db = new DUAN1NHOMContext();
        private void nhanvien_Load(object sender, EventArgs e)
        {
            loadnhanVien();
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_taiKhoan.Text) || string.IsNullOrEmpty(txt_matKhau.Text))
            {
                MessageBox.Show("Vui lòng điển thông tin.");
                return;
            }
            if (string.IsNullOrEmpty(txt_diaChi.Text))
            {
                MessageBox.Show("Vui lòng điển thông tin");
                return;
            }
            Nhanvien idfod = db.Nhanviens.Where(z => z.Sdt.Equals(txtsđt.Text)).FirstOrDefault();
            if (idfod != null)
            {
                MessageBox.Show("Số điện thoại đã được sử dụng mời nhập số điện thoại khác!!! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Nhanvien cccd = db.Nhanviens.Where(z => z.Cccd.Equals(txtcccd.Text)).FirstOrDefault();
            if (cccd != null)
            {
                MessageBox.Show("CCCD đã được sử dụng mời CCCD khác!!! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Nhanvien tk = db.Nhanviens.Where(z => z.Taikhoan.Equals(txt_taiKhoan.Text)).FirstOrDefault();
            if (tk != null)
            {
                MessageBox.Show("Tài khoản đã được sử dụng mời Tài khoản khác!!! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string cccdPattern = @"^\d{9}$|^\d{12}$";
            if (txtsđt.Text.Length != 10 || !Regex.IsMatch(txtsđt.Text, "^(09|07|03|08)[0-9]{8}$"))
            {
                MessageBox.Show("Vui lòng kiểm tra lại sdt", "Thong bao");
                return;
            }
            if (txtcccd.Text.Length != 9 && txtcccd.Text.Length != 12 || !Regex.IsMatch(txtcccd.Text, cccdPattern))
            {
                MessageBox.Show("Số CCCD không hợp lệ. Vui lòng nhập số CCCD gồm 9 hoặc 12 chữ số.", "Lỗi");
                return; // Dừng việc thực hiện cập nhật thông tin nhân viên
            }
            else
            {
                try
                {

                    string tt = rdo_dangLam.Checked ? "Đang làm" : "Nghỉ việc";
                    string gt = rdo_nam.Checked ? "Nam" : "Nữ";
                    string mess = nv.createnvSer(CreatemaNV(), txtTen.Text, DateTime.Parse(dtpNgaySinh.Text), txt_diaChi.Text, txtsđt.Text, txt_taiKhoan.Text, txt_matKhau.Text, txt_quyen.Text, txtcccd.Text, tt, gt);
                    MessageBox.Show(mess, "Thong bao");
                    loadnhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }
            }
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_taiKhoan.Text)||string.IsNullOrEmpty(txt_matKhau.Text))
            {
                MessageBox.Show("Vui lòng điển thông tin.");
                return;
            }
            if (string.IsNullOrEmpty(txt_diaChi.Text))
            {
                MessageBox.Show("Vui lòng điển thông tin");
                return;
            }
            string cccdPattern = @"^\d{9}$|^\d{12}$";
            if (txtsđt.Text.Length != 10 || !Regex.IsMatch(txtsđt.Text, "^(09|07|03|08)[0-9]{8}$"))
            {
                MessageBox.Show("Vui lòng kiểm tra lại sdt", "Thong bao");
                return;
            }
            if (txtcccd.Text.Length != 9 && txtcccd.Text.Length != 12 || !Regex.IsMatch(txtcccd.Text, cccdPattern))
            {
                MessageBox.Show("Số CCCD không hợp lệ. Vui lòng nhập số CCCD gồm 9 hoặc 12 chữ số.", "Lỗi");
                return; // Dừng việc thực hiện cập nhật thông tin nhân viên
            }
            else
            {
                try
                {

                    string tt = rdo_dangLam.Checked ? "Đang làm" : "Nghỉ việc";
                    string gt = rdo_nam.Checked ? "Nam" : "Nữ";
                    string mess = nv.updatenvSer(txtMaNV.Text, txtTen.Text, DateTime.Parse(dtpNgaySinh.Text), txt_diaChi.Text, txtsđt.Text, txt_taiKhoan.Text, txt_matKhau.Text, txt_quyen.Text, txtcccd.Text, tt, gt);
                    MessageBox.Show(mess, "Thong bao");
                    loadnhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }
            }



        }

        private void btn_voHieuHoaNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTen.Text = "";
            txtcccd.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            rdo_nam.Checked = false;
            rdo_nu.Checked = false;
            txtsđt.Text = "";
            txt_taiKhoan.Text = "";
            txt_matKhau.Text = "";
            txt_diaChi.Text = "";
            rdo_dangLam.Checked = false;
            rdo_nghiLam.Checked = false;
            txt_quyen.Text = "";
        }

        private void dgv_diaChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //if (i >= 0)
            //{

            //    txtMaNV.Text = dgv_diaChi.Rows[i].Cells[0].Value.ToString();
            //    txtTen.Text = dgv_diaChi.CurrentRow.Cells[1].Value.ToString();

            //    dtpNgaySinh.Value = Convert.ToDateTime(dgv_diaChi.CurrentRow.Cells[2].Value);
            //    if (dgv_diaChi.CurrentRow.Cells[10].Value.ToString().Equals("Nam", StringComparison.OrdinalIgnoreCase))
            //    {
            //        rdo_nam.Checked = true;
            //    }
            //    else
            //    {
            //        rdo_nu.Checked = true;
            //    }
            //    txt_diaChi.Text = dgv_diaChi.CurrentRow.Cells[3].Value.ToString();
            //    txtsđt.Text = dgv_diaChi.CurrentRow.Cells[4].Value.ToString();
            //    txt_taiKhoan.Text = dgv_diaChi.CurrentRow.Cells[5].Value.ToString();
            //    txtcccd.Text = dgv_diaChi.CurrentRow.Cells[8].Value.ToString();
            //    txt_matKhau.Text = dgv_diaChi.CurrentRow.Cells[6].Value.ToString();

            //    txt_quyen.Text = dgv_diaChi.CurrentRow.Cells[7].Value.ToString();

            //    if (dgv_diaChi.CurrentRow.Cells[9].Value.ToString().Equals("Đang làm", StringComparison.OrdinalIgnoreCase))
            //    {
            //        rdo_dangLam.Checked = true;
            //    }
            //    else
            //    {
            //        rdo_nghiLam.Checked = true;
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = from x in nv.getAllnhanvienSer()
                    where x.Tennv.Contains(txt_tìmKiem.Text)
                    //where x.Sdt.Contains(txt_tìmKiem.Text)
                    select new
                    {
                        x.Manv,
                        x.Tennv,
                        x.Ngaysinh,
                        x.Diachi,
                        x.Sdt,
                        x.Taikhoan,
                        x.Matkhau,
                        x.Quyen,
                        x.Cccd,
                        x.Tinhtrang,
                        x.Gioitinh
                    };
            if (string.IsNullOrEmpty(txt_tìmKiem.Text))
            {
                loadnhanVien();
            }
            else
            {
                dgv_diaChi.DataSource = q.ToList();
            }
        }
    }
}

