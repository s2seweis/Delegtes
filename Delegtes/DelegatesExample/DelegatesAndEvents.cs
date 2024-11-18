using System;

namespace Delegtes.DelegatesExample
{
    internal class DelegatesAndEvents
    {
        // Define a delegate to compare two Person objects
        public delegate int Comparison<T>(T x, T y);

        // Person class with properties Age and Name
        public class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }

        // PersonSorter class to sort the array using a Comparison delegate
        public class PersonSorter
        {
            // Sort method to sort the 'people' array using a delegate for comparison
            public void Sort(Person[] people, Comparison<Person> comparison)
            {
                // Iterate through the array using a simple bubble sort
                for (int i = 0; i < people.Length - 1; i++)
                {
                    for (int j = i + 1; j < people.Length; j++)
                    {
                        // Use the provided comparison delegate to compare people[i] and people[j]
                        if (comparison(people[i], people[j]) > 0)
                        {
                            // Swap people[i] and people[j] to maintain the correct order
                            Person temp = people[i];
                            people[i] = people[j];
                            people[j] = temp;
                        }
                    }
                }
            }

            // Method to sort by age and display result
            public void SortByAgeAndDisplay(Person[] people)
            {
                Sort(people, CompareByAge);
                DisplayPeople(people, "Age");
            }

            // Method to sort by name and display result
            public void SortByNameAndDisplay(Person[] people)
            {
                Sort(people, CompareByName);
                DisplayPeople(people, "Name");
            }

            // Comparison method to sort by Age
            private static int CompareByAge(Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            }

            // Comparison method to sort by Name
            private static int CompareByName(Person x, Person y)
            {
                return x.Name.CompareTo(y.Name);
            }

            // Display people after sorting
            private void DisplayPeople(Person[] people, string sortCriteria)
            {
                Console.WriteLine($"\nSorted by {sortCriteria}:");
                foreach (Person person in people)
                {
                    Console.WriteLine($"{person.Name}, {person.Age}");
                }
            }
        }
    }
}
