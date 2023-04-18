using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv05
{
    internal class Radio
    {
        private Dictionary<int, double> preset = new Dictionary<int, double>();

 
        public double Frequency { get; set; }

       
        public bool Enabled { get; set; }

    
        public Radio(double frequency = 107.00)
        {
            Frequency = frequency;
            Enabled = false;
        }

   
        public void setOnPrefix(int number, double frequency)
        {
     
            if (!preset.ContainsKey(number))
            {
                this.preset.Add(number, frequency);
            }
       
            else
            {
                this.preset.Remove(number);
                this.preset.Add(number, frequency);
            }
        }

     
        public void tuneOnPrefix(int number)
        {
           
            if (preset.TryGetValue(number, out double value))
            {
                this.Frequency = value;
            }
          
            else
            {
                throw new Exception("Not in preset");
            }
        }

        
        public override string ToString()
        {
            if (Enabled == false)
            {
                return "Radio is off";
            }
            else
            {
                return String.Format("Frquency is {0, 0:N2}", Frequency);
            }
        }
    }

}
