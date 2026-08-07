using IT3045_finalproj.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace IT3045_finalproj.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TeamMember> TeamMembers => Set<TeamMember>();
        public DbSet<Hobby> Hobbies => Set<Hobby>();
        public DbSet<Food> Foods => Set<Food>();
        public DbSet<Movie> Movies => Set<Movie>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { TeamMemberId = 1, Name = "Owen O'Connell", BirthDate = new DateTime(2006, 2, 3), CollegeProgram = "Information Technology", YearInProgram = "Junior" },
                new TeamMember { TeamMemberId = 2, Name = "Ely Bush", BirthDate = new DateTime(2005, 12, 27), CollegeProgram = "Information Technology", YearInProgram = "Junior" }
            );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { HobbyId = 1, Name = "Basketball", Category = "Sports", HoursPerWeek = 5, Description = "Pickup games on weekends" },
                new Hobby { HobbyId = 2, Name = "Knitting", Category = "Indoor", HoursPerWeek = 10, Description = "Little projects while watching TV" }
            );

            modelBuilder.Entity<Food>().HasData(
                new Food { FoodId = 1, FoodName = "Pizza", MealType = "Dinner", Calories = 500, IsVegetarian = false },
                new Food { FoodId = 2, FoodName = "Onion Rings", MealType = "Snack", Calories = 300, IsVegetarian = true }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010, Rating = 8.8 },
                new Movie { MovieId = 2, Title = "Saltburn", Genre = "Thriller", ReleaseYear = 2023, Rating = 7.0 }
            );
        }
    }
}
