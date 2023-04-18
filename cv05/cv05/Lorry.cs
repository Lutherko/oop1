using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{

    public class Lorry : Car
    {
        
        public double MaxCargo { get; private set; }  
        public double TransportedCargo { get; set; }  

        
        public Lorry(double tankSize, FuelType fuel, double maxCargo, double TankCondition = 0) : base(tankSize, fuel, TankCondition)
        {
            MaxCargo = maxCargo;
            TransportedCargo = 0;
        }

        
        public void SetTransportedCargo(double quantity)
        {           
            if (quantity > MaxCargo)
            {
                throw new ArgumentException($"This vehicle can transport max. {MaxCargo} kg");
            }
            TransportedCargo += quantity;
        }

        
        public override string ToString()
        {
            return $"Lorry: Fuel={Fuel}, TankCondition={TankCondition}, TransportedCargo={TransportedCargo}";
        }
    }
}


