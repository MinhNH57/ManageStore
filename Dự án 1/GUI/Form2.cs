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

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_newVAT.Text))
            {
                if(float.TryParse(txt_newVAT.Text , out float i))
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
            foreach(var i in q)
            {
                v.updateVatser(i.MaVat, "Không hoạt động");
                var updatevat = cb_VAt.SelectedValue;
                v.updateVatser((int)updatevat, "Hoạt động");
                VAT.mucVAT = (double)v.getAllVatSer().Find(x => x.TinhTrang == "Hoạt động").MucVat;
            }
        }
    }
}
