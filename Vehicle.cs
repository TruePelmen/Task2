using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Vehicle
    {
        //event
        public event EventHandler ServiceNeeded;
        // fields
        private string registration_number;
        private uint year;
        private double race;
        private uint seats;
        private double cost;
        private bool need_to;
        private double race_when_lastTS_was_done;

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
        public double GetRWLTSWD()
        {
            return race_when_lastTS_was_done;
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
            race_when_lastTS_was_done = race;
        }
        public void SetRWLTSWD(double RWLTSWD)
        {
            race_when_lastTS_was_done = RWLTSWD;
        }
        // Constructors
        public Vehicle()
        {
            registration_number = "";
            year = 0;
            race = 0.0;
            seats = 0;
            cost = 0.0;
            need_to = false;
            race_when_lastTS_was_done = 0.0;
        }
        public Vehicle(string r_n, uint y, double r, uint s, double c, bool nto, double rwltswd)
        {
            registration_number = r_n;
            year = y;
            race = r;
            seats = s;
            cost = c;
            need_to = nto;
            race_when_lastTS_was_done = rwltswd;
        }
        // Other methods
        public override string ToString()
        {
            return $"Vehicle: \n\tRegistration number:{registration_number}; \n\tYear: {year}; \n\tRace: {race}; \n\tSeats: {seats}; \n\tCost:{cost}; \n\tIs TS needed: {need_to}\n";
        }
        public double Price()
        {
            return cost * 1.15;
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
        public bool CheckTS()
        {
            return (DateTime.Now.Year - GetYear() < 10 || GetNTO());
        }
        public void Trip(double km)
        {
            if(CheckTS())
            {
                if(km>=15000.0)
                {
                    SetNTO(false);
                }
                race += km;
                if(race - race_when_lastTS_was_done > 15000.0)
                {
                    SetNTO(false);
                }   
                Console.WriteLine($"The trip has ended successfully! Race is now {race} km.");
                if(!GetNTO())
                {
                    Console.WriteLine("Technical service is needed now!");
                }
                else
                {
                    Console.WriteLine("Technical service is not needed yet.");
                }
                cost += 0.01 * km;
            }
            else
            {
                OnServiceNeeded();
                
            }
        }        
        protected virtual void OnServiceNeeded()
        {
            Console.WriteLine("This vehicle neeeds TS! You cannot use it right now.");
            ServiceNeeded?.Invoke(this, EventArgs.Empty);
        }
    }
}

