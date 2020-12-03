using Microsoft.EntityFrameworkCore.Migrations;

namespace LautrePizza_Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disches_DischTypes_TypeId",
                table: "Disches");

            migrationBuilder.DropIndex(
                name: "IX_Disches_TypeId",
                table: "Disches");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Disches");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "DischTypes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Disches",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DishTypeId",
                table: "Disches",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DishTypeId",
                table: "Disches");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "DischTypes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Disches",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Disches",
                type: "integer",
                nullable: true);

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
    }
}
