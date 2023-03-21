using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Vehicle a = new Vehicle("ascd", 1912, 3223.4, 4, 1000, true, 3000.0);
            Console.WriteLine(a);
            a.SetNTO(true);
            a.Trip(1000.0);
            a.Trip(15000.0);
            //Console.WriteLine(a.Price());
            //Console.WriteLine("Enter the info about vehicle: ");
            //Vehicle b = Console.ReadLine();
            //Console.WriteLine(b);
            //Console.WriteLine(a<b);
            //Console.WriteLine(b<a);
            Taxi t = new Taxi("khjg", 1988, 16433.4, 3, 1000, 150, false, 10000.0);
            Console.WriteLine(t);
            t.SetNTO(true);
            t.Trip(15000.0);
            //Console.WriteLine(t.Price(100.0, 4));
            Bus b = new Bus("khjg", 1988, 16433.4, 3, 1000, true, false, 10000.0);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
