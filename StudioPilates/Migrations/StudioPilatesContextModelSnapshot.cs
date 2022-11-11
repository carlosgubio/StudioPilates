using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudioPilates.Migrations
{
    public partial class InitialStudioPilatesContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer_Payments",
                columns: table => new
                {
                    Id_customer_payment = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_customer_plan = table.Column<int>(nullable: false),
                    Paid_value = table.Column<int>(nullable: false),
                    Paid_at = table.Column<DateTime>(nullable: false),
                    Payment_method = table.Column<int>(nullable: false),
                    Text = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Payments", x => x.Id_customer_payment);
                });

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

            migrationBuilder.CreateTable(
                name: "Customer_Question_Responses",
                columns: table => new
                {
                    Id_customer_question_response = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_customer = table.Column<int>(nullable: false),
                    Id_question = table.Column<int>(nullable: false),
                    Response = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Question_Responses", x => x.Id_customer_question_response);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id_customer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(maxLength: 11, nullable: false),
                    Gender = table.Column<string>(maxLength: 1, nullable: false),
                    Occupation = table.Column<string>(maxLength: 50, nullable: false),
                    Birth_date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id_customer);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id_plan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Payment_recurrence = table.Column<string>(maxLength: 50, nullable: false),
                    Contract_recurrence = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id_plan);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id_question = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id_question);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    CustomerId_customer = table.Column<int>(nullable: false),
                    Street = table.Column<string>(maxLength: 100, nullable: false),
                    Number = table.Column<string>(maxLength: 10, nullable: false),
                    Complement = table.Column<string>(maxLength: 100, nullable: true),
                    District = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    Zip_code = table.Column<string>(maxLength: 8, nullable: false),
                    Reference = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.CustomerId_customer);
                    table.ForeignKey(
                        name: "FK_Address_Customers_CustomerId_customer",
                        column: x => x.CustomerId_customer,
                        principalTable: "Customers",
                        principalColumn: "Id_customer",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Customer_Payments");

            migrationBuilder.DropTable(
                name: "Customer_plans");

            migrationBuilder.DropTable(
                name: "Customer_Question_Responses");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
