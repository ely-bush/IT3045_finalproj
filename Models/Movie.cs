namespace IT3045_finalproj.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        [Required]
        public double Rating { get; set; }
    }
}
