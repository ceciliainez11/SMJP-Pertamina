namespace SMJP.MasterDataServices.API.Models
{
    public class UsersDto
    {
        public int UserID { get; set; }
        public string AvatarUrl { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int CompanyID { get; set; }
        public int RegionID { get; set; }
        public int SiteID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public int IsAdmin { get; set; }
        public int SyncTime { get; set; }
        public int IsActive { get; set; }
        public DateTime ActiveDate { get; set; }
        public string CreatedByIpAddress { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
