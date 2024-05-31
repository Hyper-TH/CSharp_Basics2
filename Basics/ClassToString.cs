using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class ClassToString
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string ReturnDetails()
            {
                return $"Name: {Name}\nAge: {Age}";
            }

            public override string ToString()
            {
                return $"Name: {Name}\tAge: {Age}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Person)
                {
                    // Cast the object first as a person class
                    Person person = obj as Person;
                    return Name.Equals(person.Name) && Age == person.Age;
                }

                return false;
            }
        }

        public static void ShowToString()
        {
            Person person = new Person("Hyper", 23);
            Person test = new Person("Harry", 23);

            if (person.Equals(test))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }
            
            if (person.Equals(5))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            // Console.WriteLine(person.ReturnDetails());
            // Console.WriteLine(person.ToString());
            Console.WriteLine(person);
        }
    }
}
