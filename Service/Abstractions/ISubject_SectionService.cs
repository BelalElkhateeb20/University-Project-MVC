using Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Abstractions
{
    public interface ISubject_SectionService
    {
        public Task<Subject_Section> GetSubject_SectionInfo(int id);
    }
}
