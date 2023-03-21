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
        }
        public override string ToString()
        {
            return base.ToString() + "\tAir conditing: " + this.has_air_cond;
        }
    }
}
