using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class Debugging
    {
        public static void ShowDebugging()
        {
            // Example 1 

            int age = 35;   // Place breakpoint at this line

            if (age > 18)    // Hover over this
            {
                Console.WriteLine("18+");
            }   
            else if (age > 30)  // Hover over this
            {
                Console.WriteLine("30+");
            }

            // Example 2
            string name = "Hyper";  // Place breakpoint here
            int age2;   // Default value 0
            age2 = 23;

            PrintDetails(name, age2);   // Step in to get into the function (Step over ignores the function)

            // Example 
            string message = ReadFromConsole("Enter anything"); // Put break point here, then step into
            Console.WriteLine(message);
        }

        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
        }

        static string ReadFromConsole(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
