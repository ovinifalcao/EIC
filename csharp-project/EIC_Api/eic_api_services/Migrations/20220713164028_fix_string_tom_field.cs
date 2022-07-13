using Microsoft.EntityFrameworkCore.Migrations;

namespace eic_api_services.Migrations
{
    public partial class fix_string_tom_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tom",
                table: "Playlists_Info",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(1)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tom",
                table: "Playlists_Info",
                type: "varchar(1)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
