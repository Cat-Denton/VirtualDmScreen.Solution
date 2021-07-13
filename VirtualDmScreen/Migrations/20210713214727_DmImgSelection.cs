using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDmScreen.Migrations
{
    public partial class DmImgSelection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DmImgSelectionId",
                table: "DmChoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DmImgSelections",
                columns: table => new
                {
                    DmImgSelectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ImgName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ImgPath = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DmImgSelections", x => x.DmImgSelectionId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ec976d2a-96d5-485f-b2be-7f86c5187c48");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "20d0c3b3-8aa8-4583-8ca7-3012bfbb8bac");

            migrationBuilder.InsertData(
                table: "DmImgSelections",
                columns: new[] { "DmImgSelectionId", "ImgName", "ImgPath" },
                values: new object[,]
                {
                    { 1, "Party of Adventurers", "/img/party.jpg" },
                    { 2, "White Dragon", "/img/whitedragon.jpg" },
                    { 3, "Red Dragon", "/img/reddragon.jpg" },
                    { 4, "Fire Breathing Dragon", "/img/firebreath.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "DmChoices",
                keyColumn: "DmChoiceId",
                keyValue: 1,
                column: "DmImgSelectionId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_DmChoices_DmImgSelectionId",
                table: "DmChoices",
                column: "DmImgSelectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_DmChoices_DmImgSelections_DmImgSelectionId",
                table: "DmChoices",
                column: "DmImgSelectionId",
                principalTable: "DmImgSelections",
                principalColumn: "DmImgSelectionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DmChoices_DmImgSelections_DmImgSelectionId",
                table: "DmChoices");

            migrationBuilder.DropTable(
                name: "DmImgSelections");

            migrationBuilder.DropIndex(
                name: "IX_DmChoices_DmImgSelectionId",
                table: "DmChoices");

            migrationBuilder.DropColumn(
                name: "DmImgSelectionId",
                table: "DmChoices");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "14a4be72-d5ed-41c7-a4d8-1d5af90428d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d9035dbb-7381-496f-81d8-94570fe74e97");
        }
    }
}
