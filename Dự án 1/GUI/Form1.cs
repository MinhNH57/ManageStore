using AForge.Video.DirectShow;
using Dự_án_1;
using Dự_án_1.Valiable;
using ZXing;

namespace QRCodeReader
{
    public partial class Form1 : Form
    {
        FilterInfoCollection camCollection;
        //VideoCaptureDevice videoCaptureDevice;
        //bool scanning = false;
        private bool scanning = false;
        private VideoCaptureDevice videoCaptureDevice;
        private Thread captureThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            camCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in camCollection)
            {
                cbb_Cam.Items.Add(item.Name);
            }
            if (camCollection.Count > 0)
            {
                cbb_Cam.SelectedIndex = 0;
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            if (scanning)
            {
                ptb_Image.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!scanning)
            {
                // Truy cập Control cbb_Cam trên luồng giao diện người dùng chính
                if (cbb_Cam.InvokeRequired)
                {
                    cbb_Cam.Invoke(new Action(() =>
                    {
                        StartVideoCapture();
                    }));
                }
                else
                {
                    StartVideoCapture();
                }

                scanning = true;
                timer1.Start();
            }
        }

        private void StartVideoCapture()
        {
            videoCaptureDevice = new VideoCaptureDevice(camCollection[cbb_Cam.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += new AForge.Video.NewFrameEventHandler(VideoCaptureDevice_NewFrame);
            videoCaptureDevice.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                //videoCaptureDevice.Stop();
            }
        }

        public string QRCodeResult { get; private set; }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (scanning && ptb_Image.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)ptb_Image.Image);
                if (result != null)
                {
                    QRCodeResult = result.ToString().Trim();
                    if (!string.IsNullOrEmpty(QRCodeResult))
                    {
                        IDsanpham.maspct = QRCodeResult;
                        timer1.Stop();
                        scanning = false;

                        // Gán giá trị mã QR quét được cho thuộc tính QRCodeResult
                        QRCodeResult = QRCodeResult;

                        // Đóng form con
                        Close();
                    }
                }
            }
        }

        private void btn_tatcam_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoCaptureDevice != null)
                {
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.SignalToStop();
                        videoCaptureDevice.WaitForStop();
                        ptb_Image.Image = null;
                        videoCaptureDevice = null;
                        scanning = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi dừng camera: " + ex.Message);
            }
        }
    }
}
