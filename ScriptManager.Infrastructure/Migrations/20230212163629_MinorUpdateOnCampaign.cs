using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScriptManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MinorUpdateOnCampaign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Scripts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Campaigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Scripts");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Answers");
        }
    }
}
