using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegtes.MonitorTemperature
{
    public delegate void TemperatureChangeHandler(string message);

    internal class MonitorTemperatureApp
    {
        
        public event TemperatureChangeHandler OnTemperatureChange;

        private int _temperature;

        public int Temperature { 
            get { return _temperature; } 
            set { 
                _temperature = value;
                if (_temperature > 40)
                {
                    RaiseTemperatureChangedEvent("Warning: Temperature is dangerously high!");
                }
                else if (_temperature > 30)
                {
                    RaiseTemperatureChangedEvent("Alert: Temperature is above the normal threshold!");
                }
                else if (_temperature >= 20 && _temperature <= 30)
                {
                    RaiseTemperatureChangedEvent("Info: Temperature is within the safe range.");
                }
                else if (_temperature >= 10 && _temperature < 20)
                {
                    RaiseTemperatureChangedEvent("Notice: Temperature is slightly below the safe range.");
                }
                else if (_temperature >= 0 && _temperature < 10)
                {
                    RaiseTemperatureChangedEvent("Caution: Temperature is very low!");
                }
                else
                {
                    RaiseTemperatureChangedEvent("Critical: Temperature is below freezing point!");
                }

            } 
        }

        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            // ? <= could be empty/ zero
            OnTemperatureChange?.Invoke(message);
        }
    }

    public class TemperatureAlert
    {
        public void OnTemperatureChanged(string message)
        {
            Console.WriteLine("Alert: " + message);
        }
    }

    
}
