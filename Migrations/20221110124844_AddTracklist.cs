using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyRecordApp.Migrations
{
    public partial class AddTracklist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tracks",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Artists");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Artists",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseDate",
                table: "Records",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "RecordId",
                table: "Labels",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    RecordId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Track_Records_RecordId",
                        column: x => x.RecordId,
                        principalTable: "Records",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Labels_RecordId",
                table: "Labels",
                column: "RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Track_RecordId",
                table: "Track",
                column: "RecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Labels_Records_RecordId",
                table: "Labels",
                column: "RecordId",
                principalTable: "Records",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labels_Records_RecordId",
                table: "Labels");

            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropIndex(
                name: "IX_Labels_RecordId",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "RecordId",
                table: "Labels");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Artists",
                newName: "LastName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseDate",
                table: "Records",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tracks",
                table: "Records",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Artists",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
