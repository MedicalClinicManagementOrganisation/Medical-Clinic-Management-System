using Microsoft.EntityFrameworkCore.Migrations;

namespace Console_Management_of_medical_clinic.Migrations
{
    public partial class AddStatusDoctorsDayPlanModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "DbDoctorsDayPlan",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "DbDoctorsDayPlan");
        }
    }
}
