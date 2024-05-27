using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class LocalAutoWindow
    {
        public static void ShowWindow()
        {
            // Autos tab will display values based on current position
            // Locals will show all the variables
            // Watch will watch the variables by highlighting variables and choosing watch (pinboard)
            string name = "Hyper";
            int age;
            age = 23;

            PrintDetails(name, age);
        }

        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
        }
    }
}
