using DemoApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Inheritance
{
    public class Student : IPerson
    {
        public Student()
        {
            Grade = 5;
        }
        public int Grade { get; private set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void YouHaveToImplementMe()
        {
            Console.WriteLine("hi");
            Grade = 10;
        }
    }
    
}
