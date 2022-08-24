using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCodedChatbot.Database.Migrations
{
    public partial class AddingSongLinkToSongRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SongId",
                table: "SongRequests",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.Sql("UPDATE SongRequests SET SongId = NULL WHERE SongId = 0");

            migrationBuilder.CreateIndex(
                name: "IX_SongRequests_SongId",
                table: "SongRequests",
                column: "SongId");

            migrationBuilder.AddForeignKey(
                name: "FK_SongRequests_Songs_SongId",
                table: "SongRequests",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SongRequests_Songs_SongId",
                table: "SongRequests");

            migrationBuilder.DropIndex(
                name: "IX_SongRequests_SongId",
                table: "SongRequests");

            migrationBuilder.AlterColumn<int>(
                name: "SongId",
                table: "SongRequests",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true,
                defaultValue: 0);
        }
    }
}
