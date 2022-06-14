using Microsoft.EntityFrameworkCore.Migrations;

namespace eic_api_services.Migrations
{
    public partial class EICDtBase_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ministerios",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "Louvor" },
                    { 2, "Mídias" },
                    { 3, "Sonoplastia" }
                });

            migrationBuilder.InsertData(
                table: "Platformas",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "Spotify" },
                    { 2, "Youtube" },
                    { 3, "Deezer" }
                });

            migrationBuilder.InsertData(
                table: "Funcoes",
                columns: new[] { "Id", "Descricao", "MinisterioId" },
                values: new object[] { 1, "Voz", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ministerios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ministerios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Platformas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Platformas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Platformas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ministerios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
