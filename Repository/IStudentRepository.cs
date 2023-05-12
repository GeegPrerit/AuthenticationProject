using ProjectAuthentication.Models;

namespace ProjectAuthentication.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudent();
        Student GetStudent(int id);
        void AddStudent(Student stu);

        

        void UpdateStudent(int id, Student stu);
        void DeleteStudent(int id);
        int Results(int id);

    }
}
