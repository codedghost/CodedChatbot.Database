using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreCodedChatbot.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddingYlylEntriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YlylRewards_YlylSubmissions_YlylSubmissionId",
                table: "YlylRewards");

            migrationBuilder.DropIndex(
                name: "IX_YlylRewards_YlylSubmissionId",
                table: "YlylRewards");

            migrationBuilder.DropColumn(
                name: "HasReceivedReward",
                table: "YlylSubmissions");

            migrationBuilder.DropColumn(
                name: "HasWon",
                table: "YlylSubmissions");

            migrationBuilder.DropColumn(
                name: "IsImage",
                table: "YlylSubmissions");

            migrationBuilder.DropColumn(
                name: "YlylRewardId",
                table: "YlylSubmissions");

            migrationBuilder.RenameColumn(
                name: "YlylSubmissionId",
                table: "YlylRewards",
                newName: "YlylEntryId");

            migrationBuilder.CreateTable(
                name: "YlylEntries",
                columns: table => new
                {
                    EntryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YlylSubmissionId = table.Column<int>(type: "int", nullable: false),
                    HasWon = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsImage = table.Column<bool>(type: "bit", nullable: false),
                    HasReceivedReward = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    YlylRewardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YlylEntries", x => x.EntryId);
                    table.ForeignKey(
                        name: "FK_YlylEntries_YlylSubmissions_YlylSubmissionId",
                        column: x => x.YlylSubmissionId,
                        principalTable: "YlylSubmissions",
                        principalColumn: "SubmissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YlylRewards_YlylEntryId",
                table: "YlylRewards",
                column: "YlylEntryId",
                unique: true,
                filter: "[YlylEntryId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_YlylEntries_YlylSubmissionId",
                table: "YlylEntries",
                column: "YlylSubmissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_YlylRewards_YlylEntries_YlylEntryId",
                table: "YlylRewards",
                column: "YlylEntryId",
                principalTable: "YlylEntries",
                principalColumn: "EntryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YlylRewards_YlylEntries_YlylEntryId",
                table: "YlylRewards");

            migrationBuilder.DropTable(
                name: "YlylEntries");

            migrationBuilder.DropIndex(
                name: "IX_YlylRewards_YlylEntryId",
                table: "YlylRewards");

            migrationBuilder.RenameColumn(
                name: "YlylEntryId",
                table: "YlylRewards",
                newName: "YlylSubmissionId");

            migrationBuilder.AddColumn<bool>(
                name: "HasReceivedReward",
                table: "YlylSubmissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasWon",
                table: "YlylSubmissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsImage",
                table: "YlylSubmissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "YlylRewardId",
                table: "YlylSubmissions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_YlylRewards_YlylSubmissionId",
                table: "YlylRewards",
                column: "YlylSubmissionId",
                unique: true,
                filter: "[YlylSubmissionId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_YlylRewards_YlylSubmissions_YlylSubmissionId",
                table: "YlylRewards",
                column: "YlylSubmissionId",
                principalTable: "YlylSubmissions",
                principalColumn: "SubmissionId");
        }
    }
}
