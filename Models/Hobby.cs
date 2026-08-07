using System.ComponentModel.DataAnnotations;

namespace IT3045_finalproj.Models
{
    public class Hobby
    {
        [Key]
        public int HobbyId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public int HoursPerWeek { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
