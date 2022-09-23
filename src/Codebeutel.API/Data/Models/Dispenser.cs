namespace Codebeutel.API.Data.Models
{
    public class Dispenser
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsDefect { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Report> Reports { get; set; }

    }
}
