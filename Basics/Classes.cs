using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public static class Classes
    {
        /*
        struct Person
        {
            public string name;
            public int age;

            public Person(string name = "", int age = 0)
            {
                this.name = name;
                this.age = age;
            }
        }
        */
        
        class Person
        {
            public string name;
            public int age;

            // General constructor
            public Person()
            {

            }

            public Person(string name)
            {
                this.name = name;
                this.age = 0;
            }

            public Person(int age)
            {
                this.name = "";
                this.age = age;
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        public static void ShowClasses()
        {
            Person person = new Person();
            Person person1 = new Person("Hyper");
            Person person2 = new Person(23);
            Person person3 = new Person("Hyper", 23);

            ReadString("Enter your name: ", ref person.name);
            ReadInt("Enter your age: ", ref person.age);

            Console.WriteLine(person1.name);
            Console.WriteLine(person1.age);

            Console.WriteLine(person2.name);
            Console.WriteLine(person2.age);

            Console.WriteLine(person3.name);
            Console.WriteLine(person3.age);
        }

        static void ReadString(string message, ref string input)
        {
            Console.WriteLine(message);
            input = Convert.ToString(input);
        }

        static void ReadInt(string message, ref int input)
        { 
            Console.WriteLine(message); 
            input = Convert.ToInt32(input); 
        }
    }
}
