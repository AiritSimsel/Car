using System;
using System.Collections.Generic;
using System.Text;

namespace DudeWheresMyCar
{
    class Car
    {
        
        
        //The car can drive.Every lap the car passes increases the value of the odometer by 100 and decreases the value of the fuel tank by 5 .

        public string mark;
        public string model;
        public string registrationNumber;
        public string colour;
        public int odometer = 0;
        public int fuelTank = 60;

        public Car(string _mark, string _model, string _registrationNumber, string _colour)
        {
            mark = _mark;
            model = _model;
            registrationNumber = _registrationNumber;
            colour = _colour;
            
        }

        public void ViewCar()
        {
            Console.WriteLine($"Mark: {mark}\nModel: {model}\nRegistration number: {registrationNumber}\nColour: {colour}\nOdometer count: {odometer}\nFuel tank: {fuelTank}");
        }

        public void Lap()
        {
            odometer += 100;
            fuelTank -= 5;
            if (fuelTank == 0)
            {
                Console.WriteLine("The fueltank is empty!");
            }
            
        }




    }
}
