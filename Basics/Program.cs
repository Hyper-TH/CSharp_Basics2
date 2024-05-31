using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    // Class Properties Lesson 
    class Person
    {
        // For auto properties, use public; Use this method if there's no additional logic
        // public string name { get; set; }
        // public int age { get; set;  }

        // For properties and GettersSetters use private
        private string name;
        private int age;

        // Public variables (middle man) / Properties
        /*
        public string Name
        {
            // get { return name; }
            // set { name = value; }
            get => name; 
            set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name!";
        }

        public int Age 
        { 
            get => age;  
            set => age = value >= 0 && value <= 100 ? value : -1; 
        }
        */

        public Person(string name, int age)
        {
            // No need for these if doing properties
            this.name = name;
            this.age = age;

            // Name = name;
            // Age = age;
        }

        // Getters and Setters
        /*
        public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name!";
        public string GetName() => this.name;

        public void SetAge(int age) => this.age = age >= 0 && age <= 100 ? age : -1;
        public int GetAge() => this.age;
        */

        public string ReturnDetails()
        {
            return $"Name: {name}\nAge: {age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShowLessons();
            /*Person person = new Person("Hyper", 23);
            Console.WriteLine(person.ReturnDetails());

            person.Name = "Harry";
            person.Age = 25;

            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}");
            */

            Console.ReadLine();
        }

        static void ShowLessons()
        {
            // Exceptions.ShowExceptions();
            // PrintErrors.ShowPrintErrors();
            // CustomTryParse.ShowCustomTryParse();
            // Debugging.ShowDebugging();
            // LocalAutoWindow.ShowWindow();
            // FixLogicError.ShowFixLogicError();
            // Structures.ShowStructures();
            // Classes.ShowClasses();
            // ClassFunctions.ShowClassFunctions();
            // ClassFields.ShowClassFields();
            // ClassScopes.ShowClassScopes();
            ClassToString.ShowToString();
        }
    }
}
