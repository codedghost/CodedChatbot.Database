using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreCodedChatbot.Database.Migrations
{
    /// <inheritdoc />
    public partial class ChannelPointsVips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChannelPointVipRequests",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommandType",
                table: "ChannelRewards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChannelPointVipRequests",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CommandType",
                table: "ChannelRewards");
        }
    }
}
