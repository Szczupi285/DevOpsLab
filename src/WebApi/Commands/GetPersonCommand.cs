using MediatR;

namespace WebApi.Commands
{
    public record GetPersonCommand() : IRequest<Person>;
}