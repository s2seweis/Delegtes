using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegtes.DelegatesExample
{
    public class DelegateExampleOne
    {

        // 1. Declaration: Once there is a delegate keyword we not add a body to it like for an method
        public delegate void Notify(string message);
        public DelegateExampleOne()
        {
            DelegateExampleMethod();
        }

        private void DelegateExampleMethod()
        {
            // Delegates define a method signature 
            // and any method assigned to a delegate must match this signature 

            // 2. Instantiation:
            Notify notifyDelegate = ShowMessage; // One way
            //Notify notifyDelegate = new Notify(notifyDelegate); // Other way


            // 3. Invocation:
            notifyDelegate("Just a simple Text!");
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

// Delegates can be declared inside or outside of any given class, but it depends on the use case,
// Its remommended not use it inside of a class but you can do if its related to the class
// So declare the delegate outside if a class