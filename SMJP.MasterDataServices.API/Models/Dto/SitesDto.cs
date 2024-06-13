namespace SMJP.MasterDataServices.API.Models.Dto
{
    public class SitesDto
    {
        public int SiteID { get; set; }
        public int CompanyID { get; set; }
        public Companies Company { get; set; }
        public int RegionID { get; set; }
        public Regions Region { get; set; }
        public string SiteName { get; set; }
        public string SiteDesc { get; set; }
        public string SiteLatitude { get; set; }
        public string SiteLongitude { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
