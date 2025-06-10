using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Core.Application.Bases;
using Core.Application.Features.Auth.Command.Rules;
using Core.Application.Interfaces.AutoMapper;
using Core.Application.Interfaces.Tokens;
using Core.Application.Interfaces.UnitOfWorks;
using Core.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Core.Application.Features.Auth.Command.RefreshToken
{
    public class RefreshTokenCommandHandler : BaseHandler, IRequestHandler<RefreshTokenCommandRequest, RefreshTokenCommandResponse>
    {
        private readonly AuthRules _authRules;
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;
        public RefreshTokenCommandHandler(AuthRules authRules, UserManager<User> userManager, ITokenService tokenService, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _authRules = authRules;
            _userManager = userManager;
            _tokenService = tokenService;
        }

        public async Task<RefreshTokenCommandResponse> Handle(RefreshTokenCommandRequest request, CancellationToken cancellationToken)
        {
            var principal = _tokenService.GetPrincipalFromExpiredToken(request.AccessToken);
            string email = principal.FindFirstValue(ClaimTypes.Email);

            User user = await _userManager.FindByEmailAsync(email);

            IList<string> roles = await _userManager.GetRolesAsync(user);

            await _authRules.RefreshTokenShouldNotBeExpired(user.RefreshTokenExpiryTime);

            JwtSecurityToken jwtSecurityToken = await _tokenService.CreateToken(user, roles);
            string refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;

            await _userManager.UpdateAsync(user);

            string token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

            return new()
            {
                AccessToken = token,
                RefreshToken = refreshToken,
            };
        }
    }
}