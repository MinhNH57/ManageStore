namespace Dự_án_1.GUI
{
    partial class magg
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            txtMaGiamGia = new TextBox();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            txt_tyleGiam = new TextBox();
            label5 = new Label();
            txt_tenKM = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            btnLamMoi = new Button();
            panel7 = new Panel();
            btnSua = new Button();
            panel6 = new Panel();
            btnThem = new Button();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            dgvDanhSachMaGiamGia = new DataGridView();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachMaGiamGia).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.4356F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5644035F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 422F));
            tableLayoutPanel1.Size = new Size(1368, 422);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtMaGiamGia);
            panel4.Controls.Add(dtpNgayKetThuc);
            panel4.Controls.Add(dtpNgayBatDau);
            panel4.Controls.Add(txt_tyleGiam);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txt_tenKM);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(2, 2);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1121, 275);
            panel4.TabIndex = 0;
            // 
            // txtMaGiamGia
            // 
            txtMaGiamGia.Location = new Point(244, 49);
            txtMaGiamGia.Margin = new Padding(2);
            txtMaGiamGia.Name = "txtMaGiamGia";
            txtMaGiamGia.Size = new Size(300, 31);
            txtMaGiamGia.TabIndex = 11;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Location = new Point(792, 118);
            dtpNgayKetThuc.Margin = new Padding(2);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(306, 31);
            dtpNgayKetThuc.TabIndex = 10;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.Location = new Point(244, 119);
            dtpNgayBatDau.Margin = new Padding(2);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(300, 31);
            dtpNgayBatDau.TabIndex = 9;
            // 
            // txt_tyleGiam
            // 
            txt_tyleGiam.Location = new Point(244, 179);
            txt_tyleGiam.Margin = new Padding(2);
            txt_tyleGiam.Name = "txt_tyleGiam";
            txt_tyleGiam.Size = new Size(306, 31);
            txt_tyleGiam.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 179);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 33);
            label5.TabIndex = 3;
            label5.Text = "Tỉ lệ giảm :";
            // 
            // txt_tenKM
            // 
            txt_tenKM.Location = new Point(792, 45);
            txt_tenKM.Margin = new Padding(2);
            txt_tenKM.Name = "txt_tenKM";
            txt_tenKM.Size = new Size(306, 31);
            txt_tenKM.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(576, 45);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 33);
            label4.TabIndex = 3;
            label4.Text = "Tên KM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(575, 115);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(184, 33);
            label3.TabIndex = 2;
            label3.Text = "Ngày kết thúc :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 33);
            label2.TabIndex = 1;
            label2.Text = "Ngày bắt đầu :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 33);
            label1.TabIndex = 0;
            label1.Text = "Mã giảm giá :";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLamMoi);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(btnSua);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btnThem);
            panel5.Location = new Point(1129, 2);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(236, 418);
            panel5.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.DarkCyan;
            btnLamMoi.Dock = DockStyle.Top;
            btnLamMoi.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLamMoi.Location = new Point(0, 287);
            btnLamMoi.Margin = new Padding(2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(236, 89);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 238);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(236, 49);
            panel7.TabIndex = 3;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DarkCyan;
            btnSua.Dock = DockStyle.Top;
            btnSua.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(0, 149);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(236, 89);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 84);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(236, 65);
            panel6.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DarkCyan;
            btnThem.Dock = DockStyle.Top;
            btnThem.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(0, 0);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(236, 84);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(10, 432);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(1368, 483);
            panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSachMaGiamGia);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1348, 463);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách mã giảm giá ";
            // 
            // dgvDanhSachMaGiamGia
            // 
            dgvDanhSachMaGiamGia.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachMaGiamGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachMaGiamGia.Dock = DockStyle.Fill;
            dgvDanhSachMaGiamGia.Location = new Point(2, 35);
            dgvDanhSachMaGiamGia.Margin = new Padding(2);
            dgvDanhSachMaGiamGia.Name = "dgvDanhSachMaGiamGia";
            dgvDanhSachMaGiamGia.RowHeadersWidth = 62;
            dgvDanhSachMaGiamGia.Size = new Size(1344, 426);
            dgvDanhSachMaGiamGia.TabIndex = 0;
            dgvDanhSachMaGiamGia.CellClick += dgvDanhSachMaGiamGia_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1388, 925);
            panel2.TabIndex = 3;
            // 
            // magg
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 925);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "magg";
            Text = "magg";
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachMaGiamGia).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private TextBox txtMaGiamGia;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private TextBox txt_tenKM;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachMaGiamGia;
        private Panel panel2;
        private Panel panel5;
        private Button btnLamMoi;
        private Panel panel7;
        private Button btnSua;
        private Panel panel6;
        private Button btnThem;
        private TextBox txt_tyleGiam;
        private Label label5;
    }
}