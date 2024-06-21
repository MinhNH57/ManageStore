namespace QRCodeReader
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            ptb_Image = new PictureBox();
            btn_Start = new Button();
            cbb_Cam = new ComboBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_tatcam = new Button();
            ((System.ComponentModel.ISupportInitialize)ptb_Image).BeginInit();
            SuspendLayout();
            // 
            // ptb_Image
            // 
            ptb_Image.Location = new Point(12, 12);
            ptb_Image.Name = "ptb_Image";
            ptb_Image.Size = new Size(522, 508);
            ptb_Image.TabIndex = 0;
            ptb_Image.TabStop = false;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(560, 117);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(194, 48);
            btn_Start.TabIndex = 1;
            btn_Start.Text = "Bật cam";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // cbb_Cam
            // 
            cbb_Cam.FormattingEnabled = true;
            cbb_Cam.Location = new Point(559, 59);
            cbb_Cam.Name = "cbb_Cam";
            cbb_Cam.Size = new Size(280, 28);
            cbb_Cam.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(560, 13);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 3;
            label1.Text = "Chọn camera";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btn_tatcam
            // 
            btn_tatcam.Location = new Point(559, 189);
            btn_tatcam.Name = "btn_tatcam";
            btn_tatcam.Size = new Size(194, 48);
            btn_tatcam.TabIndex = 1;
            btn_tatcam.Text = "Tắt cam";
            btn_tatcam.UseVisualStyleBackColor = true;
            btn_tatcam.Click += btn_tatcam_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 539);
            Controls.Add(label1);
            Controls.Add(cbb_Cam);
            Controls.Add(btn_tatcam);
            Controls.Add(btn_Start);
            Controls.Add(ptb_Image);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ptb_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptb_Image;
        private Button btn_Start;
        private ComboBox cbb_Cam;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button btn_tatcam;
    }
}