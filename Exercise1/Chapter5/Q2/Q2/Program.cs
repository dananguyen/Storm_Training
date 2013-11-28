using System;
namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string university;
            string classroom;
            sbyte age;
            int roll;

            Console.WriteLine("Enter your student name");
            name = Console.ReadLine();

            Console.WriteLine("Enter what university you attend:");
            university = Console.ReadLine();

            Console.WriteLine("Enter your classroom");
            classroom = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            age = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Enter your roll number: \n");
            roll = Int32.Parse(Console.ReadLine());



            Console.WriteLine("======================");
            Console.WriteLine("Your Student Info");
            Console.WriteLine("========================");

            Console.WriteLine("Name = {0}", name);
            Console.WriteLine("University = {0}", university);
            Console.WriteLine("Classroom = {0}", classroom);
            Console.WriteLine("Age = {0}", age);
            Console.WriteLine("Roll = {0}", roll);

            Console.ReadLine();
        }
    }
}
