using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class PrintErrors
    {
        public static void ShowPrintErrors()
        {
			try
			{
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only enter numbers");
            }
			catch (Exception e)
			{
                Console.WriteLine($"Error: {e.Message}");
			}

            Console.WriteLine("Goodbye!");
        }
    }
}
 