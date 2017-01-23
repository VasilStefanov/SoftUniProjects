using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;
            int stars = 1;
            int dash = width - 4;

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string ('*', stars), new string ('-', dash));
                stars++;
                dash -= 2;
            }
            int outerStars = n/2;
            int middleStars = n;
            for (int row = 1; row <= n/3; row++)
            {
                Console.WriteLine(@"|{0}\{1}/{0}|", new string ('*', outerStars), new string ('*', middleStars));
                outerStars++;
                middleStars -= 2;
            }
            int dashNew = 1;
            int starNew = width - 4;

            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine(@"{0}\{1}/{0}", new string('-', dashNew), new string('*', starNew));
                dashNew++;
                starNew -= 2;
            }

        }
    }
}
