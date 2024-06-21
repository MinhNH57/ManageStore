using Dự_án_1.BLL;
using Dự_án_1.DAL.Models;
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
    public partial class DialogForm : UIForm
    {
        public string soLuongmua { get; private set; }
        public DialogForm()
        {
            InitializeComponent();
        }

        private void DialogForm_Load(object sender, EventArgs e)
        {
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_soLuong.Text, out int sl) && !string.IsNullOrEmpty(txt_soLuong.Text))
            {
                if (sl > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    soLuongmua = txt_soLuong.Text;
                    this.Close();
                }
                else
                {
                    txt_loi.Text = "Số lượng phải lớn hơn 0";
                }
            }
            else
            {

            }
        }


        private void txt_soLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (int.TryParse(txt_soLuong.Text, out int sl) && !string.IsNullOrEmpty(txt_soLuong.Text))
            {
                if (sl > 0)
                {
                    if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txt_soLuong.Text))
                    {
                        // Cập nhật giá trị soLuongmua
                        soLuongmua = txt_soLuong.Text;

                        // Đóng form
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    txt_loi.Text = "Số lượng phải lớn hơn 0";
                }
            }
        }

        private void txt_soLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
