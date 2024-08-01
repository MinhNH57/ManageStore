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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            MaTH = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            uiLabel5 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            btn_Sua = new Sunny.UI.UIButton();
            btn_Them = new Sunny.UI.UIButton();
            uiPanel2 = new Sunny.UI.UIPanel();
            dgv_Thuonghieu = new DataGridView();
            tabPage3 = new TabPage();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton3 = new Sunny.UI.UIButton();
            uiTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            uiPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Thuonghieu).BeginInit();
            SuspendLayout();
            // 
            // uiTabControl1
            // 
            uiTabControl1.Controls.Add(tabPage1);
            uiTabControl1.Controls.Add(tabPage2);
            uiTabControl1.Controls.Add(tabPage3);
            uiTabControl1.Dock = DockStyle.Fill;
            uiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControl1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTabControl1.ItemSize = new Size(150, 40);
            uiTabControl1.Location = new Point(0, 0);
            uiTabControl1.MainPage = "";
            uiTabControl1.Name = "uiTabControl1";
            uiTabControl1.SelectedIndex = 0;
            uiTabControl1.Size = new Size(1126, 708);
            uiTabControl1.SizeMode = TabSizeMode.Fixed;
            uiTabControl1.TabIndex = 0;
            uiTabControl1.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            uiTabControl1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiTabControl1.SelectedIndexChanged += uiTabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uiPanel1);
            tabPage1.Controls.Add(uiButton2);
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
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
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
            cb_VAt.Font = new Font("Microsoft Sans Serif", 12F);
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
            txt_newVAT.Font = new Font("Microsoft Sans Serif", 12F);
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
            btn_capNhatThayDoi.Font = new Font("Microsoft Sans Serif", 12F);
            btn_capNhatThayDoi.Location = new Point(143, 163);
            btn_capNhatThayDoi.MinimumSize = new Size(1, 1);
            btn_capNhatThayDoi.Name = "btn_capNhatThayDoi";
            btn_capNhatThayDoi.Size = new Size(228, 44);
            btn_capNhatThayDoi.TabIndex = 2;
            btn_capNhatThayDoi.Text = "Cập nhật các thay đổi";
            btn_capNhatThayDoi.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btn_capNhatThayDoi.Click += btn_capNhatThayDoi_Click;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.Location = new Point(143, 323);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(228, 44);
            uiButton1.TabIndex = 2;
            uiButton1.Text = "Thêm mức thuế mới";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton1.Click += uiButton1_Click;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 12F);
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
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F);
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
            tabPage2.Controls.Add(uiButton3);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(uiLabel4);
            tabPage2.Controls.Add(MaTH);
            tabPage2.Controls.Add(uiLabel6);
            tabPage2.Controls.Add(uiLabel5);
            tabPage2.Controls.Add(uiLabel3);
            tabPage2.Controls.Add(btn_Sua);
            tabPage2.Controls.Add(btn_Them);
            tabPage2.Controls.Add(uiPanel2);
            tabPage2.Location = new Point(0, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1126, 668);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Insert";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(587, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 30);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(835, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 30);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 30);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(95, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 4;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(439, 13);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(207, 51);
            uiLabel4.TabIndex = 3;
            uiLabel4.Text = "BRAND";
            uiLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaTH
            // 
            MaTH.Font = new Font("Microsoft Sans Serif", 12F);
            MaTH.ForeColor = Color.FromArgb(48, 48, 48);
            MaTH.Location = new Point(95, 75);
            MaTH.Name = "MaTH";
            MaTH.Size = new Size(125, 29);
            MaTH.TabIndex = 3;
            MaTH.Text = "BrandCode";
            MaTH.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(587, 75);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(125, 29);
            uiLabel6.TabIndex = 3;
            uiLabel6.Text = "Year";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(835, 75);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(125, 29);
            uiLabel5.TabIndex = 3;
            uiLabel5.Text = "Country";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(317, 75);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(125, 29);
            uiLabel3.TabIndex = 3;
            uiLabel3.Text = "Name";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_Sua
            // 
            btn_Sua.Font = new Font("Microsoft Sans Serif", 12F);
            btn_Sua.Location = new Point(587, 184);
            btn_Sua.MinimumSize = new Size(1, 1);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(120, 39);
            btn_Sua.TabIndex = 1;
            btn_Sua.Text = "Edit";
            btn_Sua.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Microsoft Sans Serif", 12F);
            btn_Them.Location = new Point(378, 184);
            btn_Them.MinimumSize = new Size(1, 1);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(120, 39);
            btn_Them.TabIndex = 1;
            btn_Them.Text = "Insert";
            btn_Them.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btn_Them.Click += btn_Them_Click;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(dgv_Thuonghieu);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(13, 244);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(1100, 313);
            uiPanel2.TabIndex = 0;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgv_Thuonghieu
            // 
            dgv_Thuonghieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Thuonghieu.Location = new Point(3, 3);
            dgv_Thuonghieu.Name = "dgv_Thuonghieu";
            dgv_Thuonghieu.RowHeadersWidth = 51;
            dgv_Thuonghieu.RowTemplate.Height = 29;
            dgv_Thuonghieu.Size = new Size(1094, 304);
            dgv_Thuonghieu.TabIndex = 0;
            dgv_Thuonghieu.CellClick += dgv_Thuonghieu_CellClick;
            dgv_Thuonghieu.CellContentClick += dgv_Thuonghieu_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(0, 40);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(200, 60);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Size";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton2.Location = new Point(886, 612);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(228, 44);
            uiButton2.TabIndex = 2;
            uiButton2.Text = "Exit";
            uiButton2.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton2.Click += btn_capNhatThayDoi_Click;
            // 
            // uiButton3
            // 
            uiButton3.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton3.Location = new Point(886, 612);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Size = new Size(228, 44);
            uiButton3.TabIndex = 5;
            uiButton3.Text = "Exit";
            uiButton3.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiButton3.Click += uiButton3_Click;
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Thuonghieu).EndInit();
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
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton btn_Sua;
        private Sunny.UI.UIButton btn_Them;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel MaTH;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox uiTextBox1;
        private DataGridView dgv_Thuonghieu;
        private TabPage tabPage3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
    }
}