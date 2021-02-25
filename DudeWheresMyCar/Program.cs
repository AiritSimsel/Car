using System;

namespace DudeWheresMyCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car("VW", "Golf", "895BLS", "blue");
            auto.ViewCar();
            auto.Lap();      
            auto.ViewCar();

            while (auto.fuelTank > 0)
            
            {
                auto.Lap();
            }
            auto.ViewCar();
        }
    }
}
