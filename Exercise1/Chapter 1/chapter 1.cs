using System;

namespace First_c_sharp_code
{
    class Program
    {
        static void Main(string[] args)
        {
            string name; //variable for storing string value
            Console.WriteLine("Please Enter Your Good Name"); //displaying value for entering value
            name = Console.ReadLine(); //accepts and hold values in name variables
            Console.WriteLine("Welcome {0} in your first c sharp program", name);  //displaying output
            Console.ReadLine(); //holds console screen
        }
    }
}