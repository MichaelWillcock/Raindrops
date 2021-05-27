using System;

namespace Raindrops
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static string RaindropsMethod(int number)
        {
            string a = "";
            if (number%3 == 0)
            {
                a += "Pling";
            }
            if (number%5 == 0)
            {
                a += "Plang";
            }
            if (number%7 == 0)
            {
                a += "Plong";
            }
            if (number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
            {
                a = $"{number}";
            }
            return a.Trim();
        }
    }
}
