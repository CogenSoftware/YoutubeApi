using Core.Application.Bases;

namespace Core.Application.Features.Auth.Exception
{
    public class RefreshTokenShouldNotBeExpiredException : BaseExceptions
    {
        public RefreshTokenShouldNotBeExpiredException() : base("Please sign in!")
        {

        }
    }
}