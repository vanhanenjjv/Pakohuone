using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pakohuone.Data.Migrations
{
    public partial class CreateLevelsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "Rooms",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Directory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_LevelId",
                table: "Rooms",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Levels_Directory",
                table: "Levels",
                column: "Directory",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Levels_Name",
                table: "Levels",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Levels_LevelId",
                table: "Rooms",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Levels_LevelId",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_LevelId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Rooms");
        }
    }
}
