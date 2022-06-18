using CQRS_medator.Models;
using MediatR;

namespace CQRS_medator.Queries
{

    //public record GetPersonByIdQuery (int id) :IRequest<Person>;
    public class GetPersonByIdQuery : IRequest<Person>
    {
        public int Id { get; set; }
        public GetPersonByIdQuery(int id)
        {
            Id = id;    
        }
    }
}
