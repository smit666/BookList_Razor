using Microsoft.EntityFrameworkCore.Migrations;

namespace BookListRazor.Migrations
{
    public partial class SeedBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into book(Name,Author) values ('Test','Test Author')");
            migrationBuilder.Sql("insert into book(Name,Author) values ('Test1','Test Author1')");

            migrationBuilder.Sql("insert into book(Name,Author) values ('Test2','Test Author2')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
