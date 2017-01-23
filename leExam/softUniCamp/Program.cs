using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalGroups = int.Parse(Console.ReadLine());
            int totalCount = 0;
            int totalCar = 0;
            int totalMicroBus = 0;
            int totalMiniBus = 0;
            int totalBigBus = 0;
            int totalTrain = 0;
            for (int eachGroupNumberOfPeople = 0; eachGroupNumberOfPeople < totalGroups; eachGroupNumberOfPeople++)
            {
                int people = int.Parse(Console.ReadLine());
                totalCount += people;
                if (people > 0 && people <= 5)
                {
                    totalCar += people;
                    
                }
                else if (people > 5 && people <= 12)
                {
                    totalMicroBus += people;
                    
                }
                else if (people > 12 && people <= 25)
                {
                    totalMiniBus += people;
                    
                }
                else if (people > 25 && people <= 40)
                {
                    totalBigBus += people;
                    
                }
                else
                {
                    totalTrain += people;
                    
                }               
            }

            double percentCar = (totalCar / (double)totalCount) * 100;
            double percentMicroBus = (totalMicroBus / (double)totalCount) * 100;
            double percentMiniBus = (totalMiniBus / (double)totalCount) * 100;
            double percentBigBus = (totalBigBus / (double)totalCount) * 100;
            double percentTrain = (totalTrain / (double)totalCount) * 100;
            Console.WriteLine("{0:F2}%", percentCar);
            Console.WriteLine("{0:F2}%", percentMicroBus);
            Console.WriteLine("{0:F2}%", percentMiniBus);
            Console.WriteLine("{0:F2}%", percentBigBus);
            Console.WriteLine("{0:F2}%", percentTrain);


        }
    }
}
