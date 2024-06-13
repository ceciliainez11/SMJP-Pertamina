namespace SMJP.MasterDataServices.API.Models.Dto
{
    public class ShiftsDto
    {
        public int ShiftID { get; set; }
        public string Title { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
