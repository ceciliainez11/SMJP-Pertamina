using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SMJP.MasterDataServices.API.Models
{
    public class Regions
    {
        [Key]
        public int RegionID { get; set; }

        [ForeignKey("CompanyID")]
        public int CompanyID { get; set; }
        public Companies Company { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string RegionName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string RegionLatitude { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string RegionLongitude { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
