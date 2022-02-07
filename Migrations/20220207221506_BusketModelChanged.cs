using Microsoft.EntityFrameworkCore.Migrations;

namespace TestMVCApp.Migrations
{
    public partial class BusketModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buskets_Customers_CustomerId",
                table: "Buskets");

            migrationBuilder.DropIndex(
                name: "IX_Buskets_CustomerId",
                table: "Buskets");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Buskets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Buskets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
