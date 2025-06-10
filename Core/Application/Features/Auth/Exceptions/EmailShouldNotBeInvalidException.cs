using Core.Application.Bases;

namespace Core.Application.Features.Auth.Exception
{
    public class EmailShouldNotBeInvalidException : BaseExceptions
    {
        public EmailShouldNotBeInvalidException() : base("Username not found!")
        {

        }
    }
}