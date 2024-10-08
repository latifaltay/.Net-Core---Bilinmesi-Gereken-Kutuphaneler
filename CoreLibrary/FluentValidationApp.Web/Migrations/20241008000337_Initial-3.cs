using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentValidationApp.Web.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirtDay",
                table: "Customers",
                newName: "BirthDay");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "Customers",
                newName: "BirtDay");
        }
    }
}
