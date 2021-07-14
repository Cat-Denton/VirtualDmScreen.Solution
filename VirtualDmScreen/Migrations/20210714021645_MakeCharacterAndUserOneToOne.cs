using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDmScreen.Migrations
{
    public partial class MakeCharacterAndUserOneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_AspNetUsers_UserId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_UserId",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Characters",
                newName: "ApplicationUserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7574d767-72ae-4325-8846-c19d4ca30299");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b6d90467-ba9c-4393-923e-6b1dd3509594");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ApplicationUserId",
                table: "Characters",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_AspNetUsers_ApplicationUserId",
                table: "Characters",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_AspNetUsers_ApplicationUserId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_ApplicationUserId",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Characters",
                newName: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_AspNetUsers_UserId",
                table: "Characters",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
