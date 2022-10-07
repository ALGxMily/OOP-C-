using System;


namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int total;

            Console.WriteLine("First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            total = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, total);

        }
    }
}