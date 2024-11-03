using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Commands;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator medaiator)
        {
            _mediator = medaiator;
        }

        [HttpGet]
        public async Task<ActionResult> GetPerson()
        {
            var person = await _mediator.Send(new GetPersonCommand());
            return Ok(person);
        }
    }
}