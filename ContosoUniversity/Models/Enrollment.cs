using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; } // "ID" or "classnameID" becomes the primary key in the database... Using ID without classname makes it easier to implement inheritance in the data model.
        public int CourseID { get; set; } // EntityFramework makes this a Foreign Key for "Course" when you call it "CourseID"
        public int StudentID { get; set; } // EntityFramework makes this a Foreign Key for "Student" when you call it "StudentID"
        public Grade? Grade { get; set; } // The ? question mark here designates NULLABLE

        public Course Course { get; set; }
        public Student Student { get; set; }

    }
}
