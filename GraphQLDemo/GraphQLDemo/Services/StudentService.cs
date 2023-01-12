using GraphQLDemo.Models;
using GraphQLDemo.Repository;

namespace GraphQLDemo.Services
{
    public class StudentService
    {
        private readonly IDataRepository _dataRepository;

        public StudentService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [UseFiltering]
        public IEnumerable<Student> GetStudents()
        {
            return _dataRepository.GetStudents();
        }
    }
}
