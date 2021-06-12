using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Data.Migrations
{
    public partial class MoviesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (1, 'Action')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (2, 'Thriller')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (3, 'Family')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (4, 'Romance')");
            migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (5, 'Comedy')");
            migrationBuilder.Sql("INSERT INTO Movies ( Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ( 'A Love So Beautiful', 3, '2017-11-03', '2017-12-12', 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
