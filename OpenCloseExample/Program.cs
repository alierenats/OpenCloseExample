using System;

namespace OpenCloseExample
{
    public abstract class Car
    {
        protected double fuel_Consumption;

        public abstract decimal CalculateFuel();
    }

    public class CarFuel : Car
    {
        public CarFuel()
        {
            fuel_Consumption = 15.2;
        }

        public override decimal CalculateFuel()
        {
            return (decimal)(fuel_Consumption * 35.6);
        }

    }

    public class CarGas : Car
    {
        public CarGas()
        {
            fuel_Consumption = 15.2;
        }

        public override decimal CalculateFuel()
        {
            return (decimal)(fuel_Consumption * 18.2);
        }

    }

    public class CarDiesel : Car
    {
        public CarDiesel()
        {
            fuel_Consumption = 15.2;
        }

        public override decimal CalculateFuel()
        {
            return (decimal)(fuel_Consumption * 40.2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new CarDiesel();
            Car car1 = new CarGas();
            Car car2 = new CarFuel();

            Console.WriteLine(car.CalculateFuel());
            Console.WriteLine(car1.CalculateFuel());
            Console.WriteLine(car2.CalculateFuel());
        }
    }
}