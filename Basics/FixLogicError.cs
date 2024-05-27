using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class FixLogicError
    {
        public static void ShowFixLogicError()
        {
            int age = 35;

            if (age > 18 && age < 30)
            {
                Console.WriteLine("Over 18");
            }
            else if (age > 30 && age < 50)
            {
                Console.WriteLine("Over 30");
            }
            else if (age > 50)
            {
                Console.WriteLine("Over 50");
            }
        }
    }
}
