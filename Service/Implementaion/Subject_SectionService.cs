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
    public class Subject_SectionService(DBContext dBContext) : ISubject_SectionService
    {
        private readonly DBContext _dBContext = dBContext;

        public Task<Subject_Section> GetSubject_SectionInfo(int id)
        {
            var sectioninfo = _dBContext.subject_Sections.FirstOrDefaultAsync(s => s.SectionId == id);
            return sectioninfo;
        }
    }
}
