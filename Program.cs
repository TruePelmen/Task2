﻿using System;

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
            Console.WriteLine("Enter the info about vehicle: ");
            Vehicle b = Console.ReadLine();
            Console.WriteLine(b);
            Console.WriteLine(a<b);
            Console.WriteLine(b<a);
            Console.ReadLine();
        }
    }
}
