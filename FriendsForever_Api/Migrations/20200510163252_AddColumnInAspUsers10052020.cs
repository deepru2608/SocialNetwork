using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FriendsForever_Api.Migrations
{
    public partial class AddColumnInAspUsers10052020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationTime",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationTime",
                table: "AspNetUsers");
        }
    }
}
