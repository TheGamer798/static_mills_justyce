using System;

namespace static_mills_justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            // prints int methods
            Console.WriteLine(Calculate.Add(14, 59));
            Console.WriteLine(Calculate.Sub(32, 55));
            Console.WriteLine(Calculate.Multi(56, 17));
            Console.WriteLine(Calculate.Div(116, 8));
            // prints float methods
            Console.WriteLine(Calculate.Add(14.7f, 59.66f));
            Console.WriteLine(Calculate.Sub(32.505f, 55.0f));
            Console.WriteLine(Calculate.Multi(56.84f, 17.11f));
            Console.WriteLine(Calculate.Div(116.3f, 8.8f));
        }
    }
}
