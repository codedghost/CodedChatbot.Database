using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreCodedChatbot.Database.Migrations
{
    /// <inheritdoc />
    public partial class ChangingCounterKeyToName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Counters",
                table: "Counters");

            migrationBuilder.DropColumn(
                name: "CounterId",
                table: "Counters");

            migrationBuilder.AlterColumn<string>(
                name: "CounterName",
                table: "Counters",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Counters",
                table: "Counters",
                column: "CounterName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Counters",
                table: "Counters");

            migrationBuilder.AlterColumn<string>(
                name: "CounterName",
                table: "Counters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "CounterId",
                table: "Counters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Counters",
                table: "Counters",
                column: "CounterId");
        }
    }
}
