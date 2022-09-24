using System.ComponentModel.DataAnnotations;

namespace Codebeutel.API.Data.Models
{
    public class NewDispenserApproval
    {
        public int Id { get; set; }

        [Required]
        public int NewDispenserId { get; set; }

    }
}
