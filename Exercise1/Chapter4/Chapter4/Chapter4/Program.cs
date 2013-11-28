using System;
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string city;
            sbyte age;
            int pin;

            // \n line break

            Console.WriteLine ("Enter your name:");
            name = Console.ReadLine();

            Console.WriteLine ("Enter your city: ");
            city = Console.ReadLine ();

            Console.WriteLine("Enter your age: ");
            age = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Enter your pin number\n");
            pin = Int32.Parse(Console.ReadLine());

            Console.WriteLine("=============");
            Console.WriteLine("Your Complete Address\n");
            Console.WriteLine("=============");

            Console.WriteLine("Name = {0}", name);
            Console.WriteLine("City = {0}", city);
            Console.WriteLine("Age = {0}", age);
            Console.WriteLine("Pin = {0}", pin);
            Console.WriteLine("==============");

            Console.ReadLine();

        }
    }
}