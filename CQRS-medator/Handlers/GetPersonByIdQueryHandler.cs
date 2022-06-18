using CQRS_medator.Models;
using CQRS_medator.Queries;
using CQRS_medator.Repositories;
using MediatR;

namespace CQRS_medator.Handlers
{
    public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, Person>
    {
        private readonly IPersonRepository _personRepository;

        public GetPersonByIdQueryHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

       

        public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return _personRepository.GetAll().FirstOrDefault(a => a.Id == request.Id);
        }
    }
}
