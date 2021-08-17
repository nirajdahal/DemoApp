using DemoApp.Inheritance;
using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee();
            firstEmployee.FirstName = "Puran";
            firstEmployee.LastName = "Dahal";
            

            Person firstPerson = new Person();
            firstPerson.Age = 25;
            firstPerson.Gender = "Male";

            // dependency injection


        }


    }


    public class A
    {
        public void Method1()
        {

            B x = new B();

            FactoryClass factory = new FactoryClass();
         
            var b = factory.CreateBClass();
        }
    }

    public class B :  IB
    {
        public void Method2()
        {
            FactoryClass factory = new FactoryClass();

            var c = factory.CreateCClass();

        }
    } 

    public class C : IC
    {
       
    }



    public interface IB
    {

    }

    public interface IC
    {

    }



    public class FactoryClass
    {
       

        public IB CreateBClass()
        {
            D d = new D();
            return d;
        }

        public IC CreateCClass()
        {
            C a = new C();
            return a;
        }

    }



    public class D : IB
    {

    }
}

