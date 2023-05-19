using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreCodedChatbot.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddingCounterTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Counters",
                columns: table => new
                {
                    CounterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CounterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CounterSuffix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CounterValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counters", x => x.CounterId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Counters");
        }
    }
}
