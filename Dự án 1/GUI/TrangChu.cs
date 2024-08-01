using Dự_án_1.DAL.Models;
using Dự_án_1.GUI;
using Sunny.UI;
using WF.Form_Chức_Năng.Form_Chức_Năng___ADMIN;

namespace WinFormsApp1
{
    public partial class TrangChu : UIForm
    {
        private Form currentForm;

        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void OpenForm(Form newForm)
        {
            if (currentForm != null)
            {
                DisposeCurrentForm();
            }

            currentForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            uiSplitContainer1.Panel2.Controls.Add(newForm);

            int x = (uiSplitContainer1.Panel2.Width - newForm.Width) / 2;
            int y = (uiSplitContainer1.Panel2.Height - newForm.Height) / 2;

            newForm.Location = new Point(x, y);

            //uiSplitContainer1.Panel2.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void DisposeCurrentForm()
        {
            if (currentForm != null)
            {
                currentForm.Hide();
                currentForm.Dispose();
            }
        }

        // Các sự kiện click của các nhãn tương ứng với việc mở các form mới
        private void uiMarkLabel1_Click(object sender, EventArgs e)
        {
            SanPham frmsp = new SanPham();
            uiSplitContainer1.SplitterDistance = 0;
            OpenForm(frmsp);
        }

        private void uiMarkLabel2_Click(object sender, EventArgs e)
        {
            BanHang frmbanhang = new BanHang();
            uiSplitContainer1.SplitterDistance = 0;
            OpenForm(frmbanhang);
        }

        private void uiMarkLabel3_Click(object sender, EventArgs e)
        {
            hoadon frmhoadon = new hoadon();
            uiSplitContainer1.SplitterDistance = 0;
            OpenForm(frmhoadon);
        }

        private void uiMarkLabel4_Click(object sender, EventArgs e)
        {
            khachhang frmkh = new khachhang();
            uiSplitContainer1.SplitterDistance = 0;
            OpenForm(frmkh);
        }

        private void uiMarkLabel5_Click(object sender, EventArgs e)
        {
            nhanvien frmnv = new nhanvien();
            uiSplitContainer1.SplitterDistance = 0;
            OpenForm(frmnv);
        }

        private void uiMarkLabel6_Click(object sender, EventArgs e)
        {
        }

        private void uiMarkLabel7_Click(object sender, EventArgs e)
        {
        }

        private void uiMarkLabel8_Click(object sender, EventArgs e)
        {
            Form2 frmCaiDat = new();
            uiSplitContainer1.SplitterDistance = 0;
            OpenForm(frmCaiDat);
        }

        private void uiMarkLabel7_Click_1(object sender, EventArgs e)
        {
            TK tk1 = new TK();
            uiSplitContainer1.SplitterDistance = 0;
            OpenForm(tk1);
        }

        private void uiSplitContainer1_Click(object sender, EventArgs e)
        {
            if(uiSplitContainer1.SplitterDistance == 0)
            {
                uiSplitContainer1.SplitterDistance = 284;
            }
        }
    }
}
