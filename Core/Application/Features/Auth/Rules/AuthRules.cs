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
    }
}