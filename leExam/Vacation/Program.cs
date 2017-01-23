using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldPeople = int.Parse(Console.ReadLine());
            int youngPeople = int.Parse(Console.ReadLine());
            int nightsThere = int.Parse(Console.ReadLine());
            int totalTourists = oldPeople + youngPeople;
            string transport = Console.ReadLine();
            double hotelPrice = nightsThere * 82.99;

            switch (transport)
            {
                case "airplane":
                    double airplaneTotalPrice = ((oldPeople * 70.00) + (youngPeople * 50.00)) * 2;
                    double commissionAirplane = (airplaneTotalPrice + hotelPrice) * 0.10;
                    double sumAirplane = hotelPrice + airplaneTotalPrice + commissionAirplane;
                    Console.WriteLine("{0:F2}", sumAirplane); break;
                case "bus":
                    double busTotalPrice = ((oldPeople * 32.50) + (youngPeople * 28.50)) * 2;
                    double commissionBus = (busTotalPrice + hotelPrice) * 0.10;
                    double sumBus = hotelPrice + busTotalPrice + commissionBus;
                    Console.WriteLine("{0:F2}", sumBus); break;
                case "train":
                    double trainTotalPrice = ((oldPeople * 24.99) + (youngPeople * 14.99)) * 2;
                    if (totalTourists >= 50)
                    {
                        trainTotalPrice /= 2;
                    }
                    double commissionTrain = (trainTotalPrice + hotelPrice) * 0.10;
                    double sumTrain = hotelPrice + trainTotalPrice + commissionTrain;
                    Console.WriteLine("{0:F2}", sumTrain); break;
                case "boat":
                    double shipTotalPrice = ((oldPeople * 42.99) + (youngPeople * 39.99)) * 2;
                    double commissionBoat = (shipTotalPrice + hotelPrice) * 0.10;
                    double sumBoat = hotelPrice + shipTotalPrice + commissionBoat;
                    Console.WriteLine("{0:F2}", sumBoat); break;
                default:
                    break;
            }
        }
    }
}
