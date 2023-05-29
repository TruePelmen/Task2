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


            Taxi t1 = new Taxi("khjg", 1988, 16433.4, 3, 1000, 150, false, 10000.0);
            Taxi t2 = new Taxi("khjg", 1988, 16433.4, 3, 1000, 170, false, 10000.0);
            //Console.WriteLine(t1.CompareTo(t2));

            // Використання формату "T" - всі дані про таксі
            string formatG = t1.ToString("T");
            Console.WriteLine(formatG);

            // Використання формату "RN" - тільки реєстраційний номер
            string formatR = t1.ToString("RN");
            Console.WriteLine(formatR);




            //Console.WriteLine("Enter n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Vehicle[] arr = new Vehicle[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter type of the vehicle: taxi or bus");
            //    string choice = Console.ReadLine();
            //    if(choice=="Taxi")
            //    {
            //        Taxi t = Console.ReadLine();
            //        arr[i] = t;
            //    }
            //    //arr[i] = Console.ReadLine();
            //    else if(choice == "Bus")
            //    {
            //        Bus b = Console.ReadLine();
            //        arr[i] = b;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong input!");
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.ReadLine();





            //testing the event
            Vehicle vec = new Vehicle("ascd", 1912, 3223.4, 4, 1000, true, 3000.0);
            Console.WriteLine(vec.CheckTS());
            HandlerForVehicle hfv = new HandlerForVehicle(vec);
            vec.Trip(14500);
            vec.Trip(15000);
            vec.Trip(500);
            vec.Trip(500);
            vec.Trip(500);




            //testing reading the taxi and bus from the console
            //dfgh 1999 50000 4 1000 150 false 45000
            //Taxi t = Console.ReadLine();
            //Console.WriteLine(t);
            ////khgj 2005 50000 30 700 true false 45000
            //Bus b = Console.ReadLine();
            //Console.WriteLine(b);

            // Testing List<Vehicle>
            //Vehicle a = new Vehicle("ascd", 1912, 3223.4, 4, 1000, true, 3000.0);
            //Taxi t = new Taxi("khjg", 1988, 16433.4, 3, 1000, 150, false, 10000.0);
            //Bus b = new Bus("khjg", 1988, 16433.4, 3, 1000, true, true, 10000.0);
            //List<Vehicle> veh_list = new List<Vehicle>();
            //veh_list.Add(a);
            //veh_list.Add(t);
            //veh_list.Add(b);
            //foreach (Vehicle v in veh_list)
            //{
            //    Console.WriteLine(v);
            //}

            //Testing reading from the console and pushing to the List<Vehicle>
            //dfgh 1999 50000 4 1000 150 false 45000
            //khgj 2005 50000 30 700 true false 45000
            //ewwr 2010 12000 4 1500 true 10000
            //qwer 2020 1500 45 500 true 500
            //poiu 2000 25000 4 700 170 true 5000

            //Console.WriteLine("Enter your Vehicles: ");
            //List<Vehicle> veh_list = new List<Vehicle>();
            //for (int i = 0; i < 5; i++)
            //{
            //    var vehicle = Console.ReadLine();
            //    Console.WriteLine(vehicle);
            //}
            //foreach (var i in veh_list)
            //{
            //    Console.WriteLine(i);
            //}

            //Task 04.04.2023
            //string a = "123 543 54 234 578 23 8 345 587 45";
            //int[] arr = { 0 };
            //try
            //{
            //    arr = Array.ConvertAll(a.Split(), s => int.Parse(s));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"***Error^ {e.Message}");
            //}
            //foreach (int x in arr) Console.Write($"{x} ");
            //List<int> list = new(arr);
            //Console.WriteLine();
            //foreach (int x in list) Console.Write($"{x} ");
            //Stack<int> st = new Stack<int>();
            //int numb = 100;     
            //Queue<int> q = new Queue<int>();
            //foreach (int x in arr) { if (x < numb) st.Push(x); else q.Enqueue(x); } ;
            //Console.WriteLine();
            //foreach (int x in st) Console.Write($"{x} ");
            //Console.WriteLine();
            //foreach (int x in q) Console.Write($"{x} ");
            //Console.WriteLine();
            //List<int> new_list = new List<int>();
            //new_list.AddRange(st);
            //new_list.AddRange(q);
            //new_list = new_list.FindAll(x => x < 100);
            //foreach (int x in new_list) Console.Write($"{x} ");
            //new_list.Reverse();
            //Console.WriteLine();
            //foreach (int x in new_list) Console.Write($"{x} ");
            //Console.WriteLine();
            //foreach (int x in arr) Console.Write($"{x} ");
            //string new_string = string.Join(" ", arr);
            //Console.WriteLine();
            //Console.WriteLine(new_string);

            //class string_builder
        }
    }
}
