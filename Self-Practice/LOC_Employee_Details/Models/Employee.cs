using Microsoft.AspNetCore.Mvc;

namespace LOC_Employee_Details.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal ContactNo { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public int Age { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public decimal Salary { get; set; }

    }
}
