using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace cv05
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger car = new Passenger(60, Car.FuelType.Benzin, 20);

         
            Lorry truck = new Lorry(200, Car.FuelType.Nafta, 80);

      
            car.TurnOnRadio(true);
            car.setRadio(1, 89.1);
            car.tuneOnPrefix(1);
            car.RetuneByHand(99.9);
            truck.TransportedCargo = 50;

            
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());

          
            try
            {
                car.Refuel(Car.FuelType.Benzin, 100);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

          
            try
            {
                car.tuneOnPrefix(1);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}