using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactsAppHarkka.Services;
using ContactsAppHarkka.Model;

namespace ContactsAppHarkka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<Person> GetAll()
        {
            var persons = _personService.GetAll();
            return new JsonResult(persons);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            var person = _personService.GetId(id);
            return person;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Person> Create(Person person)
        {
            var newPerson = _personService.Create(person);
            return newPerson;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Person Update(int id, Person person)
        {
            var updatedPerson = _personService.Update(id, person);
            return updatedPerson;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _personService.Delete(id);
            return new NoContentResult();
        }
    }
}
