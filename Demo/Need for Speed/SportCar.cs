using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Need_for_Speed
{
    internal class SportCar:Car
    {
        public SportCar() { }
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 10;
            FuelConsumption = 10;
        }
    }
}
