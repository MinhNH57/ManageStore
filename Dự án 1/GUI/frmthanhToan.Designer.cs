namespace Dự_án_1.GUI
{
    partial class frmthanhToan
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
            uiLabel1 = new Sunny.UI.UILabel();
            txt_tienKHdua = new Sunny.UI.UITextBox();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(65, 47);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(231, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "Số tiền khách hàng đưa";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_tienKHdua
            // 
            txt_tienKHdua.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tienKHdua.Location = new Point(110, 81);
            txt_tienKHdua.Margin = new Padding(4, 5, 4, 5);
            txt_tienKHdua.MinimumSize = new Size(1, 16);
            txt_tienKHdua.Name = "txt_tienKHdua";
            txt_tienKHdua.Padding = new Padding(5);
            txt_tienKHdua.ShowText = false;
            txt_tienKHdua.Size = new Size(121, 36);
            txt_tienKHdua.TabIndex = 1;
            txt_tienKHdua.TextAlignment = ContentAlignment.MiddleLeft;
            txt_tienKHdua.UseWaitCursor = true;
            txt_tienKHdua.Watermark = "";
            txt_tienKHdua.TextChanged += txt_tienKHdua_TextChanged;
            txt_tienKHdua.KeyDown += txt_tienKHdua_KeyDown;
            // 
            // frmthanhToan
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(339, 168);
            Controls.Add(txt_tienKHdua);
            Controls.Add(uiLabel1);
            Name = "frmthanhToan";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += frmthanhToan_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txt_tienKHdua;
    }
}