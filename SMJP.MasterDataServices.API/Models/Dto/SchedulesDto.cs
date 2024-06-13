using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SMJP.MasterDataServices.API.Models.Dto
{
    public class SchedulesDto
    {
        public int ScheduleID { get; set; }
        public int CompanyID { get; set; }
        public Companies Company { get; set; }
        public int RegionID { get; set; }
        public Regions Region { get; set; }
        public int SiteID { get; set; }
        public Sites Site { get; set; }
        public int ShiftID { get; set; }
        public Shifts Shift { get; set; }
        public DateTime Date { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
