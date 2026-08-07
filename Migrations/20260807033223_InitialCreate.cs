using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IT3045_finalproj.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoursPerWeek = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    TeamMemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearInProgram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.TeamMemberId);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "Calories", "FoodName", "IsVegetarian", "MealType" },
                values: new object[,]
                {
                    { 1, 500, "Pizza", false, "Dinner" },
                    { 2, 300, "Onion Rings", true, "Snack" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "Category", "Description", "HoursPerWeek", "Name" },
                values: new object[,]
                {
                    { 1, "Sports", "Pickup games on weekends", 5, "Basketball" },
                    { 2, "Indoor", "Little projects while watching TV", 10, "Knitting" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Genre", "Rating", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Sci-Fi", 8.8000000000000007, 2010, "Inception" },
                    { 2, "Thriller", 7.0, 2023, "Saltburn" }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "TeamMemberId", "BirthDate", "CollegeProgram", "Name", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(2006, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Owen O'Connell", "Junior" },
                    { 2, new DateTime(2005, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Ely Bush", "Junior" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
