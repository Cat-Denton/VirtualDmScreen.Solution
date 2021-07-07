using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualDmScreen.Migrations
{
    public partial class ChangePlayerToCharacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiceRolls_Players_PlayerId",
                table: "DiceRolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Players_PlayerId",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Messages",
                newName: "CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_PlayerId",
                table: "Messages",
                newName: "IX_Messages_CharacterId");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "DiceRolls",
                newName: "CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_DiceRolls_PlayerId",
                table: "DiceRolls",
                newName: "IX_DiceRolls_CharacterId");

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsDm = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiceRolls_Characters_CharacterId",
                table: "DiceRolls",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Characters_CharacterId",
                table: "Messages",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiceRolls_Characters_CharacterId",
                table: "DiceRolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Characters_CharacterId",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "Messages",
                newName: "PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_CharacterId",
                table: "Messages",
                newName: "IX_Messages_PlayerId");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "DiceRolls",
                newName: "PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_DiceRolls_CharacterId",
                table: "DiceRolls",
                newName: "IX_DiceRolls_PlayerId");

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsDm = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DiceRolls_Players_PlayerId",
                table: "DiceRolls",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Players_PlayerId",
                table: "Messages",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
