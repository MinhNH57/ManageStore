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
    public partial class frmthanhToan : UIForm
    {
        public decimal tienKH { get; private set; }
        public frmthanhToan()
        {
            InitializeComponent();
        }

        private void frmthanhToan_Load(object sender, EventArgs e)
        {

        }

        private void txt_tienKHdua_KeyDown(object sender, KeyEventArgs e)
        {
            if (decimal.TryParse(txt_tienKHdua.Text, out decimal m) && !string.IsNullOrEmpty(txt_tienKHdua.Text))
            {
                if (m > 0)
                {
                    if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txt_tienKHdua.Text))
                    {
                        // Cập nhật giá trị soLuongmua
                        tienKH = decimal.Parse(txt_tienKHdua.Text);

                        // Đóng form
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void txt_tienKHdua_TextChanged(object sender, EventArgs e)
        {
            string input = txt_tienKHdua.Text;

            if (double.TryParse(input, out double amount))
            {
                string formattedAmount = string.Format("{0:#,##0}", amount);

                txt_tienKHdua.Text = formattedAmount;

                // Di chuyển con trỏ về cuối chuỗi đã định dạng
                txt_tienKHdua.SelectionStart = formattedAmount.Length;
            }
        }
    }
}
