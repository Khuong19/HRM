using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM_App
{
    public class Person
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }

    // Derived class for teaching staff
    public class Teacher : Person
    {
        public decimal Salary { get; set; }
        public List<string> Subjects { get; set; }

        public Teacher()
        {
            Subjects = new List<string>();
        }
    }

    // Derived class for administration
    public class Admin : Person
    {
        public decimal Salary { get; set; }
        public string EmploymentType { get; set; }
        public int WorkingHours { get; set; }
    }

    // Derived class for students
    public class Student : Person
    {
        public List<string> CurrentSubjects { get; set; }
        public List<string> PreviousSubjects { get; set; }

        public Student()
        {
            CurrentSubjects = new List<string>();
            PreviousSubjects = new List<string>();
        }
    }
}
