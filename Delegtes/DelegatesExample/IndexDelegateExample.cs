using System;
using static Delegtes.DelegatesExample.DelegatesAndEvents;

namespace Delegtes.DelegatesExample
{
    internal class IndexDelegateExample
    {
        // Constructor that initializes the process
        public IndexDelegateExample()
        {
            IndexDelegateExampleMethod();
        }

        public void IndexDelegateExampleMethod()
        {
            // Create an array of Person objects with Name and Age
            Person[] people =
            {
                new Person {Name ="Alice", Age = 30},
                new Person {Name ="Bob", Age = 25},
                new Person {Name ="Dennis", Age = 26},
                new Person {Name ="Charlie", Age = 19}
            };

            //// Create an instance of PersonSorter
            //PersonSorter personSorter = new PersonSorter();

            //// Sort by age (numbers) and display results using a foreach loop
            //personSorter.SortByAgeAndDisplay(people);

            //// Sort by name (alphabetical) and display results using a foreach loop
            //personSorter.SortByNameAndDisplay(people);

            //MulticastDelegatesExample multicastDelegatesExample = new MulticastDelegatesExample();

            //MulticastDelegatesExampleTwo multicastDelegatesExampleTwo = new MulticastDelegatesExampleTwo();

            EventsExample eventsExample = new EventsExample();
        }
    }
}
