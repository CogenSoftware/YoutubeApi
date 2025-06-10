using MediatR;

namespace Core.Application.Features.Auth.Command.RevokeAll
{
    public class RevokeAllCommandRequest : IRequest<Unit>
    {
    }
}