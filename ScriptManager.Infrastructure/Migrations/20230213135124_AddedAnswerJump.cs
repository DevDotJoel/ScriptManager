using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScriptManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAnswerJump : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JumpToQuestion",
                table: "Answers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JumpToQuestion",
                table: "Answers");
        }
    }
}
