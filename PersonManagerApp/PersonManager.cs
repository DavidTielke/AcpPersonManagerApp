using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonManagerApp
{
    public class PersonManager
    {
        private readonly PersonRepository _personRepository;

        public PersonManager()
        {
            _personRepository = new PersonRepository();
        }

        public IQueryable<Person> GetAllAdults()
        {
            var adults = _personRepository.Query().Where(p => p.Age >= 18);
            return adults;
        }

        public IQueryable<Person> GetAllChildren()
        {
            var children = _personRepository.Query().Where(p => p.Age < 18);
            return children;
        }
    }
}