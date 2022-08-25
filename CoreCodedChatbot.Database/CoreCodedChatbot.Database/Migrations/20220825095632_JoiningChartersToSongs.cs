using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCodedChatbot.Database.Migrations
{
    public partial class JoiningChartersToSongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Charters ([Name]) SELECT DISTINCT UploaderUsername FROM Songs");
            migrationBuilder.Sql(
                "UPDATE Songs SET Songs.CharterId = C.Id FROM Songs S INNER JOIN Charters C ON S.UploaderUsername = C.[Name]");

            migrationBuilder.DropColumn(
                name: "UploaderUsername",
                table: "Songs");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_CharterId",
                table: "Songs",
                column: "CharterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Charters_CharterId",
                table: "Songs",
                column: "CharterId",
                principalTable: "Charters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "UPDATE Songs SET Songs.UploaderUsername = C.[Name] FROM Songs S INNER JOIN Charters C ON S.CharterId = C.[Name]");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Charters_CharterId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_CharterId",
                table: "Songs");

            migrationBuilder.AddColumn<string>(
                name: "UploaderUsername",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
