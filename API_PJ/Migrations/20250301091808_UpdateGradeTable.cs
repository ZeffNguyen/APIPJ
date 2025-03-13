using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PJ.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGradeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMIN");

            migrationBuilder.DropTable(
                name: "GRADES");

            migrationBuilder.DropTable(
                name: "NOTIFICATIONS");

            migrationBuilder.DropTable(
                name: "SCHEDULES");

            migrationBuilder.DropTable(
                name: "STUDENTS");

            migrationBuilder.DropTable(
                name: "EVENTS");

            migrationBuilder.DropTable(
                name: "CLASSES");

            migrationBuilder.DropTable(
                name: "TEACHERS");

            migrationBuilder.DropTable(
                name: "SUBJECTS");
        }
    }
}
