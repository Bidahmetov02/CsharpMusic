using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestMVCApp.Migrations
{
    public partial class ProductIdAddedToBusket2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<List<int>>(
                name: "ProductId",
                table: "Buskets",
                type: "integer[]",
                nullable: true,
                oldClrType: typeof(int[]),
                oldType: "integer[]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int[]>(
                name: "ProductId",
                table: "Buskets",
                type: "integer[]",
                nullable: false,
                defaultValue: new int[0],
                oldClrType: typeof(List<int>),
                oldType: "integer[]",
                oldNullable: true);
        }
    }
}
