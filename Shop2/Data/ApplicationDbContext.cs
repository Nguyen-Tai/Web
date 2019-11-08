using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop2.Models;

namespace Shop2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
        public DbSet<DonDatHang> DonDatHangs { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<HoSoTaiKhoan> HoSoTaiKhoans { get; set; }
        public DbSet<GianHang> GianHangs { get; set; }
        public DbSet<LoaiMatHang> LoaiMatHangs { get; set; }
        public DbSet<SanPhamMatHang> SanPhamMatHangs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SanPhamMatHang>().HasKey(spmh => new { spmh.MatHangId, spmh.SanPhamId });
            modelBuilder.Entity<ChiTietDonDatHang>().HasKey(ct => new { ct.SanPhamId,ct.DonDatHangId});

        }
    }
}
