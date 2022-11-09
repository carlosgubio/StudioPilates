using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace StudioPilates.Migrations
{
    public partial class ModelCustomer_payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer_Payments",
                columns: table => new
                {
                    Id_customer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_customer_plan = table.Column<int>(nullable: false),
                    Paid_value = table.Column<int>(nullable: false),
                    Paid_at = table.Column<DateTime>(nullable: false),
                    Payment_method = table.Column<int>(nullable: false),
                    Text = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Payments", x => x.Id_customer);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer_Payments");
        }
    }
}
