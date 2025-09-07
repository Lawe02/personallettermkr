using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class resumesRealtion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UpploadedResumes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UpploadedResumes_UserId",
                table: "UpploadedResumes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UpploadedResumes_AspNetUsers_UserId",
                table: "UpploadedResumes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UpploadedResumes_AspNetUsers_UserId",
                table: "UpploadedResumes");

            migrationBuilder.DropIndex(
                name: "IX_UpploadedResumes_UserId",
                table: "UpploadedResumes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UpploadedResumes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
