using FluentValidation;

namespace Core.Application.Features.Auth.Command.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommandRequest>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("FullName is required.")
                .MinimumLength(2).WithMessage("FullName must not exceed 2 characters.")
                .MaximumLength(50).WithMessage("FullName must not exceed 50 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .MinimumLength(8).WithMessage("Email must not exceed 8 characters.")
                .MaximumLength(60).WithMessage("Email must not exceed 60 characters.")
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must not exceed 10 characters.")
                .MaximumLength(10).WithMessage("Password must not exceed 10 characters.");

            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage("ConfirmPassword is required.")
                .MinimumLength(6).WithMessage("ConfirmPassword must not exceed 10 characters.")
                .MaximumLength(10).WithMessage("ConfirmPassword must not exceed 10 characters.")
                .Equal(x => x.Password);
        }
    }
}