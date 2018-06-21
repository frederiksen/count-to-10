using System;

namespace CountTo10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i=1; i<=10; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("Done!");
        }
    }
}
