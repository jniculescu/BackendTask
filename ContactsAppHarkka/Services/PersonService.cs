using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsAppHarkka.Model;
using ContactsAppHarkka.Repositories;

namespace ContactsAppHarkka.Services
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<Person> GetAll()
        {
            return _personRepository.GetAllPeople();
        }

        public Person GetId(int id)
        {
            return _personRepository.GetId(id);
        }

        public Person Create(Person person)
        {
           return _personRepository.Create(person);

        }

        public Person Update(int id, Person person)
        {
            var savedPerson = _personRepository.GetId(id);
            if (savedPerson == null)
                throw new Exception("Person Not Found");
            else
            {
                _personRepository.Update(id, person);
                return person;
            }
        }

        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }
    }
}
