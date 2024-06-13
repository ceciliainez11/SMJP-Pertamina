using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMJP.MasterDataServices.API.Models
{
    public class Shifts
    {
        [Key]
        public int ShiftID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Title { get; set; }

        [Required]
        public DateTime StartAt { get; set; }

        [Required]
        public DateTime EndAt { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
