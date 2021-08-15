using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //class
            //object
            //when to use static keyword

            Console.WriteLine("Hello World!");
            Person.Animal =  "social anumsal";


            Person puran = new Person();
            puran.Name = "Puran";
            puran.Age = 15;
            puran.Gender = "Male";
        
            puran.Walk();

            Person niraj = new Person();
            niraj.Name = "Niraj";
            niraj.Age = 15;
            niraj.Gender = "Male";
            niraj.Walk();
            Helper.JoinNameAndAge(niraj.Name, niraj.Age);

            Person.Animal = "xyz animal";

            FileData firstFile = new FileData()
            {
                Name = "XYZ",
                SizeInMb = 10,
                PageSize = 50
            };

            firstFile.SaveFile(firstFile.Name);
            Console.ReadLine();

        }
    }


    public class Person
    {
        public static string Animal { get; set; } 

        public const string WillDie ="Yes";

        private readonly int Fingers;
        public  string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }


        public void Walk()
        {
            Console.WriteLine($"{Name} is wlaking");
        }

    }

    public class FileData
    {
        public string Name { get; set; }

        public int SizeInMb { get; set; }

        public int PageSize { get; set; }


        public void SaveFile(string name)
        {
            Console.WriteLine($"Save {name} file");
        }

    }


    public static class Helper
    {

        public static void JoinNameAndAge(string name, int age)
        {
            Console.WriteLine($"this helps to join {name} and {age}");
            
        }
    }

    
}
