namespace DavidTielke.PMA.Data.FileStorage
{
    public class FileReader : IFileReader
    {
        public string[] ReadAllLines(string path)
        {
            var lines = File.ReadAllLines(path);
            return lines;
        }
    }
}