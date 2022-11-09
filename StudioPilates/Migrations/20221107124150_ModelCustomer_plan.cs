using Microsoft.EntityFrameworkCore.Migrations;

namespace StudioPilates.Migrations
{
    public partial class ModelCustomer_plan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer_plans",
                columns: table => new
                {
                    Id_customer_plan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_customer = table.Column<int>(nullable: false),
                    Id_plan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_plans", x => x.Id_customer_plan);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer_plans");
        }
    }
}
