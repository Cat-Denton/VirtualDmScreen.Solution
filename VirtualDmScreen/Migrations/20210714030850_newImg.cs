using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDmScreen.Migrations
{
    public partial class newImg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6e6320bd-ed2e-4e45-bf22-b19bccc4afbd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e37b5115-029b-4561-b735-e8a657b44143");

            migrationBuilder.InsertData(
                table: "DmImgSelections",
                columns: new[] { "DmImgSelectionId", "ImgName", "ImgPath" },
                values: new object[] { 5, "Age of Sigmar", "/img/AgeOfSigmar.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DmImgSelections",
                keyColumn: "DmImgSelectionId",
                keyValue: 5);

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
        }
    }
}
