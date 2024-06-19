using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.FileStorage;

namespace DavidTielke.PMA.Data.DataStorage
{
    public class PersonRepository : IPersonRepository
    {
        private IPersonParser _personParser;
        private IFileReader _fileReader;

        public PersonRepository(IPersonParser personParser, 
            IFileReader fileReader)
        {
            _personParser = personParser;
            _fileReader = fileReader;
        }

        public IQueryable<Person> Query()
        {
            var dataLines = _fileReader.ReadAllLines("data.csv");
            var persons = dataLines.Select(l => _personParser.ParseCsv(l));
            return persons.AsQueryable();
        }
    }
}