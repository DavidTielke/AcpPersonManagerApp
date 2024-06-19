using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.FileStorage;

namespace DavidTielke.PMA.Data.DataStorage
{
    public class PersonRepository
    {
        private PersonParser _personParser;
        private FileReader _fileReader;

        public PersonRepository()
        {
            _personParser = new PersonParser();
            _fileReader = new FileReader();
        }

        public IQueryable<Person> Query()
        {
            var dataLines = _fileReader.ReadAllLines("data.csv");
            var persons = dataLines.Select(l => _personParser.ParseCsv(l));
            return persons.AsQueryable();
        }
    }
}