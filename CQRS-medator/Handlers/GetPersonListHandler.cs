using CQRS_medator.Models;
using CQRS_medator.Queries;
using CQRS_medator.Repositories;
using MediatR;

namespace CQRS_medator.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<Person>>
    {
        private IPersonRepository _personRepository;

        public GetPersonListHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public async Task<List<Person>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return  _personRepository.GetAll();
        }
    }
}
