using System;
using System.Collections.Generic;
using System.Text;

namespace tut1
{
    class Person
    {
        // ctrl + k ... ctrl + c
        // ctrl + k ... ctrl + u
        // cw ... tab twice

        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName { get; private set; }

        public void Print()
        {
            int? age = 25;
            Console.WriteLine($"I Am {age} years old.");
        }
    }
}