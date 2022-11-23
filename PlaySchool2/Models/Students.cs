using System;
using System.Collections.Generic;

namespace PlaySchool2.Models
{
    public class Students
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments
        {
            get; set;
        }
    }
}
