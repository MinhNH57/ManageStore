using Dự_án_1.BLL;
using Dự_án_1.BLL.Service;
using Dự_án_1.DAL.Models;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dự_án_1.GUI
{

    public partial class TK : UIForm
    {
        SPCTSer spct;
        HDCTSer hdct;
        HoaDonSer hd;
        public TK()
        {
            InitializeComponent();
            spct = new();
            hdct = new();
            hd = new HoaDonSer();
        }
        
        private async void TK_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                ThongKeSanPham();
            });

            await Task.Run(() =>
            {
                thongKeDoanhThu();
            });

            await Task.Run(() =>
            {
                thongKedonHang();
            });
            lbl_tongHD.Text = ThongKeDonHang(DateTime.Now.Month).ToString();
            tinhTangTruong();
            loadthongKeSanPham();
        }

        public void tinhTangTruong()
        {
            int thangTruoc = ThongKeDonHang(DateTime.Now.Month - 1);
            int thangSau = ThongKeDonHang(DateTime.Now.Month);
            int tangTruong = thangSau - thangTruoc;
            if(tangTruong >= 0)
            {
                lbl_tangTruong.Text = "+" + tangTruong.ToString();
            }
            else
            {
                Giamsut.Text = "-" + tangTruong.ToString();
            }
        }
        public int loadSlHangCon()
        {
            var q = spct.getAllSPCTSer().ToList();
            int slcon = 0;
            foreach (var i in q)
            {
                int sl = i.Soluong;
                slcon += sl;
            }
            return slcon;
        }

        public int loadSlhangbandi()
        {
            var q = hdct.getAllHDCTSer().ToList();
            int slbandi = 0;
            foreach (var i in q)
            {
                int sl = i.Soluong;
                slbandi += sl;
            }
            return slbandi;
        }

        public decimal loadDoanhThu()
        {
            var q = spct.getAllSPCTSer().ToList();
            decimal tongtientatca = 0;
            foreach (var item in q)
            {
                decimal donGia = item.Dongia;
                decimal s = donGia * item.Soluong;
                tongtientatca += s;
            }
            return tongtientatca;
        }
        public decimal loadtienthuve()
        {
            var q = hdct.getAllHDCTSer().ToList();
            decimal tongtienthuve = 0;
            foreach (var item in q)
            {
                decimal dongia = item.Dongia;
                tongtienthuve += dongia;
            }
            return tongtienthuve;
        }

        public void ThongKeSanPham()
        {
            var option = new UIPieOption();

            //设置Title
            option.Title = new UITitle();
            option.Title.Text = "Thống kê số lượng sản phẩm";
            option.Title.Left = UILeftAlignment.Center;

            //设置ToolTip
            option.ToolTip.Visible = true;

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Bottom;
            option.Legend.Left = UILeftAlignment.Left;

            option.Legend.AddData("Sản phẩm còn lại");
            option.Legend.AddData("Sản phẩm đã bán");

            //设置Series
            var series = new UIPieSeries();
            series.Name = "StarCount";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;
            series.Label.Show = true;

            //增加数据
            series.AddData("Sản phẩm còn lại", loadSlHangCon());
            series.AddData("Sản phẩm đã bán", loadSlhangbandi());

            //增加Series
            option.Series.Clear();
            option.Series.Add(series);

            //显示数据小数位数
            option.DecimalPlaces = 1;

            //设置Option
            uiPieChart1.SetOption(option);

            uiPieChart1.Enabled = true;
        }
        public void thongKeDoanhThu()
        {
            var option = new UIPieOption();

            // Thiết lập Title
            option.Title = new UITitle();
            option.Title.Text = "Thống kê doanh thu";
            option.Title.Left = UILeftAlignment.Center;

            // Thiết lập ToolTip
            option.ToolTip.Visible = true;

            // Thiết lập Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Bottom;
            option.Legend.Left = UILeftAlignment.Left;
            option.Legend.AddData("Doanh thu cần đạt");
            option.Legend.AddData("Doanh thu đã hoàn thành");

            // Tạo Series
            var series = new UIPieSeries();
            series.Name = "StarCount";
            series.Center = new UICenter(50, 55);
            series.Radius = 70;
            series.Label.Show = true;

            series.AddData("Doanh thu cần đạt", (double)loadDoanhThu());
            series.AddData("Doanh thu đã hoàn thành", (double)loadtienthuve());

            // Thêm Series vào Option
            option.Series.Clear();
            option.Series.Add(series);

            // Thiết lập số lượng chữ số sau dấu phẩy
            option.DecimalPlaces = 0;

            // Thiết lập Option cho biểu đồ
            uiPieChart2.SetOption(option);

            // Kích hoạt biểu đồ
            uiPieChart2.Enabled = true;

        }

        public int ThongKeDonHang(int moth)
        {
            var q = hd.getAllHoaDonSer().Where(x => x.Ngaythang.Month == moth && x.TinhTrang == "Đã thanh toán").Count();
            return q;
        }
        public void thongKedonHang()
        {
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "THỐNG KÊ ĐƠN HÀNG BÁN RA";

            var series = new UIBarSeries();
            series.Name = "Bar1";
            series.AddData(ThongKeDonHang(1));
            series.AddData(ThongKeDonHang(2));
            series.AddData(ThongKeDonHang(3));
            series.AddData(ThongKeDonHang(4));
            series.AddData(ThongKeDonHang(5));
            series.AddData(ThongKeDonHang(6));
            series.AddData(ThongKeDonHang(7));
            series.AddData(ThongKeDonHang(8));
            series.AddData(ThongKeDonHang(9));
            series.AddData(ThongKeDonHang(10));
            series.AddData(ThongKeDonHang(11));
            series.AddData(ThongKeDonHang(12));

            //数据显示小数位数
            series.DecimalPlaces = 0;
            option.Series.Add(series);

            option.XAxis.Data.Add("T1");
            option.XAxis.Data.Add("T2");
            option.XAxis.Data.Add("T3");
            option.XAxis.Data.Add("T4");
            option.XAxis.Data.Add("T5");
            option.XAxis.Data.Add("T6");
            option.XAxis.Data.Add("T7");
            option.XAxis.Data.Add("T8");
            option.XAxis.Data.Add("T9");
            option.XAxis.Data.Add("T10");
            option.XAxis.Data.Add("T11");
            option.XAxis.Data.Add("T12");

            option.ToolTip.Visible = true;
            option.YAxis.Scale = false;

            option.XAxis.Name = "Tháng";
            option.XAxis.AxisLabel.Angle = 0;//(0° ~ 90°)

            option.YAxis.Name = "Số đơn hàng bán được";
            //坐标轴显示小数位数
            option.YAxis.AxisLabel.DecimalPlaces = 0;

            //option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value = 100 });
            //option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value = 10 });

            option.ToolTip.AxisPointer.Type = UIAxisPointerType.Shadow;

            option.ShowValue = true;

            uiBarChart1.SetOption(option);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox3, "Tổng hóa đơn xuất ra");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Hóa đơn tăng so với tháng trước");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Hóa đơn giảm so với tháng trước");
        }

        public void loadthongKeSanPham()
        {
            var query = from j in hdct.getAllHDCTSer()
                        join i in spct.getAllSPCTSer() on j.Maspct equals i.Maspct
                        group j by (j.Maspct , i.Tenspct) into g
                        select new
                        {
                            /*ProductName = spct.getAllSPCTSer().Find(x => x.Maspct == g.Key).Tenspct*/
                            ProductName = g.Key.Tenspct,
                            QuantitySold = g.Sum(x => x.Soluong)
                        };

            // Khởi tạo danh sách để lưu trữ dữ liệu cho biểu đồ
            List<(string, int)> data = new List<(string, int)>();

            // Lặp qua kết quả của truy vấn và thêm dữ liệu vào danh sách
            foreach (var item in query)
            {
                data.Add((item.ProductName, item.QuantitySold));
            }
            var option = new UIDoughnutOption();

            //设置Title
            option.Title = new UITitle();
            option.Title.Text = "THỐNG KÊ LƯỢNG BÁN RA CỦA TỪNG SẢN PHẨM";
            option.Title.Left = UILeftAlignment.Center;

            //设置ToolTip
            option.ToolTip.Visible = true;

            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Bottom;
            option.Legend.Left = UILeftAlignment.Right;

            foreach(var item in data)
            {
                option.Legend.AddData(item.Item1);
            }


            //设置Series
            var series = new UIDoughnutSeries();
            series.Name = "StarCount";
            series.Center = new UICenter(50, 55);
            series.Radius.Inner = 40;
            series.Radius.Outer = 70;
            series.Label.Show = true;
            series.Label.Position = UIPieSeriesLabelPosition.Center;

            //增加数据
            foreach (var item in data)
            {
                series.AddData(item.Item1, item.Item2);
            }

            //增加Series
            option.Series.Clear();
            option.Series.Add(series);


            option.DecimalPlaces = 0;

            //设置Option
            uiDoughnutChart1.SetOption(option);
        }
    }

}
