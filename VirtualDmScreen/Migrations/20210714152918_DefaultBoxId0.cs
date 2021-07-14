using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDmScreen.Migrations
{
    public partial class DefaultBoxId0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0c005313-c8cf-4151-95a9-6b70ca765187");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c0de3de6-7809-4fe7-b3e0-cb0a669c8817");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3aa7ac7b-3b59-4345-8035-d16e13c34cf7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6dc36bd4-d5a8-4551-b4e9-caca51e9159b");
        }
    }
}
