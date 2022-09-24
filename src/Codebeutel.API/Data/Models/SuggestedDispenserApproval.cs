using System.ComponentModel.DataAnnotations.Schema;

namespace Codebeutel.API.Data.Models
{
    public class SuggestedDispenserApproval
    {
        public int Id { get; set; }

        [ForeignKey("SuggestedDispenser")]
        public int SuggestedDispenserId { get; set; }

    }
}
