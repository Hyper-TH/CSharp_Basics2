using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class ClassScopes
    {
        class Person
        {
            private string name;
            private int age;
            private string test = "hello";
            
            public Person(string name, int age)
            {
                Console.WriteLine(name);    // parameter
                Console.WriteLine(this.name);   // global
                this.name = name;
                this.age = age;
                string test = "hi";

                Console.WriteLine(test);    // Compiler will always prioritize local over global
            }

            public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;

            public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";

            public string GetName() => name;

            public int GetAge() => age;

            public string ReturnDetails() 
            {
                return $"Name: {name}\nAge: {age}"; 
            }
        }

        public static void ShowClassScopes()
        {
            Person person = new Person("Hyper", 23);
            Console.WriteLine(person.ReturnDetails());

        }
    }
}
