using CQRS_medator.Models;
using MediatR;

namespace CQRS_medator.Commands
{
    public class InsertPersonCommand:IRequest<Person>
    {
        public string Name { get; set; }

        public InsertPersonCommand(string name)
        {
            Name = name;    
        }
    }


}
