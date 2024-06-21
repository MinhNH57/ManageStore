namespace Dự_án_1.GUI
{
    partial class Form2
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
            uiTabControl1 = new Sunny.UI.UITabControl();
            tabPage1 = new TabPage();
            uiPanel1 = new Sunny.UI.UIPanel();
            cb_VAt = new Sunny.UI.UIComboBox();
            txt_newVAT = new Sunny.UI.UITextBox();
            btn_capNhatThayDoi = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            tabPage2 = new TabPage();
            uiTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabControl1
            // 
            uiTabControl1.Controls.Add(tabPage1);
            uiTabControl1.Controls.Add(tabPage2);
            uiTabControl1.Dock = DockStyle.Fill;
            uiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControl1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTabControl1.ItemSize = new Size(150, 40);
            uiTabControl1.Location = new Point(0, 0);
            uiTabControl1.MainPage = "";
            uiTabControl1.Name = "uiTabControl1";
            uiTabControl1.SelectedIndex = 0;
            uiTabControl1.Size = new Size(1126, 708);
            uiTabControl1.SizeMode = TabSizeMode.Fixed;
            uiTabControl1.TabIndex = 0;
            uiTabControl1.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            uiTabControl1.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uiPanel1);
            tabPage1.Location = new Point(0, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1126, 668);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thuế VAT";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top;
            uiPanel1.Controls.Add(cb_VAt);
            uiPanel1.Controls.Add(txt_newVAT);
            uiPanel1.Controls.Add(btn_capNhatThayDoi);
            uiPanel1.Controls.Add(uiButton1);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel1.Location = new Point(304, 104);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(481, 432);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // cb_VAt
            // 
            cb_VAt.DataSource = null;
            cb_VAt.FillColor = Color.White;
            cb_VAt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_VAt.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cb_VAt.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cb_VAt.Location = new Point(300, 98);
            cb_VAt.Margin = new Padding(4, 5, 4, 5);
            cb_VAt.MinimumSize = new Size(63, 0);
            cb_VAt.Name = "cb_VAt";
            cb_VAt.Padding = new Padding(0, 0, 30, 2);
            cb_VAt.Size = new Size(138, 36);
            cb_VAt.SymbolSize = 24;
            cb_VAt.TabIndex = 5;
            cb_VAt.TextAlignment = ContentAlignment.MiddleLeft;
            cb_VAt.Watermark = "";
            // 
            // txt_newVAT
            // 
            txt_newVAT.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_newVAT.Location = new Point(300, 242);
            txt_newVAT.Margin = new Padding(4, 5, 4, 5);
            txt_newVAT.MinimumSize = new Size(1, 16);
            txt_newVAT.Name = "txt_newVAT";
            txt_newVAT.Padding = new Padding(5);
            txt_newVAT.ShowText = false;
            txt_newVAT.Size = new Size(138, 36);
            txt_newVAT.TabIndex = 4;
            txt_newVAT.TextAlignment = ContentAlignment.TopCenter;
            txt_newVAT.Watermark = "";
            // 
            // btn_capNhatThayDoi
            // 
            btn_capNhatThayDoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_capNhatThayDoi.Location = new Point(143, 163);
            btn_capNhatThayDoi.MinimumSize = new Size(1, 1);
            btn_capNhatThayDoi.Name = "btn_capNhatThayDoi";
            btn_capNhatThayDoi.Size = new Size(228, 44);
            btn_capNhatThayDoi.TabIndex = 2;
            btn_capNhatThayDoi.Text = "Cập nhật các thay đổi";
            btn_capNhatThayDoi.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_capNhatThayDoi.Click += btn_capNhatThayDoi_Click;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(143, 323);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(228, 44);
            uiButton1.TabIndex = 2;
            uiButton1.Text = "Thêm mức thuế mới";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Click += uiButton1_Click;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(20, 249);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(276, 29);
            uiLabel2.TabIndex = 0;
            uiLabel2.Text = "Cập nhật giá trị thuế mới :";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(20, 105);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(276, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "Thuế giá trị gia tăng hiện tại :";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(0, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1126, 668);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bảo mật";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1126, 708);
            Controls.Add(uiTabControl1);
            Name = "Form2";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "Form2";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += Form2_Load;
            uiTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControl uiTabControl1;
        private TabPage tabPage1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private TabPage tabPage2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox txt_newVAT;
        private Sunny.UI.UIButton btn_capNhatThayDoi;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox cb_VAt;
    }
}