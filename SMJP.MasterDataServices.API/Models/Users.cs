using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMJP.MasterDataServices.API.Models.Dto
    {
        public class Users
        {
            [Key]
            public int UserID { get; set; }

            [Column(TypeName = "nvarchar(max)")]
            public string AvatarUrl { get; set; }

            [Required]
            [StringLength(50)]
            public string UserCode { get; set; }

            [Required]
            [StringLength(100)]
            public string FullName { get; set; }

            [Required]
            [StringLength(20)]
            public string Phone { get; set; }

            [Required]
            [StringLength(20)]
            [EmailAddress]
            public string Email { get; set; }

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
            [StringLength(50)]
            public string Username { get; set; }

            [Required]
            [Column(TypeName = "nvarchar(max)")]
            public string Password { get; set; }

            public int RoleID { get; set; }

            public int IsAdmin { get; set; }

            public int SyncTime { get; set; }

            public int IsActive { get; set; }

            public DateTime ActiveDate { get; set; }

            [Column(TypeName = "nvarchar(50)")]
            public string CreatedByIpAddress { get; set; }

            public int CreatedBy { get; set; }

            public DateTime CreatedDate { get; set; }

            public int ModifiedBy { get; set; }
            public DateTime ModifiedDate { get; set; }
        }
    }