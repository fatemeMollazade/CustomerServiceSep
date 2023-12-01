using CustomerService.Core.ApplicationService.People.Commands.PersonCreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Endpoints.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonCreateCommandHandler personService;

        public PersonController(PersonCreateCommandHandler personService)
        {
            this.personService = personService;
        }
        [HttpPost]
        public IActionResult AddPerson(PersonCreateCommand input) 
        {
            personService.AddPerson(input);
            return Ok();
        }
    }
}
