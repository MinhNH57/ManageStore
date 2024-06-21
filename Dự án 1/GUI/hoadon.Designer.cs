namespace Dự_án_1.GUI
{
    partial class hoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoadon));
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            dgv_HOADON = new DataGridView();
            panel4 = new Panel();
            txt_timKiem = new TextBox();
            button1 = new Button();
            dtp_denNgay = new DateTimePicker();
            label2 = new Label();
            btn_in = new Button();
            dtp_tuNgay = new DateTimePicker();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgv_HDCT = new DataGridView();
            pdhd = new System.Drawing.Printing.PrintDocument();
            ppdhd = new PrintPreviewDialog();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HOADON).BeginInit();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 740);
            panel2.TabIndex = 48;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.1351357F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.8648643F));
            tableLayoutPanel1.Size = new Size(1110, 740);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0, 0, 0, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1110, 330);
            panel3.TabIndex = 40;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_HOADON);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 62);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1110, 268);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dgv_HOADON
            // 
            dgv_HOADON.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_HOADON.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HOADON.Location = new Point(4, 26);
            dgv_HOADON.Margin = new Padding(2);
            dgv_HOADON.Name = "dgv_HOADON";
            dgv_HOADON.RowHeadersWidth = 62;
            dgv_HOADON.Size = new Size(1106, 244);
            dgv_HOADON.TabIndex = 0;
            dgv_HOADON.CellClick += dgv_HOADON_CellClick;
            dgv_HOADON.CellDoubleClick += dgv_HOADON_CellDoubleClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(txt_timKiem);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(dtp_denNgay);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btn_in);
            panel4.Controls.Add(dtp_tuNgay);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1110, 62);
            panel4.TabIndex = 0;
            // 
            // txt_timKiem
            // 
            txt_timKiem.Location = new Point(108, 23);
            txt_timKiem.Name = "txt_timKiem";
            txt_timKiem.PlaceholderText = "Tìm hóa đơn theo tên khách hàng";
            txt_timKiem.Size = new Size(235, 27);
            txt_timKiem.TabIndex = 54;
            txt_timKiem.TextChanged += txt_timKiem_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(893, 14);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(206, 37);
            button1.TabIndex = 47;
            button1.Text = "Lọc Hóa Đơn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtp_denNgay
            // 
            dtp_denNgay.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_denNgay.CustomFormat = "      dd/MM/yyyy";
            dtp_denNgay.Format = DateTimePickerFormat.Custom;
            dtp_denNgay.Location = new Point(737, 24);
            dtp_denNgay.Margin = new Padding(4, 5, 4, 5);
            dtp_denNgay.Name = "dtp_denNgay";
            dtp_denNgay.Size = new Size(148, 27);
            dtp_denNgay.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(615, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 26);
            label2.TabIndex = 51;
            label2.Text = "Đến Ngày :";
            // 
            // btn_in
            // 
            btn_in.BackColor = Color.Transparent;
            btn_in.FlatStyle = FlatStyle.Flat;
            btn_in.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_in.ForeColor = SystemColors.ActiveCaptionText;
            btn_in.Location = new Point(13, 12);
            btn_in.Margin = new Padding(4, 5, 4, 5);
            btn_in.Name = "btn_in";
            btn_in.Size = new Size(74, 38);
            btn_in.TabIndex = 50;
            btn_in.Text = "Print";
            btn_in.UseVisualStyleBackColor = false;
            btn_in.Click += btn_in_Click;
            // 
            // dtp_tuNgay
            // 
            dtp_tuNgay.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_tuNgay.CustomFormat = "     dd/MM/yyyy";
            dtp_tuNgay.Format = DateTimePickerFormat.Custom;
            dtp_tuNgay.Location = new Point(472, 24);
            dtp_tuNgay.Margin = new Padding(4, 5, 4, 5);
            dtp_tuNgay.Name = "dtp_tuNgay";
            dtp_tuNgay.Size = new Size(146, 27);
            dtp_tuNgay.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(350, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 26);
            label1.TabIndex = 49;
            label1.Text = "Từ Ngày :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_HDCT);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(2, 336);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1106, 402);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // dgv_HDCT
            // 
            dgv_HDCT.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_HDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HDCT.Dock = DockStyle.Fill;
            dgv_HDCT.Location = new Point(2, 29);
            dgv_HDCT.Margin = new Padding(2);
            dgv_HDCT.Name = "dgv_HDCT";
            dgv_HDCT.RowHeadersWidth = 62;
            dgv_HDCT.Size = new Size(1102, 371);
            dgv_HDCT.TabIndex = 0;
            // 
            // pdhd
            // 
            pdhd.PrintPage += pdhd_PrintPage;
            // 
            // ppdhd
            // 
            ppdhd.AutoScrollMargin = new Size(0, 0);
            ppdhd.AutoScrollMinSize = new Size(0, 0);
            ppdhd.ClientSize = new Size(400, 300);
            ppdhd.Enabled = true;
            ppdhd.Icon = (Icon)resources.GetObject("ppdhd.Icon");
            ppdhd.Name = "printPreviewDialog1";
            ppdhd.Visible = false;
            // 
            // hoadon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 740);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "hoadon";
            Text = "hoadon";
            Load += hoadon_Load;
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_HOADON).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_HDCT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private GroupBox groupBox1;
        private DataGridView dgv_HOADON;
        private Panel panel4;
        private Button button1;
        private DateTimePicker dtp_denNgay;
        private Label label2;
        private Button btn_in;
        private DateTimePicker dtp_tuNgay;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgv_HDCT;
        private TextBox txt_timKiem;
        private System.Drawing.Printing.PrintDocument pdhd;
        private PrintPreviewDialog ppdhd;
    }
}