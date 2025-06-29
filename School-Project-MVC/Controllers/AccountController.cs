using Core.Features.Account.Commands.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace School_Project_MVC.Controllers
{
    public class AccountController(IMediator mediator) : Controller
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost]
        public async Task<IActionResult> LoginInAsync(SignInCommand signInCommand)
        {
            if (!ModelState.IsValid)
                return View(signInCommand);

            var response = await _mediator.Send(signInCommand);

            if (!response.Succeeded)
            {
                ModelState.AddModelError(string.Empty, response.Message);
                return View(signInCommand);
            }

            return RedirectToAction("Index", "Home");
        }
        public  IActionResult Login()
        {
            return View("Login");
        }

    }
}
