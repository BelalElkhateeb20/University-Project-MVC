using Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstractions
{
    public interface IStudentRepo
    {
        public Task<Student> GetStudentInfo( int id);
    }
}
