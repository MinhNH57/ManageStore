namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_taiKhoan = new Sunny.UI.UITextBox();
            txt_matKhau = new Sunny.UI.UITextBox();
            pictureBox1 = new PictureBox();
            btn_Login = new Sunny.UI.UIButton();
            uiImageButton1 = new Sunny.UI.UIImageButton();
            btn_showpass = new Sunny.UI.UIImageButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_showpass).BeginInit();
            SuspendLayout();
            // 
            // txt_taiKhoan
            // 
            txt_taiKhoan.Anchor = AnchorStyles.Top;
            txt_taiKhoan.BackColor = Color.White;
            txt_taiKhoan.ButtonFillColor = Color.White;
            txt_taiKhoan.ButtonFillHoverColor = Color.White;
            txt_taiKhoan.ButtonFillPressColor = Color.White;
            txt_taiKhoan.ButtonRectColor = Color.White;
            txt_taiKhoan.ButtonRectHoverColor = Color.White;
            txt_taiKhoan.ButtonRectPressColor = Color.White;
            txt_taiKhoan.ButtonStyleInherited = false;
            txt_taiKhoan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_taiKhoan.Icon = (Image)resources.GetObject("txt_taiKhoan.Icon");
            txt_taiKhoan.Location = new Point(153, 303);
            txt_taiKhoan.Margin = new Padding(4, 5, 4, 5);
            txt_taiKhoan.MinimumSize = new Size(1, 16);
            txt_taiKhoan.Name = "txt_taiKhoan";
            txt_taiKhoan.Padding = new Padding(5);
            txt_taiKhoan.Radius = 20;
            txt_taiKhoan.RectColor = Color.White;
            txt_taiKhoan.ScrollBarColor = Color.White;
            txt_taiKhoan.ScrollBarStyleInherited = false;
            txt_taiKhoan.ShowButton = true;
            txt_taiKhoan.ShowText = false;
            txt_taiKhoan.Size = new Size(327, 59);
            txt_taiKhoan.Style = Sunny.UI.UIStyle.Custom;
            txt_taiKhoan.TabIndex = 0;
            txt_taiKhoan.TextAlignment = ContentAlignment.MiddleLeft;
            txt_taiKhoan.Watermark = "";
            txt_taiKhoan.WatermarkActiveColor = Color.Silver;
            txt_taiKhoan.WatermarkColor = Color.Silver;
            txt_taiKhoan.TextChanged += txt_taiKhoan_TextChanged;
            // 
            // txt_matKhau
            // 
            txt_matKhau.Anchor = AnchorStyles.Top;
            txt_matKhau.BackColor = Color.White;
            txt_matKhau.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_matKhau.Icon = (Image)resources.GetObject("txt_matKhau.Icon");
            txt_matKhau.Location = new Point(153, 430);
            txt_matKhau.Margin = new Padding(4, 5, 4, 5);
            txt_matKhau.MinimumSize = new Size(1, 16);
            txt_matKhau.Name = "txt_matKhau";
            txt_matKhau.Padding = new Padding(5);
            txt_matKhau.Radius = 20;
            txt_matKhau.RectColor = Color.White;
            txt_matKhau.ShowText = false;
            txt_matKhau.Size = new Size(271, 59);
            txt_matKhau.TabIndex = 0;
            txt_matKhau.TextAlignment = ContentAlignment.MiddleLeft;
            txt_matKhau.Watermark = "";
            txt_matKhau.TextChanged += txt_matKhau_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_Login
            // 
            btn_Login.BackgroundImage = (Image)resources.GetObject("btn_Login.BackgroundImage");
            btn_Login.BackgroundImageLayout = ImageLayout.Center;
            btn_Login.FillColor = Color.Empty;
            btn_Login.FillColor2 = Color.Empty;
            btn_Login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.ForeColor = Color.Black;
            btn_Login.Location = new Point(153, 586);
            btn_Login.MinimumSize = new Size(1, 1);
            btn_Login.Name = "btn_Login";
            btn_Login.RectColor = Color.FromArgb(255, 192, 255);
            btn_Login.Size = new Size(127, 44);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Đăng nhập";
            btn_Login.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Click += btn_Login_Click_1;
            // 
            // uiImageButton1
            // 
            uiImageButton1.BackgroundImage = (Image)resources.GetObject("uiImageButton1.BackgroundImage");
            uiImageButton1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiImageButton1.Location = new Point(305, 586);
            uiImageButton1.Name = "uiImageButton1";
            uiImageButton1.Size = new Size(175, 44);
            uiImageButton1.TabIndex = 3;
            uiImageButton1.TabStop = false;
            uiImageButton1.Text = "Quên mật khẩu?";
            // 
            // btn_showpass
            // 
            btn_showpass.BackColor = Color.White;
            btn_showpass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_showpass.Image = (Image)resources.GetObject("btn_showpass.Image");
            btn_showpass.Location = new Point(420, 430);
            btn_showpass.Name = "btn_showpass";
            btn_showpass.Size = new Size(65, 59);
            btn_showpass.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_showpass.TabIndex = 0;
            btn_showpass.TabStop = false;
            btn_showpass.Text = null;
            btn_showpass.Click += btn_showpass_Click;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(669, 866);
            ControlBoxCloseFillHoverColor = Color.White;
            ControlBoxFillHoverColor = Color.White;
            Controls.Add(btn_showpass);
            Controls.Add(uiImageButton1);
            Controls.Add(btn_Login);
            Controls.Add(pictureBox1);
            Controls.Add(txt_matKhau);
            Controls.Add(txt_taiKhoan);
            MaximumSize = new Size(669, 866);
            MinimumSize = new Size(669, 866);
            Name = "Login";
            RectColor = Color.White;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TextAlignment = StringAlignment.Center;
            TitleColor = Color.FromArgb(192, 192, 255);
            TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TitleForeColor = Color.Black;
            FormClosing += Login_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)uiImageButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_showpass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITextBox txt_taiKhoan;
        private Sunny.UI.UITextBox txt_matKhau;
        private PictureBox pictureBox1;
        private Sunny.UI.UIButton btn_Login;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UIImageButton btn_showpass;
    }
}
