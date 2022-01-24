using Microsoft.EntityFrameworkCore.Migrations;

namespace TestMVCApp.Migrations
{
    public partial class OnlyListsHaveCustomDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buskets_Customers_CustomerId",
                table: "Buskets");

            migrationBuilder.DropIndex(
                name: "IX_Buskets_CustomerId",
                table: "Buskets");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Buskets",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Buskets",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Buskets_CustomerId",
                table: "Buskets",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buskets_Customers_CustomerId",
                table: "Buskets",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
