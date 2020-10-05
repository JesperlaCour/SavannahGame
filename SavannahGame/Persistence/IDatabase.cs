using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistence
{
    public interface IDatabase
    {
        void SaveLogFile(List<string> LogFile, string filePath);
    }
}
