using DavidTielke.PMA.CrossCutting.Configuration;
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.FileStorage;

namespace DavidTielke.PMA.Data.DataStorage
{
    public class PersonRepository : IPersonRepository
    {
        private IPersonParser _personParser;
        private IFileReader _fileReader;
        private readonly IConfigurator _config;
        private readonly string PATH;

        public PersonRepository(IPersonParser personParser, 
            IFileReader fileReader,
            IConfigurator config)
        {
            _personParser = personParser;
            _fileReader = fileReader;
            _config = config;
            PATH = _config.Get<string>("CsvPath");
        }

        public IQueryable<Person> Query()
        {
            var dataLines = _fileReader.ReadAllLines("data.csv");
            var persons = dataLines.Select(l => _personParser.ParseCsv(l));
            return persons.AsQueryable();
        }
    }
}