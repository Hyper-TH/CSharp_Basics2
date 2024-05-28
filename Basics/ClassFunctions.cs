using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class ClassFunctions
    {
        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            // Preferred method
            public string ReturnDetails3()
            {
                return $"Name: {name}\nAge: {age}";
            }
        }

        public static void ShowClassFunctions()
        {
            Person person = new Person("Hyper", 23);

            Console.WriteLine(ReturnDetails(person.name, person.age));
            Console.WriteLine(ReturnDetails2(person));
            Console.WriteLine(person.ReturnDetails3());
        }

        static string ReturnDetails(string name, int age)
        {
            return $"Name: {name}\nAge: {age}";
        }
        
        static string ReturnDetails2(Person person)
        {
            return $"Name: {person.name}\nAge: {person.age}";
        }
    }
}
