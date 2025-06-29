
using Domain.Models.Entities;

namespace Infrastructure.Abstractions
{
    public interface IStudentService
    {
        public Task<Student> GetStudentInfo(int id);
    }
}
