using Core.Application.Bases;

namespace Core.Application.Features.Auth.Exception
{
    public class UserAlreadyExistException : BaseExceptions
    {
        public UserAlreadyExistException() : base("Already user!")
        {

        }
    }
}