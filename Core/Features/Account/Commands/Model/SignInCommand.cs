using Core.ResponeBase;
using MediatR;

namespace Core.Features.Account.Commands.Model
{
    public class SignInCommand:IRequest<Response<string>>
    {
        public int id { get; set; }
        public string Passward { get; set; }
        public bool RememberMe { get; set; }
    }
}
