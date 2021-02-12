using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EfCoreMigrations.Models
{
    public class SchoolCourse
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SchoolCourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
