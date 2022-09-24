using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Codebeutel.API.Data.Models
{
    public class Dispenser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }

        [DefaultValue(false)]
        public bool IsEmpty { get; set; }
        [DefaultValue(false)]
        public bool IsDefect { get; set; }

        [JsonIgnore]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public ICollection<Report> Reports { get; set; }

    }
}
