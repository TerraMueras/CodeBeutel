using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codebeutel.API.Data.Models
{
    public class NewDispenserApproval
    {
        public int Id { get; set; }
        public int NewDispenserId { get; set; }

    }
}
