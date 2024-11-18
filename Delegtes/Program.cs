using Delegtes.DelegatesExample;
using Delegtes.Generics;
using Delegtes.MonitorTemperatur;
using Delegtes.StockPriceAlertApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegtes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IndexDelegateExample indexDelegateExample = new IndexDelegateExample();

            //IndexGenericsExample indexGenericsExample = new IndexGenericsExample();

            //IndexMonitorTemperature indexMonitorTemperature = new IndexMonitorTemperature();

            IndexStockPriceAlert alert = new IndexStockPriceAlert();

            Console.ReadKey();
        }
    }
}
