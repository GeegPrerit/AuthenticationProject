using ProjectAuthentication.Models;

namespace ProjectAuthentication.Repository
{
    public class StudentRepository:IStudentRepository
    {
        private readonly StudentConext _context;
        public StudentRepository(StudentConext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetStudent()
        {
            return _context.Students.ToList();
        }

        public void AddStudent(Student co)
        {
            _context.Students.Add(co);
            _context.SaveChanges();
        }

        public Student GetStudent(int id)
        {
            var userobj = _context.Students.Find(id);
            return userobj;
        }

        public void UpdateStudent(int id, Student stu)
        {
            var res1 = _context.Students.Find(id);
            res1.studentName = stu.studentName;
            res1.studentGender = stu.studentGender;
            res1.studentAge = stu.studentAge;

            _context.Students.Update(res1);
        }

        public void DeleteStudent(int id)
        {
            var res = _context.Students.Find(id);
            _context.Students.Remove(res);
            _context.SaveChanges();
        }

        public int Results(int id)
        {
            var list = _context.Students.Count(a => a.CourseId==id);
            return list;
        }

    }
}
