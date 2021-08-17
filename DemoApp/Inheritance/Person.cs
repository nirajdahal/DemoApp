using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Inheritance
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public int Age { get; set; }


        public string Gender { get; set; }


        public void ParentMethod()
        {
            Console.WriteLine("I am a parent method");
        }
    }
}
