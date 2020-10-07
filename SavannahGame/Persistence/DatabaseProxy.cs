using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DatabaseProxy : IDatabase
    {
        
        public void SaveLogFile(List<string> LogFile, string filePath)
        {

            //example on using proxy on persistence layer. Filepath choosen on GUI is disrupted -illustrated with thrown exception. 
            try
            {
                //throw new Exception();
                IDatabase db = new TextFile();
                db.SaveLogFile(LogFile, filePath);
            }
            catch (Exception)
            {
                IDatabase db = new TextFile();
                filePath = @"c:/logfile.txt";
                db.SaveLogFile(LogFile, filePath);
            }
            
        }
    }
}
