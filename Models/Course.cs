using System.ComponentModel.DataAnnotations;

namespace ProjectAuthentication.Models
{
    public class Course
    {
        [Key]
        public int courseId { get; set; }

        public string? name { get; set; }

        public string? description { get; set; }

        public ICollection<Student>? Students { get; set; }

    }
}
