using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Any())
            {
                Console.WriteLine($"Hello {args.First()}");
            }
            else
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
