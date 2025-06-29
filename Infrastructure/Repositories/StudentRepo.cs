using Domain.Models.Entities;
using Domain.Models.Identity;
using Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Abstractions;

namespace Infrastructure.Repositories
{
    public class StudentRepo(DBContext dBContext ,UserManager<User> userManager) : IStudentRepo
    {
        private readonly DBContext _dBContext = dBContext;
        private readonly UserManager<User> _userManager = userManager;

        public async Task<Student> GetStudentInfo(int id )
        {
            var student = await _dBContext.students.FirstOrDefaultAsync(x=>x.StudID.Equals(id));
            return student;
        }

    }
}
