using CQRS_medator.Commands;
using CQRS_medator.Models;
using CQRS_medator.Repositories;
using MediatR;

namespace CQRS_medator.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, Person>
    {
        private readonly IPersonRepository _personRepository;
        public InsertPersonHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public async Task<Person> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            Person aPerson = new ();
            aPerson.Name = request.Name;
           await _personRepository.SavePerson(aPerson);
            return aPerson;
        }
    }
}
