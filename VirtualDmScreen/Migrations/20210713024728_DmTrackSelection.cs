using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDmScreen.Migrations
{
    public partial class DmTrackSelection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DmTrackSelection",
                columns: table => new
                {
                    DmTrackSelectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TrackName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SpotifyTrack = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DmTrackSelection", x => x.DmTrackSelectionId);
                });

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

            migrationBuilder.InsertData(
                table: "DmTrackSelection",
                columns: new[] { "DmTrackSelectionId", "SpotifyTrack", "TrackName" },
                values: new object[] { 1, "3ymKC2QCBeN3hMseX2hUYm", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DmTrackSelection");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f5ed44cb-1180-40a1-9bd7-40cb74788378");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1cf174a0-416a-4d1e-ac96-122143f41667");
        }
    }
}
