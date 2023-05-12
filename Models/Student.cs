using System.ComponentModel.DataAnnotations;

namespace ProjectAuthentication.Models
{
    public class Student
    {
        [Key]

        public int studentId { get; set; }

        public string studentName { get; set; }

        public int studentAge { get; set; }

        public string studentGender { get; set; }

        public int CourseId { get; set; }

        public Course? Course { get; set; }


    }
}
