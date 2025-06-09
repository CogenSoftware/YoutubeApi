using FluentValidation;

namespace Core.Application.Features.Auth.Command.Login
{
    public class LoginCommandValidator : AbstractValidator<LoginCommandRequest>
    {
        public LoginCommandValidator()
        {
            RuleFor(x => x.Email)
                            .NotEmpty().WithMessage("Email is required.")
                            .MinimumLength(8).WithMessage("Email must not exceed 8 characters.")
                            .MaximumLength(60).WithMessage("Email must not exceed 60 characters.")
                            .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must not exceed 10 characters.")
                .MaximumLength(10).WithMessage("Password must not exceed 10 characters.");
        }
    }
}