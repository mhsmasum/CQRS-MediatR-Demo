using CQRS_medator.Models;
using MediatR;

namespace CQRS_medator.Queries
{
    public class GetPersonListQuery:IRequest<List<Person>>
    {
    }
}
