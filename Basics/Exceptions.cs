using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class Exceptions
    {
        public static void ShowExceptions()
        {

            // System.FormatException
            // System.Overflow Exception
            bool looping = true;
            
            while (looping)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(num);
                    looping = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please only enter numbers");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please only enter a number less than 2 billion");
                }
                catch (Exception)   // Catch all
                {
                    Console.WriteLine("Something has went wrong");
                }
            }

            Console.WriteLine("Goodbye");
        }
    }
}
