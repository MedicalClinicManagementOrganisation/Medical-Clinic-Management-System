using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class RemoveIsActiveDoctorsDayPlanModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "DbDoctorsDayPlan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "DbDoctorsDayPlan",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
