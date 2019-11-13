using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop2.Data.Migrations
{
    public partial class LMH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoaiMatHangs_GianHangs_GianHangId",
                table: "LoaiMatHangs");

            migrationBuilder.AlterColumn<int>(
                name: "GianHangId",
                table: "LoaiMatHangs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LoaiMatHangs_GianHangs_GianHangId",
                table: "LoaiMatHangs",
                column: "GianHangId",
                principalTable: "GianHangs",
                principalColumn: "GianHangId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoaiMatHangs_GianHangs_GianHangId",
                table: "LoaiMatHangs");

            migrationBuilder.AlterColumn<int>(
                name: "GianHangId",
                table: "LoaiMatHangs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_LoaiMatHangs_GianHangs_GianHangId",
                table: "LoaiMatHangs",
                column: "GianHangId",
                principalTable: "GianHangs",
                principalColumn: "GianHangId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
