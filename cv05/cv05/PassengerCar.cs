using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    public class Passenger : Car
    {
        public int TransportedPersons { get; private set; }
        public int MaxPersons { get; private set; }

        
        public Passenger(double tankSize, FuelType fuel, int maxPersons, double tankCondition = 0) : base(tankSize, fuel, tankCondition)
        {
            MaxPersons = maxPersons;
            TransportedPersons = 0;
        }

       
        public void SetTransportedPersons(int count)
        {           
            if (count > MaxPersons)
            {
                throw new ArgumentException($"This car cant take more then {MaxPersons} persons");
            }
                 TransportedPersons = count;
        }

        
        public override string ToString()
        {
            return $"Passenger: Fuel={Fuel}, TankCondition={TankCondition}, TransportedPersons={TransportedPersons}";
        }
    }

}
