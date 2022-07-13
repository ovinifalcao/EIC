using Microsoft.EntityFrameworkCore.Migrations;

namespace eic_api_services.Migrations
{
    public partial class fix_Services_Playlist_info : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServicoId",
                table: "Playlists_Info",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_Info_ServicoId",
                table: "Playlists_Info",
                column: "ServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_Info_Servicos_ServicoId",
                table: "Playlists_Info",
                column: "ServicoId",
                principalTable: "Servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_Info_Servicos_ServicoId",
                table: "Playlists_Info");

            migrationBuilder.DropIndex(
                name: "IX_Playlists_Info_ServicoId",
                table: "Playlists_Info");

            migrationBuilder.DropColumn(
                name: "ServicoId",
                table: "Playlists_Info");
        }
    }
}
