namespace DavidTielke.PMA.Data.FileStorage;

public interface IFileReader
{
    string[] ReadAllLines(string path);
}