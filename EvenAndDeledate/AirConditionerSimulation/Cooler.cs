using System;

namespace EvenAndDeledate.AirConditionerSimulation
{
    public class Cooler
    {
        public Cooler(float temperature)
        {
            Temperature = temperature;
        }

        public float Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
        }

        private float _Temperature;

        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature > Temperature)   
            {
                Console.WriteLine("Cooler: On");  
            }
            else
            {
                Console.WriteLine("Cooler: Off");
            }
        }
    }
}