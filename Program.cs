using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Vehicle a = new Vehicle("ascd", 1912, 3223.4, 4, 1000);
            Console.WriteLine(a);
            Console.WriteLine(a.Cost());
            string str = Console.ReadLine();
        }
    }
}
