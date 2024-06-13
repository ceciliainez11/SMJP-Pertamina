using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMJP.MasterDataServices.API.Models
{
    public class Sites
    {
        [Key]
        public int SiteID { get; set; }

        [Required]
        [ForeignKey("CompanyID")]
        public int CompanyID { get; set; }
        public Companies Company { get; set; }

        [Required]
        [ForeignKey("RegionID")]
        public int RegionID { get; set; }
        public Regions Region { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string SiteName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string SiteDesc { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string SiteLatitude { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string SiteLongitude { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
