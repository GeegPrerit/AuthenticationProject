using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using ProjectAuthentication.Models;

namespace ProjectAuthentication.Repository
{
    public class CourseRepository:ICourseRepository
    {
        private readonly StudentConext _context;
        public CourseRepository(StudentConext context)
        {
            _context = context;
        }

        public void AddCourse(Course co)
        {
            _context.Courses.Add(co);
            _context.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            var res = _context.Courses.Find(id);
            _context.Courses.Remove(res);
            _context.SaveChanges();
        }

        public Course GetCourse(int id)
        {
            var userobj = _context.Courses.Find(id);
            return userobj;
        }

        public IEnumerable<Course> GetCourse()
        {
            return _context.Courses.Include(a => a.Students).ToList();  
        }



        public void UpdateCourse(int id, Course co)
        {
            var res1 = _context.Courses.Find(id);
            res1.name = co.name;
            res1.description = co.description;
            

            _context.Courses.Update(res1);
        }

        

       

        
    }
}
