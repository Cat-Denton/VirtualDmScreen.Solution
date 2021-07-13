using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDmScreen.Migrations
{
    public partial class DmTrackSelectionContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DmTrackSelection",
                table: "DmTrackSelection");

            migrationBuilder.RenameTable(
                name: "DmTrackSelection",
                newName: "DmTrackSelections");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DmTrackSelections",
                table: "DmTrackSelections",
                column: "DmTrackSelectionId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DmTrackSelections",
                table: "DmTrackSelections");

            migrationBuilder.RenameTable(
                name: "DmTrackSelections",
                newName: "DmTrackSelection");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DmTrackSelection",
                table: "DmTrackSelection",
                column: "DmTrackSelectionId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f211c219-22ea-45c2-b3d5-12b6c8df324a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2ee3ad88-cd91-46e6-8551-1de319409b71");
        }
    }
}
