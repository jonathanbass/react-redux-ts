using GraphQLDemo.Models;

namespace GraphQLDemo.Repository
{
    public interface IDataRepository
    {
        IEnumerable<Student> GetStudents();

        Student GetStudent(int id);

        void UpdateStudent(Student student);

        void DeleteStudent(int id);

        void CreateStudent(Student student);
    }
}