using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Test.Model;
using Test.Services.Interface;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var person = _personService.GetById(id);
            return JsonConvert.SerializeObject(person);
        }
        [HttpPut()]
        public void Put([FromBody] Person person)
        {
            _personService.Save(person);
        }
        [HttpGet("GetAll")]
        public string GetAll()
        {
            List<Person> person = _personService.GetAll();
            return JsonConvert.SerializeObject(person);
        }
    }
}
