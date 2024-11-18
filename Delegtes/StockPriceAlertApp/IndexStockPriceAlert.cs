using Delegtes.MonitorTemperature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegtes.StockPriceAlertApp
{
    internal class IndexStockPriceAlert
    {
        public IndexStockPriceAlert()
        {
            MonitorStockPrice monitor = new MonitorStockPrice();
            TemperatureAlert alert = new TemperatureAlert();
            TempCoolingAlert alert2 = new TempCoolingAlert();
            monitor.TemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += alert2.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature: ");
            monitor.Temperature = int.Parse(Console.ReadLine());
        }
    }
}
