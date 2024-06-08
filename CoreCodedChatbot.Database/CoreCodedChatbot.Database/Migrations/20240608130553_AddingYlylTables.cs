using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreCodedChatbot.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddingYlylTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YlylSessions",
                columns: table => new
                {
                    SessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OpenedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YlylSessions", x => x.SessionId);
                });

            migrationBuilder.CreateTable(
                name: "YlylSubmissions",
                columns: table => new
                {
                    SubmissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    ChannelId = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    MessageId = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    HasWon = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsImage = table.Column<bool>(type: "bit", nullable: false),
                    HasReceivedReward = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SubmissionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YlylRewardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YlylSubmissions", x => x.SubmissionId);
                    table.ForeignKey(
                        name: "FK_YlylSubmissions_YlylSessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "YlylSessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YlylRewards",
                columns: table => new
                {
                    RewardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsRedeemed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RewardValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YlylSubmissionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YlylRewards", x => x.RewardId);
                    table.ForeignKey(
                        name: "FK_YlylRewards_YlylSubmissions_YlylSubmissionId",
                        column: x => x.YlylSubmissionId,
                        principalTable: "YlylSubmissions",
                        principalColumn: "SubmissionId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_YlylRewards_YlylSubmissionId",
                table: "YlylRewards",
                column: "YlylSubmissionId",
                unique: true,
                filter: "[YlylSubmissionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_YlylSubmissions_SessionId",
                table: "YlylSubmissions",
                column: "SessionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YlylRewards");

            migrationBuilder.DropTable(
                name: "YlylSubmissions");

            migrationBuilder.DropTable(
                name: "YlylSessions");
        }
    }
}
