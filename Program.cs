using System;


namespace MyData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("What's your surname?");
            surname = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0} {1}, you're {2} and {3}cm tall!", name, surname, age, height);
        }
    }
}