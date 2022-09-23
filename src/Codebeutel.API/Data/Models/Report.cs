using System.ComponentModel.DataAnnotations.Schema;

namespace Codebeutel.API.Data.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int DispenserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
