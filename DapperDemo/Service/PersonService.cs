using DapperDemo.DataModel;
using DapperDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Service
{
    public class PersonService
    {
        private readonly PersonRepository _personRepository;
        public PersonService()
        {
            _personRepository = new PersonRepository();
        }

        public IEnumerable<Person> GetPeople()
        {
            return _personRepository.GetPeople();
        }

        public IEnumerable<Person> GetByLastName(string lastName)
        {
            return _personRepository.GetByLastName(lastName);
        }

        public IEnumerable<Person> GetByLastNameByStoreProcedure(string lastName)
        {
            return _personRepository.GetByLastName(lastName);
        }

        public void InsertNewPerson(string firstName, string lastName)
        {
            _personRepository.InsertNewPerson(firstName, lastName);
        }

    }
}
