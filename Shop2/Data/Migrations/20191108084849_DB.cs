using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop2.Data.Migrations
{
    public partial class DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonDatHangs",
                columns: table => new
                {
                    DonDatHangId = table.Column<Guid>(nullable: false),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NgayGiao = table.Column<DateTime>(nullable: true),
                    XacNhan = table.Column<bool>(nullable: false),
                    HoanTat = table.Column<bool>(nullable: false),
                    Huy = table.Column<bool>(nullable: false),
                    GhiChu = table.Column<bool>(nullable: false),
                    TenKhachHang = table.Column<string>(nullable: true),
                    EmailKhachHang = table.Column<string>(nullable: true),
                    TenNguoiTT = table.Column<string>(nullable: true),
                    DiaChiTT1 = table.Column<string>(nullable: true),
                    DiaChiTT2 = table.Column<string>(nullable: true),
                    DienThoaiTT = table.Column<string>(nullable: true),
                    TenNguoiNH = table.Column<string>(nullable: true),
                    DiaChiNH1 = table.Column<string>(nullable: true),
                    DiaChiNH = table.Column<string>(nullable: true),
                    DienThoaiNH = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonDatHangs", x => x.DonDatHangId);
                });

            migrationBuilder.CreateTable(
                name: "GianHangs",
                columns: table => new
                {
                    GianHangId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGianHang = table.Column<string>(nullable: true),
                    MoTaGH = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GianHangs", x => x.GianHangId);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    SanPhamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(nullable: true),
                    MotaSP = table.Column<string>(maxLength: 1000, nullable: true),
                    Gia = table.Column<int>(nullable: false),
                    TacGia = table.Column<string>(nullable: true),
                    NXB = table.Column<string>(maxLength: 1000, nullable: true),
                    NgonNgu = table.Column<string>(maxLength: 1000, nullable: true),
                    NgayThem = table.Column<DateTime>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.SanPhamId);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    TaiKhoanId = table.Column<Guid>(nullable: false),
                    TenTaiKhoan = table.Column<string>(nullable: true),
                    QuyenTaiKhoan = table.Column<string>(nullable: true),
                    MatKhau = table.Column<string>(nullable: true),
                    CauHoiBaoMat = table.Column<string>(nullable: true),
                    CauTraLoi = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.TaiKhoanId);
                });

            migrationBuilder.CreateTable(
                name: "LoaiMatHangs",
                columns: table => new
                {
                    MatHangId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMatHang = table.Column<string>(nullable: true),
                    MoTaMatHang = table.Column<string>(maxLength: 50, nullable: true),
                    GianHangId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiMatHangs", x => x.MatHangId);
                    table.ForeignKey(
                        name: "FK_LoaiMatHangs_GianHangs_GianHangId",
                        column: x => x.GianHangId,
                        principalTable: "GianHangs",
                        principalColumn: "GianHangId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonDatHangs",
                columns: table => new
                {
                    SanPhamId = table.Column<int>(nullable: false),
                    DonDatHangId = table.Column<Guid>(nullable: false),
                    TenSanPham = table.Column<string>(nullable: true),
                    SoLuong = table.Column<int>(nullable: false),
                    DonGia = table.Column<decimal>(type: "money", nullable: false),
                    TongCong = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonDatHangs", x => new { x.SanPhamId, x.DonDatHangId });
                    table.ForeignKey(
                        name: "FK_ChiTietDonDatHangs_DonDatHangs_DonDatHangId",
                        column: x => x.DonDatHangId,
                        principalTable: "DonDatHangs",
                        principalColumn: "DonDatHangId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonDatHangs_SanPhams_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPhams",
                        principalColumn: "SanPhamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoSoTaiKhoans",
                columns: table => new
                {
                    TaiKhoanId = table.Column<Guid>(nullable: false),
                    CreditCard = table.Column<string>(type: "ntext", nullable: true),
                    TenNguoiTT = table.Column<string>(nullable: true),
                    DiaChiTT1 = table.Column<string>(nullable: true),
                    DiaChiTT2 = table.Column<string>(nullable: true),
                    DienThoaiTT = table.Column<string>(nullable: true),
                    TenNguoiNH = table.Column<string>(nullable: true),
                    DiaChiNH1 = table.Column<string>(nullable: true),
                    DiaChiNH2 = table.Column<string>(nullable: true),
                    DienThoaiNH = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoTaiKhoans", x => x.TaiKhoanId);
                    table.ForeignKey(
                        name: "FK_HoSoTaiKhoans_TaiKhoans_TaiKhoanId",
                        column: x => x.TaiKhoanId,
                        principalTable: "TaiKhoans",
                        principalColumn: "TaiKhoanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamMatHangs",
                columns: table => new
                {
                    SanPhamId = table.Column<int>(nullable: false),
                    MatHangId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamMatHangs", x => new { x.MatHangId, x.SanPhamId });
                    table.ForeignKey(
                        name: "FK_SanPhamMatHangs_LoaiMatHangs_MatHangId",
                        column: x => x.MatHangId,
                        principalTable: "LoaiMatHangs",
                        principalColumn: "MatHangId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPhamMatHangs_SanPhams_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPhams",
                        principalColumn: "SanPhamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonDatHangs_DonDatHangId",
                table: "ChiTietDonDatHangs",
                column: "DonDatHangId");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiMatHangs_GianHangId",
                table: "LoaiMatHangs",
                column: "GianHangId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamMatHangs_MatHangId",
                table: "SanPhamMatHangs",
                column: "MatHangId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamMatHangs_SanPhamId",
                table: "SanPhamMatHangs",
                column: "SanPhamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDonDatHangs");

            migrationBuilder.DropTable(
                name: "HoSoTaiKhoans");

            migrationBuilder.DropTable(
                name: "SanPhamMatHangs");

            migrationBuilder.DropTable(
                name: "DonDatHangs");

            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropTable(
                name: "LoaiMatHangs");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "GianHangs");
        }
    }
}
