using Microsoft.AspNetCore.Mvc;

namespace LOC_Employee_Details.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public int DesignationId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationTime { get; set; }
    }
}
