using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Need_for_Speed
{
    internal class Vehicle
    {
        public double DefaultSpeedConsumption;
        public double fuel;
        public int horsePower;

        public double DefaultFuelConsumption { get; set; } = 1.25;
        public virtual double FuelConsumption { get; set; } = 1.25;
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public Vehicle() { }
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public virtual void Drive(double kilometers)
        {
            Fuel = kilometers * FuelConsumption;
        }
    }
}
