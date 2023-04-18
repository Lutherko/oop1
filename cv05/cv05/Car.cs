using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    
    public abstract class Car
    {
       
        private Radio radio = new Radio();
        public double TankSize { get; protected set; }
        public double TankCondition { get; set; }
        public FuelType Fuel { get; set; }

        
        public Car(double tankSize, FuelType fuel, double tankCondition = 0)
        {
            TankSize = tankSize;   

            Fuel = fuel;   

                       
            if (tankCondition > tankSize)
            {
                throw new ArgumentException("Tank condition can´t be more then maximum of tank capacity");
            }
            TankCondition = tankCondition;   
        }

       
        public void Refuel(FuelType typ, double quantity)
        {
            
            if (typ != Fuel)
            {
                throw new ArgumentException("Wrong type of fuel");
            }
            
            else if (quantity + TankCondition > TankSize)
            {
                throw new ArgumentException("Overloaded Tank");
            }
            else
            {
                TankCondition = TankCondition + quantity;   
            }
        }

        
        public enum FuelType
        {
            Benzin,
            Nafta
        }
        public double GiveFrequency()
        {
            return radio.Frequency;
        }
        public bool EnabledRadio()
        {
            return radio.Enabled;
        }
        public void TurnOnRadio(bool onOff)
        {
            radio.Enabled = onOff;
        }
        public void setRadio(int cislo, double frequency)
        {
            radio.setOnPrefix(cislo, frequency);
        }

        public void tuneOnPrefix(int number)
        {
            radio.tuneOnPrefix(number);
        }

        public void RetuneByHand(double frequency)
        {
            radio.Frequency = frequency;
        }
        public override string ToString()
        {
            return String.Format("Status of tank is {0} out of {1}. Type of fuel {2}. {3}. ", TankCondition, TankSize, Fuel, radio.ToString());
        }
    }



}
