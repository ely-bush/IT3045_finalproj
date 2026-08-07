using IT3045_finalproj.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace IT3045_finalproj.Data
{
    public class AppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TeamMember> TeamMembers => Set<TeamMember>();
        public DbSet<Hobby> Hobbies => Set<Hobby>();
        public DbSet<Food> FavoriteFoods => Set<Food>();
        public DbSet<Movie> Movies => Set<Movie>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FullName = "Owen Example", BirthDate = new DateTime(2003, 4, 12), CollegeProgram = "Computer Science", YearInProgram = "Senior" },
                new TeamMember { Id = 2, FullName = "Jane Doe", BirthDate = new DateTime(2002, 9, 3), CollegeProgram = "Information Technology", YearInProgram = "Junior" }
            );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { Id = 1, Name = "Basketball", Category = "Sports", HoursPerWeek = 5, Description = "Pickup games on weekends" },
                new Hobby { Id = 2, Name = "Gaming", Category = "Indoor", HoursPerWeek = 8, Description = "PC and console games" }
            );

            modelBuilder.Entity<FavoriteFood>().HasData(
                new FavoriteFood { Id = 1, FoodName = "Pancakes", MealType = "Breakfast", Calories = 350, IsVegetarian = true },
                new FavoriteFood { Id = 2, FoodName = "Bacon", MealType = "Breakfast", Calories = 250, IsVegetarian = false }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010, Rating = 8.8 },
                new Movie { Id = 2, Title = "The Godfather", Genre = "Drama", ReleaseYear = 1972, Rating = 9.2 }
            );
        }
    }
}
