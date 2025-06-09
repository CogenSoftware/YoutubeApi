using MediatR;

namespace Core.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest : IRequest<LoginCommandResponse>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}