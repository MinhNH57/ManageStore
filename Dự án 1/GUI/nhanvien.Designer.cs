namespace Dự_án_1.GUI
{
    partial class nhanvien
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
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            txt_quyen = new ComboBox();
            groupBox5 = new GroupBox();
            rdo_dangLam = new RadioButton();
            rdo_nghiLam = new RadioButton();
            groupBox3 = new GroupBox();
            rdo_nu = new RadioButton();
            rdo_nam = new RadioButton();
            btn_voHieuHoaNV = new Button();
            btn_SuaNV = new Button();
            btn_ThemNV = new Button();
            label3 = new Label();
            label2 = new Label();
            txtsđt = new TextBox();
            label1 = new Label();
            txt_diaChi = new TextBox();
            txt_matKhau = new TextBox();
            txt_taiKhoan = new TextBox();
            txtMaNV = new TextBox();
            label13 = new Label();
            label6 = new Label();
            label12 = new Label();
            label11 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtcccd = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            dgv_diaChi = new DataGridView();
            txt_tìmKiem = new TextBox();
            rdoNhanvien = new RadioButton();
            rdoquanly = new RadioButton();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_diaChi).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1388, 925);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.GhostWhite;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.8001556F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.1998444F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(1368, 905);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lavender;
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(2, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1364, 448);
            panel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_quyen);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(btn_voHieuHoaNV);
            groupBox2.Controls.Add(btn_SuaNV);
            groupBox2.Controls.Add(btn_ThemNV);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtsđt);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txt_diaChi);
            groupBox2.Controls.Add(txt_matKhau);
            groupBox2.Controls.Add(txt_taiKhoan);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(dtpNgaySinh);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtcccd);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1364, 448);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Tag = "GioiTinh";
            groupBox2.Text = "Thông Tin Nhân Viên";
            // 
            // txt_quyen
            // 
            txt_quyen.FormattingEnabled = true;
            txt_quyen.Items.AddRange(new object[] { "Admin", "Nhân Viên" });
            txt_quyen.Location = new Point(619, 66);
            txt_quyen.Name = "txt_quyen";
            txt_quyen.Size = new Size(261, 34);
            txt_quyen.TabIndex = 35;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rdo_dangLam);
            groupBox5.Controls.Add(rdo_nghiLam);
            groupBox5.Location = new Point(628, 336);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(0);
            groupBox5.Size = new Size(305, 58);
            groupBox5.TabIndex = 34;
            groupBox5.TabStop = false;
            // 
            // rdo_dangLam
            // 
            rdo_dangLam.AutoSize = true;
            rdo_dangLam.Location = new Point(15, 19);
            rdo_dangLam.Margin = new Padding(4);
            rdo_dangLam.Name = "rdo_dangLam";
            rdo_dangLam.Size = new Size(135, 30);
            rdo_dangLam.TabIndex = 33;
            rdo_dangLam.Tag = "trangThai";
            rdo_dangLam.Text = "Đang làm";
            rdo_dangLam.UseVisualStyleBackColor = true;
            // 
            // rdo_nghiLam
            // 
            rdo_nghiLam.AutoSize = true;
            rdo_nghiLam.Location = new Point(160, 20);
            rdo_nghiLam.Margin = new Padding(4);
            rdo_nghiLam.Name = "rdo_nghiLam";
            rdo_nghiLam.Size = new Size(130, 30);
            rdo_nghiLam.TabIndex = 33;
            rdo_nghiLam.Tag = "trangThai";
            rdo_nghiLam.Text = "Nghỉ làm";
            rdo_nghiLam.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdo_nu);
            groupBox3.Controls.Add(rdo_nam);
            groupBox3.Location = new Point(214, 259);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(0);
            groupBox3.Size = new Size(184, 64);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            // 
            // rdo_nu
            // 
            rdo_nu.AutoSize = true;
            rdo_nu.Location = new Point(92, 20);
            rdo_nu.Margin = new Padding(4);
            rdo_nu.Name = "rdo_nu";
            rdo_nu.Size = new Size(68, 30);
            rdo_nu.TabIndex = 33;
            rdo_nu.Tag = "vaiTro";
            rdo_nu.Text = "Nữ";
            rdo_nu.UseVisualStyleBackColor = true;
            // 
            // rdo_nam
            // 
            rdo_nam.AutoSize = true;
            rdo_nam.Location = new Point(4, 20);
            rdo_nam.Margin = new Padding(4);
            rdo_nam.Name = "rdo_nam";
            rdo_nam.Size = new Size(85, 30);
            rdo_nam.TabIndex = 33;
            rdo_nam.Tag = "vaiTro";
            rdo_nam.Text = "Nam";
            rdo_nam.UseVisualStyleBackColor = true;
            // 
            // btn_voHieuHoaNV
            // 
            btn_voHieuHoaNV.BackColor = Color.Lavender;
            btn_voHieuHoaNV.Location = new Point(1071, 186);
            btn_voHieuHoaNV.Margin = new Padding(4);
            btn_voHieuHoaNV.Name = "btn_voHieuHoaNV";
            btn_voHieuHoaNV.Size = new Size(189, 76);
            btn_voHieuHoaNV.TabIndex = 32;
            btn_voHieuHoaNV.Text = "Làm mới";
            btn_voHieuHoaNV.UseVisualStyleBackColor = false;
            btn_voHieuHoaNV.Click += btn_voHieuHoaNV_Click;
            // 
            // btn_SuaNV
            // 
            btn_SuaNV.BackColor = Color.Lavender;
            btn_SuaNV.Location = new Point(1071, 124);
            btn_SuaNV.Margin = new Padding(4);
            btn_SuaNV.Name = "btn_SuaNV";
            btn_SuaNV.Size = new Size(189, 55);
            btn_SuaNV.TabIndex = 32;
            btn_SuaNV.Text = "Sửa thông tin";
            btn_SuaNV.UseVisualStyleBackColor = false;
            btn_SuaNV.Click += btn_SuaNV_Click;
            // 
            // btn_ThemNV
            // 
            btn_ThemNV.BackColor = Color.Lavender;
            btn_ThemNV.Location = new Point(1071, 61);
            btn_ThemNV.Margin = new Padding(4);
            btn_ThemNV.Name = "btn_ThemNV";
            btn_ThemNV.Size = new Size(189, 55);
            btn_ThemNV.TabIndex = 32;
            btn_ThemNV.Text = "Thêm nhân viên";
            btn_ThemNV.UseVisualStyleBackColor = false;
            btn_ThemNV.Click += btn_ThemNV_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(489, 360);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 29;
            label3.Text = "Trạng thái :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 361);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 28;
            label2.Text = "Số điện thoại";
            // 
            // txtsđt
            // 
            txtsđt.Location = new Point(214, 351);
            txtsđt.Margin = new Padding(2);
            txtsđt.Name = "txtsđt";
            txtsđt.Size = new Size(260, 35);
            txtsđt.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 121);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 26;
            label1.Text = "Tên Nhân viên :";
            // 
            // txt_diaChi
            // 
            txt_diaChi.Location = new Point(620, 210);
            txt_diaChi.Margin = new Padding(2);
            txt_diaChi.Multiline = true;
            txt_diaChi.Name = "txt_diaChi";
            txt_diaChi.Size = new Size(260, 78);
            txt_diaChi.TabIndex = 25;
            // 
            // txt_matKhau
            // 
            txt_matKhau.Location = new Point(620, 155);
            txt_matKhau.Margin = new Padding(2);
            txt_matKhau.Name = "txt_matKhau";
            txt_matKhau.Size = new Size(260, 35);
            txt_matKhau.TabIndex = 25;
            txt_matKhau.UseSystemPasswordChar = true;
            // 
            // txt_taiKhoan
            // 
            txt_taiKhoan.Location = new Point(620, 105);
            txt_taiKhoan.Margin = new Padding(2);
            txt_taiKhoan.Name = "txt_taiKhoan";
            txt_taiKhoan.Size = new Size(260, 35);
            txt_taiKhoan.TabIndex = 25;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(214, 59);
            txtMaNV.Margin = new Padding(2);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(260, 35);
            txtMaNV.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(485, 169);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(116, 25);
            label13.TabIndex = 22;
            label13.Text = "Mật khẩu :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(485, 65);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 21;
            label6.Text = "Vai trò";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(485, 115);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(121, 25);
            label12.TabIndex = 21;
            label12.Text = "Tài khoản :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(485, 222);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(98, 25);
            label11.TabIndex = 21;
            label11.Text = "Địa Chỉ :";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "MM/dd/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(214, 210);
            dtpNgaySinh.Margin = new Padding(2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(260, 35);
            dtpNgaySinh.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 285);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 13;
            label5.Text = "Giới tính :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(35, 212);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(121, 25);
            label8.TabIndex = 13;
            label8.Text = "Ngày Sinh :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(35, 170);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 11;
            label7.Text = "Số CMND :";
            // 
            // txtcccd
            // 
            txtcccd.Location = new Point(214, 160);
            txtcccd.Margin = new Padding(2);
            txtcccd.Name = "txtcccd";
            txtcccd.Size = new Size(260, 35);
            txtcccd.TabIndex = 10;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(214, 115);
            txtTen.Margin = new Padding(2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(260, 35);
            txtTen.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 65);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 7;
            label4.Text = "Mã Nhân viên :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dgv_diaChi);
            groupBox1.Controls.Add(txt_tìmKiem);
            groupBox1.Controls.Add(rdoNhanvien);
            groupBox1.Controls.Add(rdoquanly);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 462);
            groupBox1.Margin = new Padding(10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1348, 433);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Location = new Point(1214, 27);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(116, 29);
            button1.TabIndex = 36;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgv_diaChi
            // 
            dgv_diaChi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_diaChi.Location = new Point(6, 62);
            dgv_diaChi.Margin = new Padding(4);
            dgv_diaChi.Name = "dgv_diaChi";
            dgv_diaChi.RowHeadersWidth = 51;
            dgv_diaChi.RowTemplate.Height = 29;
            dgv_diaChi.Size = new Size(1335, 364);
            dgv_diaChi.TabIndex = 0;
            dgv_diaChi.CellClick += dgv_diaChi_CellClick;
            // 
            // txt_tìmKiem
            // 
            txt_tìmKiem.Location = new Point(851, 28);
            txt_tìmKiem.Margin = new Padding(2);
            txt_tìmKiem.Name = "txt_tìmKiem";
            txt_tìmKiem.PlaceholderText = "Nhập tên nhân viên để tìm kiếm";
            txt_tìmKiem.Size = new Size(342, 28);
            txt_tìmKiem.TabIndex = 25;
            // 
            // rdoNhanvien
            // 
            rdoNhanvien.AutoSize = true;
            rdoNhanvien.Location = new Point(588, -299);
            rdoNhanvien.Margin = new Padding(2);
            rdoNhanvien.Name = "rdoNhanvien";
            rdoNhanvien.Size = new Size(119, 26);
            rdoNhanvien.TabIndex = 19;
            rdoNhanvien.TabStop = true;
            rdoNhanvien.Text = "Nhân Viên";
            rdoNhanvien.UseVisualStyleBackColor = true;
            // 
            // rdoquanly
            // 
            rdoquanly.AutoSize = true;
            rdoquanly.Location = new Point(731, -299);
            rdoquanly.Margin = new Padding(2);
            rdoquanly.Name = "rdoquanly";
            rdoquanly.Size = new Size(103, 26);
            rdoquanly.TabIndex = 20;
            rdoquanly.TabStop = true;
            rdoquanly.Text = "Quản Lý";
            rdoquanly.UseVisualStyleBackColor = true;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // nhanvien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 925);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "nhanvien";
            Text = "nhanvien";
            Load += nhanvien_Load;
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_diaChi).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private GroupBox groupBox1;
        private DataGridView dgv_diaChi;
        private TextBox txt_tìmKiem;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private GroupBox groupBox2;
        private Button btn_voHieuHoaNV;
        private Button btn_SuaNV;
        private Button btn_ThemNV;
        private Label label3;
        private Label label2;
        private TextBox txtsđt;
        private Label label1;
        private TextBox txt_diaChi;
        private TextBox txt_matKhau;
        private TextBox txt_taiKhoan;
        private TextBox txtMaNV;
        private Label label13;
        private Label label12;
        private Label label11;
        private DateTimePicker dtpNgaySinh;
        private Label label8;
        private Label label7;
        private TextBox txtcccd;
        private TextBox txtTen;
        private Label label4;
        private RadioButton rdoNhanvien;
        private RadioButton rdoquanly;
        private RadioButton rdo_nghiLam;
        private RadioButton rdo_dangLam;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private RadioButton rdo_nam;
        private Label label5;
        private GroupBox groupBox5;
        private Label label6;
        private RadioButton rdo_nu;
        private ComboBox txt_quyen;
        private Button button1;
    }
}