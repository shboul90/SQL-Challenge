using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Bonus
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Student> Students { get; set; }

    }
}
