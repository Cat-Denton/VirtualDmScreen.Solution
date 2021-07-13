using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDmScreen.Migrations
{
    public partial class DmChoices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DmChoices",
                columns: table => new
                {
                    DmChoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DmTrackSelectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DmChoices", x => x.DmChoiceId);
                    table.ForeignKey(
                        name: "FK_DmChoices_DmTrackSelections_DmTrackSelectionId",
                        column: x => x.DmTrackSelectionId,
                        principalTable: "DmTrackSelections",
                        principalColumn: "DmTrackSelectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c9f0cef3-d7eb-48f7-b5bb-4cbae37ad304");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "495afe0a-be57-47e8-a355-82fc19fbce4d");

            migrationBuilder.CreateIndex(
                name: "IX_DmChoices_DmTrackSelectionId",
                table: "DmChoices",
                column: "DmTrackSelectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DmChoices");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "67a4c23f-e47e-442f-a233-d32f95ce05ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b8281bd0-5ae7-4d56-b3ad-708ef3a5e71b");
        }
    }
}
