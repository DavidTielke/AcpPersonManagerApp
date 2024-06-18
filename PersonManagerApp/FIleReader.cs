using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonManagerApp
{
    public class FileReader
    {
        public string[] ReadAllLines(string path)
        {
            var lines = File.ReadAllLines(path);
            return lines;
        }
    }
}