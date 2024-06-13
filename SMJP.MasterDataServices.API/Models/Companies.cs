using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMJP.MasterDataServices.API.Models
{
    public class Companies
    {
        [Key]
        public int CompanyID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string LogoUrl { get; set; }
        //[NotMapped]
        //public IFormFile LogoFile { get; set; } // New property for file upload

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CompanyName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CompanyEmail { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string CompanyPhone { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string CompanyAddress { get; set; }

        [Required]
        public int ProvinceID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Latitude { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Longitude { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}