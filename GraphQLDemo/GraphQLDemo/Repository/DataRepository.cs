using AutoFixture;
using GraphQLDemo.Models;

namespace GraphQLDemo.Repository
{
    public class DataRepository : IDataRepository
    {
        private readonly IEnumerable<Student> Students;

        public DataRepository()
        {
            var fixture = new Fixture();
            fixture.CreateMany<Student>(10);
            Students = fixture.CreateMany<Student>(10);
        }

        public void CreateStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            return Students;
        }

        public void UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
