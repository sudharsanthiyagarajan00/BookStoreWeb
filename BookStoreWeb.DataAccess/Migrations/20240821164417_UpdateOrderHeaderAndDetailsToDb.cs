using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderHeaderAndDetailsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "OrderHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "OrderHeaders");
        }
    }
}
