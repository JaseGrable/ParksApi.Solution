using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
{
    public class Park
    {
        public int ParkId { get; set; }

        [Required]
        [StringLength(85, ErrorMessage = "Must be less than 85 characters.")] // longest existing national || state park name is 83 characters
        public string Name { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Must be between 2 and 20 characters.")] // District of Columbia at 20 char || include min of 2 char state code
        public string State { get; set; }

        [Required]
        // [ValidParkType(ErrorMessage = "Enter either 'National' or 'State'.")]
        [RegularExpression("^(National|State)$", ErrorMessage = "Valid values are 'National' or 'State' (case-insensitive)")]
        public string Type { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Must be less than 500 characters.")]
        public string Description { get; set; }
    }
}