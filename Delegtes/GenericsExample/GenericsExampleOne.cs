using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.GenericsExample
{
    internal class GenericsExampleOne
    {
        public GenericsExampleOne()
        {
            // Example usage of generic method
            int[] intArray = { 1, 2, 3, 4, 5 };
            string[] stringArray = { "Hello", "World", "Generics", "Example" };

            // Using the generic method
            PrintArray(intArray);
            PrintArray(stringArray);
            // Using not generic method
            PrintIntArray(intArray);
            PrintStringArray(stringArray);
        }


        // ####################################################### - Makes it simpler

        // Generic method for printing any type of array
        // Angle brackets t they are indicationg that this is a generics method,
        // Handles generic data types, the T sands for any data type
        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }

        // #######################################################
        
        // Not Generic method
        // Method for printing an integer array
        public static void PrintIntArray(int[] array)
        {
            Console.WriteLine("Integer Array:");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        // Method for printing a string array
        public static void PrintStringArray(string[] array)
        {
            Console.WriteLine("String Array:");
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
