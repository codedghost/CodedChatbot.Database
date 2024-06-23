using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreCodedChatbot.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddingUserIdToSubmissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "UserId",
                table: "YlylSubmissions",
                type: "decimal(20,0)",
                nullable: false,
                defaultValue: 1m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "YlylSubmissions");
        }
    }
}
