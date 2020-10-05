using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;


namespace Persistence
{
    public class TextFile : IDatabase
    {
        public void SaveLogFile(List<string> LogFile,string filePath)
        {

            File.WriteAllLines(filePath, LogFile);
        }
    }
}
