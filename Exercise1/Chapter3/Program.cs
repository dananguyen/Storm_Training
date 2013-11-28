using System;
namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result; //creating integer typevalue
            
            Console.WriteLine("Please Enter Value");

            num1 = Int32.Parse(Console.ReadLine()); //accepting value in num1

            Console.WriteLine("Please Enter Second Value"); //Displays Message

            num2 = Int32.Parse(Console.ReadLine());

            result = num1 + num2; //processing value

            Console.WriteLine("Add of {0} and {1} is {2}", num1, num2, result); //Output

            Console.ReadLine();
        }
    }
}