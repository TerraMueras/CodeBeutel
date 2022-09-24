using System.ComponentModel.DataAnnotations;

namespace Codebeutel.API.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
