namespace Dự_án_1.GUI
{
    partial class DialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_soLuong = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiButton1 = new Sunny.UI.UIButton();
            txt_loi = new Sunny.UI.UITextBox();
            SuspendLayout();
            // 
            // txt_soLuong
            // 
            txt_soLuong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_soLuong.Location = new Point(283, 63);
            txt_soLuong.Margin = new Padding(4, 5, 4, 5);
            txt_soLuong.MinimumSize = new Size(1, 16);
            txt_soLuong.Name = "txt_soLuong";
            txt_soLuong.Padding = new Padding(5);
            txt_soLuong.ShowText = false;
            txt_soLuong.Size = new Size(122, 36);
            txt_soLuong.TabIndex = 0;
            txt_soLuong.TextAlignment = ContentAlignment.MiddleLeft;
            txt_soLuong.Watermark = "";
            txt_soLuong.TextChanged += txt_soLuong_TextChanged;
            txt_soLuong.KeyDown += txt_soLuong_KeyDown;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(85, 70);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(191, 29);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "Số lượng sản phẩm";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(199, 181);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(125, 44);
            uiButton1.TabIndex = 2;
            uiButton1.Text = "OK";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Click += uiButton1_Click;
            // 
            // txt_loi
            // 
            txt_loi.FillColor = Color.FromArgb(243, 249, 255);
            txt_loi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_loi.Location = new Point(88, 124);
            txt_loi.Margin = new Padding(4, 5, 4, 5);
            txt_loi.MinimumSize = new Size(1, 16);
            txt_loi.Name = "txt_loi";
            txt_loi.Padding = new Padding(5);
            txt_loi.RectColor = Color.FromArgb(243, 249, 255);
            txt_loi.ShowText = false;
            txt_loi.Size = new Size(317, 36);
            txt_loi.TabIndex = 3;
            txt_loi.TextAlignment = ContentAlignment.MiddleLeft;
            txt_loi.Watermark = "";
            // 
            // DialogForm
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(539, 256);
            Controls.Add(txt_loi);
            Controls.Add(uiButton1);
            Controls.Add(uiLabel1);
            Controls.Add(txt_soLuong);
            Name = "DialogForm";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "DialogForm";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += DialogForm_Load;
            ResumeLayout(false);
        }

        #endregion

        public Sunny.UI.UITextBox txt_soLuong;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox txt_loi;
    }
}