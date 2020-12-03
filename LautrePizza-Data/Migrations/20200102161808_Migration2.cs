using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LautrePizza_Data.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Disches");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Disches",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DischTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DischTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disches_TypeId",
                table: "Disches",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disches_DischTypes_TypeId",
                table: "Disches",
                column: "TypeId",
                principalTable: "DischTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disches_DischTypes_TypeId",
                table: "Disches");

            migrationBuilder.DropTable(
                name: "DischTypes");

            migrationBuilder.DropIndex(
                name: "IX_Disches_TypeId",
                table: "Disches");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Disches");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Disches",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
