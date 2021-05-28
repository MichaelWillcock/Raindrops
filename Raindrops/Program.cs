using System;

namespace Raindrops
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Manual Tests
            Console.WriteLine(RaindropsMethod(3));
            Console.WriteLine(RaindropsMethod(25));
            Console.WriteLine(RaindropsMethod(28));
            Console.WriteLine(RaindropsMethod(30));
            Console.WriteLine(RaindropsMethod(70));
            Console.WriteLine(RaindropsMethod(21));
            Console.WriteLine(RaindropsMethod(210));
            Console.WriteLine(RaindropsMethod(1));
        }
        public static string RaindropsMethod(int number)
        {
            string result = null;
            if (number%3 == 0)
            {
                result += "Pling";
            }
            if (number%5 == 0)
            {
                result += "Plang";
            }
            if (number%7 == 0)
            {
                result += "Plong";
            }
            return result == null ? number.ToString().Trim() : result.Trim();
        }
    }
}
