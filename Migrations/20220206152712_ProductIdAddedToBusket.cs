using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestMVCApp.Migrations
{
    public partial class ProductIdAddedToBusket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<int>>(
                name: "ProductId",
                table: "Buskets",
                type: "integer[]",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Buskets");
        }
    }
}
