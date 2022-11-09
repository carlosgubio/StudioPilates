using Microsoft.EntityFrameworkCore.Migrations;

namespace StudioPilates.Migrations
{
    public partial class ModelCustomer_question_response : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer_Question_Responses");
        }
    }
}
