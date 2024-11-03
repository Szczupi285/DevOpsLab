using MediatR;

namespace WebApi.Commands
{
    public class GetPersonCommandHandler : IRequestHandler<GetPersonCommand, Person>
    {
        private Person _person;

        public GetPersonCommandHandler()
        {
            _person = new(Guid.NewGuid(), "John", "Doe");
        }

        async Task<Person> IRequestHandler<GetPersonCommand, Person>.Handle(GetPersonCommand request, CancellationToken cancellationToken)
        {
            await Task.Delay(1, cancellationToken);
            return _person;
        }
    }
}