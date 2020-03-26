using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCodedChatbot.Database.Migrations
{
    public partial class AddingCFDataFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlbumName",
                table: "Songs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CFId",
                table: "Songs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ChartedPaths",
                table: "Songs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DownloadUrl",
                table: "Songs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsOfficial",
                table: "Songs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TotalDownloads",
                table: "Songs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Tuning",
                table: "Songs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Songs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadedDateTime",
                table: "Songs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UploaderUsername",
                table: "Songs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Version",
                table: "Songs",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumName",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "CFId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "ChartedPaths",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "DownloadUrl",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "IsOfficial",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "TotalDownloads",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Tuning",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "UpdatedDateTime",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "UploadedDateTime",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "UploaderUsername",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Songs");
        }
    }
}
