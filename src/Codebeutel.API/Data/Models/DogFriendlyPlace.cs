using System.ComponentModel.DataAnnotations;

namespace Codebeutel.API.Data.Models
{
    public class DogFriendlyPlace
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public Category Category { get; set; }

    }
}
