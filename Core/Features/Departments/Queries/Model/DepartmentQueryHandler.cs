using Domain.Models.Entities;
using MediatR;

namespace Core.Features.Departments.Queries.Model
{
    public class GetAllDepartmentQuery : IRequest<List<Department>>
    {
        public GetAllDepartmentQuery()
        {
            
        }
    }
}
