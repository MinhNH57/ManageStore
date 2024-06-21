using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dự_án_1.DAL.Models
{
    public partial class DUAN1NHOMContext : DbContext
    {
        public DUAN1NHOMContext()
        {
        }

        public DUAN1NHOMContext(DbContextOptions<DUAN1NHOMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hdct> Hdcts { get; set; } = null!;
        public virtual DbSet<Hoadon> Hoadons { get; set; } = null!;
        public virtual DbSet<Kh> Khs { get; set; } = null!;
        public virtual DbSet<Km> Kms { get; set; } = null!;
        public virtual DbSet<Kmct> Kmcts { get; set; } = null!;
        public virtual DbSet<M> Ms { get; set; } = null!;
        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;
        public virtual DbSet<Size> Sizes { get; set; } = null!;
        public virtual DbSet<Spct> Spcts { get; set; } = null!;
        public virtual DbSet<Th> Ths { get; set; } = null!;
        public virtual DbSet<Vat> Vats { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=DUAN1-NHOM!;Trusted_Connection=True; TrustServerCertificate =True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hdct>(entity =>
            {
                entity.HasKey(e => e.Idhdct)
                    .HasName("PK__HDCT__F8B336775CE92C1B");

                entity.ToTable("HDCT");

                entity.Property(e => e.Idhdct)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IDHDCT");

                entity.Property(e => e.Dongia)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DONGIA");

                entity.Property(e => e.Mahd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAHD");

                entity.Property(e => e.Makm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAKM");

                entity.Property(e => e.Maspct)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASPCT");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.HasOne(d => d.MahdNavigation)
                    .WithMany(p => p.Hdcts)
                    .HasForeignKey(d => d.Mahd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HDCT_HOADON");

                entity.HasOne(d => d.MakmNavigation)
                    .WithMany(p => p.Hdcts)
                    .HasForeignKey(d => d.Makm)
                    .HasConstraintName("FK_HDCT_KM");

                entity.HasOne(d => d.MaspctNavigation)
                    .WithMany(p => p.Hdcts)
                    .HasForeignKey(d => d.Maspct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HDCT_SPCT");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.Mahd)
                    .HasName("PK__HOADON__603F20CE8F16DC1D");

                entity.ToTable("HOADON");

                entity.Property(e => e.Mahd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAHD");

                entity.Property(e => e.Makh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAKH");

                entity.Property(e => e.Manv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANV");

                entity.Property(e => e.Ngaythang)
                    .HasColumnType("date")
                    .HasColumnName("NGAYTHANG");

                entity.Property(e => e.Thanhtoan)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("THANHTOAN");

                entity.Property(e => e.Thoigiancapnhat)
                    .HasColumnType("date")
                    .HasColumnName("THOIGIANCAPNHAT");

                entity.Property(e => e.TinhTrang).HasMaxLength(20);

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Makh)
                    .HasConstraintName("FK_HOADON_KH");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HOADON_NHANVIEN");
            });

            modelBuilder.Entity<Kh>(entity =>
            {
                entity.HasKey(e => e.Makh)
                    .HasName("PK__KH__603F592C65FF794C");

                entity.ToTable("KH");

                entity.Property(e => e.Makh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAKH");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(100)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(50)
                    .HasColumnName("TENKH");
            });

            modelBuilder.Entity<Km>(entity =>
            {
                entity.HasKey(e => e.Makm)
                    .HasName("PK__KM__603F592B2F085E93");

                entity.ToTable("KM");

                entity.Property(e => e.Makm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAKM");

                entity.Property(e => e.Ngaybatdau)
                    .HasColumnType("date")
                    .HasColumnName("NGAYBATDAU");

                entity.Property(e => e.Ngayketthuc)
                    .HasColumnType("date")
                    .HasColumnName("NGAYKETTHUC");

                entity.Property(e => e.Slgiam).HasColumnName("SLGIAM");

                entity.Property(e => e.Tenkm)
                    .HasMaxLength(100)
                    .HasColumnName("TENKM");

                entity.Property(e => e.TinhTrang)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kmct>(entity =>
            {
                entity.HasKey(e => e.Makmct);

                entity.ToTable("KMCT");

                entity.Property(e => e.Makmct)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAKMCT");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(100)
                    .HasColumnName("GHICHU");

                entity.Property(e => e.Makm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAKM");

                entity.Property(e => e.Maspct)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASPCT");

                entity.HasOne(d => d.MakmNavigation)
                    .WithMany(p => p.Kmcts)
                    .HasForeignKey(d => d.Makm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KMCT_KM");

                entity.HasOne(d => d.MaspctNavigation)
                    .WithMany(p => p.Kmcts)
                    .HasForeignKey(d => d.Maspct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KMCT_MASPCT");
            });

            modelBuilder.Entity<M>(entity =>
            {
                entity.HasKey(e => e.Mamau)
                    .HasName("PK__MS__7B7346CFCF422F40");

                entity.ToTable("MS");

                entity.Property(e => e.Mamau)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAMAU");

                entity.Property(e => e.Tenmau)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TENMAU");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manv)
                    .HasName("PK__NHANVIEN__603F5114A0C0B74D");

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.Manv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANV");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cccd");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(100)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(10)
                    .HasColumnName("GIOITINH");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATKHAU");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("NGAYSINH");

                entity.Property(e => e.Quyen)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QUYEN");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TAIKHOAN");

                entity.Property(e => e.Tennv)
                    .HasMaxLength(50)
                    .HasColumnName("TENNV");

                entity.Property(e => e.Tinhtrang)
                    .HasMaxLength(50)
                    .HasColumnName("TINHTRANG");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.Masp)
                    .HasName("PK__SANPHAM__60228A32A10CEB20");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.Masp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASP");

                entity.Property(e => e.Chatlieu)
                    .HasMaxLength(10)
                    .HasColumnName("CHATLIEU");

                entity.Property(e => e.LoaiCoAo)
                    .HasMaxLength(50)
                    .HasColumnName("loaiCoAo");

                entity.Property(e => e.Loaichanquan)
                    .HasMaxLength(50)
                    .HasColumnName("loaichanquan");

                entity.Property(e => e.Loaisp)
                    .HasMaxLength(10)
                    .HasColumnName("LOAISP");

                entity.Property(e => e.Math)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATH");

                entity.Property(e => e.Tensp)
                    .HasMaxLength(50)
                    .HasColumnName("TENSP");

                entity.Property(e => e.Tt)
                    .HasMaxLength(10)
                    .HasColumnName("TT");

                entity.HasOne(d => d.MathNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.Math)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SANPHAM_TH");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.HasKey(e => e.Masize)
                    .HasName("PK__SIZE__3DD4402BE8D56AF7");

                entity.ToTable("SIZE");

                entity.Property(e => e.Masize)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASIZE");

                entity.Property(e => e.Hangcan).HasColumnName("HANGCAN");

                entity.Property(e => e.Mota)
                    .HasMaxLength(100)
                    .HasColumnName("MOTA");

                entity.Property(e => e.Tensize)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TENSIZE");
            });

            modelBuilder.Entity<Spct>(entity =>
            {
                entity.HasKey(e => e.Maspct)
                    .HasName("PK__SPCT__3D158D86F5F6BFFB");

                entity.ToTable("SPCT");

                entity.Property(e => e.Maspct)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASPCT");

                entity.Property(e => e.Dongia)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("DONGIA");

                entity.Property(e => e.HinhAnh).HasColumnType("image");

                entity.Property(e => e.Mamau)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAMAU");

                entity.Property(e => e.Masize)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASIZE");

                entity.Property(e => e.Masp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASP");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tenspct)
                    .HasMaxLength(50)
                    .HasColumnName("TENSPCT");

                entity.Property(e => e.Tt)
                    .HasMaxLength(20)
                    .HasColumnName("TT");

                entity.HasOne(d => d.MamauNavigation)
                    .WithMany(p => p.Spcts)
                    .HasForeignKey(d => d.Mamau)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPCT_MS");

                entity.HasOne(d => d.MasizeNavigation)
                    .WithMany(p => p.Spcts)
                    .HasForeignKey(d => d.Masize)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPCT_SIZE");

                entity.HasOne(d => d.MaspNavigation)
                    .WithMany(p => p.Spcts)
                    .HasForeignKey(d => d.Masp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPCT_SANPHAM");
            });

            modelBuilder.Entity<Th>(entity =>
            {
                entity.HasKey(e => e.Math)
                    .HasName("PK__TH__6023721BAE517695");

                entity.ToTable("TH");

                entity.Property(e => e.Math)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATH");

                entity.Property(e => e.Namtl).HasColumnName("NAMTL");

                entity.Property(e => e.Quocgia)
                    .HasMaxLength(20)
                    .HasColumnName("QUOCGIA");

                entity.Property(e => e.Tenth)
                    .HasMaxLength(50)
                    .HasColumnName("TENTH");
            });

            modelBuilder.Entity<Vat>(entity =>
            {
                entity.HasKey(e => e.MaVat)
                    .HasName("PK__VAT__31CE85BD45274C41");

                entity.ToTable("VAT");

                entity.Property(e => e.MaVat).ValueGeneratedNever();

                entity.Property(e => e.TinhTrang).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
