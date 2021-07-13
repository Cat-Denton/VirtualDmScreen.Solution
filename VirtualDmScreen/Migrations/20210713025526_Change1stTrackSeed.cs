using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDmScreen.Migrations
{
    public partial class Change1stTrackSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "DmTrackSelection",
                keyColumn: "DmTrackSelectionId",
                keyValue: 1,
                columns: new[] { "SpotifyTrack", "TrackName" },
                values: new object[] { "7ob4BKZ9yFXI06HvQaUXvp", "Dragon Age" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "08f5b473-9513-4d97-a033-ab6fed1dc7db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "78db1960-b220-48c9-8459-4dddc3ae7cf9");

            migrationBuilder.UpdateData(
                table: "DmTrackSelection",
                keyColumn: "DmTrackSelectionId",
                keyValue: 1,
                columns: new[] { "SpotifyTrack", "TrackName" },
                values: new object[] { "3ymKC2QCBeN3hMseX2hUYm", null });
        }
    }
}
