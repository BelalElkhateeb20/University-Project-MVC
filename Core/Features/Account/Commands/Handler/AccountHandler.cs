using Core.Features.Account.Commands.Model;
using Core.LocalizationResource;
using Core.ResponeBase;
using Domain.Models.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using Infrastructure.Abstractions;


namespace Core.Features.Account.Commands.Handler
{
    public class AccountHandler(IStudentService studentService, IStringLocalizer<SharedResources> localizer
        , UserManager<User> userManager
        , SignInManager<User> signInManager) : ResponseHandler(localizer)
        , IRequestHandler<SignInCommand, Response<string>>
    {
        private readonly IStudentService _studentService = studentService;
        private readonly IStringLocalizer<SharedResources> _localizer = localizer;
        private readonly UserManager<User> _userManager = userManager;
        private readonly SignInManager<User> _signInManager = signInManager;

        public async Task<Response<string>> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentInfo(request.id);
            if (student == null) return NotFound<string>(_localizer[SharedResourcesKeys.NotFound]);
            var user = await _userManager.FindByNameAsync(student.NameEN);
            if (user is null)
                return NotFound<string>(_localizer[SharedResourcesKeys.UserNameIsNotExist]);

            var signInResult = await _signInManager.CheckPasswordSignInAsync(user, request.Passward, lockoutOnFailure: true);
            if (!signInResult.Succeeded)
                return Faild<string>(_localizer[SharedResourcesKeys.UserNameOrPasswardIsWrong]);

            if (!user.EmailConfirmed)
                return Faild<string>(_localizer[SharedResourcesKeys.EmailNotConfirmed]);

            // ✅ تسجيل الدخول باستخدام الكوكي
            var result =  _signInManager.SignInAsync(user, isPersistent: request.RememberMe);
            if(!result.IsCompleted) return Faild<string>(_localizer[SharedResourcesKeys.ProcessFailed]);

            return Success<string>(_localizer[SharedResourcesKeys.Success]);
        }
    }
}

