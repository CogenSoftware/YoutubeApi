using System.IdentityModel.Tokens.Jwt;
using Core.Application.Bases;
using Core.Application.Features.Auth.Command.Rules;
using Core.Application.Interfaces.AutoMapper;
using Core.Application.Interfaces.Tokens;
using Core.Application.Interfaces.UnitOfWorks;
using Core.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Core.Application.Features.Auth.Command.Revoke
{
    public class RevokeCommandHandler : BaseHandler, IRequestHandler<RevokeCommandRequest, Unit>
    {
        private readonly AuthRules _authRules;
        private readonly UserManager<User> _userManager;
        public RevokeCommandHandler(AuthRules authRules, UserManager<User> userManager, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _authRules = authRules;
            _userManager = userManager;
        }

        public async Task<Unit> Handle(RevokeCommandRequest request, CancellationToken cancellationToken)
        {
            User user = await _userManager.FindByEmailAsync(request.Email);
            await _authRules.EmailShouldNotBeInvalid(user);

            user.RefreshToken = null;

            await _userManager.UpdateAsync(user);

            return Unit.Value;
        }
    }
}