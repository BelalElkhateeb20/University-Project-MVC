using Core.Features.Students.Queries.Model;
using Domain.Models.ModelView;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace School_Project_MVC.Controllers
{
    public class StudentController(IMediator mediator) : Controller
    {
        private readonly IMediator _mediator = mediator;

        public IActionResult AddStudentAsync()
        {
            return View();
        }
        public async Task<IActionResult> StudentInfo(GetStudentInfoQuery getStudentInfoQuery)
        {
            var response = await _mediator.Send(getStudentInfoQuery);
            return View("StudentInfo",response);
        }
    }
}
