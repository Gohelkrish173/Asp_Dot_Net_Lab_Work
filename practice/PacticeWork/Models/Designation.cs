namespace PacticeWork.Models
{
    public class Designation
    {
        public int DesignationId {  get; set; }
        public string? DesignationName { get; set; }
        public string? DesignationCode { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
