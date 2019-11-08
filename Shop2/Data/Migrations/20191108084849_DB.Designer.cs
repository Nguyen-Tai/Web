﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop2.Data;

namespace Shop2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191108084849_DB")]
    partial class DB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Shop2.Models.ChiTietDonDatHang", b =>
                {
                    b.Property<int>("SanPhamId")
                        .HasColumnType("int");

                    b.Property<Guid>("DonDatHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("money");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TongCong")
                        .HasColumnType("money");

                    b.HasKey("SanPhamId", "DonDatHangId");

                    b.HasIndex("DonDatHangId");

                    b.ToTable("ChiTietDonDatHangs");
                });

            modelBuilder.Entity("Shop2.Models.DonDatHang", b =>
                {
                    b.Property<Guid>("DonDatHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChiNH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChiNH1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChiTT1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChiTT2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoaiNH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoaiTT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailKhachHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GhiChu")
                        .HasColumnType("bit");

                    b.Property<bool>("HoanTat")
                        .HasColumnType("bit");

                    b.Property<bool>("Huy")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("NgayGiao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenKhachHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguoiNH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguoiTT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("XacNhan")
                        .HasColumnType("bit");

                    b.HasKey("DonDatHangId");

                    b.ToTable("DonDatHangs");
                });

            modelBuilder.Entity("Shop2.Models.GianHang", b =>
                {
                    b.Property<int>("GianHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MoTaGH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenGianHang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GianHangId");

                    b.ToTable("GianHangs");
                });

            modelBuilder.Entity("Shop2.Models.HoSoTaiKhoan", b =>
                {
                    b.Property<Guid>("TaiKhoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreditCard")
                        .HasColumnType("ntext");

                    b.Property<string>("DiaChiNH1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChiNH2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChiTT1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChiTT2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoaiNH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoaiTT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguoiNH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguoiTT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaiKhoanId");

                    b.ToTable("HoSoTaiKhoans");
                });

            modelBuilder.Entity("Shop2.Models.LoaiMatHang", b =>
                {
                    b.Property<int>("MatHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GianHangId")
                        .HasColumnType("int");

                    b.Property<string>("MoTaMatHang")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TenMatHang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MatHangId");

                    b.HasIndex("GianHangId");

                    b.ToTable("LoaiMatHangs");
                });

            modelBuilder.Entity("Shop2.Models.SanPham", b =>
                {
                    b.Property<int>("SanPhamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<string>("MotaSP")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("NXB")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("NgayThem")
                        .HasColumnType("datetime2")
                        .HasMaxLength(50);

                    b.Property<string>("NgonNgu")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("TacGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSanPham")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SanPhamId");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("Shop2.Models.SanPhamMatHang", b =>
                {
                    b.Property<int>("MatHangId")
                        .HasColumnType("int");

                    b.Property<int>("SanPhamId")
                        .HasColumnType("int");

                    b.Property<int?>("LoaiMatHangMatHangId")
                        .HasColumnType("int");

                    b.HasKey("MatHangId", "SanPhamId");

                    b.HasIndex("LoaiMatHangMatHangId");

                    b.HasIndex("SanPhamId");

                    b.ToTable("SanPhamMatHangs");
                });

            modelBuilder.Entity("Shop2.Models.TaiKhoan", b =>
                {
                    b.Property<Guid>("TaiKhoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CauHoiBaoMat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CauTraLoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuyenTaiKhoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTaiKhoan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaiKhoanId");

                    b.ToTable("TaiKhoans");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop2.Models.ChiTietDonDatHang", b =>
                {
                    b.HasOne("Shop2.Models.DonDatHang", "DonDatHang")
                        .WithMany("ChiTietDonDatHangs")
                        .HasForeignKey("DonDatHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop2.Models.SanPham", "SanPham")
                        .WithMany("ChiTietDonDatHangs")
                        .HasForeignKey("SanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop2.Models.HoSoTaiKhoan", b =>
                {
                    b.HasOne("Shop2.Models.TaiKhoan", "TaiKhoan")
                        .WithOne("HoSoTaiKhoan")
                        .HasForeignKey("Shop2.Models.HoSoTaiKhoan", "TaiKhoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop2.Models.LoaiMatHang", b =>
                {
                    b.HasOne("Shop2.Models.GianHang", null)
                        .WithMany("LoaiMatHangs")
                        .HasForeignKey("GianHangId");
                });

            modelBuilder.Entity("Shop2.Models.SanPhamMatHang", b =>
                {
                    b.HasOne("Shop2.Models.LoaiMatHang", "LoaiMatHang")
                        .WithMany("SanPhamMatHangs")
                        .HasForeignKey("LoaiMatHangMatHangId");

                    b.HasOne("Shop2.Models.SanPham", "SanPham")
                        .WithMany("SanPhamMatHangs")
                        .HasForeignKey("SanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
