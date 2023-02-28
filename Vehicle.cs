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
    }
}
