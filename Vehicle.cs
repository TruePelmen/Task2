using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Vehicle
    {
        private string registration_number;
        private uint year;
        private double race;
        private uint seats;
        private double cost;
        private bool need_to;
        //Getters
        public string GetRegNum()
        {
            return registration_number;
        }
        public uint GetYear()
        {
            return year;
        }
        public double GetRace()
        {
            return race;
        }
        public uint GetSeats()
        {
            return seats;
        }
        public double GetCost()
        {
            return cost;
        }
        public bool GetNTO()
        {
            return need_to;
        }
        //Setters
        public void SetRegNum(string r_n)
        {
            registration_number = r_n;
        }
        public void SetYear(uint y)
        {
            year = y;
        }
        public void SetRace(double r)
        {
            race = r;
        }
        public void SetSeats(uint s)
        {
            seats = s;
        }
        public void SetCost(double c)
        {
            cost = c;
        }
        public void SetNTO(bool status)
        {
            need_to = status;
        }
        public Vehicle()
        {
            registration_number = "";
            year = 0;
            race = 0.0;
            seats = 0;
            cost = 0.0;
            need_to = false;
        }
        public Vehicle(string r_n, uint y, double r, uint s, double c, bool nto)
        {
            registration_number = r_n;
            year = y;
            race = r;
            seats = s;
            cost = c;
            need_to = nto;
        }
        public override string ToString()
        {
            return $"Vehicle: \n\tRegistration number:{registration_number}; \n\tYear: {year}; \n\tRace: {race}; \n\tSeats: {seats}; \n\tCost:{cost}; \n\t Is TS needed: {need_to}\n";
        }
        public double Price()
        {
            return cost*1.15;
        }
        public static bool operator <(Vehicle this_, Vehicle other)
        {
            return this_.Price() < other.Price();
        }
        public static bool operator >(Vehicle this_, Vehicle other)
        {
            return this_.Price() > other.Price();
        }
        public static Vehicle Parse(string input)
        {
            var parts = input.Split(" ");
            return new Vehicle
            {
                registration_number = parts[0],
                year = uint.Parse(parts[1]),
                race = double.Parse(parts[2]),
                seats = uint.Parse(parts[3]),
                cost = double.Parse(parts[4]),
                need_to = bool.Parse(parts[5])
            };
        }
        public static implicit operator Vehicle(string input)
        {
            return Parse(input);
        }
        public static void ReadVehicle(out Vehicle v)
        {
            Console.Write("Enter name and age separated by comma: ");
            v = Parse(Console.ReadLine());
        }
        
        public void Trip(double km)
        {
            if(GetNTO())
            {
                double limit = 
                race += km;
            }
            else
            {
                Console.WriteLine("This vehicle neeeds TS! You cannot use it right now.");
            }
        }
    }
}

