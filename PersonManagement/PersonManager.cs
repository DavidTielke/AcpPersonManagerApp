using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStorage;

namespace DavidTielke.PMA.Logic.PersonManagement
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _personRepository;

        public PersonManager(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
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