using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Basics
{
    public static class Structures
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;
            public int number;

            // Constructor
            public Person(string name, int age, int birthMonth, int number)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
                this.number = number;
            }
        }

        public static void ShowStructures()
        {
            /*
            Person person;

            person.name = "Hyper";
            person.age = 23;
            person.birthMonth = 10;

            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");

            string newName = "";
            int newAge = 0;
            int newBirthMonth = 0;
            ReturnPerson(ref newName, ref newAge, ref newBirthMonth);

            Console.WriteLine($"{newName} - {newAge} - {newBirthMonth}");
            */

            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");
        }

        static Person ReturnPerson()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birth month: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter your number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            return new Person(name, age, birthMonth, number)
            {
                name = name,
                age = age,
                birthMonth = birthMonth,
                number = number
            };
        }

        /*
        static void ReturnPerson(ref string name, ref int age, ref int birthMonth)
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter your birth month: ");
            birthMonth = Convert.ToInt32(Console.ReadLine());
        }
        */
    }
}
