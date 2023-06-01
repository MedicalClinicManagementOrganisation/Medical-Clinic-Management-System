using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class AddNumberOfDoctorsColumnsCalendarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfAcceptedDoctors",
                table: "DbCalendars",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfDoctors",
                table: "DbCalendars",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfAcceptedDoctors",
                table: "DbCalendars");

            migrationBuilder.DropColumn(
                name: "NumberOfDoctors",
                table: "DbCalendars");
        }
    }
}
