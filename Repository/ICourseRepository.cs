using ProjectAuthentication.Models;
using System.Security.Cryptography;

namespace ProjectAuthentication.Repository
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourse();
        Course GetCourse(int id);

        void AddCourse(Course doctor);

        void UpdateCourse(int id, Course doctor);
        void DeleteCourse(int id);
        
    }
}
