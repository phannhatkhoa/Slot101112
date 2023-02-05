using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Need_for_Speed
{
    internal class RaceMotorcycle:Motorcycle
    {
        public RaceMotorcycle() { }
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 8;
            FuelConsumption = 8;
        }
    }
}
