using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Need_for_Speed
{
    internal class Car:Vehicle
    {
        public Car() { }
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 3;
            FuelConsumption = 3;
        }
    }
}
