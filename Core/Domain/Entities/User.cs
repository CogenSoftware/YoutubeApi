using Microsoft.AspNetCore.Identity;

namespace Core.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; } = null!;
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}