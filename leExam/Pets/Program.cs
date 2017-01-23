using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysAway = int.Parse(Console.ReadLine());
            int foodPrepared = int.Parse(Console.ReadLine());
            double foodDogKg = double.Parse(Console.ReadLine());
            double foodCatKg = double.Parse(Console.ReadLine());
            double foodTurtoiseGr = double.Parse(Console.ReadLine());

            double foodEatenDog = daysAway * foodDogKg;
            double foodEatenCat = daysAway * foodCatKg;
            double foodEatenTurtoise = (daysAway * foodTurtoiseGr) / 1000;
            double foodTotal = foodEatenDog + foodEatenCat + foodEatenTurtoise;

            if (foodTotal <= foodPrepared)
            {
                double difference = Math.Floor(foodPrepared - foodTotal);
                Console.WriteLine("{0} kilos of food left.", difference);
            }
            else
            {
                double difference = Math.Ceiling(foodTotal - foodPrepared);
                Console.WriteLine("{0} more kilos of food are needed.", difference);
            }

        }
    }
}
