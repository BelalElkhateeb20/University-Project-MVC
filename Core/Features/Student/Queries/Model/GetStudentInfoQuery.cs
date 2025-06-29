using Domain.Models.Entities;
using Domain.Models.ModelView;
using MediatR;


namespace Core.Features.Students.Queries.Model
{
    public class GetStudentInfoQuery:IRequest<StudentInfoMV>
    {
        public int ID { get; set; }
        public int secID { get; set; }
    }
}
