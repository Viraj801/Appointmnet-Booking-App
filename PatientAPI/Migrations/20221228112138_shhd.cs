using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientAPI.Migrations
{
    public partial class shhd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PatientEmailId",
                table: "AppointmentsTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppoimtmentId",
                table: "AppointmentsTable",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppoimtmentId",
                table: "AppointmentsTable");

            migrationBuilder.AlterColumn<string>(
                name: "PatientEmailId",
                table: "AppointmentsTable",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
