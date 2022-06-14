using Microsoft.EntityFrameworkCore.Migrations;

namespace eic_api_services.Migrations
{
    public partial class EICDtBase_Complete_Data_b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "MinisterioId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "MinisterioId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "MinisterioId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "MinisterioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "MinisterioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "MinisterioId",
                value: 1);
        }
    }
}
