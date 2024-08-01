using Dự_án_1;
using Dự_án_1.DAL;
using Dự_án_1.DAL.Models;
using Dự_án_1.GUI;
using Dự_án_1.BLL;
using Dự_án_1.DAL.Repositories;
using System.Collections.ObjectModel;
using NUnit.Framework.Legacy;
using Sunny.UI.Win32;
using Bogus;
using Microsoft.EntityFrameworkCore;
namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        private DUAN1NHOMContext _db;
        private KhachHang _khachHang;
        private Faker<Kh> _faker;

        public List<Kh> Customer;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<DUAN1NHOMContext>()
                .UseSqlite("Filename=:memory:")
                .Options;

            _db = new DUAN1NHOMContext(options);
            _db.Database.OpenConnection();
            _db.Database.EnsureCreated();

            _khachHang = new KhachHang(_db);
            _faker = new Faker<Kh>()
                .RuleFor(k => k.Makh, f => f.Random.AlphaNumeric(10))
                .RuleFor(k => k.Tenkh, f => f.Name.FullName())
                .RuleFor(k => k.Diachi, f => f.Address.FullAddress())
                .RuleFor(k => k.Sdt, f => f.Phone.PhoneNumber());
        }

        [TearDown]
        public void TearDown()
        {
            _db.Dispose();
        }

        [Test]
        public void CreateKH_ThanhCong()
        {
            // Arrange
            Kh khachhang = _faker.Generate();
            khachhang.Sdt = "0981688581";

            // Act
            var result = _khachHang.CreateKHres(khachhang);

            // Reload the Customer list
            var customerList = _db.Khs.ToList();

            
            CollectionAssert.Contains(customerList, khachhang);
        }
        [Test]
        public void CreateKH_KhongThanhcong_SdtKhongHople()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DUAN1NHOMContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using var context = new DUAN1NHOMContext(options);
            var khachHang = new KhachHang(context);

            var khachhang = new Kh()
            {
                Makh = "MinhNH01",
                Tenkh = "Nguyen Hong Minh",
                Diachi = "Vinh Loc",
                Sdt = "0981" // Số điện thoại không hợp lệ
            };

            // Act & Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => khachHang.CreateKHres(khachhang));
            Assert.That(ex.Message, Is.EqualTo("Số điện thoại phải có ít nhất 10 ký tự. (Parameter 'Sdt')"));
        }

        [Test]
        public void CreateKH_KhongThanhcong_SdtKhongTren10KyTu()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DUAN1NHOMContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using var context = new DUAN1NHOMContext(options);
            var khachHang = new KhachHang(context);

            var khachhang = new Kh()
            {
                Makh = "MinhNH01",
                Tenkh = "Nguyen Hong Minh",
                Diachi = "Vinh Loc",
                Sdt = "09816885837" // Số điện thoại không hợp lệ
            };

            // Act & Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => khachHang.CreateKHres(khachhang));
            Assert.That(ex.Message, Is.EqualTo("Số điện thoại phải có ít nhất 10 ký tự. (Parameter 'Sdt')"));
        }



    }
}