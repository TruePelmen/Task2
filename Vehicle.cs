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
        public Vehicle()
        {
            registration_number = "";
            year = 0;
            race = 0.0;
            seats = 0;
            cost = 0.0;
        }
        public Vehicle(string r_n, uint y, double r, uint s, double c)
        {
            registration_number = r_n;
            year = y;
            race = r;
            seats = s;
            cost = c;
        }
        public override string ToString()
        {
            return $"Vehicle: \n\tRegistration number:{registration_number}; \n\tYear: {year}; \n\tRace: {race}; \n\tSeats: {seats}; \n\tCost:{cost}\n";
        }
        public double Cost()
        {
            return cost*1.15;
        }
        public static bool operator <(Vehicle this_, Vehicle other)
        {
            return this_.Cost() < other.Cost();
        }
        public static bool operator >(Vehicle this_, Vehicle other)
        {
            return this_.Cost() > other.Cost();
        }
        public static Vehicle Parse(string input)
        {
            var parts = input.Split(",");
            return new Vehicle
            {
                registration_number = parts[0],
                year = uint.Parse(parts[1]),
                race = double.Parse(parts[2]),
                seats = uint.Parse(parts[3]),
                cost = double.Parse(parts[4])
            };
        }
        public static implicit operator Vehicle(string input)
        {
            return Parse(input);
        }
        public static void ReadPerson(out Vehicle v)
        {
            Console.Write("Enter name and age separated by comma: ");
            v = Parse(Console.ReadLine());
        }
    }
}

