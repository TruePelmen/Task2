using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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
            Bus b = new Bus("khjg", 1988, 16433.4, 3, 1000, true, true, 10000.0);
            Console.WriteLine(b);
            b.Trip(1000.0);
            Console.WriteLine(b);
            Console.WriteLine(b.Price_for_trip(200.0, 49));           
            */


            //Taxi t1 = new Taxi("khjg", 1988, 16433.4, 3, 1000, 150, false, 10000.0);
            //Taxi t2 = new Taxi("khjg", 1988, 16433.4, 3, 1000, 170, false, 10000.0);
            ////Console.WriteLine(t1 == t2);
            ////Console.WriteLine(t1 > t2);
            ////Console.WriteLine(t1 < t2);
            //Console.WriteLine(t1.CompareTo(t2));



            /*
            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Vehicle[] arr = new Vehicle[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
            */




            //testing the event
            //Vehicle vec = new Vehicle("ascd", 1912, 3223.4, 4, 1000, true, 3000.0);
            //Console.WriteLine(vec.CheckTS());
            //vec.Trip(14500);
            //vec.Trip(15000);
            //vec.Trip(500);
            //vec.Trip(500);
            //vec.Trip(500);



            //testing reading the taxi from the console
            //Taxi t = Console.ReadLine();
            //Console.WriteLine(t);



            Vehicle a = new Vehicle("ascd", 1912, 3223.4, 4, 1000, true, 3000.0);
            Taxi t = new Taxi("khjg", 1988, 16433.4, 3, 1000, 150, false, 10000.0);
            Bus b = new Bus("khjg", 1988, 16433.4, 3, 1000, true, true, 10000.0);
            List<Vehicle> veh_list = new List<Vehicle>();
            veh_list.Add(a);
            veh_list.Add(t);
            veh_list.Add(b);
            foreach (Vehicle v in veh_list)
            {
                Console.WriteLine(v);
            }
        }
    }
}
