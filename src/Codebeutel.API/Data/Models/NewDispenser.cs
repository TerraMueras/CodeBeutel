namespace Codebeutel.API.Data.Models
{
    public class NewDispenser
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<NewDispenserApproval> Approvals { get; set; }
    }
}
