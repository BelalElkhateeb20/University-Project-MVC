using Domain.Models.Entities;
using Infrastructure.Abstractions;

namespace Infrastructure.Implementaion
{
    public class StudentService(IStudentRepo studentRepo) : IStudentService
    {
        private readonly IStudentRepo _studentRepo = studentRepo;

        public async Task<Student> GetStudentInfo(int id)
        {
            var student = await _studentRepo.GetStudentInfo(id);
            return student;
        }
    }
}
