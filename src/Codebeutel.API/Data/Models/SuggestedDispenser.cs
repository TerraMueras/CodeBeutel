namespace Codebeutel.API.Data.Models
{
    public class SuggestedDispenser
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
        public ICollection<SuggestedDispenserApproval> Approvals { get; set; }
    }
}
