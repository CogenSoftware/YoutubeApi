using Core.Application.Bases;
using Core.Application.Features.Auth.Exception;
using Core.Domain.Entities;

namespace Core.Application.Features.Auth.Command.Rules
{
    public class AuthRules : BaseRules
    {
        public Task UserShouldNotBeExits(User? user)
        {
            if (user is not null) throw new UserAlreadyExistException();
            return Task.CompletedTask;
        }

        public Task EmailOrPasswordShouldNotBeInvalid(User? user, bool checkPassword)
        {
            if (user is null || !checkPassword) throw new EmailOrPasswordShouldNotBeInvalidException();
            return Task.CompletedTask;
        }

        public Task RefreshTokenShouldNotBeExpired(DateTime? expiryDate)
        {
            if (expiryDate <= DateTime.Now) throw new RefreshTokenShouldNotBeExpiredException();
            return Task.CompletedTask;
        }

        public Task EmailShouldNotBeInvalid(User? user)
        {
            if (user is null) throw new EmailShouldNotBeInvalidException();
            return Task.CompletedTask;
        }
    }
}