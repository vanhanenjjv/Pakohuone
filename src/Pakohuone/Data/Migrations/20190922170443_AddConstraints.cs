using Microsoft.EntityFrameworkCore.Migrations;

namespace Pakohuone.Data.Migrations
{
    public partial class AddConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Worlds_WorldId",
                table: "Rooms");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Worlds",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Directory",
                table: "Worlds",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WorldId",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Levels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Directory",
                table: "Levels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Worlds_WorldId",
                table: "Rooms",
                column: "WorldId",
                principalTable: "Worlds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Worlds_WorldId",
                table: "Rooms");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Worlds",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Directory",
                table: "Worlds",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "WorldId",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Levels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Directory",
                table: "Levels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Worlds_WorldId",
                table: "Rooms",
                column: "WorldId",
                principalTable: "Worlds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
