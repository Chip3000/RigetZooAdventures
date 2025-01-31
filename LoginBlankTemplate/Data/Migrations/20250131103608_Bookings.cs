using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginBlankTemplate.Data.Migrations
{
    /// <inheritdoc />
    public partial class Bookings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Bookings",
                newName: "Until");

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "Until",
                table: "Bookings",
                newName: "Time");
        }
    }
}
