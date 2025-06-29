using Core.Features.Departments.Queries.Model;
using Core.LocalizationResource;
using Core.ResponeBase;
using Domain.Models.Entities;
using MediatR;
using Microsoft.Extensions.Localization;
using Service.Abstractions;

namespace Core.Features.Departments.Queries.Handler
{
    public class DepartmentQueryHandler(IDepartmentService departmentService ) : IRequestHandler<GetAllDepartmentQuery, List<Department>>
    {
        private readonly IDepartmentService _departmentService = departmentService;

        public Task<List<Department>> Handle(GetAllDepartmentQuery request, CancellationToken cancellationToken)
        {
            var depatments = _departmentService.GetAllDepartment();
            if (depatments == null)
            {
                throw new KeyNotFoundException("Departments Not Fouend");
            }
            return depatments;
        }


    }
}
