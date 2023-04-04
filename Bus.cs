using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Bus: Vehicle
    {
        private bool has_air_cond;
        public Bus() : base() { has_air_cond = false; }
        public Bus(string r_n, uint y, double r, uint s, double c, bool hac, bool nto, double rwltswd) : base(r_n, y, r, s, c, nto, rwltswd)
        {
            has_air_cond = hac;
            if (GetSeats()<1)
            {
                this.SetSeats(1);
            }
            else if(GetSeats() > 50)
            {
                this.SetSeats(50);
            }
        }
        public override string ToString()
        {
            return $"Vehicle: \n\tRegistration number:{GetRegNum()}; \n\tYear: {GetYear()}; \n\tRace: {GetRace()}; \n\tSeats: {GetSeats()}; \n\tCost:{GetCost()}; \n\tIs TS needed: {GetNTO()}\n" + "\tAir conditing: " + this.has_air_cond;
        }
        public double Price_for_trip(double km, int passengers)
        {
            return Math.Round(km * GetCost() / passengers/2, 2);
        }


        public new static Bus Parse(string input)
        {
            var parts = input.Split(" ");
            return new Bus(parts[0],
                uint.Parse(parts[1]),
                double.Parse(parts[2]),
                uint.Parse(parts[3]),
                double.Parse(parts[4]),
                bool.Parse(parts[5]),
                bool.Parse(parts[6]),
                double.Parse(parts[7]));
        }
        public static implicit operator Bus(string input)
        {
            return Parse(input);
        }
        public static void ReadBus(out Bus v)
        {
            Console.Write("Enter all fields separated by ' ': ");
            v = Parse(Console.ReadLine());
        }

    }
}
