using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Taxi: Vehicle
    {
        private uint maxspeed;
        private double price;
        public Taxi(): base() { maxspeed = 0; }
        public Taxi(string r_n, uint y, double r, uint s, double c, uint m_s, bool nto) : base(r_n, y, r, s, c, nto) 
        { 
            maxspeed = m_s; 
        }
        public override string ToString()
        {
            return base.ToString() + "\tMax speed: " + this.maxspeed;
        }
    }
}
