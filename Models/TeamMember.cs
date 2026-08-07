using System;
using System.ComponentModel.DataAnnotations;

namespace IT3045_finalproj.Models
{
    public class TeamMember
    {
        [Key]
        public int TeamMemberId { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public DateTime BirthDate { get; set; }
        
        [Required]
        public string CollegeProgram { get; set; }
        
        [Required]
        public string YearInProgram { get; set; }
    }
}
