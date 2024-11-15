using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegtes.DelegatesExample
{
    internal class DelegateExampleTwo
    {
        public delegate void LogHandler(string message);
        public class Logger
        {
            public void LogToConsole(string message)
            {
                Console.WriteLine("Console Log:" + message);
            }

            public void LogToFile(string message)
            {
                Console.WriteLine("File log:" + message);
            }
        }
        public DelegateExampleTwo()
        {
            DelegateExampleTwoMethod();
        }

        private void DelegateExampleTwoMethod()
        {
            Logger logger = new Logger();
            // Logs to the console
            LogHandler logHandler = logger.LogToConsole; // just assign the method without the brackets/body, not calling the method
            logHandler("Logging to console");

            // Logs to the file 
            logHandler = logger.LogToFile;
            logHandler("Log some stuff!");
        }
    }
}
