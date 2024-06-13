using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SMJP.MasterDataServices.API.Models
{
    public class Schedules
    {
        [Key]
        public int ScheduleID { get; set; }

        [Required]
        [ForeignKey("CompanyID")]
        public int CompanyID { get; set; }
        public Companies Company { get; set; }

        [Required]
        [ForeignKey("RegionID")]
        public int RegionID { get; set; }
        public Regions Region { get; set; }

        [Required]
        [ForeignKey("SiteID")]
        public int SiteID { get; set; }
        public Sites Site { get; set; }

        [Required]
        [ForeignKey("ShiftID")]
        public int ShiftID { get; set; }
        public Shifts Shift { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
