using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCodedChatbot.Database.Migrations
{
    public partial class AddingSongUrlVersionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SongUrlVersion",
                columns: table => new
                {
                    SongUrlVersionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongId = table.Column<int>(nullable: false),
                    Version = table.Column<decimal>(nullable: false),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongUrlVersion", x => x.SongUrlVersionId);
                    table.ForeignKey(
                        name: "FK_SongUrlVersion_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SongUrlVersion_SongId",
                table: "SongUrlVersion",
                column: "SongId");

            migrationBuilder.Sql(
                "INSERT INTO SongUrlVersion(SongId, Version, Url) SELECT SongId, Version, DownloadUrl FROM Songs");

            migrationBuilder.DropColumn(
                name: "DownloadUrl",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Songs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SongUrlVersion");

            migrationBuilder.Sql(
                "INSERT INTO Songs(SongId, Version, Url) SELECT SongId, Version, DownloadUrl FROM SongUrlVersion");

            migrationBuilder.AddColumn<string>(
                name: "DownloadUrl",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Version",
                table: "Songs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
