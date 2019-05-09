using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsAppHarkka.Model;

namespace ContactsAppHarkka.Services
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person GetId(int id);
        Person Create(Person person);
        Person Update(int id, Person person);
        void Delete(int id);
    }
}
