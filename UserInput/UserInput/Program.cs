using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            //String interpolation is used to parse variables into console output
            Console.WriteLine($"{name} is {age} years old");
        }
    }
}
