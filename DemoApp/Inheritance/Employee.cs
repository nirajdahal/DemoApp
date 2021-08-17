using DemoApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Inheritance
{
    public class Employee : IPerson
    {
 
        public int AnnualIncome { get; set; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public int Age { get;  set; }
        public string Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void YouHaveToImplementMe()
        {
            Console.WriteLine("hello");
        }
    }
}
