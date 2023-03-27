using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Taxi: Vehicle, IFormattable, IComparable<Taxi>
    {
        private uint maxspeed;
        public uint GetMaxSpeed()
        {
            return maxspeed;
        }
        public Taxi(): base() { maxspeed = 0; }
        public Taxi(string r_n, uint y, double r, uint s, double c, uint m_s, bool nto, double rwltswd) : base(r_n, y, r, s, c, nto, rwltswd) 
        { 
            maxspeed = m_s;
            if (GetSeats() < 1)
            {
                this.SetSeats(1);
            }
            else if (GetSeats() > 4)
            {
                this.SetSeats(4);
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\tMax speed: " + this.maxspeed;
        }
        public double Price_for_trip(double km, int passengers)
        {
            return Math.Round(km * GetCost() / passengers, 2);
        }
        public static Taxi Parse(string input)
        {
            var parts = input.Split(" ");
            return new Taxi
            {
                //this.SetRegNum(parts[0]),
                //year = uint.Parse(parts[1]),
                //race = double.Parse(parts[2]),
                //seats = uint.Parse(parts[3]),
                //cost = double.Parse(parts[4]),
                //need_to = bool.Parse(parts[5])
            };
        }
        public static implicit operator Taxi(string input)
        {
            return Parse(input);
        }
        public static void ReadVehicle(out Taxi v)
        {
            Console.Write("Enter name and age separated by comma: ");
            v = Parse(Console.ReadLine());
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return this.ToString();
        }

        public int CompareTo(Taxi other)
        {
            return this.maxspeed.CompareTo(other.maxspeed);
            //return this.maxspeed.CompareTo(other.GetMaxSpeed());
        }
    }
}
