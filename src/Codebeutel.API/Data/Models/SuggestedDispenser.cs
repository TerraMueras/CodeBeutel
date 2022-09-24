using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Codebeutel.API.Data.Models
{
    public class SuggestedDispenser
    {
        public int Id { get; set; }

        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }

        public string Description { get; set; }

        public bool NotificationSent { get; set; }

        [JsonIgnore]
        public bool IsDeleted { get; set; }

        public ICollection<SuggestedDispenserApproval> Approvals { get; set; }
    }
}
