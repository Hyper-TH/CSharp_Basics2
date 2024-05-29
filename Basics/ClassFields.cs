using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class ClassFields
    {
        class Person
        {
            // Turned private
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;

            public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";

            public string GetName() => name; 

            public int GetAge() => age;

            public string ReturnDetails() { return $"Name: {name}\nAge: {age}"; }
        }

        public static void ShowClassFields()
        {
            Person person = new Person("Hyper", 23);
            Console.WriteLine(person.ReturnDetails());

            // Prevent rewrite by adding getters/setters
            // person.name = "Max";
            // person.age = 25;

            person.SetName("Max");
            person.SetAge(25);
            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine($"Your name is {person.GetName()}");

        }
    }
}
