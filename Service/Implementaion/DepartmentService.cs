using Domain.Models.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementaion
{
    public class DepartmentService(DBContext dBContext) : IDepartmentService
    {
        private readonly DBContext _dBContext = dBContext;

        public async Task<List<Department>> GetAllDepartment()
        {
            var deparments = await _dBContext.departments.ToListAsync();
            return  deparments;
        }
    }
}
