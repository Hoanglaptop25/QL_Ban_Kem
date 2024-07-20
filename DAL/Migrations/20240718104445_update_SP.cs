using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class update_SP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sanPhams_loaiSanPhams_IdLoaiSp",
                table: "sanPhams");

            migrationBuilder.DropIndex(
                name: "IX_sanPhams_IdLoaiSp",
                table: "sanPhams");

            migrationBuilder.AddColumn<int>(
                name: "SanPhamId",
                table: "loaiSanPhams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_loaiSanPhams_SanPhamId",
                table: "loaiSanPhams",
                column: "SanPhamId");

            migrationBuilder.AddForeignKey(
                name: "FK_loaiSanPhams_sanPhams_SanPhamId",
                table: "loaiSanPhams",
                column: "SanPhamId",
                principalTable: "sanPhams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_loaiSanPhams_sanPhams_SanPhamId",
                table: "loaiSanPhams");

            migrationBuilder.DropIndex(
                name: "IX_loaiSanPhams_SanPhamId",
                table: "loaiSanPhams");

            migrationBuilder.DropColumn(
                name: "SanPhamId",
                table: "loaiSanPhams");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_IdLoaiSp",
                table: "sanPhams",
                column: "IdLoaiSp",
                unique: true,
                filter: "[IdLoaiSp] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_sanPhams_loaiSanPhams_IdLoaiSp",
                table: "sanPhams",
                column: "IdLoaiSp",
                principalTable: "loaiSanPhams",
                principalColumn: "Id");
        }
    }
}
