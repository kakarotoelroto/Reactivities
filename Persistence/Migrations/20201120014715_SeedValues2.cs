using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValues2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] {"Id", "Name"},
                values: new object[] {4, "value 104"}
            );

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] {"Id", "Name"},
                values: new object[] {5, "value 105"}
            );

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] {"Id", "Name"},
                values: new object[] {6, "value 106"}
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
