using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStorage;

public interface IPersonParser
{
    Person ParseCsv(string dataLine);
}