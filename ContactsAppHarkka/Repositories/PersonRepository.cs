using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsAppHarkka.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactsAppHarkka.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private PersontestdbContext _context;

        public PersonRepository(PersontestdbContext context)
        {
            _context = context;
        }

        public List<Person> GetAllPeople()
        {
            return _context.Person.ToList();
        }

        public Person GetId(int id)
        {
            return _context.Person.AsNoTracking().FirstOrDefault(p => p.Id == id);
        }

        public Person Create(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
            return person;
        }

        public Person Update(int id, Person person)
        {
            var personToUpdate = GetId(id);
            personToUpdate = person;
            _context.Person.Update(personToUpdate);
            _context.SaveChanges();
            return person;
        }

        public void Delete(int id)
        {
            var personToDelete = GetId(id);
            _context.Person.Remove(personToDelete);
            _context.SaveChanges();
        }
    }
}
