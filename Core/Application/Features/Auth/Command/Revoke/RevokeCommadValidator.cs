using FluentValidation;

namespace Core.Application.Features.Auth.Command.Revoke
{
    public class RevokeCommandValidator : AbstractValidator<RevokeCommandRequest>
    {
        public RevokeCommandValidator()
        {
            RuleFor(x => x.Email)
                            .NotEmpty().WithMessage("Email is required.")
                            .MinimumLength(8).WithMessage("Email must not exceed 8 characters.")
                            .MaximumLength(60).WithMessage("Email must not exceed 60 characters.")
                            .EmailAddress();
        }
    }
}