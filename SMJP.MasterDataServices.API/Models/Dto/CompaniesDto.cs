namespace SMJP.MasterDataServices.API.Models.Dto
{
    public class CompaniesDto
    {
        public int CompanyID { get; set; }
        public string LogoUrl { get; set; }
        //public IFormFile LogoFile { get; set; } // New property for file upload
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyAddress { get; set; }
        public int ProvinceID { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
