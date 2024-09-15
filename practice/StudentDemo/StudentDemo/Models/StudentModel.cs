using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StudentDemo.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage ="Student Name can't be empty")]
        [Display(Name ="FirstNmame")]
        public string StudentName { get; set; }
        [Required]
        public string enrollmentNo { get; set; }
        [Required,MinLength(8)]
        public string password { get; set; }
        public int rollno { get; set; }
        public string EmailPersonal { get; set; }
        [Required(ErrorMessage ="Email Personal Can not be blank")]
        [EmailAddress]
        [Phone]
        //[DataType(DataType.EmailAddress)]
        public string EmailInstitute  { get; set; }
        public int currentSem { get; set; }
        [Required]
        [MinLength(10)]
        public string contactNo  { get; set; }
        public int castid   { get; set; }
        public int cityid   { get; set; }
        public string remark { get; set; }
        [DisplayFormat(DataFormatString ="{0:N2}")]
        public DateTime Birthdate   { get; set; }
        [Range(1,100)]
        public int age { get; set; }

    }
}
