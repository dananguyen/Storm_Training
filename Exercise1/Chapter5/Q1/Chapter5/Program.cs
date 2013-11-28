using System;
namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string city;
            string street;
            int house;
            int pin;

            Console.WriteLine("Enter your name: \n");
            name = Console.ReadLine();

            Console.WriteLine("Enter your city: \n");
            city = Console.ReadLine();

            Console.WriteLine("Enter your street address: \n");
            street = Console.ReadLine();

            Console.WriteLine("Enter your house number: \n");
            house = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter your pin: \n");
            pin = Int32.Parse(Console.ReadLine());


            Console.WriteLine("====================");
            Console.WriteLine("Your Complete Address");
            Console.WriteLine("====================");


            Console.WriteLine("Name = {0}", name);
            Console.WriteLine("City = {0}", city);
            Console.WriteLine("Street = {0}", street);
            Console.WriteLine("House = {0}", house);
            Console.WriteLine("Pin = {0}", pin);
            Console.WriteLine("=====================");

            Console.ReadLine();
        }
    }
}
