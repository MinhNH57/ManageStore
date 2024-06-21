namespace Dự_án_1.GUI
{
    partial class trangNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trangNhanVien));
            panel4 = new Panel();
            panel3 = new Panel();
            btn_out = new Button();
            btn_thongke = new Button();
            pictureBox2 = new PictureBox();
            btn_banhang = new Button();
            btn_hoadon = new Button();
            button10 = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(240, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1410, 900);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.OrangeRed;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(btn_out);
            panel3.Controls.Add(btn_thongke);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btn_banhang);
            panel3.Controls.Add(btn_hoadon);
            panel3.Controls.Add(button10);
            panel3.Location = new Point(0, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(241, 899);
            panel3.TabIndex = 5;
            // 
            // btn_out
            // 
            btn_out.BackColor = Color.Lime;
            btn_out.BackgroundImage = (Image)resources.GetObject("btn_out.BackgroundImage");
            btn_out.BackgroundImageLayout = ImageLayout.Stretch;
            btn_out.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_out.Location = new Point(4, 819);
            btn_out.Margin = new Padding(2);
            btn_out.Name = "btn_out";
            btn_out.Size = new Size(231, 70);
            btn_out.TabIndex = 10;
            btn_out.UseVisualStyleBackColor = false;
            // 
            // btn_thongke
            // 
            btn_thongke.BackColor = Color.Lime;
            btn_thongke.BackgroundImage = (Image)resources.GetObject("btn_thongke.BackgroundImage");
            btn_thongke.BackgroundImageLayout = ImageLayout.Stretch;
            btn_thongke.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thongke.Location = new Point(4, 447);
            btn_thongke.Margin = new Padding(2);
            btn_thongke.Name = "btn_thongke";
            btn_thongke.Size = new Size(231, 70);
            btn_thongke.TabIndex = 8;
            btn_thongke.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources.R;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 11);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(198, 198);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btn_banhang
            // 
            btn_banhang.BackColor = Color.Lime;
            btn_banhang.BackgroundImage = (Image)resources.GetObject("btn_banhang.BackgroundImage");
            btn_banhang.BackgroundImageLayout = ImageLayout.Stretch;
            btn_banhang.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_banhang.Location = new Point(2, 299);
            btn_banhang.Margin = new Padding(2);
            btn_banhang.Name = "btn_banhang";
            btn_banhang.Size = new Size(231, 70);
            btn_banhang.TabIndex = 5;
            btn_banhang.UseVisualStyleBackColor = false;
            // 
            // btn_hoadon
            // 
            btn_hoadon.BackColor = Color.Lime;
            btn_hoadon.BackgroundImage = (Image)resources.GetObject("btn_hoadon.BackgroundImage");
            btn_hoadon.BackgroundImageLayout = ImageLayout.Stretch;
            btn_hoadon.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_hoadon.Location = new Point(4, 373);
            btn_hoadon.Margin = new Padding(2);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Size = new Size(231, 70);
            btn_hoadon.TabIndex = 4;
            btn_hoadon.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Lime;
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(2, 225);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(231, 70);
            button10.TabIndex = 3;
            button10.UseVisualStyleBackColor = false;
            // 
            // trangNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1650, 904);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "trangNhanVien";
            Text = "trangNhanVien";
            Load += trangNhanVien_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel3;
        private Button btn_out;
        private Button btn_thongke;
        private PictureBox pictureBox2;
        private Button btn_banhang;
        private Button btn_hoadon;
        private Button button10;
    }
}