using Microsoft.EntityFrameworkCore.Migrations;

namespace eic_api_services.Migrations
{
    public partial class EICDtBase_Complete_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Funcoes",
                columns: new[] { "Id", "Descricao", "MinisterioId" },
                values: new object[,]
                {
                    { 2, "Violão", 1 },
                    { 3, "Guitarra", 1 },
                    { 4, "Bateria", 1 },
                    { 5, "Baixo", 1 },
                    { 6, "Teclado", 1 },
                    { 7, "Cajon", 1 },
                    { 8, "Fotografia", 1 },
                    { 9, "Projeção", 1 },
                    { 10, "Transmicao", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
