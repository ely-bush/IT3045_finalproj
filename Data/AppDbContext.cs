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
                new TeamMember { Name = "Owen O'Connell", BirthDate = new DateTime(2006, 2, 3), CollegeProgram = "Information Technology", YearInProgram = "Junior" },
                new TeamMember { Name = "Ely Bush", BirthDate = new DateTime(2005, 12, 27), CollegeProgram = "Information Technology", YearInProgram = "Junior" }
            );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { Name = "Basketball", Category = "Sports", HoursPerWeek = 5, Description = "Pickup games on weekends" },
                new Hobby { Name = "Knitting", Category = "Indoor", HoursPerWeek = 10, Description = "Little projects while watching TV" }
            );

            modelBuilder.Entity<Food>().HasData(
                new Food { FoodName = "Pizza", MealType = "Dinner", Calories = 500, IsVegetarian = false },
                new Food { FoodName = "Onion Rings", MealType = "Snack", Calories = 300, IsVegetarian = true }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010, Rating = 8.8 },
                new Movie { Title = "Saltburn", Genre = "Thriller", ReleaseYear = 2023, Rating = 7.0 }
            );
        }
    }
}
