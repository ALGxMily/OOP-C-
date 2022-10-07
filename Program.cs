using System;

namespace IntroVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 253452;
            short num2 = -125;
            byte num3 = 100;
            float numFloat = 1.234132F;
            double numDouble = -1234.234;
            char ch = 'g';
            string str = "Hello";

            Console.WriteLine("num1 = {0}\nnum2 = {1}\nnum3 = {2}\nnumFloat = {3}\nnumDouble = {4}\nch = {5}\nstr = {6}\n", num1, num2, num3, numFloat, numDouble, ch, str);
        }
    }
}