using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace WebAppCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "CreatedTime", table: "Trip");
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Trip",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalDate",
                table: "Stop",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Stop",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DateCreated", table: "Trip");
            migrationBuilder.DropColumn(name: "ArrivalDate", table: "Stop");
            migrationBuilder.DropColumn(name: "Order", table: "Stop");
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Trip",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
