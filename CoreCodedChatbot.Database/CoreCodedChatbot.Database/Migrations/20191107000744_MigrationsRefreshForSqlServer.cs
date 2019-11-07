using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCodedChatbot.Database.Migrations
{
    public partial class MigrationsRefreshForSqlServer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InfoCommands",
                columns: table => new
                {
                    InfoCommandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InfoText = table.Column<string>(nullable: false),
                    InfoHelpText = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoCommands", x => x.InfoCommandId);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingName = table.Column<string>(nullable: false),
                    SettingValue = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingId);
                });

            migrationBuilder.CreateTable(
                name: "SongGuessingRecord",
                columns: table => new
                {
                    SongGuessingRecordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongDetails = table.Column<string>(nullable: false),
                    FinalPercentage = table.Column<decimal>(nullable: false),
                    UsersCanGuess = table.Column<bool>(nullable: false),
                    IsInProgress = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongGuessingRecord", x => x.SongGuessingRecordId);
                });

            migrationBuilder.CreateTable(
                name: "SongRequests",
                columns: table => new
                {
                    SongRequestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestUsername = table.Column<string>(maxLength: 255, nullable: false),
                    SongId = table.Column<int>(nullable: false),
                    RequestTime = table.Column<DateTime>(nullable: false),
                    Played = table.Column<bool>(nullable: false),
                    InDrive = table.Column<bool>(nullable: false),
                    VipRequestTime = table.Column<DateTime>(nullable: true),
                    SuperVipRequestTime = table.Column<DateTime>(nullable: true),
                    RequestText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongRequests", x => x.SongRequestId);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongName = table.Column<string>(nullable: false),
                    SongArtist = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                });

            migrationBuilder.CreateTable(
                name: "StreamStatuses",
                columns: table => new
                {
                    StreamStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BroadcasterUsername = table.Column<string>(nullable: false),
                    IsOnline = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreamStatuses", x => x.StreamStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(nullable: false),
                    UsedVipRequests = table.Column<int>(nullable: false),
                    UsedSuperVipRequests = table.Column<int>(nullable: false, defaultValue: 0),
                    SendgiftVipRequests = table.Column<int>(nullable: false, defaultValue: 0),
                    ModGivenVipRequests = table.Column<int>(nullable: false),
                    FollowVipRequest = table.Column<int>(nullable: false),
                    SubVipRequests = table.Column<int>(nullable: false),
                    DonationOrBitsVipRequests = table.Column<int>(nullable: false),
                    ReceivedGiftVipRequests = table.Column<int>(nullable: false, defaultValue: 0),
                    TokenVipRequests = table.Column<int>(nullable: false),
                    TokenBytes = table.Column<int>(nullable: false),
                    TotalBitsDropped = table.Column<int>(nullable: false),
                    TotalDonated = table.Column<int>(nullable: false),
                    TimeLastInChat = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "InfoCommandKeywords",
                columns: table => new
                {
                    InfoCommandKeywordText = table.Column<string>(nullable: false),
                    InfoCommandId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoCommandKeywords", x => new { x.InfoCommandId, x.InfoCommandKeywordText });
                    table.ForeignKey(
                        name: "FK_InfoCommandKeywords_InfoCommands_InfoCommandId",
                        column: x => x.InfoCommandId,
                        principalTable: "InfoCommands",
                        principalColumn: "InfoCommandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SongPercentageGuess",
                columns: table => new
                {
                    SongPercentageGuessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongGuessingRecordId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Guess = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongPercentageGuess", x => x.SongPercentageGuessId);
                    table.ForeignKey(
                        name: "FK_SongPercentageGuess_SongGuessingRecord_SongGuessingRecordId",
                        column: x => x.SongGuessingRecordId,
                        principalTable: "SongGuessingRecord",
                        principalColumn: "SongGuessingRecordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SongPercentageGuess_SongGuessingRecordId",
                table: "SongPercentageGuess",
                column: "SongGuessingRecordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfoCommandKeywords");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "SongPercentageGuess");

            migrationBuilder.DropTable(
                name: "SongRequests");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "StreamStatuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "InfoCommands");

            migrationBuilder.DropTable(
                name: "SongGuessingRecord");
        }
    }
}
