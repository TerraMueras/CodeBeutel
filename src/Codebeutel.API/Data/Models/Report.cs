using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Codebeutel.API.Data.Models
{
    public class Report
    {
        public int Id { get; set; }

        [Required]
        public int DispenserId { get; set; }

        [JsonIgnore]
        public bool IsDeleted { get; set; }
    }
}
