using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriaPriceKg = double.Parse(Console.ReadLine());
            double cacaPriceKg = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double midiKg = double.Parse(Console.ReadLine());

            double palamudPriceKg = skumriaPriceKg + (skumriaPriceKg * 0.60);
            double palamudTotalPrice = palamudKg * palamudPriceKg;
            double safridPriceKg = cacaPriceKg + (cacaPriceKg * 0.80);
            double safridTotalPrice = safridKg * safridPriceKg;
            double midiTotalPrice = midiKg * 7.50;

            double totalPrice = palamudTotalPrice + safridTotalPrice + midiTotalPrice;

            Console.WriteLine("{0:F2}", totalPrice);
        }
    }
}
