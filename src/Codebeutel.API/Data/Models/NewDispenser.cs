using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Codebeutel.API.Data.Models
{
    public class NewDispenser
    {
        public int Id { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }

        [JsonIgnore]
        public bool IsDeleted { get; set; }

        public ICollection<NewDispenserApproval> Approvals { get; set; }
    }
}
