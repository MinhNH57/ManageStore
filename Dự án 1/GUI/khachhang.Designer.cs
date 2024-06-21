namespace Dự_án_1.GUI
{
    partial class khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(khachhang));
            dgv_KH = new DataGridView();
            panel4 = new Panel();
            uiImageButton1 = new Sunny.UI.UIImageButton();
            txtTimKiem = new Sunny.UI.UITextBox();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnSua = new Sunny.UI.UIImageButton();
            txt_diaChi = new Sunny.UI.UITextBox();
            txt_sdt = new Sunny.UI.UITextBox();
            txt_tenKH = new Sunny.UI.UITextBox();
            txt_maKH = new Sunny.UI.UILabel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_KH).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiImageButton1).BeginInit();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSua).BeginInit();
            SuspendLayout();
            // 
            // dgv_KH
            // 
            dgv_KH.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_KH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_KH.Dock = DockStyle.Fill;
            dgv_KH.Location = new Point(2, 88);
            dgv_KH.Margin = new Padding(2);
            dgv_KH.Name = "dgv_KH";
            dgv_KH.RowHeadersWidth = 62;
            dgv_KH.Size = new Size(1106, 427);
            dgv_KH.TabIndex = 1;
            dgv_KH.CellClick += dgv_KH_CellClick;
            dgv_KH.DataBindingComplete += dgv_KH_DataBindingComplete;
            // 
            // panel4
            // 
            panel4.Controls.Add(uiImageButton1);
            panel4.Controls.Add(txtTimKiem);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(2, 29);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1106, 59);
            panel4.TabIndex = 0;
            // 
            // uiImageButton1
            // 
            uiImageButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiImageButton1.Image = (Image)resources.GetObject("uiImageButton1.Image");
            uiImageButton1.Location = new Point(706, 5);
            uiImageButton1.Name = "uiImageButton1";
            uiImageButton1.Size = new Size(76, 49);
            uiImageButton1.SizeMode = PictureBoxSizeMode.StretchImage;
            uiImageButton1.TabIndex = 2;
            uiImageButton1.TabStop = false;
            uiImageButton1.Text = null;
            uiImageButton1.Click += uiImageButton1_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.FillColor = SystemColors.ButtonHighlight;
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(789, 16);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.MinimumSize = new Size(1, 16);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Padding = new Padding(5);
            txtTimKiem.RectColor = SystemColors.ButtonHighlight;
            txtTimKiem.ShowText = false;
            txtTimKiem.Size = new Size(221, 36);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextAlignment = ContentAlignment.MiddleLeft;
            txtTimKiem.Watermark = "";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(dgv_KH);
            groupBox1.Controls.Add(panel4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1110, 517);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khách hàng";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 223);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1110, 517);
            panel3.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(592, 46);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 22);
            label6.TabIndex = 4;
            label6.Text = "Địa chỉ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 92);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã Khách hàng :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(txt_diaChi);
            panel2.Controls.Add(txt_sdt);
            panel2.Controls.Add(txt_tenKH);
            panel2.Controls.Add(txt_maKH);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 223);
            panel2.TabIndex = 45;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(791, 110);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(95, 91);
            btnSua.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSua.TabIndex = 16;
            btnSua.TabStop = false;
            btnSua.Text = null;
            btnSua.Click += btnSua_Click_1;
            // 
            // txt_diaChi
            // 
            txt_diaChi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_diaChi.Location = new Point(691, 33);
            txt_diaChi.Margin = new Padding(4, 5, 4, 5);
            txt_diaChi.MinimumSize = new Size(1, 16);
            txt_diaChi.Name = "txt_diaChi";
            txt_diaChi.Padding = new Padding(5);
            txt_diaChi.RectColor = SystemColors.ButtonFace;
            txt_diaChi.ShowText = false;
            txt_diaChi.Size = new Size(294, 58);
            txt_diaChi.TabIndex = 15;
            txt_diaChi.TextAlignment = ContentAlignment.MiddleLeft;
            txt_diaChi.Watermark = "";
            // 
            // txt_sdt
            // 
            txt_sdt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_sdt.Location = new Point(201, 132);
            txt_sdt.Margin = new Padding(4, 5, 4, 5);
            txt_sdt.MinimumSize = new Size(1, 16);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Padding = new Padding(5);
            txt_sdt.RectColor = SystemColors.ButtonFace;
            txt_sdt.ShowText = false;
            txt_sdt.Size = new Size(294, 36);
            txt_sdt.TabIndex = 15;
            txt_sdt.TextAlignment = ContentAlignment.MiddleLeft;
            txt_sdt.Watermark = "";
            // 
            // txt_tenKH
            // 
            txt_tenKH.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tenKH.Location = new Point(201, 78);
            txt_tenKH.Margin = new Padding(4, 5, 4, 5);
            txt_tenKH.MinimumSize = new Size(1, 16);
            txt_tenKH.Name = "txt_tenKH";
            txt_tenKH.Padding = new Padding(5);
            txt_tenKH.RectColor = SystemColors.ButtonFace;
            txt_tenKH.ShowText = false;
            txt_tenKH.Size = new Size(294, 36);
            txt_tenKH.TabIndex = 15;
            txt_tenKH.TextAlignment = ContentAlignment.MiddleLeft;
            txt_tenKH.Watermark = "";
            // 
            // txt_maKH
            // 
            txt_maKH.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_maKH.ForeColor = Color.FromArgb(48, 48, 48);
            txt_maKH.Location = new Point(201, 41);
            txt_maKH.Name = "txt_maKH";
            txt_maKH.Size = new Size(125, 29);
            txt_maKH.TabIndex = 14;
            txt_maKH.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 146);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 22);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại :";
            // 
            // khachhang
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1110, 740);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "khachhang";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "khachhang";
            ZoomScaleRect = new Rectangle(19, 19, 1110, 740);
            Load += khachhang_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_KH).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiImageButton1).EndInit();
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSua).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_KH;
        private Panel panel4;
        private Button btnLammoi;
        private GroupBox groupBox1;
        private Panel panel3;
        private Label label6;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Sunny.UI.UILabel txt_maKH;
        private Sunny.UI.UITextBox txt_diaChi;
        private Sunny.UI.UITextBox txt_sdt;
        private Sunny.UI.UITextBox txt_tenKH;
        private Sunny.UI.UIImageButton btnSua;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UITextBox txtTimKiem;
    }
}