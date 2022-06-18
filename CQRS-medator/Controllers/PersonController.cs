using CQRS_medator.Commands;
using CQRS_medator.Models;
using CQRS_medator.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_medator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var data =  await _mediator.Send(new GetPersonListQuery());
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Person person)
        {
            var data = await _mediator.Send(new InsertPersonCommand(person.Name));
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _mediator.Send(new GetPersonByIdQuery(id));
            return Ok(data);
        }
    }
}
