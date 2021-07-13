using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDmScreen.Migrations
{
    public partial class MoreDmTrackSelectionSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "DmTrackSelections",
                columns: new[] { "DmTrackSelectionId", "SpotifyTrack", "TrackName" },
                values: new object[,]
                {
                    { 2, "2EelmLcDmP1h1BuRUu7h7W", "City in the Clouds" },
                    { 3, "18O8Y4mZ2sNOBYBwBR1LVK", "Willow's Theme" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DmTrackSelections",
                keyColumn: "DmTrackSelectionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DmTrackSelections",
                keyColumn: "DmTrackSelectionId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6fe16174-2cb6-4cd9-a404-3fc34958fc76");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7ce638f7-3f60-4259-a10d-136d27b1a5ab");
        }
    }
}
