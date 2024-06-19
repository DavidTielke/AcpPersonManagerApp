using DavidTielke.PMA.CrossCutting.Configuration;
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStorage;

namespace DavidTielke.PMA.Logic.PersonManagement
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _personRepository;
        private readonly IConfigurator _config;
        private readonly int AGETRESHOLD;

        public PersonManager(IPersonRepository personRepository, IConfigurator config)
        {
            _personRepository = personRepository;
            _config = config;
            AGETRESHOLD = _config.Get<int>("AgeTreshold");
        }

        public IQueryable<Person> GetAllAdults()
        {
            var adults = _personRepository.Query().Where(p => p.Age >= AGETRESHOLD);
            return adults;
        }

        public IQueryable<Person> GetAllChildren()
        {
            var children = _personRepository.Query().Where(p => p.Age < AGETRESHOLD);
            return children;
        }
    }
}