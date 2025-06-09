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

namespace Core.Application.Features.Auth.Command.Login
{
    public class LoginCommandHandler : BaseHandler, IRequestHandler<LoginCommandRequest, LoginCommandResponse>
    {
        private readonly AuthRules _authRules;
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _configuration;
        public LoginCommandHandler(AuthRules authRules, UserManager<User> userManager, ITokenService tokenService, IConfiguration configuration, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _authRules = authRules;
            _userManager = userManager;
            _tokenService = tokenService;
            _configuration = configuration;
        }

        public async Task<LoginCommandResponse> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
            User user = await _userManager.FindByEmailAsync(request.Email);
            bool checkPassword = await _userManager.CheckPasswordAsync(user, request.Password);

            await _authRules.EmailOrPasswordShouldNotBeInvalid(user, checkPassword);

            IList<string> roles = await _userManager.GetRolesAsync(user);
            JwtSecurityToken jwtSecurityToken = await _tokenService.CreateToken(user, roles);
            string refreshToken = _tokenService.GenerateRefreshToken();
            int.TryParse(_configuration["JWT:RefreshTokenValidityDays"], out int refreshTokenValidityDays);

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(refreshTokenValidityDays);

            await _userManager.UpdateAsync(user);
            await _userManager.UpdateSecurityStampAsync(user);

            string token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            await _userManager.SetAuthenticationTokenAsync(user, "Default", "AccessToken", token);

            return new()
            {
                Token = token,
                RefreshToken = refreshToken,
                Expiration = jwtSecurityToken.ValidTo
            };
        }
    }
}