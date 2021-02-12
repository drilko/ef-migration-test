using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreMigrations.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {        
            public int EnrollmentID { get; set; }
            public int SchoolCourseID { get; set; }
            public int StudentID { get; set; }
            public Grade? Grade { get; set; }

            public SchoolCourse SchoolCourse { get; set; }
            public Student Student { get; set; }
       
    }
}
