using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegtes.StockPriceAlertApp
{
    // public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEvetArgs : EventArgs
    {
        // Property hoding the temperature
        public int Temperature { get; }
        // Constructor
        public TemperatureChangedEvetArgs(int temperature)
        {
            Temperature = temperature;
        }
    }

    public class TempCoolingAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEvetArgs e)
        {
            Console.WriteLine($"TEMP COOLING ALERT: temperature is {e.Temperature} sender is: {sender} ");
        }
    }

    internal class MonitorStockPrice
    {
        public event EventHandler<TemperatureChangedEvetArgs> TemperatureChanged;

        // public event TemperatureChangeHandler OnTemperatureChange;

        private int _temperature;

        public int Temperature { 
            get { return _temperature; } 

            set { 
                if (_temperature != value)
                {
                    _temperature = value;
                    //Raise Event
                    OnTemperatureChanged(new TemperatureChangedEvetArgs(_temperature));
                }

            } 
        }

        protected virtual void OnTemperatureChanged(TemperatureChangedEvetArgs e)
        {
            // Letting every subscriber know!
            TemperatureChanged?.Invoke(this, e);
        }
    }

    // Subscriber 
    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEvetArgs e)
        {
            Console.WriteLine($"Alert: temperature is {e.Temperature} sender is: {sender} ");
        }
    }

    
}
