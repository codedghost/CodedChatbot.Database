using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCodedChatbot.Database.Migrations
{
    public partial class ChannelRewards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChannelRewards",
                columns: table => new
                {
                    ChannelRewardId = table.Column<Guid>(nullable: false),
                    RewardTitle = table.Column<string>(nullable: false),
                    RewardDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChannelRewards", x => x.ChannelRewardId);
                });

            migrationBuilder.CreateTable(
                name: "ChannelRewardRedemption",
                columns: table => new
                {
                    ChannelRewardRedemptionId = table.Column<Guid>(nullable: false),
                    ChannelRewardId = table.Column<Guid>(nullable: false),
                    RedeemedBy = table.Column<string>(nullable: false),
                    RedeemedAt = table.Column<DateTime>(nullable: false),
                    Processed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChannelRewardRedemption", x => x.ChannelRewardRedemptionId);
                    table.ForeignKey(
                        name: "FK_ChannelRewardRedemption_ChannelRewards_ChannelRewardId",
                        column: x => x.ChannelRewardId,
                        principalTable: "ChannelRewards",
                        principalColumn: "ChannelRewardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChannelRewardRedemption_ChannelRewardId",
                table: "ChannelRewardRedemption",
                column: "ChannelRewardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChannelRewardRedemption");

            migrationBuilder.DropTable(
                name: "ChannelRewards");
        }
    }
}
