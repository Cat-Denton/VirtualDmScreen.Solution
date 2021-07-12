using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDmScreen.Migrations
{
    public partial class AddResultToDiceRoll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Result",
                table: "DiceRolls",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Result",
                table: "DiceRolls");
        }
    }
}
