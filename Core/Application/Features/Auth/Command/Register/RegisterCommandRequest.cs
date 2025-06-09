using MediatR;

namespace Core.Application.Features.Auth.Command.Register
{
    public class RegisterCommandRequest : IRequest<Unit>
    {
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;

    }
}