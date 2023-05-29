using System;
using System.Collections.Generic;
using System.Globalization;
//using System.Collections.IEnumerable;
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
            return $"Taxi: \n\tRegistration number:{GetRegNum()}; \n\tYear: {GetYear()}; \n\tRace: {GetRace()}; \n\tSeats: {GetSeats()}; \n\tCost:{GetCost()}; \n\tIs TS needed: {GetNTO()}\n" + "\tMax speed: " + this.maxspeed;  //base.ToString()
        }
        public double Price_for_trip(double km, int passengers)
        {
            return Math.Round(km * GetCost() / passengers, 2);
        }
        public new static Taxi Parse(string input)
        {
            var parts = input.Split(" ");
            return new Taxi(parts[0], 
                uint.Parse(parts[1]), 
                double.Parse(parts[2]), 
                uint.Parse(parts[3]), 
                double.Parse(parts[4]), 
                uint.Parse(parts[5]), 
                bool.Parse(parts[6]), 
                double.Parse(parts[7]));
        }
        public static implicit operator Taxi(string input)
        {
            return Parse(input);
        }
        public static void ReadTaxi(out Taxi v)
        {
            Console.Write("Enter all fields separated by ' ': ");
            v = Parse(Console.ReadLine());
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null)
            {
                // Якщо формат не вказано, повертаємо значення в форматі за замовчуванням
                format = "T";
            }

            switch (format.ToUpper())
            {
                case "T":
                    // Формат "T" - повертає всю інформацію про таксі
                    return this.ToString();//$"Taxi: {GetRegNum()}, Year: {GetYear()}, Race: {GetRace()}, Seats: {GetSeats()}, Cost: {GetCost()}, Max Speed: {GetMaxSpeed()}, Technical service is needed: {GetNTO()}, Last TS Date: {GetRWLTSWD()}";
                case "RN":
                    // Формат "RN" - повертає тільки реєстраційний номер
                    return $"Registration Number: {GetRegNum()}";
                case "Y&R":
                    // Формат "Y&R" - повертає рік випуску і пробіг
                    return $"Year: {GetYear()}, Race: {GetRace()}";
                default:
                    // Якщо вказаний невідомий формат, просто повертаємо значення в форматі за замовчуванням
                    return ToString("T", formatProvider);
            }
        }

        public int CompareTo(Taxi other)
        {
            //Taxi arg = other as Taxi; 
            //if (arg != null) 
            //{ if (this.maxspeed > arg.maxspeed) return 1; 
            //    else if (this.maxspeed < arg.maxspeed) return -1; 
            //    else return 0; 
            //} 
            //else throw new ArgumentException("Not Taxi"); 
            //return this.maxspeed.CompareTo(other.maxspeed);
            return this.maxspeed.CompareTo(other.GetMaxSpeed());
        }
    }
}
