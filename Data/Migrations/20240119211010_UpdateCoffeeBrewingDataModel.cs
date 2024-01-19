using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilteredCoffee.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCoffeeBrewingDataModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoffeeId",
                table: "Brewing",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoffeeId",
                table: "Brewing");
        }
    }
}
