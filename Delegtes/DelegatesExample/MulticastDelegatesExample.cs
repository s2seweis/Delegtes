using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegtes.DelegatesExample.DelegateExampleTwo;

namespace Delegtes.DelegatesExample
{
    internal class MulticastDelegatesExample
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

        public MulticastDelegatesExample()
        {
            MulticastDelegatesExampleMethod();
        }

        private void MulticastDelegatesExampleMethod()
        {
            Logger logger = new Logger();
            // Logs to the console
            LogHandler logHandler = logger.LogToConsole; // just assign the method without the brackets/body, not calling the method
            //logHandler("Logging to console");
            // This makes out log handler a multicast delegate because it has two methods assigned to it: 1. LogToFile(), 2. LogToConsole()

            Console.WriteLine("Add a method to the Delegate:");
            logHandler += logger.LogToFile; // Adding Another Method to the Delegate (Multicast Delegate), += operator is used to add a method to an existing delegate

            // Invokes the multicast delegate
            // logHandler calls now to methods: 1. LogToFile(), 2. LogToConsole() 
            logHandler("Log this info!");

            Console.WriteLine("Remove a method from the Delegate:");
            logHandler -= logger.LogToFile;
            logHandler("Only one method should do a log!");

            // Logs to the file 
            logHandler = logger.LogToFile;
            //logHandler("Log some stuff!");

        }
    }

   
}

// Multicast Delegates ?

/*
What are Multicast Delegates in C#? 
A multicast delegate in C# is a delegate that holds references to and can invoke multiple methods. 

Why use Multicast Delegates in C#?
You would use a multicast delegate to allow multiple methods tp be called in a sequence through a single delegate invocation.

When use Multicast Delegates in C#?
You would use a multicast delegate when you need to notify multiple event handlers or 
execute multiple related methods in response to a single event or operation. 
 */
