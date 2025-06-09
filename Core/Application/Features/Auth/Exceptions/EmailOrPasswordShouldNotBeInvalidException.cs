using Core.Application.Bases;

namespace Core.Application.Features.Auth.Exception
{
    public class EmailOrPasswordShouldNotBeInvalidException : BaseExceptions
    {
        public EmailOrPasswordShouldNotBeInvalidException() : base("Username or password incorrect!")
        {

        }
    }
}