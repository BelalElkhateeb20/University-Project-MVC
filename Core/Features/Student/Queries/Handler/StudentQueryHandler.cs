using Core.Features.Students.Queries.Model;
using Domain.Models.ModelView;
using Infrastructure.Abstractions;
using MediatR;
using Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Features.Students.Queries.Handler
{
    public class StudentQueryHandler(IStudentService studentService ,ISubject_SectionService subject_SectionService) : IRequestHandler<GetStudentInfoQuery, StudentInfoMV>
    {
        private readonly IStudentService _studentService = studentService;
        private readonly ISubject_SectionService _subject_SectionService = subject_SectionService;

        public async Task<StudentInfoMV> Handle(GetStudentInfoQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentInfo(request.ID);
            var sub_secinfo =await _subject_SectionService.GetSubject_SectionInfo(request.secID);
            var studentinfo = new StudentInfoMV
            {
                student = student,
                Subject_Section = sub_secinfo
            };
            return studentinfo;
        }
    }
}
