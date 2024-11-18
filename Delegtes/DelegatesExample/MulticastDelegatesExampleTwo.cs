using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegtes.DelegatesExample
{
    internal class MulticastDelegatesExampleTwo
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
            static void InvokeSafely(LogHandler logHandler, string message)
            {
                LogHandler tempLogHandler = logHandler;
                if (tempLogHandler != null)
                {
                    tempLogHandler(message);
                }
            }

        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if(logHandler == null)
            {
                return false;
            }
            foreach(var d in logHandler.GetInvocationList())
            {
                if(d == (Delegate) method)
                {
                    return true;
                }
            }
            return false;
        }

        public MulticastDelegatesExampleTwo()
        {
            MulticastDelegatesExampleMethod();
        }

        public void MulticastDelegatesExampleMethod()
        {
            // Creating a multicast delegate
            Logger logger = new Logger();
            // Logs to the console
            LogHandler logHandler = logger.LogToConsole; // just assign the method without the brackets/body, not calling the method
            //logHandler("Logging to console");
            // This makes out log handler a multicast delegate because it has two methods assigned to it: 1. LogToFile(), 2. LogToConsole()

            //Console.WriteLine("Add a method to the Delegate:");
            //logHandler += logger.LogToFile; // Adding Another Method to the Delegate (Multicast Delegate), += operator is used to add a method to an existing delegate

            // Invokes the multicast delegate
            // logHandler calls now to methods: 1. LogToFile(), 2. LogToConsole() 
            //logHandler("Log this info!");

            // Invoke it safely
            foreach(LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling!");
                } catch (Exception ex)
                {
                    Console.WriteLine("Exception caught: " + ex.ToString());
                }
            }

            //Console.WriteLine("Remove a method from the Delegate:");
            //logHandler -= logger.LogToFile;

            if(IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
                Console.WriteLine("Log to file method removed");
            }

            if(logHandler != null)
            {
            InvokeSafely(logHandler, "Only one method should do a log!");
            }

            //logHandler("Only one method should do a log!");

            // Logs to the file 
            //logHandler = logger.LogToFile;
            //logHandler("Log some stuff!");

        }
    }
}
