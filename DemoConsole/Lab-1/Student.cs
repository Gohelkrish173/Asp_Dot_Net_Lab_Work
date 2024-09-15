using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Lab_1
{
    internal class Student
    {
        long Enrollment_No;
        string Student_Name;
        int Semester;
        double CPI;
        double SPI;

        public Student(long Enrollment_No,string Student_Name,int Semester,double CPI,double SPI)
        {
            this.Enrollment_No = Convert.ToInt64(Enrollment_No);
            this.Student_Name = Student_Name;
            this.Semester = Convert.ToInt16(Semester);
            this.SPI =Convert.ToDouble(SPI);
            this.CPI = Convert.ToDouble(CPI);
        }

        public Student(string Student_Name)
        {
            this.Student_Name=Student_Name;
        }

        public void DisplayStudentDetail()
        {
            Console.WriteLine("Enrollement_NO : " + Enrollment_No);
            Console.WriteLine("Student_Name : " + Student_Name);
            Console.WriteLine("Semester : " + Semester);
            Console.WriteLine("SPI : " + SPI);
            Console.WriteLine("CPI : " + CPI);
        }
    }
}
