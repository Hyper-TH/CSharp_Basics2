using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class CustomTryParse
    {
        public static void ShowCustomTryParse()
        {
            /*
             * Create an int array and try convert any string to an int
             * Notice the rror, write a try...catch handler around it
             * Catch the error and output the error message
             * Without changint the current code
             * 
             * Why is this a bad situation and how can we know if its been converted?
             * 
             * Create a custom try parse function
             * Find the real function and copy return type/params
             * Read the tooltip it gives you, to give you ideas on what to do
            */

            const int LENGTH = 10;
            int[] arr1 = new int[LENGTH];
            int[] arr2 = new int[LENGTH];
            int result;
            bool success = false;

            for (int i = 0; i < LENGTH; i++)
            {
                arr1[i] = ReadInt("Enter a number");

                do
                {
                    success = TryParse(Console.ReadLine(), out result);
                } while (!success);

                arr2[i] = result;
            }

            Console.WriteLine("Array 1:");
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Array 2:");
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }
        
        static int ReadInt(string message)
        {
            Console.WriteLine(message);

            bool running = true;
            int num = 0;

            while (running)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());

                    running = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"{e.Message}: Enter an int");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine($"{e.Message}: Enter a number less than 2 billion");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e}");
                }
            }

            return num;
        }

        // Custom Try Parse
        static bool TryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32((string)input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
