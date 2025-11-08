using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCEFCC.Migrations
{
    /// <inheritdoc />
    public partial class v2_new_field_active : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "People",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "People");
        }
    }
}
