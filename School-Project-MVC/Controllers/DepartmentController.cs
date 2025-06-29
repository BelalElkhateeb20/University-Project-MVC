using Core.Features.Departments.Queries.Handler;
using Core.Features.Departments.Queries.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace School_Project_MVC.Controllers
{
    public class DepartmentController(IMediator mediator) : Controller
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments(GetAllDepartmentQuery getAll)
        {
            var response = await _mediator.Send(getAll);
            return View("GetAllDepartments", response);
        }
    }
}
