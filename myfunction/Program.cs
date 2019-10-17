using System;

namespace myfunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string color;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your favourite color?");
            color = Console.ReadLine();
            KnowMe(name, color);
        }
            

        

        public static void KnowMe(string name, string color)
        {
            Console.WriteLine($"Hello, {name}. Your favourit color is {color}.");
        }

    }
}
