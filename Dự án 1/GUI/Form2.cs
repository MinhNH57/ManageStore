using Dự_án_1.BLL;
using Dự_án_1.BLL.Service;
using Dự_án_1.Valiable;
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
    public partial class Form2 : UIForm
    {
        VATSer v = new();
        Brandser th = new();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var q = v.getAllVatSer().ToList();
            cb_VAt.DataSource = q.ToList();
            cb_VAt.DisplayMember = "MucVat";
            cb_VAt.ValueMember = "MaVat";
        }

        public void LoadTH()
        {

            var t = th.getAllBrandSer().ToList();

            dgv_Thuonghieu.DataSource = t;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_newVAT.Text))
            {
                if (float.TryParse(txt_newVAT.Text, out float i))
                {
                    MessageBox.Show("TT");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập vào chuỗi hợp lệ", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa thêm một mức thuế giá trị gia tăng mới nào", "Thông báo");
            }
        }

        private void btn_capNhatThayDoi_Click(object sender, EventArgs e)
        {
            var q = v.getAllVatSer().ToList();
            foreach (var i in q)
            {
                v.updateVatser(i.MaVat, "Không hoạt động");
                var updatevat = cb_VAt.SelectedValue;
                v.updateVatser((int)updatevat, "Hoạt động");
                VAT.mucVAT = (double)v.getAllVatSer().Find(x => x.TinhTrang == "Hoạt động").MucVat;
            }
        }

        private void uiTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiTabControl1.SelectedTab == tabPage2)
            {
                LoadTH();
            }
        }

        private void dgv_Thuonghieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Thuonghieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                textBox1.Text = dgv_Thuonghieu.Rows[i].Cells[0].Value.ToString();
                textBox2.Text = dgv_Thuonghieu.Rows[i].Cells[1].Value.ToString();
                textBox3.Text = dgv_Thuonghieu.Rows[i].Cells[3].Value.ToString();
                textBox4.Text = dgv_Thuonghieu.Rows[i].Cells[2].Value.ToString();
            }
        }

        static string GenerateCode()
        {
            Random random = new Random();
            int code = random.Next(10000, 100000); // Tạo số ngẫu nhiên từ 10000 đến 99999
            return code.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string mess = th.CreateSer(GenerateCode(), textBox2.Text, int.Parse(textBox4.Text), textBox3.Text);
                MessageBox.Show(mess);
                LoadTH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string mess = th.UpdateSer(textBox1.Text, textBox2.Text, int.Parse(textBox4.Text), textBox3.Text);
                MessageBox.Show(mess);
                LoadTH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
