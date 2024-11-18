using Delegtes.MonitorTemperature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegtes.MonitorTemperatur
{
    internal class IndexMonitorTemperature
    {
        public IndexMonitorTemperature()
        {
            MonitorTemperatureApp monitor = new MonitorTemperatureApp();
            TemperatureAlert alert = new TemperatureAlert();
            monitor.OnTemperatureChange += alert.OnTemperatureChanged;

            //monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature: ");
            monitor.Temperature = int.Parse(Console.ReadLine());
        }
    }
}
