using System.ComponentModel.DataAnnotations;

namespace IT3045_finalproj.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        [Required]
        public string FoodName { get; set; }

        [Required]
        public string MealType { get; set; }

        [Required]
        public int Calories { get; set; }

        [Required]
        public Boolean IsVegetarian { get; set; }
    }
}
