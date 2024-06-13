namespace SMJP.MasterDataServices.API.Models.Dto
{
    public class RegionsDto
    {
        public int RegionID { get; set; }
        public int CompanyID { get; set; }
        public Companies Company { get; set; }
        public string RegionName { get; set; }
        public string RegionLatitude { get; set; }
        public string RegionLongitude { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
