using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CancStore.Migrations
{
    public partial class AddStoredAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "StoredAmount",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoredAmount",
                table: "Products");
        }
    }
}
