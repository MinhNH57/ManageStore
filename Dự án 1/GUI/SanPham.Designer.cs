namespace WF.Form_Chức_Năng.Form_Chức_Năng___ADMIN
{
    partial class SanPham
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_themSP = new Sunny.UI.UIImageButton();
            btn_voHIeu = new Sunny.UI.UIImageButton();
            uiImageButton5 = new Sunny.UI.UIImageButton();
            btn_suaSP = new Sunny.UI.UIImageButton();
            dgv_dataSP = new DataGridView();
            cb_thuongHieu = new ComboBox();
            label20 = new Label();
            label19 = new Label();
            label11 = new Label();
            cb_loaiChanQuan = new ComboBox();
            cb_loaicoAo = new ComboBox();
            cb_loaiSP = new ComboBox();
            label10 = new Label();
            cb_chatLieu = new ComboBox();
            label9 = new Label();
            txt_tìmKiem1 = new TextBox();
            txt_tenSP = new TextBox();
            txt_maSP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            uiImageButton4 = new Sunny.UI.UIImageButton();
            btn_themByexcel = new Sunny.UI.UIImageButton();
            uiImageButton3 = new Sunny.UI.UIImageButton();
            uiImageButton2 = new Sunny.UI.UIImageButton();
            uiImageButton1 = new Sunny.UI.UIImageButton();
            btn_QR = new Sunny.UI.UIImageButton();
            QRCodePictureBox = new PictureBox();
            btn_img = new Sunny.UI.UIImageButton();
            label24 = new Label();
            dvg_sPCT = new DataGridView();
            pic_spct = new PictureBox();
            cb_size = new ComboBox();
            cb_mau = new ComboBox();
            label3 = new Label();
            label12 = new Label();
            label4 = new Label();
            cb_maSP = new ComboBox();
            label6 = new Label();
            txt_timKiem = new TextBox();
            txt_soLuong = new TextBox();
            txt_Gia = new TextBox();
            txt_tenSPCT = new TextBox();
            txt_maSPCT = new TextBox();
            label13 = new Label();
            label7 = new Label();
            label8 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tt = new Sunny.UI.UIToolTip(components);
            uiImageButton6 = new Sunny.UI.UIImageButton();
            uiImageButton7 = new Sunny.UI.UIImageButton();
            uiImageButton8 = new Sunny.UI.UIImageButton();
            uiImageButton9 = new Sunny.UI.UIImageButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_themSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_voHIeu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_suaSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_dataSP).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiImageButton4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_themByexcel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_QR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QRCodePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvg_sPCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_spct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton9).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 43);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(434, 7);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 31);
            label5.TabIndex = 1;
            label5.Text = "Sản phẩm";
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(8);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8);
            panel2.Size = new Size(1041, 669);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(8, 8);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1025, 653);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_themSP);
            tabPage1.Controls.Add(btn_voHIeu);
            tabPage1.Controls.Add(uiImageButton5);
            tabPage1.Controls.Add(uiImageButton8);
            tabPage1.Controls.Add(uiImageButton9);
            tabPage1.Controls.Add(uiImageButton7);
            tabPage1.Controls.Add(uiImageButton6);
            tabPage1.Controls.Add(btn_suaSP);
            tabPage1.Controls.Add(dgv_dataSP);
            tabPage1.Controls.Add(cb_thuongHieu);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(cb_loaiChanQuan);
            tabPage1.Controls.Add(cb_loaicoAo);
            tabPage1.Controls.Add(cb_loaiSP);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(cb_chatLieu);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txt_tìmKiem1);
            tabPage1.Controls.Add(txt_tenSP);
            tabPage1.Controls.Add(txt_maSP);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1017, 620);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sản phẩm";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btn_themSP
            // 
            btn_themSP.Anchor = AnchorStyles.Top;
            btn_themSP.Font = new Font("Microsoft Sans Serif", 12F);
            btn_themSP.Location = new Point(661, 259);
            btn_themSP.Name = "btn_themSP";
            btn_themSP.Size = new Size(157, 44);
            btn_themSP.TabIndex = 54;
            btn_themSP.TabStop = false;
            btn_themSP.Text = "Thêm sản phẩm";
            btn_themSP.Click += btn_themSP_Click_1;
            // 
            // btn_voHIeu
            // 
            btn_voHIeu.Anchor = AnchorStyles.Top;
            btn_voHIeu.Font = new Font("Microsoft Sans Serif", 12F);
            btn_voHIeu.Location = new Point(379, 259);
            btn_voHIeu.Name = "btn_voHIeu";
            btn_voHIeu.Size = new Size(232, 44);
            btn_voHIeu.TabIndex = 54;
            btn_voHIeu.TabStop = false;
            btn_voHIeu.Text = "Vô hiệu hóa sản phẩm";
            btn_voHIeu.Click += btn_voHIeu_Click_1;
            // 
            // uiImageButton5
            // 
            uiImageButton5.Anchor = AnchorStyles.Top;
            uiImageButton5.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton5.Location = new Point(106, 259);
            uiImageButton5.Name = "uiImageButton5";
            uiImageButton5.Size = new Size(232, 44);
            uiImageButton5.TabIndex = 54;
            uiImageButton5.TabStop = false;
            uiImageButton5.Text = "Sửa thông tin sản phẩm";
            uiImageButton5.Click += btn_suaSP_Click_1;
            uiImageButton5.MouseHover += btn_suaSP_MouseHover;
            // 
            // btn_suaSP
            // 
            btn_suaSP.Anchor = AnchorStyles.Top;
            btn_suaSP.Font = new Font("Microsoft Sans Serif", 12F);
            btn_suaSP.Location = new Point(343, 179);
            btn_suaSP.Name = "btn_suaSP";
            btn_suaSP.Size = new Size(38, 28);
            btn_suaSP.TabIndex = 54;
            btn_suaSP.TabStop = false;
            btn_suaSP.Text = "+";
            btn_suaSP.Click += btn_suaSP_Click;
            btn_suaSP.MouseHover += btn_suaSP_MouseHover;
            // 
            // dgv_dataSP
            // 
            dgv_dataSP.Anchor = AnchorStyles.Top;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_dataSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_dataSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_dataSP.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_dataSP.Location = new Point(2, 370);
            dgv_dataSP.Margin = new Padding(2);
            dgv_dataSP.Name = "dgv_dataSP";
            dgv_dataSP.RowHeadersWidth = 62;
            dgv_dataSP.RowTemplate.Height = 33;
            dgv_dataSP.Size = new Size(1013, 248);
            dgv_dataSP.TabIndex = 24;
            dgv_dataSP.CellClick += dgv_dataSP_CellClick;
            dgv_dataSP.DoubleClick += dgv_dataSP_DoubleClick;
            // 
            // cb_thuongHieu
            // 
            cb_thuongHieu.Anchor = AnchorStyles.Top;
            cb_thuongHieu.FormattingEnabled = true;
            cb_thuongHieu.Location = new Point(32, 179);
            cb_thuongHieu.Margin = new Padding(2);
            cb_thuongHieu.Name = "cb_thuongHieu";
            cb_thuongHieu.Size = new Size(306, 28);
            cb_thuongHieu.TabIndex = 21;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top;
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label20.Location = new Point(784, 159);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(122, 18);
            label20.TabIndex = 20;
            label20.Text = "Loại chân quần";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top;
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label19.Location = new Point(589, 159);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(88, 18);
            label19.TabIndex = 20;
            label19.Text = "Loại cổ áo";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label11.Location = new Point(32, 159);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 18);
            label11.TabIndex = 20;
            label11.Text = "Thương hiệu";
            // 
            // cb_loaiChanQuan
            // 
            cb_loaiChanQuan.Anchor = AnchorStyles.Top;
            cb_loaiChanQuan.FormattingEnabled = true;
            cb_loaiChanQuan.Items.AddRange(new object[] { "Ống suông", "Skinny", "Ống loe", "None" });
            cb_loaiChanQuan.Location = new Point(784, 179);
            cb_loaiChanQuan.Margin = new Padding(2);
            cb_loaiChanQuan.Name = "cb_loaiChanQuan";
            cb_loaiChanQuan.Size = new Size(139, 28);
            cb_loaiChanQuan.TabIndex = 19;
            // 
            // cb_loaicoAo
            // 
            cb_loaicoAo.Anchor = AnchorStyles.Top;
            cb_loaicoAo.FormattingEnabled = true;
            cb_loaicoAo.Items.AddRange(new object[] { "Cổ tròn", "Cổ tim", "Cổ cao", "Cổ thấp", "Cổ có khuy", "None" });
            cb_loaicoAo.Location = new Point(589, 179);
            cb_loaicoAo.Margin = new Padding(2);
            cb_loaicoAo.Name = "cb_loaicoAo";
            cb_loaicoAo.Size = new Size(139, 28);
            cb_loaicoAo.TabIndex = 19;
            // 
            // cb_loaiSP
            // 
            cb_loaiSP.Anchor = AnchorStyles.Top;
            cb_loaiSP.FormattingEnabled = true;
            cb_loaiSP.Items.AddRange(new object[] { "Áo Khoác", "Áo T-Shirt", "Áo Len", "Áo Polo", "Áo sơ mi", "Quần jeans", "Quần kaki", "Bộ" });
            cb_loaiSP.Location = new Point(589, 109);
            cb_loaiSP.Margin = new Padding(2);
            cb_loaiSP.Name = "cb_loaiSP";
            cb_loaiSP.Size = new Size(306, 28);
            cb_loaiSP.TabIndex = 19;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label10.Location = new Point(589, 89);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(118, 18);
            label10.TabIndex = 18;
            label10.Text = "Loại sản phẩm";
            // 
            // cb_chatLieu
            // 
            cb_chatLieu.Anchor = AnchorStyles.Top;
            cb_chatLieu.FormattingEnabled = true;
            cb_chatLieu.Items.AddRange(new object[] { "Canvas", "Gió", "Polyme", "Tổng hợp", "Cotton" });
            cb_chatLieu.Location = new Point(589, 47);
            cb_chatLieu.Margin = new Padding(2);
            cb_chatLieu.Name = "cb_chatLieu";
            cb_chatLieu.Size = new Size(306, 28);
            cb_chatLieu.TabIndex = 17;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label9.Location = new Point(589, 27);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 18);
            label9.TabIndex = 16;
            label9.Text = "Chất liệu";
            // 
            // txt_tìmKiem1
            // 
            txt_tìmKiem1.Anchor = AnchorStyles.Top;
            txt_tìmKiem1.Location = new Point(343, 327);
            txt_tìmKiem1.Margin = new Padding(2);
            txt_tìmKiem1.Name = "txt_tìmKiem1";
            txt_tìmKiem1.PlaceholderText = "Searching";
            txt_tìmKiem1.Size = new Size(306, 27);
            txt_tìmKiem1.TabIndex = 5;
            txt_tìmKiem1.TextChanged += txt_tìmKiem_TextChanged;
            // 
            // txt_tenSP
            // 
            txt_tenSP.Anchor = AnchorStyles.Top;
            txt_tenSP.Location = new Point(32, 110);
            txt_tenSP.Margin = new Padding(2);
            txt_tenSP.Name = "txt_tenSP";
            txt_tenSP.Size = new Size(306, 27);
            txt_tenSP.TabIndex = 3;
            // 
            // txt_maSP
            // 
            txt_maSP.Anchor = AnchorStyles.Top;
            txt_maSP.Enabled = false;
            txt_maSP.Location = new Point(32, 48);
            txt_maSP.Margin = new Padding(2);
            txt_maSP.Name = "txt_maSP";
            txt_maSP.Size = new Size(306, 27);
            txt_maSP.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.Location = new Point(32, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 18);
            label2.TabIndex = 4;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.Location = new Point(32, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 18);
            label1.TabIndex = 2;
            label1.Text = "Mã :";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(uiImageButton4);
            tabPage2.Controls.Add(btn_themByexcel);
            tabPage2.Controls.Add(uiImageButton3);
            tabPage2.Controls.Add(uiImageButton2);
            tabPage2.Controls.Add(uiImageButton1);
            tabPage2.Controls.Add(btn_QR);
            tabPage2.Controls.Add(QRCodePictureBox);
            tabPage2.Controls.Add(btn_img);
            tabPage2.Controls.Add(label24);
            tabPage2.Controls.Add(dvg_sPCT);
            tabPage2.Controls.Add(pic_spct);
            tabPage2.Controls.Add(cb_size);
            tabPage2.Controls.Add(cb_mau);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(cb_maSP);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txt_timKiem);
            tabPage2.Controls.Add(txt_soLuong);
            tabPage2.Controls.Add(txt_Gia);
            tabPage2.Controls.Add(txt_tenSPCT);
            tabPage2.Controls.Add(txt_maSPCT);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1017, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sản phẩm chi tiết";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // uiImageButton4
            // 
            uiImageButton4.Anchor = AnchorStyles.Top;
            uiImageButton4.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton4.ForeColor = Color.Fuchsia;
            uiImageButton4.Location = new Point(405, 295);
            uiImageButton4.Name = "uiImageButton4";
            uiImageButton4.Size = new Size(374, 33);
            uiImageButton4.SizeMode = PictureBoxSizeMode.StretchImage;
            uiImageButton4.TabIndex = 74;
            uiImageButton4.TabStop = false;
            uiImageButton4.Text = "Insert products from Excel file";
            uiImageButton4.Click += uiImageButton4_Click;
            uiImageButton4.MouseEnter += uiImageButton3_MouseEnter;
            // 
            // btn_themByexcel
            // 
            btn_themByexcel.Anchor = AnchorStyles.Top;
            btn_themByexcel.Font = new Font("Microsoft Sans Serif", 12F);
            btn_themByexcel.Image = (Image)resources.GetObject("btn_themByexcel.Image");
            btn_themByexcel.Location = new Point(717, 232);
            btn_themByexcel.Name = "btn_themByexcel";
            btn_themByexcel.Size = new Size(62, 51);
            btn_themByexcel.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_themByexcel.TabIndex = 74;
            btn_themByexcel.TabStop = false;
            btn_themByexcel.Text = null;
            btn_themByexcel.Click += btn_themByexcel_Click;
            btn_themByexcel.MouseEnter += uiImageButton3_MouseEnter;
            // 
            // uiImageButton3
            // 
            uiImageButton3.Anchor = AnchorStyles.Top;
            uiImageButton3.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton3.Image = (Image)resources.GetObject("uiImageButton3.Image");
            uiImageButton3.Location = new Point(607, 232);
            uiImageButton3.Name = "uiImageButton3";
            uiImageButton3.Size = new Size(62, 51);
            uiImageButton3.SizeMode = PictureBoxSizeMode.StretchImage;
            uiImageButton3.TabIndex = 74;
            uiImageButton3.TabStop = false;
            uiImageButton3.Text = null;
            uiImageButton3.Click += uiImageButton3_Click;
            uiImageButton3.MouseEnter += uiImageButton3_MouseEnter;
            // 
            // uiImageButton2
            // 
            uiImageButton2.Anchor = AnchorStyles.Top;
            uiImageButton2.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton2.Image = (Image)resources.GetObject("uiImageButton2.Image");
            uiImageButton2.Location = new Point(504, 232);
            uiImageButton2.Name = "uiImageButton2";
            uiImageButton2.Size = new Size(62, 51);
            uiImageButton2.SizeMode = PictureBoxSizeMode.StretchImage;
            uiImageButton2.TabIndex = 74;
            uiImageButton2.TabStop = false;
            uiImageButton2.Text = null;
            uiImageButton2.Click += uiImageButton2_Click;
            uiImageButton2.MouseEnter += uiImageButton2_MouseEnter;
            // 
            // uiImageButton1
            // 
            uiImageButton1.Anchor = AnchorStyles.Top;
            uiImageButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton1.Image = (Image)resources.GetObject("uiImageButton1.Image");
            uiImageButton1.Location = new Point(405, 235);
            uiImageButton1.Name = "uiImageButton1";
            uiImageButton1.Size = new Size(58, 51);
            uiImageButton1.SizeMode = PictureBoxSizeMode.StretchImage;
            uiImageButton1.TabIndex = 74;
            uiImageButton1.TabStop = false;
            uiImageButton1.Text = null;
            uiImageButton1.Click += uiImageButton1_Click_2;
            uiImageButton1.MouseEnter += uiImageButton1_MouseEnter;
            // 
            // btn_QR
            // 
            btn_QR.Anchor = AnchorStyles.Top;
            btn_QR.Font = new Font("Microsoft Sans Serif", 12F);
            btn_QR.Image = (Image)resources.GetObject("btn_QR.Image");
            btn_QR.Location = new Point(887, 55);
            btn_QR.Name = "btn_QR";
            btn_QR.Size = new Size(116, 73);
            btn_QR.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_QR.TabIndex = 73;
            btn_QR.TabStop = false;
            btn_QR.Text = null;
            btn_QR.Click += uiImageButton1_Click_1;
            btn_QR.MouseEnter += btn_QR_MouseEnter;
            // 
            // QRCodePictureBox
            // 
            QRCodePictureBox.Anchor = AnchorStyles.Top;
            QRCodePictureBox.BorderStyle = BorderStyle.Fixed3D;
            QRCodePictureBox.Location = new Point(877, 10);
            QRCodePictureBox.Name = "QRCodePictureBox";
            QRCodePictureBox.Size = new Size(131, 149);
            QRCodePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            QRCodePictureBox.TabIndex = 68;
            QRCodePictureBox.TabStop = false;
            QRCodePictureBox.Click += QRCodePictureBox_Click;
            // 
            // btn_img
            // 
            btn_img.Anchor = AnchorStyles.Top;
            btn_img.Font = new Font("Microsoft Sans Serif", 12F);
            btn_img.Image = (Image)resources.GetObject("btn_img.Image");
            btn_img.Location = new Point(776, 62);
            btn_img.Name = "btn_img";
            btn_img.Size = new Size(62, 55);
            btn_img.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_img.TabIndex = 73;
            btn_img.TabStop = false;
            btn_img.Text = null;
            btn_img.Click += uiImageButton1_Click;
            btn_img.MouseEnter += btn_img_MouseEnter;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Top;
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label24.Location = new Point(18, 299);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(36, 18);
            label24.TabIndex = 72;
            label24.Text = "Tìm";
            // 
            // dvg_sPCT
            // 
            dvg_sPCT.Anchor = AnchorStyles.Top;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dvg_sPCT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dvg_sPCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dvg_sPCT.DefaultCellStyle = dataGridViewCellStyle8;
            dvg_sPCT.Location = new Point(3, 361);
            dvg_sPCT.Name = "dvg_sPCT";
            dvg_sPCT.RowHeadersWidth = 51;
            dvg_sPCT.Size = new Size(1011, 213);
            dvg_sPCT.TabIndex = 69;
            dvg_sPCT.CellClick += dvg_sPCT_CellClick;
            dvg_sPCT.CellContentClick += dvg_sPCT_CellContentClick;
            // 
            // pic_spct
            // 
            pic_spct.Anchor = AnchorStyles.Top;
            pic_spct.BorderStyle = BorderStyle.Fixed3D;
            pic_spct.Location = new Point(744, 10);
            pic_spct.Name = "pic_spct";
            pic_spct.Size = new Size(127, 149);
            pic_spct.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_spct.TabIndex = 68;
            pic_spct.TabStop = false;
            pic_spct.Click += pic_spct_Click;
            // 
            // cb_size
            // 
            cb_size.Anchor = AnchorStyles.Top;
            cb_size.FormattingEnabled = true;
            cb_size.Location = new Point(19, 170);
            cb_size.Margin = new Padding(2);
            cb_size.Name = "cb_size";
            cb_size.Size = new Size(306, 28);
            cb_size.TabIndex = 64;
            // 
            // cb_mau
            // 
            cb_mau.Anchor = AnchorStyles.Top;
            cb_mau.FormattingEnabled = true;
            cb_mau.Location = new Point(19, 232);
            cb_mau.Margin = new Padding(2);
            cb_mau.Name = "cb_mau";
            cb_mau.Size = new Size(306, 28);
            cb_mau.TabIndex = 64;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label3.Location = new Point(19, 212);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 18);
            label3.TabIndex = 63;
            label3.Text = "Màu";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label12.Location = new Point(405, 150);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(39, 18);
            label12.TabIndex = 61;
            label12.Text = "Giá ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label4.Location = new Point(405, 81);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 61;
            label4.Text = "Số lượng";
            // 
            // cb_maSP
            // 
            cb_maSP.Anchor = AnchorStyles.Top;
            cb_maSP.FormattingEnabled = true;
            cb_maSP.Location = new Point(405, 39);
            cb_maSP.Margin = new Padding(2);
            cb_maSP.Name = "cb_maSP";
            cb_maSP.Size = new Size(306, 28);
            cb_maSP.TabIndex = 60;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label6.Location = new Point(405, 19);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 18);
            label6.TabIndex = 59;
            label6.Text = "Mã SP";
            // 
            // txt_timKiem
            // 
            txt_timKiem.Anchor = AnchorStyles.Top;
            txt_timKiem.Location = new Point(55, 295);
            txt_timKiem.Margin = new Padding(2);
            txt_timKiem.Name = "txt_timKiem";
            txt_timKiem.Size = new Size(306, 27);
            txt_timKiem.TabIndex = 57;
            txt_timKiem.TextChanged += txt_timKiem_TextChanged;
            // 
            // txt_soLuong
            // 
            txt_soLuong.Anchor = AnchorStyles.Top;
            txt_soLuong.Location = new Point(405, 101);
            txt_soLuong.Margin = new Padding(2);
            txt_soLuong.Name = "txt_soLuong";
            txt_soLuong.Size = new Size(306, 27);
            txt_soLuong.TabIndex = 58;
            txt_soLuong.TextChanged += txt_soLuong_TextChanged;
            // 
            // txt_Gia
            // 
            txt_Gia.Anchor = AnchorStyles.Top;
            txt_Gia.Location = new Point(405, 171);
            txt_Gia.Margin = new Padding(2);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(306, 27);
            txt_Gia.TabIndex = 58;
            txt_Gia.TextChanged += txt_tenSPCT_TextChanged;
            // 
            // txt_tenSPCT
            // 
            txt_tenSPCT.Anchor = AnchorStyles.Top;
            txt_tenSPCT.Location = new Point(19, 101);
            txt_tenSPCT.Margin = new Padding(2);
            txt_tenSPCT.Name = "txt_tenSPCT";
            txt_tenSPCT.Size = new Size(306, 27);
            txt_tenSPCT.TabIndex = 58;
            txt_tenSPCT.TextChanged += txt_tenSPCT_TextChanged;
            // 
            // txt_maSPCT
            // 
            txt_maSPCT.Anchor = AnchorStyles.Top;
            txt_maSPCT.Enabled = false;
            txt_maSPCT.Location = new Point(19, 39);
            txt_maSPCT.Margin = new Padding(2);
            txt_maSPCT.Name = "txt_maSPCT";
            txt_maSPCT.Size = new Size(306, 27);
            txt_maSPCT.TabIndex = 55;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label13.Location = new Point(19, 141);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(41, 18);
            label13.TabIndex = 56;
            label13.Text = "Size";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label7.Location = new Point(19, 81);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 18);
            label7.TabIndex = 56;
            label7.Text = "Tên";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label8.Location = new Point(19, 19);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 18);
            label8.TabIndex = 54;
            label8.Text = "Mã SPCT";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // tt
            // 
            tt.BackColor = Color.FromArgb(54, 54, 54);
            tt.ForeColor = Color.FromArgb(239, 239, 239);
            tt.OwnerDraw = true;
            // 
            // uiImageButton6
            // 
            uiImageButton6.Anchor = AnchorStyles.Top;
            uiImageButton6.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton6.Location = new Point(900, 47);
            uiImageButton6.Name = "uiImageButton6";
            uiImageButton6.Size = new Size(38, 28);
            uiImageButton6.TabIndex = 54;
            uiImageButton6.TabStop = false;
            uiImageButton6.Text = "+";
            uiImageButton6.Click += btn_suaSP_Click;
            uiImageButton6.MouseHover += btn_suaSP_MouseHover;
            // 
            // uiImageButton7
            // 
            uiImageButton7.Anchor = AnchorStyles.Top;
            uiImageButton7.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton7.Location = new Point(900, 109);
            uiImageButton7.Name = "uiImageButton7";
            uiImageButton7.Size = new Size(38, 28);
            uiImageButton7.TabIndex = 54;
            uiImageButton7.TabStop = false;
            uiImageButton7.Text = "+";
            uiImageButton7.Click += btn_suaSP_Click;
            uiImageButton7.MouseHover += btn_suaSP_MouseHover;
            // 
            // uiImageButton8
            // 
            uiImageButton8.Anchor = AnchorStyles.Top;
            uiImageButton8.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton8.Location = new Point(733, 179);
            uiImageButton8.Name = "uiImageButton8";
            uiImageButton8.Size = new Size(38, 28);
            uiImageButton8.TabIndex = 54;
            uiImageButton8.TabStop = false;
            uiImageButton8.Text = "+";
            uiImageButton8.Click += btn_suaSP_Click;
            uiImageButton8.MouseHover += btn_suaSP_MouseHover;
            // 
            // uiImageButton9
            // 
            uiImageButton9.Anchor = AnchorStyles.Top;
            uiImageButton9.Font = new Font("Microsoft Sans Serif", 12F);
            uiImageButton9.Location = new Point(928, 179);
            uiImageButton9.Name = "uiImageButton9";
            uiImageButton9.Size = new Size(38, 28);
            uiImageButton9.TabIndex = 54;
            uiImageButton9.TabStop = false;
            uiImageButton9.Text = "+";
            uiImageButton9.Click += btn_suaSP_Click;
            uiImageButton9.MouseHover += btn_suaSP_MouseHover;
            // 
            // SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1041, 669);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SanPham";
            Text = "SanPham";
            Load += SanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_themSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_voHIeu).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton5).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_suaSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_dataSP).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uiImageButton4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_themByexcel).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton3).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_QR).EndInit();
            ((System.ComponentModel.ISupportInitialize)QRCodePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvg_sPCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_spct).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton6).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton7).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton8).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Panel panel2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TextBox textBox5;
        private NumericUpDown numericUpDown1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Sunny.UI.UIToolTip tt;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Sunny.UI.UIImageButton btn_themSP;
        private Sunny.UI.UIImageButton btn_voHIeu;
        private Sunny.UI.UIImageButton btn_suaSP;
        private DataGridView dgv_dataSP;
        private ComboBox cb_thuongHieu;
        private Label label20;
        private Label label19;
        private Label label11;
        private ComboBox cb_loaiChanQuan;
        private ComboBox cb_loaicoAo;
        private ComboBox cb_loaiSP;
        private Label label10;
        private ComboBox cb_chatLieu;
        private Label label9;
        private TextBox txt_tìmKiem1;
        private TextBox txt_tenSP;
        private TextBox txt_maSP;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Sunny.UI.UIImageButton uiImageButton4;
        private Sunny.UI.UIImageButton btn_themByexcel;
        private Sunny.UI.UIImageButton uiImageButton3;
        private Sunny.UI.UIImageButton uiImageButton2;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UIImageButton btn_QR;
        private PictureBox QRCodePictureBox;
        private Sunny.UI.UIImageButton btn_img;
        private Label label24;
        private DataGridView dvg_sPCT;
        private PictureBox pic_spct;
        private ComboBox cb_size;
        private ComboBox cb_mau;
        private Label label3;
        private Label label12;
        private Label label4;
        private ComboBox cb_maSP;
        private Label label6;
        private TextBox txt_timKiem;
        private TextBox txt_soLuong;
        private TextBox txt_Gia;
        private TextBox txt_tenSPCT;
        private TextBox txt_maSPCT;
        private Label label13;
        private Label label7;
        private Label label8;
        private Sunny.UI.UIImageButton uiImageButton5;
        private Sunny.UI.UIImageButton uiImageButton7;
        private Sunny.UI.UIImageButton uiImageButton6;
        private Sunny.UI.UIImageButton uiImageButton8;
        private Sunny.UI.UIImageButton uiImageButton9;
    }
}