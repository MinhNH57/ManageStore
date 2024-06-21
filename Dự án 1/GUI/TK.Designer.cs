namespace Dự_án_1.GUI
{
    partial class TK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TK));
            uiTabControl1 = new Sunny.UI.UITabControl();
            tabPage1 = new TabPage();
            uiPieChart2 = new Sunny.UI.UIPieChart();
            uiPieChart1 = new Sunny.UI.UIPieChart();
            tabPage2 = new TabPage();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            uiBarChart1 = new Sunny.UI.UIBarChart();
            panel1 = new Panel();
            uiLabel4 = new Sunny.UI.UILabel();
            Giamsut = new Sunny.UI.UILabel();
            lbl_tangTruong = new Sunny.UI.UILabel();
            lbl_tongHD = new Sunny.UI.UILabel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tabPage3 = new TabPage();
            panel2 = new Panel();
            uiDoughnutChart1 = new Sunny.UI.UIDoughnutChart();
            toolTip1 = new ToolTip(components);
            uiTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            uiTableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabControl1
            // 
            uiTabControl1.Controls.Add(tabPage1);
            uiTabControl1.Controls.Add(tabPage2);
            uiTabControl1.Controls.Add(tabPage3);
            uiTabControl1.Dock = DockStyle.Fill;
            uiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControl1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTabControl1.ItemSize = new Size(150, 40);
            uiTabControl1.Location = new Point(0, 0);
            uiTabControl1.MainPage = "";
            uiTabControl1.Name = "uiTabControl1";
            uiTabControl1.SelectedIndex = 0;
            uiTabControl1.Size = new Size(1110, 740);
            uiTabControl1.SizeMode = TabSizeMode.Fixed;
            uiTabControl1.TabIndex = 0;
            uiTabControl1.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            uiTabControl1.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uiPieChart2);
            tabPage1.Controls.Add(uiPieChart1);
            tabPage1.Location = new Point(0, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1110, 700);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tổng quát";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiPieChart2
            // 
            uiPieChart2.Anchor = AnchorStyles.Top;
            uiPieChart2.ChartStyleType = Sunny.UI.UIChartStyleType.Default;
            uiPieChart2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPieChart2.LegendFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiPieChart2.Location = new Point(3, 361);
            uiPieChart2.MinimumSize = new Size(1, 1);
            uiPieChart2.Name = "uiPieChart2";
            uiPieChart2.RectColor = Color.White;
            uiPieChart2.Size = new Size(1104, 336);
            uiPieChart2.SubFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiPieChart2.TabIndex = 1;
            uiPieChart2.Text = "uiPieChart1";
            // 
            // uiPieChart1
            // 
            uiPieChart1.Anchor = AnchorStyles.Top;
            uiPieChart1.BackColor = Color.White;
            uiPieChart1.ChartStyleType = Sunny.UI.UIChartStyleType.Default;
            uiPieChart1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPieChart1.LegendFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiPieChart1.Location = new Point(3, 3);
            uiPieChart1.MinimumSize = new Size(1, 1);
            uiPieChart1.Name = "uiPieChart1";
            uiPieChart1.RectColor = Color.White;
            uiPieChart1.Size = new Size(1104, 352);
            uiPieChart1.SubFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiPieChart1.TabIndex = 1;
            uiPieChart1.Text = "uiPieChart1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(uiTableLayoutPanel1);
            tabPage2.Location = new Point(0, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(200, 60);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Đơn hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 1;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.91892F));
            uiTableLayoutPanel1.Controls.Add(uiBarChart1, 0, 0);
            uiTableLayoutPanel1.Controls.Add(panel1, 0, 1);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 2;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.Size = new Size(200, 60);
            uiTableLayoutPanel1.TabIndex = 0;
            uiTableLayoutPanel1.TagString = null;
            // 
            // uiBarChart1
            // 
            uiBarChart1.Dock = DockStyle.Fill;
            uiBarChart1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiBarChart1.LegendFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiBarChart1.Location = new Point(3, 3);
            uiBarChart1.MinimumSize = new Size(1, 1);
            uiBarChart1.Name = "uiBarChart1";
            uiBarChart1.Size = new Size(194, 24);
            uiBarChart1.SubFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiBarChart1.TabIndex = 0;
            uiBarChart1.Text = "uiBarChart1";
            // 
            // panel1
            // 
            panel1.Controls.Add(uiLabel4);
            panel1.Controls.Add(Giamsut);
            panel1.Controls.Add(lbl_tangTruong);
            panel1.Controls.Add(lbl_tongHD);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 24);
            panel1.TabIndex = 1;
            // 
            // uiLabel4
            // 
            uiLabel4.Anchor = AnchorStyles.Top;
            uiLabel4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(-318, 15);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(811, 54);
            uiLabel4.TabIndex = 2;
            uiLabel4.Text = "TỔNG HỢP BÁO CÁO";
            uiLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Giamsut
            // 
            Giamsut.Anchor = AnchorStyles.Top;
            Giamsut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Giamsut.ForeColor = Color.Red;
            Giamsut.Location = new Point(396, 229);
            Giamsut.Name = "Giamsut";
            Giamsut.Size = new Size(125, 29);
            Giamsut.TabIndex = 1;
            Giamsut.Text = "0";
            Giamsut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_tangTruong
            // 
            lbl_tangTruong.Anchor = AnchorStyles.Top;
            lbl_tangTruong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tangTruong.ForeColor = Color.FromArgb(0, 192, 0);
            lbl_tangTruong.Location = new Point(37, 229);
            lbl_tangTruong.Name = "lbl_tangTruong";
            lbl_tangTruong.Size = new Size(125, 29);
            lbl_tangTruong.TabIndex = 1;
            lbl_tangTruong.Text = "0";
            lbl_tangTruong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_tongHD
            // 
            lbl_tongHD.Anchor = AnchorStyles.Top;
            lbl_tongHD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tongHD.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_tongHD.Location = new Point(-345, 229);
            lbl_tongHD.Name = "lbl_tongHD";
            lbl_tongHD.Size = new Size(125, 29);
            lbl_tongHD.TabIndex = 1;
            lbl_tongHD.Text = "0";
            lbl_tongHD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-318, 118);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.MouseEnter += pictureBox3_MouseEnter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(420, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel2);
            tabPage3.Location = new Point(0, 40);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(200, 60);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sản phẩm";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(uiDoughnutChart1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 60);
            panel2.TabIndex = 1;
            // 
            // uiDoughnutChart1
            // 
            uiDoughnutChart1.Dock = DockStyle.Fill;
            uiDoughnutChart1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDoughnutChart1.LegendFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiDoughnutChart1.Location = new Point(0, 0);
            uiDoughnutChart1.MinimumSize = new Size(1, 1);
            uiDoughnutChart1.Name = "uiDoughnutChart1";
            uiDoughnutChart1.Size = new Size(200, 60);
            uiDoughnutChart1.SubFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiDoughnutChart1.TabIndex = 0;
            uiDoughnutChart1.Text = "uiDoughnutChart1";
            // 
            // TK
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1110, 740);
            Controls.Add(uiTabControl1);
            Name = "TK";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "TK";
            ZoomScaleRect = new Rectangle(19, 19, 1110, 740);
            Load += TK_Load;
            uiTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            uiTableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControl uiTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Sunny.UI.UIPieChart uiPieChart1;
        private Sunny.UI.UIPieChart uiPieChart2;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIBarChart uiBarChart1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private ToolTip toolTip1;
        private Sunny.UI.UILabel Giamsut;
        private Sunny.UI.UILabel lbl_tangTruong;
        private Sunny.UI.UILabel lbl_tongHD;
        private Sunny.UI.UILabel uiLabel4;
        private Panel panel2;
        private Sunny.UI.UIDoughnutChart uiDoughnutChart1;
    }
}