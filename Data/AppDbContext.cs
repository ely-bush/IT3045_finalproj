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
                new TeamMember { Name = "Owen Example", BirthDate = new DateTime(2003, 4, 12), CollegeProgram = "Computer Science", YearInProgram = "Senior" },
                new TeamMember { Name = "Jane Doe", BirthDate = new DateTime(2002, 9, 3), CollegeProgram = "Information Technology", YearInProgram = "Junior" }
            );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { Name = "Basketball", Category = "Sports", HoursPerWeek = 5, Description = "Pickup games on weekends" },
                new Hobby { Name = "Gaming", Category = "Indoor", HoursPerWeek = 8, Description = "PC and console games" }
            );

            modelBuilder.Entity<Food>().HasData(
                new Food { FoodName = "Pancakes", MealType = "Breakfast", Calories = 350, IsVegetarian = true },
                new Food { FoodName = "Bacon", MealType = "Breakfast", Calories = 250, IsVegetarian = false }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010, Rating = 8.8 },
                new Movie { Title = "The Godfather", Genre = "Drama", ReleaseYear = 1972, Rating = 9.2 }
            );
        }
    }
}
