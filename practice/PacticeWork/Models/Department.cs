namespace PacticeWork.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? DepartmentCode { get; set; }
        public int? DesignationId { get; set; }
        public DateTime? creationDate {  get; set; }
        public DateTime? modificationDate { get; set; }

    }
}
