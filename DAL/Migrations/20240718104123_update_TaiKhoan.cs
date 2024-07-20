using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class update_TaiKhoan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiets_TaiKhoans_TaiKhoanId",
                table: "HoaDonChiTiets");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonChiTiets_TaiKhoanId",
                table: "HoaDonChiTiets");

            migrationBuilder.DropColumn(
                name: "TaiKhoanId",
                table: "HoaDonChiTiets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TaiKhoanId",
                table: "HoaDonChiTiets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_TaiKhoanId",
                table: "HoaDonChiTiets",
                column: "TaiKhoanId");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiets_TaiKhoans_TaiKhoanId",
                table: "HoaDonChiTiets",
                column: "TaiKhoanId",
                principalTable: "TaiKhoans",
                principalColumn: "Id");
        }
    }
}
